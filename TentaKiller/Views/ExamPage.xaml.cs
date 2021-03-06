﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TentaKiller.Models;

namespace TentaKiller.Views
{
    /// <summary>
    /// Interaction logic for ExamPage.xaml
    /// </summary>
    public partial class ExamPage : Page
    {
        protected MainWindow mainWindow;
        protected TentaKiller.Models.Exam exam;
        public TentaKiller.Models.Exam Exam {
            get { return exam; }
            set {
                exam = value;
                DataContext = value;
                //  ItemsSource="{Binding Challanges, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}" IsSynchronizedWithCurrentItem="True"
                challangeList.IsSynchronizedWithCurrentItem = false;
                challangeList.ClearValue(ItemsControl.ItemsSourceProperty);
                challangeList.ItemsSource = value.Challanges;
            } }

        public ExamPage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
            challangeList.SelectionChanged += SelectionChanged;
        }

        public void AddNewChallange(object sender, EventArgs ea)
        {
            Challange challange = new Challange();
            exam.Challanges.Add(challange);
            challange.Exams.Add(exam);
            mainWindow.app.Data.Challanges.Add(challange);
            mainWindow.app.Data.SaveChanges();
            mainWindow.ChallangePage.Challange = challange;
            mainWindow.Navigate(mainWindow.ChallangePage);
        }

        public void RemoveExam(object sender, EventArgs ea)
        {
            MessageBoxResult result = MessageBox.Show("Are you certain you'd like to remove this Exam? (This is irreversable).", "Remove Exam?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                // TODO remove related Challanges (unless that Challange is part of another Exam)
                mainWindow.app.Data.Exams.Local.Remove(exam);
                mainWindow.app.Data.SaveChanges();
                mainWindow.AddFeedback("Removed Exam '" + exam.Name + "' [" + exam.Id + "]");
                mainWindow.Navigate(mainWindow.ExamsPage);
            }
        }

        protected void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (challangeList.SelectedItem == null) return;

            mainWindow.ChallangePage.Challange = (Challange)challangeList.SelectedItem;
            mainWindow.Navigate(mainWindow.ChallangePage);
        }

        public void TakeExam(object sender, EventArgs e)
        {
            Trial trial = new Trial();
            trial.Student = mainWindow.LoggedInStudent;
            trial.Exam = exam;
            IEnumerator<Challange> i = exam.Challanges.GetEnumerator();
            while (i.MoveNext())
            {
                TrialPart part = new TrialPart() { Trial = trial, Challange = i.Current };
                trial.Parts.Add(part);
                mainWindow.app.Data.TrialParts.Local.Add(part);
            }
            mainWindow.app.Data.Trials.Local.Add(trial);
            mainWindow.app.Data.SaveChanges();
            mainWindow.Navigate(trial);
        }
    }
}

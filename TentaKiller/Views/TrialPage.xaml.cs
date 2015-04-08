using System;
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
    public partial class TrialPage : Page
    {
        protected MainWindow mainWindow;

        // TODO clean, confusing with selectedPart
        protected TrialPart currentPart;
        public TrialPart CurrentPart {
            get { return currentPart; }
            set {
                currentPart = value;
                selectedPartQuestion.Text = currentPart.Challange.Question;
                choicesList.ItemsSource = GenerateChoices(currentPart.Challange);
                choicesList.SelectedItem = currentPart.Answer;
            }
        }

        internal List<string> GenerateChoices(Challange challange)
        {
            // get list of all
            List<string> choices = new List<string>();
            choices.Add(challange.Answer);
            IEnumerator<Lie> i = challange.Lies.GetEnumerator();
            while (i.MoveNext()) choices.Add(i.Current.Text);

            // shuffle
            Random random = new Random();
            int shuffles = choices.Count * 3;
            while (shuffles-- > 0)
            {
                int r = random.Next(choices.Count);
                string t = choices[r];
                choices.RemoveAt(r);
                choices.Add(t);
            }

            // return
            return choices;
        }

        protected TentaKiller.Models.Trial trial;
        public TentaKiller.Models.Trial Trial
        {
            get { return trial; }
            set
            {
                trial = value;
                DataContext = "";
                DataContext = value;
                partList.ClearValue(ItemsControl.ItemsSourceProperty);
                partList.ItemsSource = value.Parts;
            }
        }

        public TrialPage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
            partList.SelectionChanged += partList_SelectionChanged;
            choicesList.SelectionChanged += choicesList_SelectionChanged;
        }

        private void choicesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (choicesList.SelectedItem == null) return;

            CurrentPart.Answer = (string)choicesList.SelectedItem;
        }

        private void partList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (partList.SelectedItem == null) return;

            CurrentPart = (TrialPart)partList.SelectedItem;
        }

        private void Grade(object sender, RoutedEventArgs e)
        {
            // TODO Points stuff.. not really correct. part.Points should reflect Exam-Challange relation (non-existant property atm.)
            trial.Ended = DateTime.Now;
            trial.Points = 0;
            trial.MaxPoints = 0;
            IEnumerator<TrialPart> i = trial.Parts.GetEnumerator();
            while (i.MoveNext())
            {
                TrialPart part = i.Current;
                trial.MaxPoints += part.Points;
                if (part.Answer != null && part.Answer.Equals(part.Challange.Answer))
                {
                    trial.Points += part.Points;
                }
            }
            trial.Graded = true;

            mainWindow.app.Data.SaveChanges();

            mainWindow.Navigate(trial);

            string result = trial.Points.ToString();
            string max = trial.MaxPoints.ToString();

            MessageBox.Show(trial.Exam.Name + ": results: " + result + "/" + max + "  is correct.");
        }

        private void SelectChoice(object sender, MouseButtonEventArgs e)
        {
            CurrentPart.Answer = (string)choicesList.SelectedItem;
        }

        private void SelectPart(object sender, MouseButtonEventArgs e)
        {
            CurrentPart = (TrialPart)partList.SelectedItem;
        }
    }
}

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
    /// Interaction logic for ChallangePage.xaml
    /// </summary>
    public partial class ChallangePage : Page
    {
        protected MainWindow mainWindow;

        protected Challange challange;
        public Challange Challange {
            get { return challange; }
            set {
                challange = value;
                DataContext = value;
                lieList.ClearValue(ItemsControl.ItemsSourceProperty);
                lieList.ItemsSource = value.Lies;
            }
        }

        public ChallangePage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
            lieList.IsSynchronizedWithCurrentItem = true;
        }

        public void AddLie(object sender, EventArgs ea)
        {
            InputWindow inputDialog = new InputWindow("New Lie", "An answer, but a false one.", "", mainWindow);
            if (inputDialog.ShowDialog() == true)
            {
                challange.Lies.Add(new Lie(inputDialog.Answer));
                mainWindow.app.Data.SaveChanges();
                // refresh
                Challange = challange;
            }
        }

        private void EditSelectedLies(object sender, RoutedEventArgs ea)
        {
            foreach (Lie lie in lieList.SelectedItems)
            {
                InputWindow inputDialog = new InputWindow("Editing Lie", "An answer, but a false one.", lie.Text, mainWindow);
                if (inputDialog.ShowDialog() == true)
                {
                    // An unhandled exception of type 'System.InvalidOperationException' occurred in PresentationFramework.dll
                    //Additional information: Operation is not valid while ItemsSource is in use. Access and modify elements with ItemsControl.ItemsSource instead.
                    //lieList.Items.Remove(current);
                    //lieList.Items.Add(inputDialog.Answer);
                    lie.Text = inputDialog.Answer;
                }
            }

            mainWindow.app.Data.SaveChanges();

            // refresh
            Challange = challange;
        }

        private void RemoveSelectedLies(object sender, RoutedEventArgs ea)
        {
            foreach (Lie lie in lieList.SelectedItems)
            {
                MessageBoxResult result = MessageBox.Show("Are you certain you'd like to remove this lie? (This is irreversable).", "Remove Lie?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
                if (result == MessageBoxResult.Yes)
                {
                    challange.Lies.Remove(lie);
                    mainWindow.app.Data.Lies.Local.Remove(lie);
                }
            }

            mainWindow.app.Data.SaveChanges();

            // refresh
            Challange = challange;
        }
    }
}

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

namespace TentaKiller.Views
{
    /// <summary>
    /// Interaction logic for StudentsPage.xaml
    /// </summary>
    public partial class StudentsPage : Page
    {
        protected MainWindow mainWindow;

        public StudentsPage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
            // TODO listView.SelectionChanged += SelectionChanged;
            listView.IsSynchronizedWithCurrentItem = true;
            listView.ItemsSource = window.app.Data.Students.Local;
        }
    }
}

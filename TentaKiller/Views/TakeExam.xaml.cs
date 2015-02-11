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
    public partial class TakeExamPage : Page
    {
        protected MainWindow mainWindow;

           
       public TakeExamPage(MainWindow window)
        {
            mainWindow = window;
            //initializeComponent();
            
        }
    }
}

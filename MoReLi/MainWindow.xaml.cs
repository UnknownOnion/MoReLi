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

namespace MoReLi
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            List<SewingPattern> lOfSP = new List<SewingPattern>()
            {
               SewingPatternLoader.Instance.GetSewingPattern(@"C:\Users\Victor\Desktop\BeeShorty Man")
                
            };
            DataContext = lOfSP;
        }
    }
}

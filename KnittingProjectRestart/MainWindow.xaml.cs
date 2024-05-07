using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace KnittingProjectRestart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
       


        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            CControl.Content = new HomePage();
        }

        private void btnPatterns_Click(object sender, RoutedEventArgs e)
        {
            CControl.Content = new PatternsPage();
        }

        private void btnProjects_Click(object sender, RoutedEventArgs e)
        {
            CControl.Content = new ProjectList();
        }
    }
}
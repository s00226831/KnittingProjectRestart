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

namespace KnittingProjectRestart
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
            CControl.Content = new ProjectCreation();
        }

        private void btnOpenProject_Click(object sender, RoutedEventArgs e)
        {
            CControl.Content = new ProjectList();
        }

        private void btnViewPatterns_Click(object sender, RoutedEventArgs e)
        {
            CControl.Content = new PatternsPage();
        }
    }
}

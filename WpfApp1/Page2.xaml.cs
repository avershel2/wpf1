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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2(string DrainageArea, string ManholeID )
        {
            InitializeComponent();
            manholeid.Content = "Manhole ID: " + ManholeID;
            drainagearea.Content = "Drainage Area: " + DrainageArea;
            InspectionDateTime.Content = "Inspection Date/Time: " + DateTime.Now;
            ParentJobNumber.Content = "Parent Job Number: " + "55";
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {

                NavigationService.Navigate(new Page1());
            
        }
    }
}

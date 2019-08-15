using DAL.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            InspectionService inspectionService = new InspectionService();
            List<string> DrainageAreas = new List<string>();
            DrainageAreas.Add("Make Selection...");
            comboBox1.SelectedIndex = 0;

            DrainageAreas.AddRange(inspectionService.GetDrainageAreas());

            comboBox1.ItemsSource = DrainageAreas;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;

        }

        private void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            string s = comboBox1.Text;
            ComboBox cmb = sender as ComboBox;


            if (s != "Make Selection...")
            {
                InspectionService inspectionService = new InspectionService();
                var Manholes = inspectionService.GetManholeByDrainageArea(s);
                List<Author> authors = new List<Author>();
                foreach(var manhole in Manholes)
                {
                    authors.Add(new Author()
                    {
                        Manhole = manhole
                    });
                }

                dataGrid1.ItemsSource = authors;
            }
            else
            {
                dataGrid1.ItemsSource = null;

            }

        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Author customer = (Author)dataGrid1.SelectedItem;
            if(customer == null)
            {
                MessageBox.Show("You must select a manhole.");
            }
            else
            {
                NavigationService.Navigate(new Page2(comboBox1.Text, customer.Manhole));
                //myFrame.Navigate(new System.Uri("Page1.xaml",UriKind.RelativeOrAbsolute));
            }
        }


    }

    public class Author
    {
        [DisplayName("Manhole ID")]
        public string Manhole { get; set; }
    }

}

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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Binddata();
            Binddata1();


        }
        void Binddata()
        {
            testdatagrid.ItemsSource = Library.MediaList;
            // Name.ItemsSource = Library.libraryMembers;

        }
        void Binddata1()
        {
            memebrs.ItemsSource = Library.libraryMembers;


        }

        private void LendMediaButton_Click(object sender, RoutedEventArgs e)
        {
            if (testdatagrid.SelectedItem != null && memebrs.SelectedItem != null)
            {
                if (((Media)testdatagrid.SelectedItem).Availability)
                {

                    ((Media)testdatagrid.SelectedItem).libraryMembers = ((LibraryMember)memebrs.SelectedItem).Name;
                    LibraryMember libraryMember = (LibraryMember)memebrs.SelectedItem;
                    Media media = (Media)testdatagrid.SelectedItem;
                    ((Media)testdatagrid.SelectedItem).Availability = false;
                  
                    LibraryMember.CurrentlyBorrowed.Add(media);
                    UpdateTestDataGrid();
                    MessageBox.Show(libraryMember.Name + " has lent the " + media.Mediatype, "Pop Up");
                }
                else
                {
                    MessageBox.Show("Sorry! Media is Unavailable");
                }
            }
            else
            {
                MessageBox.Show("Please select the Name first and then Media");
            }

        }


        private void ReturnMediabutton_Click(object sender, RoutedEventArgs e)
        {

            if (testdatagrid.SelectedItem != null && memebrs.SelectedItem != null)
            {
                if (!((Media)testdatagrid.SelectedItem).Availability)
                {
                    if (((LibraryMember)(memebrs.SelectedItem)).Name == ((Media)testdatagrid.SelectedItem).libraryMembers)
                    {

                        ((Media)testdatagrid.SelectedItem).libraryMembers = ((LibraryMember)memebrs.SelectedItem).Name;
                        LibraryMember libraryMember = (LibraryMember)memebrs.SelectedItem;
                        Media media = (Media)testdatagrid.SelectedItem;
                        ((Media)testdatagrid.SelectedItem).Availability = true;

                        ((Media)testdatagrid.SelectedItem).libraryMembers = "";
                        UpdateTestDataGrid();
                        MessageBox.Show(libraryMember.Name + " has returned the " + media.Mediatype, "Pop Up");
                    }
                    else
                    {
                        MessageBox.Show(((LibraryMember)memebrs.SelectedItem).Name + " haven't lent this media");
                    }
                }
                else
                {
                    MessageBox.Show("Media is Available");
                }
            }
            else
            {
                MessageBox.Show("Invalid Action");
            }
        }

        private void MediaInfoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MemberInfoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        public void UpdateTestDataGrid()
        {
            testdatagrid.UnselectAllCells();
            //testdatagrid.UnselectAllCells();
            testdatagrid.ItemsSource = null;
            testdatagrid.ItemsSource = Library.MediaList;
        }
       
        private void testdatagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

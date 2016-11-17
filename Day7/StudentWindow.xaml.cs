using Day7.Model;
using Day7.ViewModel;
using System.Windows;

namespace Day7
{
    /// <summary>
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        private StudentViewModel studentViewModel = null;

        public StudentWindow()
        {
            InitializeComponent();
            UpdateStudentList();
        }

        private void UpdateStudentList()
        {
            studentViewModel = new StudentViewModel();
            studentViewModel.LoadStudentListView();
            foreach (StudentModel student in studentViewModel.StudentList)
            {
                lvStudentInfo.Items.Add(student);
            }
        }

        private void cmRemoveStudent_Click(object sender, RoutedEventArgs e)
        {
            lvStudentInfo.Items.Remove(lvStudentInfo.SelectedItem);
        }
    }
}
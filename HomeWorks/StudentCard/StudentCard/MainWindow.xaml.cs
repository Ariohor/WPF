using DataAccess;
using Models;
using System;
using System.Windows;

namespace StudentCard
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewStudent(TestModels.GetStudent());
        }

        private void ViewStudent(Student student)
        {
            this.nameTextBlock.Text = student.Name;
            this.birthdayTextBlock.Text = student.Birthday.ToString();
            this.addressTextBlock.Text = student.Address;
            this.groupTextBlock.Text = student.GroupName;
            this.phoneNumberTextBlock.Text = student.PhoneNumber;
            this.courseTextBlock.Text = student.Course.ToString();
            this.studyFormTextBlock.Text = student.StudyForm;
        }
    }
}

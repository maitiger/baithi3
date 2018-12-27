using AppWcf.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AppWcf
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Student> student;

        internal ObservableCollection<Student> GetStudents { get => this.student; set => this.student = value; }
        public MainPage()
        {
            this.InitializeComponent();
        }

       

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student()
            {
                StudentId1 = this.StudentId.Text,
                FullName1 = this.FirtName.Text,
                LastName1 = this.LastName.Text,
                Phone1 = this.Phone.Text,
                Email1 = this.Email.Text

            };
            this.StudentId.Text = int.Studen;
            this.NameSong.Text = string.Empty;
            this.FirtName.Text = string.Empty;
            this.Phone.Text = string.Empty;
            this.Email.Text = string.Empty;
            ModelStudent.GetAllStudent();
        }
    }
}

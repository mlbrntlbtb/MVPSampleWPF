using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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
using MVPSampleWPF.Views;
using MVPSampleWPF.Presenters;

namespace MVPSampleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ITestScript
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public new string Title
        {
            get
            {
                return TitleBox.Text;
            }
            set
            {
                TitleBox.Text = value;
            }
        }
        public string Author
        {
            get 
            { 
                return AuthorBox.Text; 
            }

            set 
            { 
                AuthorBox.Text = value;
            }
        }
        public string Description 
        {
            get 
            { 
                return DescriptionBox.Text; 
            }
            set
            {
                DescriptionBox.Text = value;
            }
        }
        public string FilePath
        {
            get
            {
                string testFolderPath = @"C:\Users\Melbourne\source\repos\MVPSampleWPF\MVPSampleWPF\Tests\";
                string appendFile = System.IO.Path.Combine(testFolderPath, TitleBox.Text + ".xml");
                return appendFile;
            }
            set
            {
                TitleBox.Text = value;
            }
        }
        public string Browser
        {
            get
            {
                return BrowserComboBox.Text;
            }
            set
            {
                BrowserComboBox.SelectedValue = value;
            }
        }

        //public Dictionary<int, string> TestSteps 
        //{
        //    get
        //    {

        //    }
        //    set
        //    {

        //    }
        //}

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            TestScriptPresenter testScriptPresenter = new TestScriptPresenter(this);
            testScriptPresenter.SaveTest();
        }
    }
}

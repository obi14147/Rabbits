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
using System.IO;
using System.Data;

namespace Rabbits
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string dataFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Rabbits" + @"\Rabbits.csv";
        private Database database;
        public MainWindow()
        {
            InitializeComponent();
            database = new Database(dataFile);
            createFolder();
            if (!checkFileExists()){ return; }

            database.ReadData();
            Data[] data = database.ReturnData();

            Rabbits.ItemsSource = data;
            //List<User> users = new List<User>();
            //users.Add(new User() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23) });
            //users.Add(new User() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17) });
            //users.Add(new User() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2) });

            //dgUsers.ItemsSource = users;

        }
        
        private void btnView_click(object sender, RoutedEventArgs e)
        {
            DataRowView dataRowView = (DataRowView)((Button)e.Source).DataContext;
            string test = dataRowView[1].ToString(); //Takto nejak
        }

        //private void processData()
        //{
        //    try
        //    {
        //        database.ReadData();
        //        foreach (Data d in database.ReturnData())
        //        {

        //            string period = d.Date.ToString("MM/yyyy");
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Database could not be load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void createFolder()
        {
            string ny = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Rabbits";
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Rabbits"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Rabbits");
            }
        }

        private bool checkFileExists()
        {
            if (File.Exists(dataFile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

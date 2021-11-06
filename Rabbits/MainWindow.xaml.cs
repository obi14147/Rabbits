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
        public List<Data> dataRabbits = new List<Data>();

        public MainWindow()
        {
            InitializeComponent();
            database = new Database(dataFile);
            this.createFolder();
            if (!checkFileExists()){ return; }

            this.processData();
        }
        
        private void btnView_click(object sender, RoutedEventArgs e)
        {
            Data rowData = ((FrameworkElement)sender).DataContext as Data;
            RabbitInfo rabbitInfo = new RabbitInfo(rowData.RabbitName);
            rabbitInfo.Show();
        }

        private void processData()
        {
            this.dataRabbits.Clear();
            try
            {
                database.ReadData();
                List<Data> dataToList = new List<Data>();
                List<Data> itemsToRemove = new List<Data>();
                foreach (Data d in database.ReturnData())
                {
                    Data toGrid = new Data(
                    d.RabbitName, d.DateStart, d.DateBirth, d.DateParaMum, d.DateSplit, d.Note
                    );

                    dataToList.Add(toGrid);
                    this.dataRabbits.Add(toGrid);

                    // Check if list not contains the same rabbit, if true check the dateStart, if new is bigger
                    // Add the item to list, which items will be remove from list to grid
                    foreach (Data item in dataToList)
                    {
                        if (item.RabbitName == d.RabbitName & item.DateStart < d.DateStart)
                        {
                            itemsToRemove.Add(item);
                        }
                    }

                    foreach (Data item in itemsToRemove)
                    {
                        dataToList.Remove(item);
                    }

                    this.dataGridRabbits.ItemsSource = dataToList.ToArray();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Database could not be load", "Error");
            }
        }

        private List<Data> getInfoAboutRabbit(string rabbitName)
        {
            List<Data> dataToList = new List<Data>();
            try
            {
                database.ReadData();
                foreach (Data item in database.ReturnData())
                {
                    if (item.RabbitName == rabbitName)
                    {
                        dataToList.Add(item);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Database could not be load", "Error");
            }
            return dataToList;
        }
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

        //private void btnNewRabbit_Click(object sender, RoutedEventArgs e)
        //{
        //    NewRabbit newRabbit = new NewRabbit();
        //    newRabbit.Show();
        //    this.Close();
        //}

        private void Window_Activated(object sender, EventArgs e)
        {
            this.processData();
        }

        private void mnNewRabbit(object sender, RoutedEventArgs e)
        {
            NewRabbit newRabbit = new NewRabbit();
            newRabbit.Show();
            this.Close();
        }
    }
}

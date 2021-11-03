using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Rabbits
{
    /// <summary>
    /// Interaction logic for RabbitInfo.xaml
    /// </summary>
    /// 
    public class InfoData
    {
        public DateTime DateStart { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime DateParaMum { get; set; }
        public DateTime DateSplit { get; set; }
        public string Note { get; set; }
        public InfoData(DateTime dateStart, DateTime dateBirth, DateTime dateParaMum, DateTime dateSplit, string note)
        {
            DateStart = dateStart;
            DateBirth = dateBirth;
            DateParaMum = dateParaMum;
            DateSplit = dateSplit;
            Note = note;
        }
    }
    public partial class RabbitInfo : Window
    {
        private MainWindow mainWindow = new MainWindow();
        //List<Data> dataRabbits = mainWindow.dataRabbits;

        public RabbitInfo(string rabbitName)
        {
            InitializeComponent();
            dataFromDatabaseToDc(rabbitName);
        }

        private void dataFromDatabaseToDc(string rabbitName)
        {
            List<InfoData> dataToList = new List<InfoData>();
            foreach (Data rabbit in mainWindow.dataRabbits)
            {
                if (rabbit.RabbitName == rabbitName)
                {
                    InfoData toGrid = new InfoData(
                    rabbit.DateStart, rabbit.DateBirth, rabbit.DateParaMum, rabbit.DateSplit, rabbit.Note
                    );
                    dataToList.Add(toGrid);
                }
            }
            this.dataGridRabbits.ItemsSource = dataToList.ToArray();
            this.lblRabbitName.Content = rabbitName;

        }
    }
}

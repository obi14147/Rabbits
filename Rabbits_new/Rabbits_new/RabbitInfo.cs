using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rabbits_new
{    public partial class RabbitInfo : Form
    {
        private MainWindow mainWindow = new MainWindow();
        public RabbitInfo(string rabbitName)
        {
            InitializeComponent();
            this.lblName.Text = rabbitName;
            this.InitializeGrid();

            dataFromDatabaseToGrid(rabbitName);
        }

        #region Initialize component
        private void InitializeGrid()
        {
            this.dataGridInfo.ColumnCount = 5;
            this.dataGridInfo.Columns[0].Name = "Nahóňěná";
            this.dataGridInfo.Columns[1].Name = "Kocení";
            this.dataGridInfo.Columns[2].Name = "Odstav";
            this.dataGridInfo.Columns[3].Name = "Rozdělení";
            this.dataGridInfo.Columns[4].Name = "Poznámky";
        }
        #endregion
        private void dataFromDatabaseToGrid(string rabbitName)
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

            foreach (InfoData rab in dataToList)
            {
                this.dataGridInfo.Rows.Add(rab.DateStart.ToString("dd.MM.yyyy"), rab.DateBirth.ToString("dd.MM.yyyy"), rab.DateParaMum.ToString("dd.MM.yyyy"), rab.DateSplit.ToString("dd.MM.yyyy"), rab.Note);
            }
            //this.dataGridRabbits.ItemsSource = dataToList.ToArray();
            //this.lblRabbitName.Content = rabbitName;

        }
    }
}

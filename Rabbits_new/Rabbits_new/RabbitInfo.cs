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
        private DatabaseFemale database;
        private CalculateDate calculateDate;
        private string RabbitName { get; set; }

        public RabbitInfo(string rabbitName)
        {
            RabbitName = rabbitName;
            InitializeComponent();
            
            database = new DatabaseFemale(MainWindow.dataFileFemaleRabbits);

            this.lblName.Text = rabbitName;
            this.InitializeGrid();

            this.dataFromDatabaseToGrid();
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
        private void dataFromDatabaseToGrid()
        {
            this.dataGridInfo.Rows.Clear();

            List<InfoData> dataToList = new List<InfoData>();
            foreach (DataFemale rabbit in mainWindow.dataRabbits)
            {
                if (rabbit.RabbitName == this.RabbitName)
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
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            calculateDate = new CalculateDate();
            if (this.dtTmStart.Text == "")
            {
                MessageBox.Show("Write a start date!", "Warning");
                return;
            }
            DateTime dateStart;
            if (!DateTime.TryParse(this.dtTmStart.Text, out dateStart))
                MessageBox.Show("Unable to convert '{0}' to a date.", this.dtTmStart.Text);

            DateTime[] dates = calculateDate.getDates(dateStart);

            database.AddData(this.RabbitName, dateStart, dates[0], dates[1], dates[2], this.txtNote.Text);
            try
            {
                database.SaveData();
            }
            catch (Exception)
            {
                MessageBox.Show("Database could not be saved", "Error");
            }
            mainWindow.processData();
            this.dataFromDatabaseToGrid();
        }
    }
}

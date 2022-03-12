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
        private List<InfoData> dataToList = new List<InfoData>();
        public RabbitInfo(string rabbitName, string category)
        {
            RabbitName = rabbitName;
            InitializeComponent();
            
            database = new DatabaseFemale(MainWindow.dataFileFemaleRabbits);

            this.lblName.Text = rabbitName;
            this.InitializeGrid();

            if (category == "Samica")
            {
                this.dataFromDatabaseToGrid();
            }
            else
            {
                this.dataGridInfo.Hide();
                this.txtNote.Hide();
                this.dtTmStart.Hide();
                this.btnStart.Hide();
            }
        }

        #region Initialize component
        private void InitializeGrid()
        {
            this.dataGridInfo.ColumnCount = 6;
            this.dataGridInfo.Columns[0].Name = "Nahóňěná";
            this.dataGridInfo.Columns[0].ReadOnly = true;
            this.dataGridInfo.Columns[1].Name = "Kocení";
            this.dataGridInfo.Columns[1].ReadOnly = true;
            this.dataGridInfo.Columns[2].Name = "Odstav";
            this.dataGridInfo.Columns[2].ReadOnly = true;
            this.dataGridInfo.Columns[3].Name = "Rozdělení";
            this.dataGridInfo.Columns[3].ReadOnly = true;
            this.dataGridInfo.Columns[4].Name = "Poznámky";
            this.dataGridInfo.Columns[5].Name = "Počet mladých";
        }
        #endregion
        private void dataFromDatabaseToGrid()
        {
            this.dataGridInfo.Rows.Clear();
            dataToList.Clear();

            foreach (DataFemale rabbit in mainWindow.dataRabbits)
            {
                if (rabbit.RabbitName == this.RabbitName)
                {
                    InfoData toGrid = new InfoData(
                    rabbit.DateStart, rabbit.DateBirth, rabbit.DateParaMum, rabbit.DateSplit, rabbit.Note, rabbit.NumberKids
                    );
                    dataToList.Add(toGrid);
                }
            }

            foreach (InfoData rab in dataToList)
            {
                this.dataGridInfo.Rows.Add(rab.DateStart.ToString("dd.MM.yyyy"), rab.DateBirth.ToString("dd.MM.yyyy"), rab.DateParaMum.ToString("dd.MM.yyyy"), rab.DateSplit.ToString("dd.MM.yyyy"), rab.Note, rab.NumberKids);
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

            database.AddData(this.RabbitName, dateStart, dates[0], dates[1], dates[2], this.txtNote.Text, 0);
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

        //TODO: Kdyz je zmena poznamky, nebo poctu mladat - porjit celu tabulku a pak opravit data v databazi
        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}

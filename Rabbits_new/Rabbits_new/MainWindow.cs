using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rabbits_new
{
    public partial class MainWindow : Form
    {
        public static string dataFileFemaleRabbits = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Rabbits" + @"\RabbitsFemale_test.csv";
        public static string dataFileAllRabbits = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Rabbits" + @"\RabbitsAll_test.csv";
        private DatabaseFemale databaseFemale;
        private DatabaseRabbits databaseAllRabbits;

        private CalculateDate calculateDate;
        public List<DataFemale> dataRabbits = new List<DataFemale>();
        public MainWindow()
        {
            InitializeComponent();
            this.InitializeGrid();

            //this.dpStart.SelectedDate = DateTime.Today;
            databaseFemale = new DatabaseFemale(dataFileFemaleRabbits);
            databaseAllRabbits = new DatabaseRabbits(dataFileAllRabbits);

            this.createFolder();
            //TODO: Not work correctly
            if (!checkFileExists(dataFileFemaleRabbits)) { return; }
            if (!checkFileExists(dataFileAllRabbits)) { return; }

            this.processData();
        }
        #region Initialize component
        private void InitializeGrid()
        {
            dataGridRabbits.ColumnCount = 4;
            dataGridRabbits.Columns[0].Name = "Králík";
            dataGridRabbits.Columns[1].Name = "Narození";
            dataGridRabbits.Columns[2].Name = "Smrt";
            dataGridRabbits.Columns[3].Name = "Poznámky";

            DataGridViewButtonColumn btnMore = new DataGridViewButtonColumn();
            btnMore.Text = "Podrobnosti";
            btnMore.UseColumnTextForButtonValue = true;
            dataGridRabbits.Columns.Add(btnMore);

            //dataGridRabbits.ColumnCount = 6;
            //dataGridRabbits.Columns[0].Name = "Králík";
            //dataGridRabbits.Columns[0].ReadOnly = true;
            //dataGridRabbits.Columns[1].Name = "Nahóňěná";
            //dataGridRabbits.Columns[1].ReadOnly = true;
            //dataGridRabbits.Columns[2].Name = "Kocení";
            //dataGridRabbits.Columns[2].ReadOnly = true;
            //dataGridRabbits.Columns[3].Name = "Odstav";
            //dataGridRabbits.Columns[3].ReadOnly = true;
            //dataGridRabbits.Columns[4].Name = "Rozdělení";
            //dataGridRabbits.Columns[4].ReadOnly = true;
            //dataGridRabbits.Columns[5].Name = "Poznámky";

            //DataGridViewButtonColumn btnMore = new DataGridViewButtonColumn();
            //btnMore.Text = "Podrobnosti";
            //btnMore.UseColumnTextForButtonValue = true;
            //dataGridRabbits.Columns.Add(btnMore);
        }

        private void dataGridRabbits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int rowIndex = dataGridRabbits.CurrentCell.RowIndex;
                string name = dataGridRabbits.Rows[rowIndex].Cells[0].Value.ToString();
                string category = dataGridRabbits.Rows[rowIndex].Cells[3].Value.ToString();
                RabbitInfo rabbitInfo = new RabbitInfo(name, category);
                rabbitInfo.Show();
            }
        }
        #endregion

        public void processData()
        {
            this.dataGridRabbits.Rows.Clear();
            this.dataRabbits.Clear();
            try
            {
                databaseFemale.ReadData();
                foreach (DataFemale d in databaseFemale.ReturnData())
                {
                    DataFemale toList = new DataFemale(
                    d.RabbitName, d.DateStart, d.DateBirth, d.DateParaMum, d.DateSplit, d.Note, d.NumberKids
                    );
                    this.dataRabbits.Add(toList);
                }

                databaseAllRabbits.ReadData();
                foreach (DataAllRabbits rabbit in databaseAllRabbits.ReturnData())
                {
                    string dateDeathString = rabbit.DateDeath.ToString("dd.MM.yyyy");
                    if (rabbit.DateDeath.Year == DateTime.MaxValue.Year)
                    {
                        dateDeathString = "";
                    }
                    this.dataGridRabbits.Rows.Add(rabbit.RabbitName, rabbit.DateBirth.ToString("dd.MM.yyyy"), dateDeathString, rabbit.Category, rabbit.Note);

                }
                //databaseFemale.ReadData();
                //List<DataFemale> dataToList = new List<DataFemale>();
                //List<DataFemale> itemsToRemove = new List<DataFemale>();
                //foreach (DataFemale d in databaseFemale.ReturnData())
                //{
                //    DataFemale toGrid = new DataFemale(
                //    d.RabbitName, d.DateStart, d.DateBirth, d.DateParaMum, d.DateSplit, d.Note
                //    );

                //    dataToList.Add(toGrid);
                //    this.dataRabbits.Add(toGrid);

                //    // Check if list not contains the same rabbit, if true check the dateStart, if new is bigger
                //    // Add the item to list, which items will be remove from list to grid
                //    foreach (DataFemale item in dataToList)
                //    {
                //        if (item.RabbitName == d.RabbitName & item.DateStart < d.DateStart)
                //        {
                //            itemsToRemove.Add(item);
                //        }
                //    }

                //    foreach (DataFemale item in itemsToRemove)
                //    {
                //        dataToList.Remove(item);
                //    }
                //}
                //foreach (DataFemale rab in dataToList)
                //{
                //    this.dataGridRabbits.Rows.Add(rab.RabbitName, rab.DateStart.ToString("dd.MM.yyyy"), rab.DateBirth.ToString("dd.MM.yyyy"), rab.DateParaMum.ToString("dd.MM.yyyy"), rab.DateSplit.ToString("dd.MM.yyyy"), rab.Note);
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show("Database could not be load " + e, "Error");
            }
        }
        private void createFolder()
        {
            string ny = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Rabbits";
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Rabbits"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Rabbits");
            }
        }
        private bool checkFileExists(string file_path)
        {
            if (File.Exists(file_path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void newRabbitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRabbit newRabbit = new NewRabbit();
            newRabbit.Show();
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            this.processData();
        }
    }
}

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
        public static string dataFolderRabbits = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Rabbits";
        public static string dataFolderInfoToPrint = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Rabbits\InfoToPrint";

        public static string dataFileFemaleRabbits = dataFolderRabbits + @"\RabbitsFemale.csv";
        public static string dataFileAllRabbits = dataFolderRabbits + @"\RabbitsAll.csv";
        private DatabaseFemale databaseFemale;
        private DatabaseRabbits databaseAllRabbits;

        public List<DataFemale> dataRabbits = new List<DataFemale>();
        public MainWindow()
        {
            InitializeComponent();
            this.InitializeGrid();

            databaseFemale = new DatabaseFemale(dataFileFemaleRabbits);
            databaseAllRabbits = new DatabaseRabbits(dataFileAllRabbits);

            this.createFolder(dataFolderRabbits);
            this.createFolder(dataFolderInfoToPrint);
            this.createFile(dataFileFemaleRabbits);
            this.createFile(dataFileAllRabbits);

            this.processData();
        }
        #region Initialize component
        private void InitializeGrid()
        {
            dataGridRabbits.ColumnCount = 5;
            dataGridRabbits.Columns[0].Name = "Králík";
            dataGridRabbits.Columns[1].Name = "Narození";
            dataGridRabbits.Columns[2].Name = "Smrt";
            dataGridRabbits.Columns[3].Name = "Kategorie";
            dataGridRabbits.Columns[4].Name = "Poznámky";

            DataGridViewButtonColumn btnMore = new DataGridViewButtonColumn();
            btnMore.Text = "Podrobnosti";
            btnMore.UseColumnTextForButtonValue = true;
            dataGridRabbits.Columns.Add(btnMore);
        }

        private void dataGridRabbits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
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
            }
            catch (Exception e)
            {
                MessageBox.Show("Database could not be load " + e, "Error");
            }
        }
        private void createFolder(string folderName)
        {
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
        }
        private void createFile(string file_path)
        {
            if (!File.Exists(file_path))
            {
                File.Create(file_path);
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

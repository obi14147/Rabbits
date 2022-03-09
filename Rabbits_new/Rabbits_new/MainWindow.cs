﻿using System;
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
        public static string dataFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Rabbits" + @"\Rabbits_test.csv";
        private Database database;
        private CalculateDate calculateDate;
        public List<Data> dataRabbits = new List<Data>();
        public MainWindow()
        {
            InitializeComponent();
            this.InitializeGrid();

            //this.dpStart.SelectedDate = DateTime.Today;
            database = new Database(dataFile);
            this.createFolder();
            if (!checkFileExists()) { return; }
            this.processData();
        }
        #region Initialize component
        private void InitializeGrid()
        {
            dataGridRabbits.ColumnCount = 6;
            dataGridRabbits.Columns[0].Name = "Králík";
            dataGridRabbits.Columns[1].Name = "Nahóňěná";
            dataGridRabbits.Columns[2].Name = "Kocení";
            dataGridRabbits.Columns[3].Name = "Odstav";
            dataGridRabbits.Columns[4].Name = "Rozdělení";
            dataGridRabbits.Columns[5].Name = "Poznámky";

            DataGridViewButtonColumn btnMore = new DataGridViewButtonColumn();
            btnMore.Text = "Podrobnosti";
            btnMore.UseColumnTextForButtonValue = true;
            dataGridRabbits.Columns.Add(btnMore);
        }

        private void dataGridRabbits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int rowIndex = dataGridRabbits.CurrentCell.RowIndex;
                string name = dataGridRabbits.Rows[rowIndex].Cells[0].Value.ToString();
                RabbitInfo rabbitInfo = new RabbitInfo(name);
                rabbitInfo.Show();
            }
        }
        #endregion

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
                }
                foreach (Data rab in dataToList)
                {
                    this.dataGridRabbits.Rows.Add(rab.RabbitName, rab.DateStart.ToString("dd.MM.yyyy"), rab.DateBirth.ToString("dd.MM.yyyy"), rab.DateParaMum.ToString("dd.MM.yyyy"), rab.DateSplit.ToString("dd.MM.yyyy"), rab.Note);
                }
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

        private void newRabbitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRabbit newRabbit = new NewRabbit();
            newRabbit.Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Rabbits_new
{    public partial class RabbitInfo : Form
    {
        private MainWindow mainWindow = new MainWindow();
        private DatabaseFemale database;
        private CalculateDate calculateDate;
        private string RabbitName { get; set; }
        private List<InfoData> dataToList = new List<InfoData>();

        private Font printFont;
        private StreamReader streamToPrint;
        private string printer;
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
                this.grBxStart.Hide();
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

        private void saveChanges()
        {
            for (int i = 0; i < this.dataGridInfo.RowCount; i++)
            {
                string rabbitName = this.lblName.Text;
                string dateStart = this.dataGridInfo.Rows[i].Cells[0].Value.ToString();
                string dateBirth = this.dataGridInfo.Rows[i].Cells[1].Value.ToString();
                string dateParaMum = this.dataGridInfo.Rows[i].Cells[2].Value.ToString();
                string dateSplit = this.dataGridInfo.Rows[i].Cells[3].Value.ToString();

                string noteCheck = this.dataGridInfo.Rows[i].Cells[4].Value.ToString();
                int numberKidsCheck = Int32.Parse(this.dataGridInfo.Rows[i].Cells[5].Value.ToString());

                string noteOld = dataToList[i].Note;
                int numberKidsOld = dataToList[i].NumberKids;

                if (noteCheck != noteOld || numberKidsCheck != numberKidsOld)
                {
                    string[] oldData = { rabbitName, dateStart, dateBirth, dateParaMum, dateSplit, noteOld, numberKidsOld.ToString() };
                    string[] newData = { rabbitName, dateStart, dateBirth, dateParaMum, dateSplit, noteCheck, numberKidsCheck.ToString() };
                    database.EditData(oldData, newData);
                }
            }
        }
        private void prepareToPrintData(string[] infoToPrint)
        {
            DateTime today = DateTime.Now;
            string fileName = this.RabbitName + "_" + GetTimestamp(today) + ".txt";
            string path = MainWindow.dataFolderInfoToPrint + @"\" + fileName;
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                string data = "--------------------------------------\n" +
                    $"|  Králík:_______{infoToPrint[0]} |\n" +
                    $"|  Připuštěna:___{infoToPrint[1]} |\n" +
                    $"|  Kocení:_______{infoToPrint[2]} |\n" +
                    $"|  Odstav:_______{infoToPrint[3]} |\n" +
                    $"|  Rozdělení:____{infoToPrint[4]} |\n" +
                    "--------------------------------------";
                sw.WriteLine(data);
                sw.Flush();
            }
            this.printData(path);
            this.deleteFile(path);
        }

        private void printData(string path)
        {
            selectPrinter();
            try
            {
                streamToPrint = new StreamReader(path);
                try
                {
                    printFont = new Font("Arial", 12);
                    this.printRabbitInfo.PrinterSettings.PrinterName = printer;
                    this.printRabbitInfo.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                    this.printRabbitInfo.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void selectPrinter()
        {
            using (Form form = new Form())
            {
                ComboBox cmBxPrinters = new ComboBox();
                Button btnConfirmPrinter = new Button();

                form.Text = "Vyberte tiskárnu";
                form.Size = new Size(500, 200);
                form.FormBorderStyle = FormBorderStyle.FixedSingle;

                cmBxPrinters.Dock = DockStyle.Top;
                cmBxPrinters.DropDownStyle = ComboBoxStyle.DropDownList;

                btnConfirmPrinter.Text = "Potvrdit";
                btnConfirmPrinter.Dock = DockStyle.Bottom;
                btnConfirmPrinter.Size = new Size(200, 50);
                btnConfirmPrinter.Click += new EventHandler(btnConfirmPrinter_Click);

                form.Controls.Add(cmBxPrinters);
                form.Controls.Add(btnConfirmPrinter);

                for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                {
                    printer = PrinterSettings.InstalledPrinters[i];
                    cmBxPrinters.Items.Add(printer);
                    if (this.printRabbitInfo.PrinterSettings.IsDefaultPrinter)
                    {
                        cmBxPrinters.Text = this.printRabbitInfo.PrinterSettings.PrinterName;
                    }
                }

                form.ShowDialog();
                printer = cmBxPrinters.Text;

                void btnConfirmPrinter_Click(object sender, EventArgs e)
                {
                    form.Close();
                }
            }
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            while (count < linesPerPage && ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }
        }
        private static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        private void deleteFile(string path)
        {
            try
            { 
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
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
            // Possible printing
            DialogResult dgRes = MessageBox.Show("Přejete si data i rovnou vytisknout?", "Tisk", MessageBoxButtons.YesNo);
            if (dgRes == DialogResult.Yes)
            {
                string[] dataToPrint =
                {
                    this.RabbitName,
                    dateStart.ToString("dd.MM.yyyy"),
                    dates[0].ToString("dd.MM.yyyy"),
                    dates[1].ToString("dd.MM.yyyy"),
                    dates[2].ToString("dd.MM.yyyy")
                };
                this.prepareToPrintData(dataToPrint);
            }
            mainWindow.processData();
            this.dataFromDatabaseToGrid();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.saveChanges();
            this.Close();
        }

        private void RabbitInfo_Deactivate(object sender, EventArgs e)
        {
            this.saveChanges();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dataGridInfo.CurrentCell.RowIndex;
            string[] dataToPrint = 
            {
                this.lblName.Text,
                this.dataGridInfo.Rows[rowIndex].Cells[0].Value.ToString(),
                this.dataGridInfo.Rows[rowIndex].Cells[1].Value.ToString(),
                this.dataGridInfo.Rows[rowIndex].Cells[2].Value.ToString(),
                this.dataGridInfo.Rows[rowIndex].Cells[3].Value.ToString()
            };
            this.prepareToPrintData(dataToPrint);
        }
    }
}

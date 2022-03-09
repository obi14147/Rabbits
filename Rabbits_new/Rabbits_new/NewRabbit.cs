using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rabbits_new
{
    public partial class NewRabbit : Form
    {
        private Database database;
        private CalculateDate calculateDate;
        public NewRabbit()
        {
            InitializeComponent();
            database = new Database(MainWindow.dataFile);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            calculateDate = new CalculateDate();
            if (this.txtName.Text == "")
            {
                MessageBox.Show("Write a rabbit name!", "Warning");
                return;
            }
            else if (this.dtTmStart.Text == "")
            {
                MessageBox.Show("Write a start date!", "Warning");
                return;
            }
            DateTime dateStart;
            if (!DateTime.TryParse(this.dtTmStart.Text, out dateStart))
                MessageBox.Show("Unable to convert '{0}' to a date.", this.dtTmStart.Text);

            DateTime[] dates = calculateDate.getDates(dateStart);

            database.AddData(this.txtName.Text, dateStart, dates[0], dates[1], dates[2], txtNote.Text);
            try
            {
                database.SaveData();
            }
            catch (Exception)
            {

                MessageBox.Show("Database could not be saved", "Error");
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

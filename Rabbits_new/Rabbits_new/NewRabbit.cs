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
        private DatabaseRabbits databaseRabbits;
        public NewRabbit()
        {
            InitializeComponent();
            databaseRabbits = new DatabaseRabbits(MainWindow.dataFileAllRabbits);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text == "")
            {
                MessageBox.Show("Write a rabbit name!", "Warning");
                return;
            }
            else if (this.cmBoxCategory.Text == "")
            {
                MessageBox.Show("Write a rabbit category!", "Warning");
                return;
            }
            else if (this.dtTmBirth.Text == "")
            {
                MessageBox.Show("Write a birth date!", "Warning");
                return;
            }
            DateTime dateStart;
            if (!DateTime.TryParse(this.dtTmBirth.Text, out dateStart))
                MessageBox.Show("Unable to convert '{0}' to a date.", this.dtTmBirth.Text);

            DateTime dateDeath = DateTime.MaxValue;

            databaseRabbits.AddData(this.txtName.Text, dateStart, dateDeath,this.cmBoxCategory.Text, this.txtNote.Text);
            try
            {
                databaseRabbits.SaveData();
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

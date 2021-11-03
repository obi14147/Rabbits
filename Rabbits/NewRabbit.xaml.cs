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
using System.ComponentModel;

namespace Rabbits
{
    /// <summary>
    /// Interaction logic for NewRabbit.xaml
    /// </summary>
    public partial class NewRabbit : Window
    {
        private MainWindow mainWindow = new MainWindow();
        private Database database;
        private CalculateDate calculateDate;
        public NewRabbit()
        {
            InitializeComponent();
            database = new Database(MainWindow.dataFile);
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            calculateDate = new CalculateDate();
            if (txtBoxRabbitName.Text == "")
            {
                MessageBox.Show("Write a rabbit name!", "Warning");
                return;
            }
            else if (txtStartDate.Text == "")
            {
                MessageBox.Show("Write a start date!", "Warning");
                return;
            }
            DateTime dateStart;
            if (!DateTime.TryParse(txtStartDate.Text, out dateStart))
                MessageBox.Show("Unable to convert '{0}' to a date.", txtStartDate.Text);

            DateTime[] dates = calculateDate.getDates(dateStart);

            database.AddData(txtBoxRabbitName.Text, dateStart, dates[0], dates[1], dates[2], txtNote.Text);
            try
            {
                database.SaveData();
            }
            catch (Exception)
            {

                MessageBox.Show("Database could not be saved", "Error");
            }

            this.Close();
            mainWindow.Show();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }

        private void NewRabbit_Closing(object sender, CancelEventArgs e)
        {
            mainWindow.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Rabbits_new
{
    public class DataAllRabbits
    {
        public string RabbitName { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime DateDeath { get; set; }
        public string Sex { get; set; }
        public string Note { get; set; }
        public DataAllRabbits(string rabbitName, DateTime dateBirth, DateTime dateDeath, string sex, string note)
        {
            RabbitName = rabbitName;
            DateBirth = dateBirth;
            DateDeath = dateDeath;
            Sex = sex;
            Note = note;
        }
    }

    class DatabaseRabbits
    {
        private List<DataAllRabbits> data;
        private string file;

        public DatabaseRabbits(string file)
        {
            data = new List<DataAllRabbits>();
            this.file = file;
        }
        public void AddData(string rabbitName, DateTime dateBirth, DateTime dateDeath, string sex, string note)
        {
            DataAllRabbits d = new DataAllRabbits(rabbitName, dateBirth, dateDeath, sex, note);
            data.Add(d);
        }

        public DataAllRabbits[] ReturnData()
        {
            return data.ToArray();
        }

        public void SaveData()
        {
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                foreach (DataAllRabbits d in data)
                {
                    string[] data = { d.RabbitName, d.DateBirth.ToString("dd/MM/yyyy"), d.DateDeath.ToString("dd/MM/yyyy"), d.Sex, d.Note };
                    string line = String.Join(";", data);
                    sw.WriteLine(line);
                }
                sw.Flush();
            }
        }

        public void ReadData()
        {
            data.Clear();
            using (StreamReader sr = new StreamReader(file))
            {
                string l;

                while ((l = sr.ReadLine()) != null)
                {
                    string[] splitted = l.Split(';');
                    string rabbitName = splitted[0];
                    DateTime dateBirth = DateTime.Parse(splitted[1]);
                    DateTime dateDeath = DateTime.Parse(splitted[2]);
                    string sex = splitted[3];
                    string note = splitted[4];
                    AddData(rabbitName, dateBirth, dateDeath, sex, note);
                }
            }
        }

        public void DeleteData(string rabbitName, string dateStart, string dateBirth, string dateParaMum, string dateSplit, string note)
        {
            string searchedLine = $"{rabbitName};{dateStart};{dateStart};{dateBirth};{dateParaMum};{dateSplit};{note}";
            List<string> lines = new List<string>();

            using (StreamReader sr = new StreamReader(file))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line == searchedLine)
                    {
                        line = "";
                    }
                    else
                    {
                        lines.Add(line);
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(file, false))
            {
                foreach (string ln in lines)
                {
                    sw.WriteLine(ln);
                }
                sw.Flush();
            }
        }
    }
}

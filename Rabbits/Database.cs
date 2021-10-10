using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Rabbits
{
    public class Data
    {
        public string RabbitName { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime DateParaMum { get; set; }
        public DateTime DateSplit { get; set; }
        public string Note { get; set; }
        public Data(string rabbitName, DateTime dateStart, DateTime dateBirth, DateTime dateParaMum, DateTime dateSplit, string note)
        {
            RabbitName = rabbitName;
            DateStart = dateStart;
            DateBirth = dateBirth;
            DateParaMum = dateParaMum;
            DateSplit = dateSplit;
            Note = note;
        }
    }
    class Database
    {
        private List<Data> data;
        private string file;

        public Database(string file)
        {
            data = new List<Data>();
            this.file = file;
        }
        public void AddData(string rabbitName, DateTime dateStart, DateTime dateBirth, DateTime dateParaMum, DateTime dateSplit, string note)
        {
            Data d = new Data(rabbitName, dateStart, dateBirth, dateParaMum, dateSplit, note);
            data.Add(d);
        }

        public Data[] ReturnData()
        {
            return data.ToArray();
        }

        public void SaveData()
        {
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                foreach (Data d in data)
                {
                    string[] data = { d.RabbitName, d.DateStart.ToString("dd/MM/yyyy"),d.DateBirth.ToString("dd/MM/yyyy"), d.DateParaMum.ToString("dd/MM/yyyy"), d.DateSplit.ToString("dd/MM/yyyy"), d.Note };
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
                    DateTime dateStart = DateTime.Parse(splitted[1]);
                    DateTime dateBirth = DateTime.Parse(splitted[2]);
                    DateTime dateParaMum = DateTime.Parse(splitted[3]);
                    DateTime dateSplit = DateTime.Parse(splitted[4]);
                    string note = splitted[5];
                    AddData(rabbitName, dateStart, dateBirth, dateParaMum, dateSplit, note);
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

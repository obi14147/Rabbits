using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Rabbits_new
{
    public class DataFemale
    {
        public string RabbitName { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime DateParaMum { get; set; }
        public DateTime DateSplit { get; set; }
        public string Note { get; set; }
        public int NumberKids { get; set; }
        public DataFemale(string rabbitName, DateTime dateStart, DateTime dateBirth, DateTime dateParaMum, DateTime dateSplit, string note, int numberKids)
        {
            RabbitName = rabbitName;
            DateStart = dateStart;
            DateBirth = dateBirth;
            DateParaMum = dateParaMum;
            DateSplit = dateSplit;
            Note = note;
            NumberKids = numberKids;
        }
    }
    class DatabaseFemale
    {
        private List<DataFemale> data;
        private string file;

        public DatabaseFemale(string file)
        {
            data = new List<DataFemale>();
            this.file = file;
        }
        public void AddData(string rabbitName, DateTime dateStart, DateTime dateBirth, DateTime dateParaMum, DateTime dateSplit, string note, int numberKids)
        {
            DataFemale d = new DataFemale(rabbitName, dateStart, dateBirth, dateParaMum, dateSplit, note, numberKids);
            data.Add(d);
        }

        public DataFemale[] ReturnData()
        {
            return data.ToArray();
        }

        public void SaveData()
        {
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                foreach (DataFemale d in data)
                {
                    string[] data = { d.RabbitName, d.DateStart.ToString("dd/MM/yyyy"), d.DateBirth.ToString("dd/MM/yyyy"), d.DateParaMum.ToString("dd/MM/yyyy"), d.DateSplit.ToString("dd/MM/yyyy"), d.Note, d.NumberKids.ToString() };
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
                    int numberKids = Int32.Parse(splitted[6]);
                    AddData(rabbitName, dateStart, dateBirth, dateParaMum, dateSplit, note, numberKids);
                }
            }
        }
        public void DeleteData(string rabbitName, string dateStart, string dateBirth, string dateParaMum, string dateSplit, string note, string numberKids)
        {
            string searchedLine = $"{rabbitName};{dateStart};{dateBirth};{dateParaMum};{dateSplit};{note};{numberKids}";
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
        public void EditData(string[] oldData, string[] newData)
        {
            string searchedLine = $"{oldData[0]};{oldData[1]};{oldData[2]};{oldData[3]};{oldData[4]};{oldData[5]};{oldData[6]}";
            string newLine = $"{newData[0]};{newData[1]};{newData[2]};{newData[3]};{newData[4]};{newData[5]};{newData[6]}";
            List<string> lines = new List<string>();

            using (StreamReader sr = new StreamReader(file))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line == searchedLine)
                    {
                        line = newLine;
                    }
                    lines.Add(line);
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

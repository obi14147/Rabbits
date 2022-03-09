using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbits_new
{
    public class InfoData
    {
        public DateTime DateStart { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime DateParaMum { get; set; }
        public DateTime DateSplit { get; set; }
        public string Note { get; set; }
        public InfoData(DateTime dateStart, DateTime dateBirth, DateTime dateParaMum, DateTime dateSplit, string note)
        {
            DateStart = dateStart;
            DateBirth = dateBirth;
            DateParaMum = dateParaMum;
            DateSplit = dateSplit;
            Note = note;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les11
{
    internal class Warlord
    {
        public string Fio { get; set; }
        private int numberOfBattles;
        public int NumberOfBattles
        {
            get => numberOfBattles;
            set
            {
                if (value >= 0) numberOfBattles = value;
            }
        }
        private int numberWins;
        public int NumberWins 
        { 
            get => numberWins;
            set { if (value >= 0) numberWins = value; } 
        }
        public Warlord(string fio, int numberOfBattles, int numberWins)
        {
            Fio = fio;
            NumberOfBattles = numberOfBattles;
            NumberWins = numberWins;
        }

        public virtual double GetQuality()
        {
            return (double)(NumberWins * NumberWins) / NumberOfBattles;
        }

        public override string? ToString()
        {
            return $"ФИО:{Fio}, количество битв:{NumberOfBattles}," +
                $" количество побед:{NumberWins}.Коэффициент:{GetQuality()}";
        }
    }
}

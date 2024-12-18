using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les11
{
    internal class WarlordSuper:Warlord
    {
        private int numberSuperWin;
        public int NumberSuperWin
        {
            get => numberSuperWin;
            set
            {
                if (value >= 0&&value<=NumberOfBattles) 
                    numberSuperWin = value;
            }
        }
        public WarlordSuper(string fio, int numberOfBattles, int numberWins, int _numberSuperWin) : base(fio, numberOfBattles, numberWins)
        {
            NumberSuperWin = _numberSuperWin;
        }

        public override double GetQuality()
        {
            return (NumberSuperWin*NumberSuperWin/NumberOfBattles) +base.GetQuality();
        }

        public override string? ToString()
        {
            return $"ФИО:{Fio}, количество битв:{NumberOfBattles}," +
                $" количество побед:{NumberWins}," +
                $" количество побед с превосходящими силами:{NumberSuperWin}.Коэффициент:{GetQuality()}";
        }
    }
}

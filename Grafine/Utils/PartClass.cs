using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafine.Utils
{
    class PartClass
    {
        public int ID;
        public string Mark;
        public string Type;
        public int Year;
        public string Maker;
        public int Price;
        public int Amount;
        public string Code;

        public PartClass()
        {

        }
        public PartClass(int id, string mark, string type, int year, string maker, int price, int amount, string code)
        {
            this.ID = id;
            this.Mark = mark;
            this.Type = type;
            this.Year = year;
            this.Maker = maker;
            this.Price = price;
            this.Amount = amount;
            this.Code = code;
        }
    }
}

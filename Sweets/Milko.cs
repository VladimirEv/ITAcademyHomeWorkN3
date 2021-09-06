using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskItAcademy.Sweets
{
    public class Milko : SweetsParametrs
    {
        public Milko() : base(4, "Milko", 1, 1.8, 1.7)
        {
            SweetPosition = 4;
            SweetName = "Milko";
            SweetWeight = 1;
            SweetSugar = 1.8;
            SweetCostInKg = 1.7;
        }
    }
}

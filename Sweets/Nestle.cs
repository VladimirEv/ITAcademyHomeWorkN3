using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskItAcademy.Sweets
{ 
    public class Nestle : SweetsParametrs
    {
        public Nestle() : base(3, "Nestle", 1, 1.4, 3.2)
        {
            SweetPosition = 3;
            SweetName = "Nestle";
            SweetWeight = 1;
            SweetSugar = 1.4;
            SweetCostInKg = 3.2;
        }
    }
}

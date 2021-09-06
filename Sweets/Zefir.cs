using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskItAcademy.Sweets
{
    public class Zefir : SweetsParametrs
    {
        public Zefir() : base(7, "Zefir", 1, 1.1, 2.5)
        {
            SweetPosition = 7;
            SweetName = "Zefir";
            SweetWeight = 1;
            SweetSugar = 1.1;
            SweetCostInKg = 2.5;
        }
    }
}

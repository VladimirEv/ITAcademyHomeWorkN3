using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskItAcademy
{
    public abstract class SweetsParametrs
    {
        public int SweetPosition { get; set; }
        public string SweetName { get; set; }
        public double SweetWeight { get; set; }
        public double SweetSugar { get; set; }
        public double SweetCostInKg { get; set; }

        protected SweetsParametrs(int sweetPosition, string sweetName, double sweetWeight, double sweetSugar, double sweetCostInKg)
        { 
            SweetPosition = sweetPosition;
            SweetName = sweetName;
            SweetWeight = sweetWeight;
            SweetSugar = sweetSugar;
            SweetCostInKg = sweetCostInKg;
        }

    }
}

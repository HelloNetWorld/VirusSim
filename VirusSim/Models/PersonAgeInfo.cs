using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace VirusSim.Models
{
    public class PersonAgeInfo
    {
        private double _average = -1;

        public string Name { get; set; }
        public double Total { get; set; }
        public int Count { get; set; }
        public double Average
        {
            get
            {
                if (_average == -1)
                {
                    CalculateAverage();
                }
                return _average;
            }
        }

        private void CalculateAverage()
        {
            if (Count > 0)
            {
                _average = Total / Count;
            }
        }
    }
}

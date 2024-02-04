using System;
using System.Collections.Generic;
using System.Linq;
using HighwayToPeak.Models.Contracts;
using System.Text;
using System.Threading.Tasks;

namespace HighwayToPeak.Models
{
    public class BaseCamp : IBaseCamp
    {
        private List<string> residents;

        public BaseCamp()
        {
            residents = new List<string>();
        }

        public IReadOnlyCollection<string> Residents => residents.OrderBy(r => r).ToList().AsReadOnly();

        public void ArriveAtCamp(string climberName)
        {
            if (!residents.Contains(climberName))
                residents.Add(climberName);
        }

        public void LeaveCamp(string climberName)
        {
            if (residents.Contains(climberName))
                residents.Remove(climberName);
        }
    }
}

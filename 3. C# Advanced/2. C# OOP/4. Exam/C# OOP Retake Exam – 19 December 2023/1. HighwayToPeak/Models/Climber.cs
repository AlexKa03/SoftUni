using HighwayToPeak.Models.Contracts;
using HighwayToPeak.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayToPeak.Models
{
    public abstract class Climber : IClimber
    {
        private List<string> conqueredPeaks;

        protected Climber(string name, int stamina)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(ExceptionMessages.ClimberNameNullOrWhiteSpace);

            Name = name;
            Stamina = stamina;
            conqueredPeaks = new List<string>();
        }

        public string Name { get; private set; }
        public int Stamina { get; protected set; }
        public IReadOnlyCollection<string> ConqueredPeaks => conqueredPeaks.AsReadOnly();

        public void Climb(IPeak peak)
        {
            if (!conqueredPeaks.Contains(peak.Name))
                conqueredPeaks.Add(peak.Name);

            switch (peak.DifficultyLevel)
            {
                case "Extreme":
                    Stamina -= 6;
                    break;
                case "Hard":
                    Stamina -= 4;
                    break;
                case "Moderate":
                    Stamina -= 2;
                    break;
            }

            Stamina = Math.Clamp(Stamina, 0, 10);
        }

        public abstract void Rest(int daysCount);

        public override string ToString()
        {
            string peaksConquered = ConqueredPeaks.Count == 0 ? "no peaks conquered" : $"{ConqueredPeaks.Count}";
            return $"{this.GetType().Name} - Name: {Name}, Stamina: {Stamina}\nPeaks conquered: {peaksConquered}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighwayToPeak.Core.Contracts;
using HighwayToPeak.Models;
using HighwayToPeak.Models.Contracts;
using HighwayToPeak.Repositories;
using HighwayToPeak.Repositories.Contracts;
using HighwayToPeak.Utilities.Messages;

namespace HighwayToPeak.Core
{
    public class Controller : IController
    {
        private IRepository<IPeak> peaks;
        private IRepository<IClimber> climbers;
        private IBaseCamp baseCamp;

        public Controller()
        {
            peaks = new PeakRepository();
            climbers = new ClimberRepository();
            baseCamp = new BaseCamp();
        }

        public string AddPeak(string name, int elevation, string difficultyLevel)
        {
            if (peaks.All.Any(p => p.Name == name))
            {
                return String.Format(OutputMessages.PeakAlreadyAdded, name);
            }

            if (difficultyLevel != "Extreme" && difficultyLevel != "Hard" && difficultyLevel != "Moderate")
            {
                return String.Format(OutputMessages.PeakDiffucultyLevelInvalid, difficultyLevel);
            }

            var peak = new Peak(name, elevation, difficultyLevel);
            peaks.Add(peak);

            return String.Format(OutputMessages.PeakIsAllowed, name, peaks.GetType().Name);
        }

        public string NewClimberAtCamp(string name, bool isOxygenUsed)
        {
            if (climbers.All.Any(c => c.Name == name))
            {
                return String.Format(OutputMessages.ClimberCannotBeDuplicated, name, climbers.GetType().Name);
            }

            IClimber climber = isOxygenUsed ? new OxygenClimber(name) : new NaturalClimber(name);
            climbers.Add(climber);
            baseCamp.ArriveAtCamp(name);

            return String.Format(OutputMessages.ClimberArrivedAtBaseCamp, name);
        }

        public string AttackPeak(string climberName, string peakName)
        {
            var climber = climbers.All.FirstOrDefault(c => c.Name == climberName);
            if (climber == null)
            {
                return String.Format(OutputMessages.ClimberNotArrivedYet, climberName);
            }

            var peak = peaks.All.FirstOrDefault(p => p.Name == peakName);
            if (peak == null)
            {
                return String.Format(OutputMessages.PeakIsNotAllowed, peakName);
            }

            if (!baseCamp.Residents.Contains(climberName))
            {
                return String.Format(OutputMessages.ClimberNotFoundForInstructions, climberName, peakName);
            }

            if (peak.DifficultyLevel == "Extreme" && climber is NaturalClimber)
            {
                return String.Format(OutputMessages.NotCorrespondingDifficultyLevel, climberName, peakName);
            }

            baseCamp.LeaveCamp(climberName);
            climber.Climb(peak);

            if (climber.Stamina == 0)
            {
                return String.Format(OutputMessages.NotSuccessfullAttack, climberName);
            }

            baseCamp.ArriveAtCamp(climberName);
            return String.Format(OutputMessages.SuccessfulAttack, climberName, peakName);
        }

        public string CampRecovery(string climberName, int daysToRecover)
        {
            var climber = climbers.All.FirstOrDefault(c => c.Name == climberName);
            if (climber == null || !baseCamp.Residents.Contains(climberName))
            {
                return String.Format(OutputMessages.ClimberIsNotAtBaseCamp, climberName);
            }

            if (climber.Stamina == 10)
            {
                return String.Format(OutputMessages.NoNeedOfRecovery, climberName);
            }

            climber.Rest(daysToRecover);
            return String.Format(OutputMessages.ClimberRecovered, climberName, daysToRecover);
        }

        public string BaseCampReport()
        {
            if (!baseCamp.Residents.Any())
            {
                return "BaseCamp is currently empty.";
            }

            var report = new StringBuilder();
            report.AppendLine("BaseCamp residents:");
            foreach (var resident in baseCamp.Residents)
            {
                var climber = climbers.All.FirstOrDefault(c => c.Name == resident);
                report.AppendLine($"Name: {climber.Name}, Stamina: {climber.Stamina}, Count of Conquered Peaks: {climber.ConqueredPeaks.Count}");
            }

            return report.ToString().TrimEnd();
        }

        public string OverallStatistics()
        {
            var stats = new StringBuilder();
            stats.AppendLine("***Highway-To-Peak***");

            foreach (var climber in climbers.All.OrderByDescending(c => c.ConqueredPeaks.Count).ThenBy(c => c.Name))
            {
                stats.AppendLine(climber.ToString());
                foreach (var peak in peaks.All.OrderByDescending(p => p.Elevation))
                {
                    if (climber.ConqueredPeaks.Contains(peak.Name))
                    {
                        stats.AppendLine(peak.ToString());
                    }
                }
            }

            return stats.ToString().TrimEnd();
        }
    }
}

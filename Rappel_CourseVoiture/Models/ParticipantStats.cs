using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rappel_CourseVoiture.Models
{
    public class ParticipantStats
    {
        private Participant _racer;
        private double _ultimateTime;

        public ParticipantStats(Participant racer, double ultimateTime)
        {
            _racer = racer;
            _ultimateTime = ultimateTime;
        }

        public Participant Racer
        {
            get
            {
                return _racer;
            }
        }

        public double UltimateTime
        {
            get
            {
                return _ultimateTime;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTracker.Models
{
    public class Routine
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Exercise { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public int Weight { get; set; }
        public string DayOfWeek { get; set; }

    }
}

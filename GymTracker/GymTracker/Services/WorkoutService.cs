using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTracker.Services
{
    public class WorkoutService
    {
      
            public List<WorkoutExercise> Exercises { get; private set; } = new List<WorkoutExercise>();

        public event Action OnExercisesChanged;

        
            public void AddExercise(WorkoutExercise exercise)
            {
                Exercises.Add(exercise);
            NotifyExercisesChanged();
            }
        private void NotifyExercisesChanged() => OnExercisesChanged?.Invoke();
    }

        public class WorkoutExercise
        {
            public string Name { get; set; }
            public int Sets { get; set; }
            public int Reps { get; set; }
            public int Weight { get; set; }
            public string DayOfWeek { get; set; }
        }
    }


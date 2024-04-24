using System;

namespace PowerPlaner.Domain.Entities
{
    public class WorkoutSchedule
    {
        public int Id { get; set; }
        public int WorkoutPlanId { get; set; }
        public int Day { get; set; }
        public string ExerciseName { get; set; } = default!;
        public int Sets { get; set; }
        public int Reps { get; set; }
        public int Weight { get; set; }
        public int Tempo { get; set; }

    }
}
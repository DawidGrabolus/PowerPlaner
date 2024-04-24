using PowerPlaner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlaner.Domain.Entites
{
    public class WorkoutSheet
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public List<WorkoutSchedule>? Schedules { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string EncodedName { get; set; } = default!;

        public void EncodeName() => EncodedName = Name.ToLower().Replace(" ", "-");

        public void AddSchedule(WorkoutSchedule schedule)
        {
            if (Schedules == null)
            {
                Schedules = new List<WorkoutSchedule>();
            }

            Schedules.Add(schedule);
        }
    }
}

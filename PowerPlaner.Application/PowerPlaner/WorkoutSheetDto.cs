using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlaner.Application.PowerPlaner
{
    public class WorkoutSheetDto
    {
        public string Name { get; set; } = default!;
        public string? EncodedName { get; set; }
    }
}

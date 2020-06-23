using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolPoprawa.Models
{
    public class Task
    {
        public int IdTask { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime Deadline { get; set; }
        public int IdTeam { get; set; }
        public int IdTaskType { get; set; }
        public int IdAssignedTo { get; set; }
        public int IdCreator { get; set; }
    }
}

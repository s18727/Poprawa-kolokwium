using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.DTO
{
    public class Project
    {
        public int IdTeam { get; set; }
        public int idTask { get; set; }
        public String name { get; set; }
        public DateTime deadline
        {
            get; set;
        }
    }
}

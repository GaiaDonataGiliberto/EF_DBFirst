using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFramework1
{
    public partial class Room
    {
        public Room()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int? Posti { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}

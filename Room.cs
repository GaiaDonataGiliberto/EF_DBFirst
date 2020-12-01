using System;
using System.Collections.Generic;

#nullable disable

namespace EF_DBFirst
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

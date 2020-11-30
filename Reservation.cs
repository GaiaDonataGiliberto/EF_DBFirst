using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFramework1
{
    public partial class Reservation
    {
        public int ScheduleId { get; set; }
        public int? Ppl { get; set; }
        public string Mail { get; set; }
        public int Id { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}

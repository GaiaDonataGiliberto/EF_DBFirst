using System;
using System.Collections.Generic;

#nullable disable

namespace EF_DBFirst
{
    public partial class Schedule
    {
        public Schedule()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public int MovieId { get; set; }
        public int RoomId { get; set; }
        public decimal? Price { get; set; }
        public TimeSpan? Time { get; set; }
        public int? Disp { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}

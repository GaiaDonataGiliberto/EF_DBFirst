using System;
using System.Collections.Generic;

#nullable disable

namespace EF_DBFirst
{
    public partial class Movie
    {
        public Movie()
        {
            Casts = new HashSet<Cast>();
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public string Titolo { get; set; }
        public string Genere { get; set; }
        public int? Durata { get; set; }

        public virtual ICollection<Cast> Casts { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}

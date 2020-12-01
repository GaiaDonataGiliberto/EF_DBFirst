using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_DBFirst
{
    public class Esercizi
    {

        // lettura film

        public static void GetMovies()
        {

            using (var ctx = new cinemaDBContext())
            {

                //var movies =
                //    from m in ctx.Movies
                //    select m;

                foreach (var m in ctx.Movies)
                {
                    Console.WriteLine($"ID: {m.Id} - Titolo: {m.Titolo}");
                }


            }
        }


        // inserimento film

        public static void InsertMovie(Movie m)
        {
            using (var ctx = new cinemaDBContext())
            {
                ctx.Movies.Add(m);
                ctx.SaveChanges();

                Console.WriteLine("Film inserito con successo");
            }

        }


        // eliminazione film in modalità connessa
        public static void DeleteMovie(int id)
        {
            using (var ctx = new cinemaDBContext())
            {
                var m = ctx.Movies.Find(id);

                if (m != null)
                {
                    Console.WriteLine($"Stai eliminando il film: {m.Titolo}");

                    ctx.Movies.Remove(m);

                    ctx.SaveChanges();

                    Console.WriteLine("Film eliminato con successo");
                }
                else
                {
                    Console.WriteLine("Non esiste un film con questo id");
                }


                


            }
        }

        public static void DeleteMovieDis(int id)
        {
            var m = new Movie();

            using (var ctx = new cinemaDBContext())
            {
                
                    m = ctx.Movies.Find(id); 
                
            }

            // manipolo il movie m senza connessione aperta

            using (var ctx = new cinemaDBContext())
            {
                if (m != null)
                {
                    ctx.Entry<Movie>(m).State = EntityState.Deleted;

                    ctx.SaveChanges();

                    Console.WriteLine($"Stai eliminando il film: {m.Titolo}");
                    Console.WriteLine("Film eliminato con successo");
                }
                else
                    Console.WriteLine("Non esiste un film con questo id");

            }

        }

    }
}

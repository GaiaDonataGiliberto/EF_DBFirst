using System;

namespace EF_DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            var movie = new Movie() { Titolo = "Harry Potter", Durata = 93, Genere = "Fantasy" };

            // Esercizi.InsertMovie(movie);




            Esercizi.DeleteMovie(11);

            Esercizi.GetMovies();
        }
    }
}

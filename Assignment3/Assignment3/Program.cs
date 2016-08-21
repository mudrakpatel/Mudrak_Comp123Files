using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Mudrak Patel;Tarun Rana;Khushdial Singh;Iqbal Gill

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie terminator = new Movie("Judgement Day", 105);
            terminator.AddActor("Arnold Schwarzenegger");
            terminator.SetGenre(MovieGenre.Horror | MovieGenre.Action);
            terminator.AddActor("Linda Hamilton");
            Show s1 = new Show(terminator, MovieDay.Mon, 5.95, new Time(11, 35, 0));

            Console.WriteLine(s1);
            Theater eglinton = new Theater("Cineplex");
            eglinton.AddShow(s1);
            eglinton.PrintShows(MovieGenre.Action);                                   //displays one object


            Movie godzilla = new Movie("Godzilla 2014", 123);
            godzilla.AddActor("Aaron Johnson");
            godzilla.AddActor("Ken Watanabe");
            godzilla.AddActor("Elizabeth Olsen");
            godzilla.SetGenre(MovieGenre.Action);

            Movie trancendence = new Movie("Transendence", 120);
            trancendence.AddActor("Johnny Depp");
            trancendence.AddActor("Morgan Freeman");
            trancendence.SetGenre(MovieGenre.Comedy);
            eglinton.AddShow(new Show(trancendence, MovieDay.Sun, 7.87, new Time(18, 5, 0)));

            Movie m1 = new Movie("The Shawshank Redemption", 120);
            m1.AddActor("Tim Robbins");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(MovieGenre.Action);
            eglinton.AddShow(new Show(m1, MovieDay.Sun, 8.87, new Time(14, 5, 0)));


            m1 = new Movie("Olympus Has Fallen", 120);
            m1.AddActor("Gerard Butler");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(MovieGenre.Action);
            eglinton.AddShow(new Show(m1, MovieDay.Sun, 8.87, new Time(16, 5, 0)));

            m1 = new Movie("The Mask of Zorro", 136);
            m1.AddActor("Antonio Banderas");
            m1.AddActor("Anthony Hopkins");
            m1.AddActor(" Catherine Zeta-Jones");
            m1.SetGenre(MovieGenre.Action | MovieGenre.Romance);
            eglinton.AddShow(new Show(m1, MovieDay.Sun, 8.87, new Time(16, 5, 0)));

            m1 = new Movie("Four Weddings and a Funeral", 117);
            m1.AddActor("Hugh Grant");
            m1.AddActor("Andie MacDowell");
            m1.AddActor("Kristin Scott Thomas");
            m1.SetGenre(MovieGenre.Comedy | MovieGenre.Romance);
            eglinton.AddShow(new Show(m1, MovieDay.Sat, 8.87, new Time(15, 5, 0)));

            m1 = new Movie("You've Got Mail", 119);
            m1.AddActor("Tom Hanks");
            m1.AddActor("Meg Ryan");
            m1.SetGenre(MovieGenre.Comedy | MovieGenre.Romance);
            eglinton.AddShow(new Show(m1, MovieDay.Sat, 8.87, new Time(15, 5, 0)));

            Show s2 = new Show(godzilla, MovieDay.Mon, 6.89, new Time(13, 15, 0));
            eglinton.AddShow(s2);

            s2 = new Show(godzilla, MovieDay.Sun, 6.89, new Time(14, 15, 0));
            eglinton.AddShow(s2);

            s2 = new Show(godzilla, MovieDay.Sun, 6.89, new Time(16, 55, 0));
            eglinton.AddShow(s2);

            eglinton.PrintShows(MovieGenre.Action);                                       //displays ten objects

            eglinton.PrintShows(MovieDay.Sun);                           //displays six objects

            eglinton.PrintShows(MovieGenre.Action);                      //displays seven objects

            eglinton.PrintShows(MovieGenre.Romance);                     //displays three objects

            eglinton.PrintShows(MovieGenre.Action | MovieGenre.Romance); //displays one object

            eglinton.PrintShows("Morgan Freeman");                       //displays three objects

            eglinton.PrintShows(new Time(14, 30, 0));                    //displays two objects


        }
    }
}

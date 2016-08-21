using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Mudrak Patel;Tarun Rana;Khushdial Singh;Iqbal Gill

namespace Assignment3{
    #region MovieDay
    enum MovieDay {
        Sun,
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat
    };
    #endregion
    #region MovieGenre
    //MovieGenre enum creation
    enum MovieGenre {
      Unrated,
      Action,
      Romance,
      Documentary,
      Mystery,
      Musical,
      Horror,
      Comedy
    };
    #endregion
    #region Genre //Commented
    //Genre enum creation
    //public enum Genre
    //{
    //    unrated,
    //    action,
    //    romance,
    //    documentary,
    //    mystery,
    //    musical,
    //    horror,
    //    comedy
    //};
    #endregion 
    #region Time
    class Time
    {
        //Properties
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }
        //Methods and Constructor
        public Time(int hours,int minutes,int seconds){
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        //ToString() method
        public override string ToString(){
            return String.Format("{0} : {1} : {2}\n\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>",Hours,Minutes,Seconds);
        }
    }
    #endregion
    #region Movie
    class Movie{
        //Properties
        public int Length { get; private set; }
        public string Title { get; private set; }
        public List<string> Cast = new List<string>();
        public MovieGenre Genre { get; private set;}
        //Methods and Constructors
        public Movie(string title,int length){
            Length = length;
            Title = title;
            Cast = new List<string>(); 
        }
        public void AddActor(string actor){
            Cast.Add(actor);
        }
        public void SetGenre(MovieGenre genre) {
            Genre = genre;
        }
        public override string ToString(){
            return String.Format("Title:> {0}_Length-> {1}",Title,Length);
        }
    }
    #endregion
    #region Theater
    class Theater{
        //Properties
        private string Name { get; set; }
        public List<Show> Shows { get; private set; }
        //Methods and constructors
        public Theater(string name){
            Name = name;
            Shows = new List<Show>();
        }
        public void AddShow(Show show) {
            Shows.Add(show);
        }
        public void PrintShows(MovieGenre genre) {
         foreach (Show s in Shows) { 
            Console.WriteLine(s);
          }
        }
        public void PrintShows(MovieDay day){
            foreach (Show s in Shows){
                if (s.Day == day) { 
                    Console.WriteLine(s);
                }
            }
        }
        public void PrintShows(Time time){
            foreach (Show s in Shows) {
                
                    if (s.Time.Hours == time.Hours) {
                      
                      
                                Console.WriteLine(s);
                            }
                        }
                }
            
        
        public void PrintShows(string actor)
        {
            foreach (Show s in Shows)
            {
                foreach(string a in s.Movie.Cast){
                    if (a == actor){
                        Console.WriteLine(s);
                    }
                }
                Console.WriteLine("");
            }
        }
    }
    #endregion
    #region Show
    class Show {
        //Properties
        public double Price { get; private set;}
        public MovieDay Day { get; private set; }
        public Movie Movie { get; private set; }
        public Time Time { get; private set; }
        //Methods and constructors
        public Show(Movie movie, MovieDay day, double price,Time time){
            Price = price;
            Movie = movie;
            Day = day;
            Time = time;
        }
        public override string ToString(){
            return String.Format("{0:c} {1} {2} {3} ",Price,Movie,Day,Time);
        }
    }
    #endregion
}
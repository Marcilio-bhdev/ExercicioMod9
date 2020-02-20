using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioMod9.Entities;

namespace ExercicioMod9
{
    class Program
    {
        static void Main(string[] args)
        {

            Comments c1 = new Comments("Have a nice Trip");
            Comments c2 = new Comments("Wow That´s awesome");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new Zeland",
                "I'm going to visit this wonderful country!",
                12            
              );

            p1.AddComments(c1);
            p1.AddComments(c2);

            Console.WriteLine(p1);
        }
    }
}

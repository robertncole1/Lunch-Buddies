using System.Collections.Generic;

namespace Lunch_Buddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var lunchBuddy = new LunchBuddy.LunchBuddy("Rob", "Cole");
            lunchBuddy.Eat();
            lunchBuddy.Eat("burger");
            lunchBuddy.Eat(new List<LunchBuddy.LunchBuddy>
            {
                new LunchBuddy.LunchBuddy("Man", "Smith"),
                new LunchBuddy.LunchBuddy("Woman", "Smith")
            });
            lunchBuddy.Eat("Tacos", new List<LunchBuddy.LunchBuddy>
            {
                new LunchBuddy.LunchBuddy("Man", "Cole"),
                new LunchBuddy.LunchBuddy("Woman", "Cole")
            });


        }
    }
}

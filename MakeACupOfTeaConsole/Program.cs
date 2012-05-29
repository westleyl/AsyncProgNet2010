using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeACupOfTeaConsole
{
    class Program
    {
        private static bool IsTeaReadyToDrink = false;

        static void Main(string[] args)
        {
            Console.Title = "Gerrabrewon !";
            Console.WriteLine("Gerrabrewon ! - Version 0.1");
            Console.WriteLine();
                
            MakeCupOfTea();

            int nextObservation = 0;
            while ((!IsTeaReadyToDrink))
            {
                if ((nextObservation < randomObservations.Length))
                {
                    Console.ReadKey(true);
                    Console.WriteLine(randomObservations[nextObservation++]);
                }
            }

            Console.WriteLine("Thankyou, your tea is now ready.");

            var q = Console.ReadLine();
        }

        #region Sychronous methods (old fashioned stuff!)

        private static Task MakeCupOfTea()
        {
            BoilKettle();

            WarmPot();

            SteepTea();

            PourTea(1);

            AddMilk(2);

            AddSugar(0);

            IsTeaReadyToDrink = true;

            return null;
        }

        private static void BoilKettle()
        {
            Console.WriteLine("---> Boiling kettle.");
            var t = Task.Delay(10000);
            while (!t.IsCompleted) { }
            Console.WriteLine("---> Kettle boiled.");
        }

        private static void WarmPot()
        {
            var t = Task.Delay(2500);
            while (!t.IsCompleted) { }
            Console.WriteLine("---> Pot warmed.");
        }

        private static void SteepTea()
        {
            var t = Task.Delay(5000);
            while (!t.IsCompleted) { }
            Console.WriteLine("---> Brew ready.");
        }

        private static void PourTea(int numberOfMugs)
        {
            Console.WriteLine("---> Tea poured into " + numberOfMugs.ToString() + " mug(s).");
        }

        private static void AddMilk(int numberOfDashesOfMilk)
        {
            Console.WriteLine("---> Added " + numberOfDashesOfMilk + " dash(es) of milk.");
        }

        private static void AddSugar(int numberOfTeaspoons)
        {
            if (numberOfTeaspoons < 0)
            {
                return;
            }
            Console.WriteLine("---> Added " + numberOfTeaspoons + " spoon(s) of sugar.");
        }

        #endregion

        #region Asyc methods using Async CTP

        private static async Task MakeCupOfTeaAsync()
        {
            await BoilKettleAsync();
            await WarmPotAsync();
            await SteepTeaAsync();
            
            PourTea(1);
            AddMilk(2);
            AddSugar(0);

            IsTeaReadyToDrink = true;
        }

        private static async Task BoilKettleAsync()
        {
            Console.WriteLine("---> Boiling kettle.");
            await Task.Delay(10000);
            Console.WriteLine("---> Kettle boiled.");
        }

        private static async Task WarmPotAsync()
        {
            await Task.Delay(2500);
            Console.WriteLine("---> Pot warmed.");
        }

        private static async Task SteepTeaAsync()
        {
            await Task.Delay(5000);
            Console.WriteLine("---> Brew ready.");
        }

        #endregion

        #region Observations from the maker of the tea

        static readonly string[] randomObservations = new string[]
                                              {
                                                  "Nice weather out isn't it.",
                                                  "Next time, you should try the almond croissant with your tea.",
                                                  "I had that Linus Torvalds in here the other day.",
                                                  "WHO THINKS THAT THE NEW METRO UI WORKS FOR THEM?",
                                                  "Visual Studio 11, now with added capitalization.",
                                                  "SkillsMattter, possibly the best food of any training provider."
                                              };


        #endregion
    }
}

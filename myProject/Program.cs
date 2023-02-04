using System;

namespace myProject
{
    class fitnessRegimen
    {
        private string _Move;
        private int _Rounds;
        private int _Time;
    
        public fitnessRegimen()
        {
            _Move = "";
            _Rounds = 0;
            _Time = 0;
        }

        public fitnessRegimen(string move, int rounds, int time)
        {
            _Move = move;
            _Rounds = rounds;
            _Time = time;
        }
        public string GetMove() 
        { 
            return _Move; 
        }
        public void SetMove(string move) 
        {
            _Move = move;
        }

        public int GetRounds() 
        { 
            return _Rounds; 
        }
        public void SetRounds(int rounds) 
        {
            _Rounds = rounds;
        }
        public int GetTime() 
        {
            return _Time;
        }
        public void SetTime(int time)
        {
            _Time = time;
        }
    }
    

    class myStore
    {
        static void Main(string[] args)
        {

            fitnessRegimen workout1 = new fitnessRegimen();
            workout1.SetMove("Push-Ups");
            workout1.SetRounds(4);
            workout1.SetTime(30);

            fitnessRegimen workout2 = new fitnessRegimen();
            Console.WriteLine("What move do you want to do?");
            workout2.SetMove(Console.ReadLine());
            Console.WriteLine("How many round do you want to do?");
            workout2.SetRounds(int.Parse(Console.ReadLine()));
            Console.WriteLine("How many seconds should each round be?");
            workout2.SetTime(int.Parse(Console.ReadLine()));

            fitnessRegimen workout3 = new fitnessRegimen("Crunches", 5, 45);

            Console.WriteLine("What move do you want to do?");
            string tempMove = Console.ReadLine();
            Console.WriteLine("How many round do you want to do?");
            int tempRound = int.Parse(Console.ReadLine());
            Console.WriteLine("How many seconds should each round be?");
            int tempTime = int.Parse(Console.ReadLine());
            fitnessRegimen workout4 = new fitnessRegimen(tempMove, tempRound, tempTime);

            displayRegimen(workout1);
            displayRegimen(workout2);
            displayRegimen(workout3);
            displayRegimen(workout4);
        }

        static void displayRegimen(fitnessRegimen workout)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Here's your workout plan:");
            Console.WriteLine($"Move: {workout.GetMove()}");
            Console.WriteLine($"Rounds: {workout.GetRounds()}");
            Console.WriteLine($"Time: {workout.GetTime()} seconds");
        }

    }
}
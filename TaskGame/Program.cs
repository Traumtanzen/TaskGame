using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Today we're playing forfeits.");
            Response();
            Choice();
            //PlayRound();
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
        static int Choice()
        {
            string inputNr = (Console.ReadLine());
            if (int.TryParse(inputNr, out int actNumber) && actNumber < 2 || actNumber > 10)
            {
                Console.WriteLine("Sorry, there's too many or too little of you.");
                Response();
            }
            else if (Enumerable.Range(2, 10).Contains(actNumber))
            {
                Console.WriteLine($"Ok! I see that there are {actNumber} of you. Enter your names, please");
                Players();
            }
            else
            {
                Console.WriteLine("You should enter a number of players.");
                Response();
            }
            return actNumber;
        }
        static void Response()
        {
            Console.WriteLine("We need 2-10 players. How many of you are here now?");
            Choice();
        }
        static void PlayRound()
        {
            string player = Players();
            string forfeit = Forfeits();
            Console.WriteLine($"Ok, {player}, here's your task: \n{forfeit}");
            Console.ReadLine();
        }
        static string Players()
        {
            int nmbrOfPlayers = Choice();
            List<string> player = new List<string>(capacity: nmbrOfPlayers);
            int length = player.Count;
            for (int counter = 0; counter <= length; counter++)
            {
                player.Add(Console.ReadLine());
            }
            var random = new Random();
            var list = player;
            int index = random.Next(list.Count);
            return (list[index]);
        }
        static string Forfeits()
        {
            List<string> forfeit = new List<string>(20);
            forfeit.Add("Spend the next half an hour tied to the person whose birthday is closest to your own.");
            forfeit.Add("Kiss everyone in the room whose name begins with the same letter as your own.");
            forfeit.Add("Tell a joke.");
            forfeit.Add("Tie an apron on another player at the same time as they try to tie one on you.");
            forfeit.Add("Go round the room and give everyone a piece of advice.");
            forfeit.Add("Recite a poem.");
            forfeit.Add("Say the alphabet backwards (NB cheat by saying \"the alphabet backwards\")");
            forfeit.Add("Impersonate a chicken.");
            forfeit.Add("Put your forehead on the top of a broom and walk round it five times, keeping your head in place. Then try to walk in a straight line to the door.");
            forfeit.Add("Eat three dry crackers within one minute. Without water. And blindfolded.");
            forfeit.Add("Get on all fours and bark like a dog.");
            forfeit.Add("Drink a glass of water from the wrong side of the glass.");
            forfeit.Add("Bend over backwards and kiss the wall.");
            forfeit.Add("Limbo under a broom.");
            forfeit.Add("Find the boiled egg in a bowl full of raw eggs. Do this by cracking successive eggs on someone else's head until you find the hard one.");
            forfeit.Add("Eat jelly with a fork.");
            forfeit.Add("Swap clothes with the person on your left.");
            forfeit.Add("Fashion a newspaper outfit for the nearest male.");
            forfeit.Add("Put lipstick on the nearest man - blindfolded.");
            forfeit.Add("Feed grapes to the nearest member of the opposite sex.");

            var random = new Random();
            var list = forfeit;
            int index = random.Next(list.Count);
            return (list[index]);
        }
    }
}

using System;
using System.Threading;
using System.Threading.Channels;

namespace Funny_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "This program is sponsored by RAID SHADOW LEGENDS";
            Console.WriteLine("Haha program go brrrrr");
            Thread.Sleep(80);
            for (int i = 1; i < 69; i++)
            {
                Console.WriteLine("rrrrrrrrrrrrrrrrrrrrrr");
                Thread.Sleep(80);
            }
            Console.WriteLine("You made it to the end, how does it feel, loser? What did you expect? A cookie? You get nothing. Leave.");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
            if (answer == "no" || answer == "no." || answer == "nope" || answer == "nope.")
            {
                Console.WriteLine("OH MY GOOOOOOOOOOOD");
                Thread.Sleep(500);
            }
        }
    }
}

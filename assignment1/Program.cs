using System;
using System.Collections.Generic;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            void Start()
            {
                List<Character> characters = new List<Character>
                {
                    new Queen(),
                    new Troll(),
                    new King(),
                    new Knight()
                };

                foreach (Character character in characters)
                    character.Fight();
                Console.WriteLine();

                // Change weapon of knight to axe
                characters[3].Weapon = new AxeBehaviour();

                foreach (Character character in characters)
                    character.Fight();
            }

            Start();
        }
    }
}

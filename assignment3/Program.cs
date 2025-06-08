using System;
using System.Collections.Generic;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            void Start()
            {
                // Create a tank and assign a driver
                IAttacker tank = new Tank();
                tank.AssignDriver("Frank");

                // Create a robot
                Robot robot = new Robot();

                // Create a robot adapter
                IAttacker robotAdapter = new RobotAdapter(robot);
                robotAdapter.AssignDriver("Mark");

                // Create attackers list and add tank and robot adapter
                List<IAttacker> attackers = new List<IAttacker>
                {
                    tank,
                    robotAdapter
                };

                // Process all attackers
                foreach (IAttacker attacker in attackers)
                {
                    Console.WriteLine($"Driver of attacker: {attacker.Driver}");
                    attacker.DriveForward();
                    attacker.UseWeapon();
                }
            }

            Start();
        }
    }
}

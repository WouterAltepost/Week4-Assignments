using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class Robot
    {
        public void WalkForward()
        {
            Console.WriteLine("Robot walks forward");
        }

        public void SmashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands");
        }

        public void AssignHumanOperator(string operatorName)
        {
            Console.WriteLine($"Robot is moved by {operatorName}");
        }
    }

}

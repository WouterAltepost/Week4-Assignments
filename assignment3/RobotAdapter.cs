using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class RobotAdapter : IAttacker
    {
        private readonly Robot robot;
        private string driver;

        public RobotAdapter(Robot robot)
        {
            this.robot = robot;
        }

        public string Driver => driver;

        public void AssignDriver(string driver)
        {
            this.driver = driver;
            robot.AssignHumanOperator(driver);
        }

        public void DriveForward()
        {
            robot.WalkForward();
        }

        public void UseWeapon()
        {
            robot.SmashWithHands();
        }
    }

}

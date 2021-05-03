using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    public static class Helper
    {
        public static Position SetPosition(string inputPosition)
        {

            Position position = new Position();
            try
            {

                string[] positionDetail = inputPosition.Split(' ');

                int positionValue = 0;

                //Get X-coordinate
                int.TryParse(positionDetail[0], out positionValue);
                position.x = positionValue;

                //Get Y-coordinate
                int.TryParse(positionDetail[1], out positionValue);
                position.y = positionValue;

                //Get direction
                Direction currentDirection;
                Enum.TryParse<Direction>(positionDetail[2], out currentDirection);
                position.direction = currentDirection;

                return position;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

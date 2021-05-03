using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    public class Validator
    {
        public bool ValidateTotalInstructions(List<string> inputInstructions, out string validationMessage)
        {
            bool isValid = true;
            validationMessage = string.Empty;

            if(inputInstructions.Count == 0 )
            {
                validationMessage = Constants.INSTRUCTIONS_NOT_PROVIDED;
                isValid = false;
                return isValid;
            }

            if(inputInstructions.Count % 2 !=1 || inputInstructions.Count < 3 )
            {
                validationMessage = Constants.INVALID_TOTAL_INSTRUCTIONS;
                isValid = false;
                return isValid;
            }

            return isValid;
        }

        public bool ValidatePosition(string position, out string validationMessage)
        {
            bool isValid = true;
            validationMessage = string.Empty;

            string[] positionDetail = position.Split(' ');

            if (positionDetail.Count() != 3)
            {
                isValid = false;
                validationMessage = Constants.INVALID_POSITION_INSTRUCTION;
                return isValid;
            }

            int positionValue = 0;

            //Validate X-coordinate
            isValid = int.TryParse(positionDetail[0], out positionValue);
            if (!isValid)
            { 
                validationMessage = Constants.INVALID_X_COORDINATE;
                return isValid;
            }

            //Validate Y-coordinate
            isValid = int.TryParse(positionDetail[1], out positionValue);
            if (!isValid)
            {
                validationMessage = Constants.INVALID_Y_COORDINATE;
                return isValid;
            }

            //Validate direction
            Direction currentDirection;
            isValid = Enum.TryParse<Direction>(positionDetail[2], out currentDirection);

            if (!isValid)
            {
                validationMessage = Constants.INVALID_DIRECTION_VALUE;
                return isValid;
            }

            return isValid;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    public class Navigator
    {
        public List<string> Navigate(List<string> inputInstructions)
        {
            string inputUpperRightCoordinates = "";
            string inputPosition = "";
            string inputExploreInstruction = "";

            List<string> result = new List<string>();
            bool isValid = true;

            try
            {
                Validator validator = new Validator();
                string validationMessage = string.Empty;

                isValid = validator.ValidateTotalInstructions(inputInstructions, out validationMessage);
                if(!isValid)
                {
                    result.Add(validationMessage);
                    return result;
                }

                if (inputInstructions.Count > 1)
                {
                    inputUpperRightCoordinates = inputInstructions[0];
                }

                for (int instructionIndex = 1; instructionIndex < inputInstructions.Count; instructionIndex++)
                {
                    if (instructionIndex % 2 == 1)
                    {
                        inputPosition = inputInstructions[instructionIndex];
                    }
                    else
                    {
                        inputExploreInstruction = inputInstructions[instructionIndex];
                        isValid = true;
                        validationMessage = string.Empty;

                        isValid = validator.ValidatePosition(inputPosition, out validationMessage);

                        if (!isValid)
                        {
                            result.Add(validationMessage);
                        }
                        else
                        {
                            string output = ProcessInstruction(inputUpperRightCoordinates, inputPosition, inputExploreInstruction, out isValid);
                            result.Add(output);
                        }
                    }
                }

                return result;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private string ProcessInstruction(string upperLimit, string position, string exploreInstruction, out bool isValid)
        {
            string result = "";
            isValid = true;


            Position currentPosition = Helper.SetPosition(position);

            for(int commandIndex=0; commandIndex<exploreInstruction.Length; commandIndex++)
            {
                if(exploreInstruction[commandIndex]=='L')
                {
                    currentPosition.direction = currentPosition.direction.Left();
                }
                else if(exploreInstruction[commandIndex]=='R')
                {
                    currentPosition.direction = currentPosition.direction.Right();
                }
                else if (exploreInstruction[commandIndex]=='M')
                {
                    switch(currentPosition.direction)
                    {
                        case Direction.N:
                            currentPosition.y += 1;
                            break;
                        case Direction.E:
                            currentPosition.x += 1;
                            break;
                        case Direction.S:
                            currentPosition.y -= 1;
                            break;
                        case Direction.W:
                            currentPosition.x -= 1;
                            break;
                    }

                    currentPosition = VerifyBorderConditions(currentPosition, upperLimit);
                }
            }

            result = currentPosition.x + " " + currentPosition.y + " " + currentPosition.direction.ToString();

            return result;
        }

        private Position VerifyBorderConditions(Position currentPosition, string upperLimit)
        {
            string[] upperCoordinates = upperLimit.Split(' ');

            if (currentPosition.x > Convert.ToInt32(upperCoordinates[0]))
                currentPosition.x = Convert.ToInt32(upperCoordinates[0]);
            else if (currentPosition.x < 0)
                currentPosition.x = 0;

            if (currentPosition.y > Convert.ToInt32(upperCoordinates[1]))
                currentPosition.y = Convert.ToInt32(upperCoordinates[1]);
            else if (currentPosition.y < 0)
                currentPosition.y = 0;

            return currentPosition;
        }
    }
}

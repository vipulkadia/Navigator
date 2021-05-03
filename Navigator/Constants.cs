using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    public static class Constants
    {
        private const string ErrorPrefix = "ERROR : ";
        public const string INVALID_TOTAL_INSTRUCTIONS = ErrorPrefix + "Number of total instructions provided are not valid";
        public const string INVALID_POSITION_INSTRUCTION = ErrorPrefix + "Input instruction for the position is not valid";
        public const string INVALID_X_COORDINATE = ErrorPrefix + "X-coordinate of input position is not valid";
        public const string INVALID_Y_COORDINATE = ErrorPrefix + "Y-coordinate of input position is not valid";
        public const string INVALID_DIRECTION_VALUE = ErrorPrefix + "Direction of input position is not valid";
        public const string INSTRUCTIONS_NOT_PROVIDED = ErrorPrefix + "Please provide instructions";
    }
}

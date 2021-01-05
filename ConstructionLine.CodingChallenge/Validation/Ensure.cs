using System;

namespace ConstructionLine.CodingChallenge.Validation
{
    public class Ensure
    {
        public static void IsNotNull(object argumentValue, string argumentName)
        {
            if (argumentValue == null)
                throw new ArgumentNullException(null, $"Argument {argumentName} cannot be null.");
        }
    }
}

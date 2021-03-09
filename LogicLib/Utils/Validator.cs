namespace LogicLib.Utils
{
    public class Validator
    {
        public static bool ValidateStringToIntInRange(string userInput, out int answer, int lBound = 1, int rBound = 3)
        {
            answer = default;
            return int.TryParse(userInput, out answer) && (answer >= lBound && answer <= rBound);
        }
    }
}
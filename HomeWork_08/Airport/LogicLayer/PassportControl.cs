using System.Text.RegularExpressions;

namespace Airport
{
    public class PassportControl
    {
        public static bool CheckForValidPassport(Person person)
        {
            return Regex.IsMatch(person.passport, ConstantsValues.PassportPattern, RegexOptions.IgnoreCase);
        }
    }
}
using System.Text.RegularExpressions;

namespace Airport
{
    public class PassportControl
    {
        public bool CheckForValidPassport(Person person)
        {
            return Regex.IsMatch(person.passport, ConstantsValues.PassportPattern, RegexOptions.IgnoreCase);
        }
    }
}
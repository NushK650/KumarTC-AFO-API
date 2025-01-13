using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KumarTC_AFO_API.Services
{
    public class GuessItService
    {
                public string hard(string guessnum)
        {
            Random random = new Random();
            int randomnum = random.Next(1, 101);
            bool valid = int.TryParse(guessnum, out int var);
            if (valid)
            {

                if (randomnum > var)
                {
                    return " your guess is lower than my number";
                }
                else if (randomnum < var)
                {
                    return " your guess is greater than my number";
                }
                else
                {
                    return " your guess is equal to my number";
                }
            }
            else
            {
                return "invalid try again pick a number between 1-100";
            }
        }

                public string medium(string guessnum)
        {
            Random random = new Random();
            int randomnum = random.Next(1, 51);
            bool valid = int.TryParse(guessnum, out int var);
            if (valid)
            {

                if (randomnum > var)
                {
                    return " your guess is lower than my number";
                }
                else if (randomnum < var)
                {
                    return " your guess is greater than my number";
                }
                else
                {
                    return " your guess is equal to my number";
                }
            }
            else
            {
                return "invalid try again pick a number between 1-50";
            }
        }

                public string easy(string guessnum)
        {
            Random random = new Random();
            int randomnum = random.Next(1, 11);
            bool valid = int.TryParse(guessnum, out int var);
            if (valid)
            {

                if (randomnum > var)
                {
                    return " your guess is lower than my number";
                }
                else if (randomnum < var)
                {
                    return " your guess is greater than my number";
                }
                else
                {
                    return " your guess is equal to my number";
                }
            }
            else
            {
                return "invalid try again pick a number between 1-10";
            }
        }

    }
}
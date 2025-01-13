using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KumarTC_AFO_API.Services
{
    public class Magic8BallService
    {
        public string Magic8Ball(string input)
        {
            Random random = new Random();
            int randomnum = random.Next(1, 8);
            switch (randomnum)
            {
                case 1:
                    return "yes";

                case 2:
                    return "no";

                case 3:
                    return "maybe";

                case 4:
                    return "ask again";

                case 5:
                    return " i dont know";

                case 6:
                    return " likely";

                case 7:
                    return " unlikely";

                default:
                    return " can not predict right now";
                    

            }

        }
    }
}
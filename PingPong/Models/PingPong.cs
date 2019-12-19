using System.Collections.Generic;

namespace Pong
{
    public class PingPong
    {
        public static List<string> IsPingPong(int input)
        {
            List<string> result = new List<string> {};
            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("Ping-Pong");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Pong");
                }
                else if (i % 3 == 0 )
                {
                    result.Add("Ping");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }
    }
}
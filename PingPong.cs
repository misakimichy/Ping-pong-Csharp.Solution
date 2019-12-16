using System;
using System.Collections.Generic;
using MainProgram;

namespace Pong
{
    public class PingPong
    {
        public List<string> IsPingPong(int input)
        {
            List<string> result = new List<string> {};
            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("ping-pong");
                }
                else if (i % 5 == 0)
                {
                    result.Add("pong");
                }
                else if (i % 3 == 0 )
                {
                    result.Add("ping");
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
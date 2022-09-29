using System;

namespace Lib2
{
    public class Lib2Class
    {
        private static readonly Random Random = new Random();

        public int ReturnRandomValue()
        {
            return Random.Next(10);
        }
    }
}

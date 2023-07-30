using System;
using System.Collections.Generic;

namespace BorigaBaraka
{
    public class Generation
    {
        public List<int> GetRandom()
        {

            Random random = new Random();

            List<int> list = new List<int>();


            while (list.Count < 24)
            {

                int R = random.Next(1, 25);
                if (list.Contains(R))
                {
                    continue;
                }
                list.Add(R);

            }

            return list;
        }
        public List<Present> GetPresents(List<int> rNumbers)
        {
            var presents = new List<Present>();

            foreach (var number in rNumbers)
            {
                presents.Add((Present)number);
            }

            return presents;
        }
    }

}

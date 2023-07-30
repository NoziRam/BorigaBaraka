using System;

namespace BorigaBaraka
{
    public struct Conversation
    {
        static int counter = -1;
        Random rnd;

        public string GetName()
        {
            rnd = new Random();
            return $"Iltimos ismingizni kiriting";

        }
        public string SayHello(string name) => $"Assalomu alekum {name}! Marhamat start tugmasini bosing";

        public string Suhbat()
        {
            int number = rnd.Next(1, 5);

            counter++;
            if (counter + number <= 24)
                return $"Marhamat {number} ta tugmachani bosing";
            else return $"Marhamat {24 - counter} ta tugmachani bosing";
        }
    }
}

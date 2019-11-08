using System;

namespace ulohaoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program, ktorý nám povie, ktorá sociálna sieť má najviac používateľov a ktorá je najaktívnejšia z pohľadu koľko ľudí ju používa a koľko ľudí ju používa aktívne.");
            socialsite Facebook = new socialsite("Facebook", 10, 5);
            socialsite Instagram = new socialsite("Instagram", 15,7);
            socialsite Twitter = new socialsite("Twitter", 4, 1);
            socialsite Snapchat = new socialsite("Snapchat", 9, 8);
            mostactive.mostuser(Facebook, Instagram, Twitter, Snapchat);
            mostactive.mostactiv(Facebook, Instagram, Twitter, Snapchat);

        }
    }
}

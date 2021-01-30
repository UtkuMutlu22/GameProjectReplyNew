using System;

namespace GameProjectReply
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new ValidationManager());
            gamerManager.Add( new Gamer { Id = 1, FirstName = "Utku", LastName = "Mutlu", BirtYear = 1995, IdentityNumber = 121212 });
        }
    }
}

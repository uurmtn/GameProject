using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1991,
                FirstName = "UĞUR",
                LastName = "METİN",
                IdentityNumber = 12345

            });
            gamerManager.Delete(new Gamer
            {
                Id = 1,
                BirthYear = 1991,
                FirstName = "UĞUR",
                LastName = "METİN",
                IdentityNumber = 12345

            });
            gamerManager.Update(new Gamer
            {
                Id = 1,
                BirthYear = 1991,
                FirstName = "UĞUR",
                LastName = "METİN",
                IdentityNumber = 12345

            });


        }
    }
}

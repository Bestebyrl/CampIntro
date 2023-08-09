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
                BirthYear = 1985, 
                FisrtName = "Engin",
                LastName = "Demiroğ", 
                IdentityNumber = 12345 
            });
           

            KampanyaManager kampanyaManager = new KampanyaManager(new OrderManager());
            kampanyaManager.Add(new Kampanya
            {
                UrunAdi = "çilek",
                UrunFiyati=50,
                İndirimMiktari=20
            });
        }
    }
}

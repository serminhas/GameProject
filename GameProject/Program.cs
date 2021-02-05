using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "Sermin", LastName = "EH", IdentityNumber = 124 });

            Campaign campaign1 = new Campaign();
            campaign1.Id = 12;
            campaign1.Name = "BuyOneGetOneFree";


           CampaignManager campaignManager=new CampaignManager();
            campaignManager.Add(campaign1);

        }
    }
}

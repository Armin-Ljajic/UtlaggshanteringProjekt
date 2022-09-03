using Utläggningshantering.Context;
using Utläggningshantering.Models;

namespace Utläggningshantering.Data
{
    public class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.UserExpenses.Any())
            {
                context.Add(new UserExpense()
                {
                    AmountIncludingVAT = 500,
                    Comment = "Min kommentar",
                    Date = DateTime.Now,
                    Members = "Armin Ljajic",
                    PlaceOfPurchase = "Ikea",
                    Reason = "Kontorsinredning",
                    VAT = 100
                });
                context.Add(new UserExpense()
                {
                    AmountIncludingVAT = 340,
                    Comment = "Min kommentar",
                    Date = DateTime.Now,
                    Members = "Erik Larsson",
                    PlaceOfPurchase = "Bauhaus",
                    Reason = "Reparation",
                    VAT = 70
                });
                context.Add(new UserExpense()
                {
                    AmountIncludingVAT = 670,
                    Comment = "Min kommentar",
                    Date = DateTime.Now,
                    Members = "Mohammad Eriksson",
                    PlaceOfPurchase = "Filmgiganten",
                    Reason = "Filmkväll",
                    VAT = 140
                });
                context.Add(new UserExpense()
                {
                    AmountIncludingVAT = 550,
                    Comment = "Min kommentar",
                    Date = DateTime.Now,
                    Members = "Sven Svensson",
                    PlaceOfPurchase = "NetOnNet",
                    Reason = "Trasigt tangentbord",
                    VAT = 110
                });
                context.Add(new UserExpense()
                {
                    AmountIncludingVAT = 800,
                    Comment = "Min kommentar",
                    Date = DateTime.Now,
                    Members = "Kicki Fredriksson",
                    PlaceOfPurchase = "Finlines",
                    Reason = "Kundmöte",
                    VAT = 150
                });
                context.Add(new UserExpense()
                {
                    AmountIncludingVAT = 400,
                    Comment = "Min kommentar",
                    Date = DateTime.Now,
                    Members = "Paul Knutsson",
                    PlaceOfPurchase = "Hemmakväll",
                    Reason = "Afterwork",
                    VAT = 80
                });
                context.Add(new UserExpense()
                {
                    AmountIncludingVAT = 500,
                    Comment = "Min kommentar",
                    Date = DateTime.Now,
                    Members = "Lars Rickard Davidsson",
                    PlaceOfPurchase = "ICA",
                    Reason = "Frukost på kontor",
                    VAT = 100
                });
                context.Add(new UserExpense()
                {
                    AmountIncludingVAT = 500,
                    Comment = "Min kommentar",
                    Date = DateTime.Now,
                    Members = "Lars Rickard Davidsson",
                    PlaceOfPurchase = "ICA",
                    Reason = "Frukost på kontor",
                    VAT = 100
                });

                context.SaveChanges();
            }
        }
    }
}

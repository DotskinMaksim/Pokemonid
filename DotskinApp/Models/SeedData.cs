using DotskinApp.Data;
using Microsoft.EntityFrameworkCore;

namespace DotskinApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context=new DotskinAppContext
                (serviceProvider
                .GetRequiredService<DbContextOptions<DotskinAppContext>>()
                ))
            {
                if (context.Pokemon.Any()) {
                    return;
                       
                }
                context.Pokemon.AddRange(
                    new Pokemon
                    {
                        Name = "Balbasaur",
                        DiscoveryRegion = "Kanto",
                        PokedexEntryID = 1,
                        ElemntType = "Grass",
                        Gender = "Male",
                        ImageURL= "https://i5.walmartimages.com/seo/Pokemon-Posters-Collection-of-Top-200-Pokemons-Paperback-9781649832214_81f63131-51d5-4829-b298-13e162b3f8d8.b32df8d33f97f84384e0860028bcf8fe.jpeg?odnHeight=768&odnWidth=768&odnBg=FFFFFF"
                    }
                );
                context.SaveChanges();
            }
           

        }

    }
}

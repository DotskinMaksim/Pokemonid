using System.ComponentModel.DataAnnotations;

namespace DotskinApp.Models
{
    public class Pokemon
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        [Display(Name = "Pokedex ID")]

        public int PokedexEntryID { get; set; }
        [Display(Name = "Region of discovery")]

        public string DiscoveryRegion { get; set; }
        [Display(Name = "Pokemon type")]

        public string ElemntType { get; set; }

        public string ImageURL { get; set; }
    }
}

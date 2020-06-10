using System;

namespace TheRockBakery.Models
{
    public class BakeGood
    {
        string [] BakedGoods = new string []
        {
            "croissant",
            "egg tart",
            "tiramisu",
            "cup cake",
            "cookie",
            "mousse",
            "creme brulee",
            "flan",
            "pie",
            "frittatta",
            "deep dish cheese cake",
            "cannoli",
            "fondue"
        };

        string[] Preparations = new string []
        {
            "Frosted",
            "Jelly filled",
            "Bruleed",
            "Sprinkled",
            "Sugar coated",
            "Burnt",
            "Glazed",
            "Chocolate covered",
            "Plain",
            "Deconstructed",
            "Shakified",
            "Blended"
        };

        string [] Fillings = new string[]
        {
            "jelly",
            "marscapone",
            "pudding",
            "maple syrup",
            "cream cheese",
            "Cheeze Itz",
            "agave nectar",
            "corn",
            "zero calorie sweetner"
        };

        public string Value { get; set; }

        public BakeGood()
        {
            Random rand = new Random();
            Value += Preparations[rand.Next(Preparations.Length)];
            Value += " ";
            Value += BakedGoods[rand.Next(BakedGoods.Length)];
            Value += " with ";
            Value += Fillings[rand.Next(Fillings.Length)];
        }
    }
}
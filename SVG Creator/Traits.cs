namespace SVG_Creator  {
    /// <summary>
    /// Defines the traits of part of the art work
    /// </summary>
    public class Traits  {
        //Defines the Avatar type Male, Female, Monkey, ...
        public string Avatar { get; set; } = "Any";
        // Basically defines the SVG layer in final ART Work
        // Eg:- Skin, Hair, Weapon etc
        public string Gene { get; set; }
        // Unique name of the trait
        public string Name { get; set; }
        // Define how rare is the trait
        public string Rarity { get; set; } = "Common";
        // Define which series the trait belongs
        public int Series { get; set; } = 0;
        // Actual SVG of the trait
        public string SVG { get; set; }
        // Index of the trait in the Gene
        public int Index { get; set; }
        // Unique description of the trait to be displayed in marketplace
        public string Description { get; set; }
    }
}

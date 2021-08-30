using System.IO;
using System.Threading.Tasks;

namespace SVG_Creator  {
    /// <summary>
    /// Program to generate the art work using Custom algorithm
    /// </summary>
    public class Program  {
        public static async Task Main() {
            int count = 0;
            // Iterate thru all Traits and merge the SVG using Gene 
            // TODO consider Traits.Avatar and other attributes
            foreach (var bgColor in Constants.bgColorMap) {
                // First Create Background with trait color
                string backgroundRectWithColor = Constants.backgroundRect.Replace(Constants.bgColorFill, bgColor.Value.SVG);
                foreach (var skinColor in Constants.skinColorMap) {
                    // Add Skin with trait color
                    string skinWithColor = Constants.skin.Replace(Constants.skinColorFill, skinColor.Value.SVG);
                    // Add the Crown
                    foreach (var crownmap in Constants.crownMap) {
                        // Add the face with skin color
                        foreach (var faceMap in Constants.faceMap) {
                        string faceWithColor = faceMap.Value.SVG.Replace(Constants.skinColorFill, skinColor.Value.SVG);
                            //Add the dress
                            foreach (var dressMap in Constants.dressMap) {
                                // Add the Weapon
                                foreach (var weapon in Constants.weaponMap) {
                                    //Add the hand cover
                                    string handCoverWithSkin =
                                        Constants.handCover.Replace(Constants.skinColorFill, skinColor.Value.SVG);
                                    // Combine all and create the final art work
                                    // Update the file location here
                                    File.WriteAllText("C:\\work\\NFT\\SVG\\Output\\Dummy" + count + ".svg",
                                    Constants.svgHeader +
                                    backgroundRectWithColor +
                                    skinWithColor +
                                    Constants.hair +
                                    crownmap+
                                    dressMap.Value.SVG +
                                    faceWithColor +
                                    weapon.Value.SVG +
                                    handCoverWithSkin +
                                    Constants.svgFooter
                                );
                                count++;
                            }
                        }
                    }
                    }
                }
            }
        }
    }
}

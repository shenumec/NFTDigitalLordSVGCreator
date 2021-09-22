using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SVG_Creator  {
    /// <summary>
    /// Program to generate the art work using Custom algorithm
    /// </summary>
    public class Program  {
        public static async Task Main() {
            int count = 0;
            StringBuilder filename= new StringBuilder();
            // Iterate thru all Traits and merge the SVG using Gene 
            // TODO consider Traits.Avatar and other attributes
            foreach (var bgColor in Constants.bgColorMap)
            {
                filename.Append(bgColor.Value.Name);
                // First Create Background with trait color
                var backgroundRectWithColor =
                    Constants.backgroundRect.Replace(Constants.bgColorFill, bgColor.Value.SVG);
                foreach (var skinColor in Constants.skinColorMap)
                {
                    // Add Skin with trait color
                    var skinWithColor = Constants.skin.Replace(Constants.skinColorFill, skinColor.Value.SVG);
                    filename.Append(skinColor.Value.Name);
                    // Add the Crown
                    foreach (var crownmap in Constants.crownMap)
                    {
                        filename.Append(crownmap.Value.Name);
                        // Add the face with skin color
                        foreach (var faceMap in Constants.faceMap)
                        {
                            var faceWithColor = faceMap.Value.SVG.Replace(Constants.skinColorFill, skinColor.Value.SVG);
                            filename.Append(faceMap.Value.Name);
                            //Add the dress
                            foreach (var dressMap in Constants.dressMap)
                            {
                                filename.Append(dressMap.Value.Name);
                                // Add the Weapon
                                foreach (var weapon in Constants.weaponMap)
                                {
                                    //Add the hand cover
                                    var handCoverWithSkin =
                                        Constants.handCover.Replace(Constants.skinColorFill, skinColor.Value.SVG);
                                    filename.Append(weapon.Value.Name);
                                    // Combine all and create the final art work
                                    // Update the file location here
                                    File.WriteAllText("C:\\work\\NFT\\SVG\\Output\\Dummy" + count + filename + ".svg",
                                        Constants.svgHeader +
                                        backgroundRectWithColor +
                                        skinWithColor +
                                        Constants.hair +
                                        crownmap.Value.SVG +
                                        dressMap.Value.SVG +
                                        faceWithColor +
                                        weapon.Value.SVG +
                                        handCoverWithSkin +
                                        Constants.svgFooter
                                    );
                                    count++;
                                    filename.Replace(weapon.Value.Name, "");
                                }

                                filename.Replace(dressMap.Value.Name, "");
                            }
                            filename.Replace(faceMap.Value.Name,"");
                        }

                        filename.Replace(crownmap.Value.Name, "");
                    }

                    filename.Replace(skinColor.Value.Name, "");
                }

                filename.Replace(bgColor.Value.Name, "");
            }
        }
    }
}

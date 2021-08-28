using System.IO;
using System.Threading.Tasks;
using SVG_Creator;

namespace SerializeToFileAsync
{
    public class Program
    {
        public static async Task Main()

        {
            int count = 0;

            foreach (var bgColor in Constants.bgColorMap)
            {
                string backgroundRectWithColor = Constants.backgroundRect.Replace(Constants.bgColorFill, bgColor.Value.SVG);
                foreach (var skinColor in Constants.skinColorMap)
                {
                    string skinWithColor = Constants.skin.Replace(Constants.skinColorFill, skinColor.Value.SVG);
                    foreach (var crownmap in Constants.crownMap)
                    {
                        foreach (var faceMap in Constants.faceMap)
                    {
                        string faceWithColor = faceMap.Value.SVG.Replace(Constants.skinColorFill, skinColor.Value.SVG);
                            foreach (var dressMap in Constants.dressMap)
                        {

                            foreach (var weapon in Constants.weaponMap)
                            {
                                string handCoverWithSkin =
                                    Constants.handCover.Replace(Constants.skinColorFill, skinColor.Value.SVG);
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

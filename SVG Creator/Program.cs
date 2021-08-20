using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
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
                string backgroundRectWithColor = Constants.backgroundRect.Replace(Constants.bgColorFill, bgColor.Value);
                foreach (var skinColor in Constants.skinColorMap)
                {
                    string skinWithColor = Constants.skin.Replace(Constants.skinColorFill, skinColor.Value);
                    foreach (var crownmap in Constants.crownMap)
                    {
                        foreach (var faceMap in Constants.faceMap)
                    {
                        string faceWithColor = faceMap.Value.Replace(Constants.skinColorFill, skinColor.Value);
                            foreach (var dressMap in Constants.dressMap)
                        {

                            foreach (var weapon in Constants.weaponMap)
                            {
                                string handCoverWithSkin =
                                    Constants.handCover.Replace(Constants.skinColorFill, skinColor.Value);
                                File.WriteAllText("C:\\work\\NFT\\SVG\\Output\\Dummy" + count + ".svg",
                                    Constants.svgHeader +
                                    backgroundRectWithColor +
                                    skinWithColor +
                                    Constants.hair +
                                    crownmap+
                                    dressMap.Value +
                                    faceWithColor +
                                    weapon.Value +
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

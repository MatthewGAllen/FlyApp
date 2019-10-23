using System.Collections.Generic;
using System.IO;
using System.Linq;
using FlyApp.API.Models;

namespace FlyApp.API.Data
{
    public class Seed
    {
        public static void SeedMaterials(DataContext context)
        {
            if(!context.Materials.Any())
            {
                List<string> mats = new List<string>();
                using(var reader = new StreamReader(@"D:\FlyFishingImages\fly_tying.csv"))
                {
                    while(!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        mats.Add(line);
                    }
                }

                foreach(var m in mats)
                {
                    var hold = new Material
                    {
                        Name = m
                    };
                    
                    context.Materials.Add(hold);
                }

                context.SaveChanges();
            }
        }
    }
}
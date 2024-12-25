using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;

namespace RealWorldBiomeMapCreator.Biomes
{
    public static class BiomeMapper
    {
        private static readonly List<(Rgba32 Color, Biome Biome)> colorToBiomeList = new List<(Rgba32, Biome)>
        {
            (new Rgba32(0, 0, 255), Biome.OCEAN),
            (new Rgba32(124, 252, 0), Biome.PLAINS),
            (new Rgba32(238, 221, 130), Biome.DESERT),
            (new Rgba32(169, 169, 169), Biome.WINDSWEPT_HILLS),
            (new Rgba32(34, 139, 34), Biome.FOREST),
            (new Rgba32(0, 100, 0), Biome.TAIGA),
            (new Rgba32(85, 107, 47), Biome.SWAMP),
            (new Rgba32(46, 139, 87), Biome.MANGROVE_SWAMP),
            (new Rgba32(70, 130, 180), Biome.RIVER),
            (new Rgba32(176, 224, 230), Biome.FROZEN_OCEAN),
            (new Rgba32(175, 238, 238), Biome.FROZEN_RIVER),
            (new Rgba32(255, 255, 255), Biome.SNOWY_PLAINS),
            (new Rgba32(255, 245, 186), Biome.BEACH),
            (new Rgba32(0, 0, 128), Biome.DEEP_OCEAN),
            (new Rgba32(128, 128, 128), Biome.STONY_SHORE),
            (new Rgba32(240, 255, 255), Biome.SNOWY_BEACH),
            (new Rgba32(152, 251, 152), Biome.BIRCH_FOREST),
            (new Rgba32(1, 50, 32), Biome.DARK_FOREST),
            (new Rgba32(169, 223, 191), Biome.SNOWY_TAIGA),
            (new Rgba32(244, 164, 96), Biome.SAVANNA),
            (new Rgba32(210, 180, 140), Biome.SAVANNA_PLATEAU),
            (new Rgba32(205, 133, 63), Biome.BADLANDS),
            (new Rgba32(139, 69, 19), Biome.WOODED_BADLANDS),
            (new Rgba32(0, 191, 255), Biome.WARM_OCEAN),
            (new Rgba32(100, 149, 237), Biome.COLD_OCEAN),
            (new Rgba32(65, 105, 225), Biome.DEEP_LUKEWARM_OCEAN),
            (new Rgba32(0, 0, 139), Biome.DEEP_COLD_OCEAN),
            (new Rgba32(176, 224, 230), Biome.DEEP_FROZEN_OCEAN),
            (new Rgba32(255, 215, 0), Biome.SUNFLOWER_PLAINS),
            (new Rgba32(172, 172, 172), Biome.WINDSWEPT_GRAVELLY_HILLS),
            (new Rgba32(255, 105, 180), Biome.FLOWER_FOREST),
            (new Rgba32(173, 216, 230), Biome.ICE_SPIKES),
            (new Rgba32(144, 238, 144), Biome.OLD_GROWTH_BIRCH_FOREST),
            (new Rgba32(222, 184, 135), Biome.WINDSWEPT_SAVANNA),
            (new Rgba32(210, 105, 30), Biome.ERODED_BADLANDS),
            (new Rgba32(50, 205, 50), Biome.BAMBOO_JUNGLE),
            (new Rgba32(173, 255, 47), Biome.MEADOW),
            (new Rgba32(238, 238, 238), Biome.SNOWY_SLOPES),
            (new Rgba32(224, 255, 255), Biome.FROZEN_PEAKS),
            (new Rgba32(211, 211, 211), Biome.JAGGED_PEAKS),
            (new Rgba32(170, 172, 170), Biome.STONY_PEAKS),
            (new Rgba32(255, 182, 193), Biome.CHERRY_GROVE)
        };

        public static Biome DetermineBiome(Rgba32 color)
        {
            Biome closestBiome = Biome.PLAINS;
            double closestDistance = double.MaxValue;

            foreach (var (colorValue, biome) in colorToBiomeList)
            {
                double distance = GetColorDistance(color, colorValue);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestBiome = biome;
                }
            }

            return closestBiome;
        }

        private static double GetColorDistance(Rgba32 color1, Rgba32 color2)
        {
            return Math.Sqrt(Math.Pow(color1.R - color2.R, 2) + Math.Pow(color1.G - color2.G, 2) + Math.Pow(color1.B - color2.B, 2));
        }
    }
}
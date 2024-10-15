using SixLabors.ImageSharp.PixelFormats;

namespace RealWorldBiomeMapCreator.Biomes;

public static class BiomeMapper
{
    // @TODO implementeer dit
    public static Biome DetermineBiome(Rgba32 color)
    {
        // Voorbeeldlogica om kleuren aan biomes te koppelen
        if (color.R > 200 && color.G > 200 && color.B > 200)
        {
            return Biome.SNOWY_PLAINS;
        }
        else if (color.R < 50 && color.G < 50 && color.B > 200)
        {
            return Biome.OCEAN;
        }
        else if (color.R > 200 && color.G > 150 && color.B < 50)
        {
            return Biome.DESERT;
        }
        else
        {
            return Biome.PLAINS;
        }
    }
}

using SixLabors.ImageSharp.PixelFormats;

namespace RealWorldBiomeMapCreator.Height
{
    public static class HeightMapper
    {
        public static int GetHeight(Rgba32 color)
        {
            // Bereken de helderheid van de kleur (gemiddelde van R, G en B)
            double brightness = (color.R + color.G + color.B) / 3.0;

            // Schaal de helderheid naar een hoogte tussen 0 en 384
            int height = (int)(brightness / 255.0 * 384);

            return height;
        }
    }
}
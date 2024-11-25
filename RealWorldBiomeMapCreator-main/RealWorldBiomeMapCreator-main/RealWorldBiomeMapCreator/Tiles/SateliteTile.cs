using RealWorldBiomeMapCreator.Biomes;
using RealWorldBiomeMapCreator.Height;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;

namespace RealWorldBiomeMapCreator.Tiles
{
    public class SateliteTile : ITile
    {
        private Image<Rgba32> imageTile;
        private int tileSize;

        public SateliteTile(Image<Rgba32> imageSource, int tileSize = 256)
        {
            this.imageTile = imageSource;
            this.tileSize = tileSize;
        }

        public void AnalyzeTile()
        {
            for (int y = 0; y < imageTile.Height; y++)
            {
                for (int x = 0; x < imageTile.Width; x++)
                {
                    Rgba32 pixelColor = imageTile[x, y];
                    Biome biome = BiomeMapper.DetermineBiome(pixelColor);
                    int surfaceHeight = HeightMapper.GetHeight();

                    Console.WriteLine($"Pixel ({x},{y}) heeft kleur ({pixelColor.R},{pixelColor.G},{pixelColor.B}) en is biome {biome} en hoogte is {surfaceHeight}");
                }
            }
        }

        public void GetTileData()
        {
            throw new NotImplementedException();
        }
    }
}
using RealWorldBiomeMapCreator.Biomes;
using RealWorldBiomeMapCreator.Height;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace RealWorldBiomeMapCreator.Tiles;

public class SateliteTile : ITile
{
    private Image<Rgba32> imageTile;

    private int worldX;
    
    private int worldY;
    
    private int zoomLevel;

    private int tileSize;
    
    // TileSize is het aantal pixel dat de tile groot is (standaard 256 x 256)
    public SateliteTile(Image<Rgba32> imageSource, int tileSize = 256)
    {
        this.imageTile = imageSource;
        this.tileSize = tileSize;
    }

    // @TODO Deze functie moet geen void zijn, maar juist het result opslaan.
    public void AnalyzeTile()
    {
        for (int y = 0; y < imageTile.Height; y++)
        {
            for (int x = 0; x < imageTile.Width; x++)
            {
                Rgba32 pixelColor = imageTile[x, y];
                Biome biome = BiomeMapper.DetermineBiome(pixelColor);
                int surfaceHeight = HeightMapper.GetHeight(); // @TODO Implementeer dit
                Console.WriteLine($"Pixel ({x},{y}) is biome {biome} en hoogte is {surfaceHeight}");
                // @TODO Sla het resultaat ergens in op?
            }
        }
        
    }

    // @TODO Implementeer dit, dit hoort geen void te zijn
    public void GetTileData()
    {
        throw new NotImplementedException();
    }
}
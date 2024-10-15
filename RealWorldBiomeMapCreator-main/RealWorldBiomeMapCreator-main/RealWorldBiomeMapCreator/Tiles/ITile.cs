using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace RealWorldBiomeMapCreator.Tiles;

public interface ITile
{
    public void AnalyzeTile();
    public void GetTileData();
}
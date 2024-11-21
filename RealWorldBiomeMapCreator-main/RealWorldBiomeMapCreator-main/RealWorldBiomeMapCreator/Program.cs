using RealWorldBiomeMapCreator.Tiles;
using System.Threading.Tasks;

namespace RealWorldBiomeMapCreator
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            TileDownloader tileDownloader = new TileDownloader();

            // Download de tile
            int worldX = 64;
            int worldY = 42;
            SateliteTile sateliteTile = new SateliteTile(await tileDownloader.DownloadTile(worldX, worldY, 7));

            // Analyseer de tile
            sateliteTile.AnalyzeTile();
        }
    }
}
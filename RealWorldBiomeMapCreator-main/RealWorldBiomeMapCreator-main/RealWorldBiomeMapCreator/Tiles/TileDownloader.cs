using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace RealWorldBiomeMapCreator.Tiles
{
    public class TileDownloader
    {
        private static readonly HttpClient client = new HttpClient();

        public TileDownloader()
        {
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
        }

        public async Task<Image<Rgba32>> DownloadTile(int x, int y, int zoom)
        {
            string url = $"https://mt1.google.com/vt/lyrs=s&x={x}&y={y}&z={zoom}";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            using (Stream imageStream = await response.Content.ReadAsStreamAsync())
            {
                return Image.Load<Rgba32>(imageStream);
            }
        }
    }
}
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace RealWorldBiomeMapCreator.Tiles;

public class TileDownloader
{
    private static readonly HttpClient client = new HttpClient();

    public TileDownloader()
    {
        // Voeg een User-Agent header toe aan elk verzoek, anders krijgen we een 403 error.
        client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
    }
    
    // @TODO maak het mogelijk meerdere layers te downloaden
    public async Task<Image<Rgba32>> DownloadTile(int x, int y, int zoom) // int x, int y, int zoom = 7
    {
        // @TODO Andere sources zijn hier te vinden (maar andere mogen ook):
        // https://gist.github.com/xantiagoma/39145a3042eca53a57ac3290a1a34973?permalink_comment_id=3415377
        
        // Er zijn verschillende layers beschikbaar:
        
        // @TODO verwerkt de daadwerkelijke parameters in de URL
        string url = $"https://mt1.google.com/vt/lyrs=s&x=65&y=42&z=7";
        //string url = $"https://mt1.google.com/vt/lyrs=m&x=65&y=42&z=7"; // Deze heeft ook annotaties (plaatsnamen), hiermee kun je dus geen betrouwbare biomemap maken.
        //string url = $"https://mt1.google.com/vt/lyrs=p&x=65&y=42&z=7";
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();

        using (Stream imageStream = await response.Content.ReadAsStreamAsync())
        {
            // Decode de afbeelding direct in een ImageSharp Image
            return Image.Load<Rgba32>(imageStream);
        }
    }
}

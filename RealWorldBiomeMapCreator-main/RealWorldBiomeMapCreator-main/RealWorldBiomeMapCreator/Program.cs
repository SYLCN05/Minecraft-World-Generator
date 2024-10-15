using RealWorldBiomeMapCreator.Tiles;

namespace RealWorldBiomeMapCreator;

public class Program
{
    public static async Task Main(string[] args)
    {
        TileDownloader tileDownloader = new TileDownloader();
        
        /*
         Hieronder zien jullie een voorbeelduitwerking, van het downloaden en analyseren van 1 tile,
         zoals jullie misschien al kunnen zien is dit nog niet af, daarnaast wordt de verkeerde tile gebruikt.
         Plaatsnamen zijn namelijk zwarte letters en daarmee is geen Biome te maken.
         Combineer minimaal 3 tiles met elkaar en bepaal welke Biome erbij hoort, er zijn veel Biomes (zie de Biome enum), dus denk goed na hoe je dit aanpakt!
         
         Bonus: Als je toch bezig bent met het kijken naar kaarten, bedenk welke hoogte daarbij hoort en sla deze samen met Biome op in de SurfaceSafer. 
         
         Het beste resultaat wint een prijs en wordt daarnaast daadwerkelijk gebruikt als basis voor een Minecraft World Generator
         die we lanceren op de Game Night.
         
         BELANGRIJK! Download niet teveel tiles achter elkaar, mogelijk wordt je dan geblokkeerd dus ga hier zuinig mee om!
         Cache dus de tiles door ze op te slaan naar een bestand en steeds te controleren of het bestand al bestaat!
         */
        
        // Download de tile, probeer ook andere delen van de wereld uit voor de andere biomes.
        
        // Zoom werkt zo: Zoom 0 betekent, wereld is opgedeeld in 1x1 tile, zoom 1 betekent wereld is opgedeeld in 2x2 tiles, zoom 2 betekent wereld is opgedeeld in 4x4 tiles, zoom 3 betekent wereld is opgedeeld in 8x8 tiles.
        // Dus zoom 7 zoals default hieronder betekent dat de wereld is opgedeeld in 128x128 stukken (tiles) (we tellen altijd vanaf 0 dus 0 t/m 127)
        // Deze coordinaten zijn een deel van Nederland, het eindresultaat zal het liefste met zoom 9 moeten werken.
        int worldX = 64;
        int worldY = 42;
        SateliteTile sateliteTile = new SateliteTile(await tileDownloader.DownloadTile(worldX, worldY, 7));
        
        // @TODO (Bonus) maak deze analyse multithreaded, zodat het sneller wordt om de hele wereld te laden.
        sateliteTile.AnalyzeTile();
        
        // @TODO (Bonus) Doe iets met result? Save as file? Misschien weer als een image? Zorg ervoor dat de output makkelijk te lezen is.
    }
}

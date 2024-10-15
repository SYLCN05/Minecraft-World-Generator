import requests
import os
import time

# Basis-URL voor de Google Maps Tiles API
TILE_URL = "https://mt1.google.com/vt/lyrs=m&x={x}&y={y}&z={zoom}"

# Zoomniveau instellen
zoom = 1

# Functie om een specifieke tile op te halen en op te slaan
def fetch_tile(x, y, zoom, folder="tiles"):
    # Maak de URL voor de specifieke tile
    url = TILE_URL.format(x=x, y=y, zoom=zoom)
    
    # Stel de bestandsnaam in voor de tile
    tile_filename = os.path.join(folder, f"tile_{zoom}_{x}_{y}.png")
    
    # Maak de map aan als deze nog niet bestaat
    os.makedirs(folder, exist_ok=True)
    
    # Haal de tile op via de URL
    response = requests.get(url)
    
    # Controleer of de tile succesvol is opgehaald
    if response.status_code == 200:
        # Sla de tile op in een bestand
        with open(tile_filename, 'wb') as file:
            file.write(response.content)
        print(f"Tegel {x}, {y} opgeslagen als {tile_filename}")
    else:
        print(f"Fout bij het ophalen van tegel {x}, {y} op zoom {zoom}")

# Loop door alle X- en Y-coördinaten (256x256 tiles bij zoomniveau 8)
def download_all_tiles(zoom):
    for x in range(2**zoom):  # X-coördinaten: 0 t/m 255
        for y in range(2**zoom):  # Y-coördinaten: 0 t/m 255
            fetch_tile(x, y, zoom)
            time.sleep(1)  # Kleine pauze om de API niet te overbelasten

# Start het downloaden van alle tiles op zoomniveau 8
download_all_tiles(zoom)

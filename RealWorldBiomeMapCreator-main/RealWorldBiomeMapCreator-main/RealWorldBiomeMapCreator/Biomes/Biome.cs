namespace RealWorldBiomeMapCreator.Biomes;

// @TODO wat iedere biome exact is kun je vinden in de MineCraft documentatie! Ik heb wel een korte beschrijving door ChatGPT laten maken.
/*
 * OCEAN – Zeeën en oceanen: #0000FF (Blauw)

     
   PLAINS – Graslanden: #7CFC00 (Lichtgroen)

     
   DESERT – Woestijnen: #EEDD82 (Zandgeel)

     
   WINDSWEPT_HILLS – Rotsachtige of bergachtige gebieden: #A9A9A9 (Donkergrijs)

     
   FOREST – Gemengde loofbossen: #228B22 (Groen)

     
   TAIGA – Koude, naaldbossen: #006400 (Donkergroen)

     
   SWAMP – Moerassen: #556B2F (Olijfgroen)

     
   MANGROVE_SWAMP – Mangrovemoerassen, tropische kustgebieden: #2E8B57 (Zeegroen)

     
   RIVER – Rivieren: #4682B4 (Staalblauw)

     
   FROZEN_OCEAN – Bevroren zeeën: #B0E0E6 (Lichtblauw)

     
   FROZEN_RIVER – Bevroren rivieren: #AFEEEE (Bleekblauw)

     
   SNOWY_PLAINS – Sneeuwbedekte vlaktes: #FFFFFF (Wit)

     
   BEACH – Stranden: #FFF5BA (Lichtgeel)

     
   JUNGLE – Tropische regenwouden: #006400 (Donkergroen)

     
   SPARSE_JUNGLE – Dungezaaide regenwouden of bosgebieden: #228B22 (Groen)

     
   DEEP_OCEAN – Diepe oceanen: #000080 (Marineblauw)

     
   STONY_SHORE – Rotsachtige kusten: #808080 (Grijs)

     
   SNOWY_BEACH – Sneeuwstranden: #F0FFFF (Ijsblauw)

     
   BIRCH_FOREST – Berkenbossen: #98FB98 (Pale Green)

     
   DARK_FOREST – Dichte, donkere bossen: #013220 (Diepgroen)

     
   SNOWY_TAIGA – Sneeuwbedekte naaldbossen: #A9DFBF (Bleekgroen met sneeuwtint)

     
   OLD_GROWTH_PINE_TAIGA – Oude naaldbossen: #556B2F (Olijfgroen)

     
   WINDSWEPT_FOREST – Bergbossen: #4682B4 (Staalblauw met bosgroen tint)

     
   SAVANNA – Savannes: #F4A460 (Zanderig)

     
   SAVANNA_PLATEAU – Hooggelegen savannes: #D2B48C (Tan)

     
   BADLANDS – Droge, rotsachtige gebieden: #CD853F (Perkament)

     
   WOODED_BADLANDS – Droge gebieden met beperkte vegetatie: #8B4513 (Sienna)

     
   WARM_OCEAN – Warme tropische oceanen: #00BFFF (Diephemelsblauw)

     
   LUKEWARM_OCEAN – Gematigde oceanen: #4682B4 (Staalblauw)

     
   COLD_OCEAN – Koudere oceanen: #6495ED (Korenbloemblauw)

     
   DEEP_LUKEWARM_OCEAN – Diepe gematigde oceanen: #4169E1 (Koningsblauw)

     
   DEEP_COLD_OCEAN – Diepe koudere oceanen: #00008B (Donkerblauw)

     
   DEEP_FROZEN_OCEAN – Diepe bevroren oceanen: #B0E0E6 (Lichtblauw)

     
   SUNFLOWER_PLAINS – Vlaktes met zonnebloemen: #FFD700 (Goud)

     
   WINDSWEPT_GRAVELLY_HILLS – Gravelheuvels of bergachtige gebieden: #ACACAC (Donkergrijs)

     
   FLOWER_FOREST – Bloemenrijke bossen of weiden: #FF69B4 (Roze)

     
   ICE_SPIKES – Gevormde ijsstructuren: #ADD8E6 (Ijsblauw)

     
   OLD_GROWTH_BIRCH_FOREST – Oude berkenbossen: #90EE90 (Lichtgroen)

     
   OLD_GROWTH_SPRUCE_TAIGA – Oude sparrenbossen: #006400 (Donkergroen)

     
   WINDSWEPT_SAVANNA – Bergachtige savannes: #DEB887 (Lichtbruin)

     
   ERODED_BADLANDS – Geërodeerde woestijnachtige gebieden: #D2691E (Chocoladebruin)

     
   BAMBOO_JUNGLE – Bamboebossen: #32CD32 (Limoengroen)

     
   MEADOW – Bloemenweides of alpenweiden: #ADFF2F (Groengeel)

     
   GROVE – Bossen aan de voet van bergen: #006400 (Donkergroen)

     
   SNOWY_SLOPES – Besneeuwde berghellingen: #EEEEEE (Wit)

     
   FROZEN_PEAKS – Bevroren bergtoppen: #E0FFFF (Ijsblauw)

     
   JAGGED_PEAKS – Scherpe bergtoppen: #D3D3D3 (Lichtgrijs)

     
   STONY_PEAKS – Stenen bergtoppen: #AAACAA (Donkergrijs)

     
   CHERRY_GROVE – Kersenbossen: #FFB6C1 (Lichtroze)
 */
public enum Biome {
    OCEAN,
    PLAINS,
    DESERT,
    WINDSWEPT_HILLS,
    FOREST,
    TAIGA,
    SWAMP,
    MANGROVE_SWAMP,
    RIVER,
    NETHER_WASTES,
    THE_END,
    FROZEN_OCEAN,
    FROZEN_RIVER,
    SNOWY_PLAINS,
    MUSHROOM_FIELDS,
    BEACH,
    JUNGLE,
    SPARSE_JUNGLE,
    DEEP_OCEAN,
    STONY_SHORE,
    SNOWY_BEACH,
    BIRCH_FOREST,
    DARK_FOREST,
    SNOWY_TAIGA,
    OLD_GROWTH_PINE_TAIGA,
    WINDSWEPT_FOREST,
    SAVANNA,
    SAVANNA_PLATEAU,
    BADLANDS,
    WOODED_BADLANDS,
    SMALL_END_ISLANDS,
    END_MIDLANDS,
    END_HIGHLANDS,
    END_BARRENS,
    WARM_OCEAN,
    LUKEWARM_OCEAN,
    COLD_OCEAN,
    DEEP_LUKEWARM_OCEAN,
    DEEP_COLD_OCEAN,
    DEEP_FROZEN_OCEAN,
    THE_VOID,
    SUNFLOWER_PLAINS,
    WINDSWEPT_GRAVELLY_HILLS,
    FLOWER_FOREST,
    ICE_SPIKES,
    OLD_GROWTH_BIRCH_FOREST,
    OLD_GROWTH_SPRUCE_TAIGA,
    WINDSWEPT_SAVANNA,
    ERODED_BADLANDS,
    BAMBOO_JUNGLE,
    SOUL_SAND_VALLEY,
    CRIMSON_FOREST,
    WARPED_FOREST,
    BASALT_DELTAS,
    DRIPSTONE_CAVES,
    LUSH_CAVES,
    DEEP_DARK,
    MEADOW,
    GROVE,
    SNOWY_SLOPES,
    FROZEN_PEAKS,
    JAGGED_PEAKS,
    STONY_PEAKS,
    CHERRY_GROVE
}
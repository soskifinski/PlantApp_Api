using PlantApp.Api.Models;

namespace PlantApp.Api.Data
{
    public static class DbSeeder
    {
        public static void Seed(PlantDbContext context)
        {
            if (context.Plants.Any())
                return; 

            var plants = new List<Plant>
            {
                new()
                {
                    Name = "Rosmarin",
                    Latin = "Rosmarinus officinalis",
                    Description = "Ein mediterranes Küchenkraut mit intensivem Aroma, das oft zu Fleischgerichten passt.",
                    ImageName = "rosmarin",
                    Category = "Gartenpflanze",
                    Poisonous = false,
                    Edible = true,
                    HardyInWinter = true,
                    LightRequirement = "Sonnig",
                    LeafColor = "Grün",
                    BloomingPeriod = "Frühling bis Sommer",
                    HarvestMonths = new short[] { 4,5,6,7,8,9 },
                    FertilizingCycle = new short[] { 3,6 },
                    WateringCycle = new short[] { 5,6,7,8 },
                    SoilType = "sandig, trocken"
                },

                new()
                {
                    Name = "Erdbeere",
                    Latin = "Fragaria x ananassa",
                    Description = "Eine süße rote Fruchtpflanze, beliebt in Desserts und als Snack.",
                    ImageName = "erdbeere",
                    Category = "Gartenpflanze",
                    Poisonous = false,
                    Edible = true,
                    HardyInWinter = true,
                    LightRequirement = "Sonnig",
                    LeafColor = "Grün",
                    BloomingPeriod = "Frühling",
                    HarvestMonths = new short[] { 5,6,7 },
                    FertilizingCycle = new short[] { 3,5 },
                    WateringCycle = new short[] { 4,5,6,7 },
                    SoilType = "humusreich"
                },

                new ()
                {
                    Name = "Monstera",
                    Latin = "Monstera deliciosa",
                    Description = "Eine tropische Zimmerpflanze mit charakteristischen, geschlitzten Blättern.",
                    ImageName = "monstera",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "halbschattig, hell, indirektes Licht",
                    LeafColor = "Grün",
                    BloomingPeriod = "Selten",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,6,8 },
                    WateringCycle = new short[] { 3,4,5,6,7,8,9 },
                    SoilType = "torfhaltig, gut durchlässig"
                },

                new ()
                {
                    Name = "Basilikum",
                    Latin = "Ocimum basilicum",
                    Description = "Ein aromatisches Kraut, besonders beliebt in der italienischen Küche.",
                    ImageName = "basilikum",
                    Category = "Gartenpflanze",
                    Poisonous = false,
                    Edible = true,
                    HardyInWinter = false,
                    LightRequirement = "Sonnig",
                    LeafColor = "Grün",
                    BloomingPeriod = "Sommer",
                    HarvestMonths = new short[] { 6,7,8,9 },
                    FertilizingCycle = new short[] { 5,7 },
                    WateringCycle = new short[] { 5,6,7,8 },
                    SoilType = "feucht, gut durchlässig"
                },

                new ()
                {
                    Name = "Mirabelle",
                    Latin = "Prunus domestica subsp. syriaca",
                    Description = "Eine gelbe Pflaumenart mit süßem Geschmack, ideal für Marmeladen und Kuchen.",
                    ImageName = "mirabelle",
                    Category = "Gartenpflanze",
                    Poisonous = false,
                    Edible = true,
                    HardyInWinter = true,
                    LightRequirement = "Sonnig bis halbschattig",
                    LeafColor = "Grün",
                    BloomingPeriod = "Frühling",
                    HarvestMonths = new short[] { 8 },
                    FertilizingCycle = new short[] { 3,6 },
                    WateringCycle = new short[] { 4,5,6,7,8 },
                    SoilType = "nährstoffreich, gut durchlässig"
                },

                new ()
                {
                    Name = "Japanischer Ahorn",
                    Latin = "Acer palmatum",
                    Description = "Ein dekorativer Laubbaum mit farbenfrohem Herbstlaub, beliebt in Ziergärten.",
                    ImageName = "ahorn",
                    Category = "Gartenpflanze",
                    Poisonous = false,
                    Edible = false,
                    HardyInWinter = true,
                    LightRequirement = "Halbschattig",
                    LeafColor = "Rot bis orange",
                    BloomingPeriod = "Frühling",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4 },
                    WateringCycle = new short[] { 5,6,7 },
                    SoilType = "leicht sauer, humusreich"
                },

                new ()
                {
                    Name = "Süßkirsche",
                    Latin = "Prunus avium",
                    Description = "Ein hoher Obstbaum mit süßen roten Früchten, beliebt bei Mensch und Tier.",
                    ImageName = "suesskirsche",
                    Category = "Gartenpflanze",
                    Poisonous = false,
                    Edible = true,
                    HardyInWinter = true,
                    LightRequirement = "Sonnig",
                    LeafColor = "Grün",
                    BloomingPeriod = "Frühling",
                    HarvestMonths = new short[] { 6,7 },
                    FertilizingCycle = new short[] { 3,6 },
                    WateringCycle = new short[] { 4,5,6,7 },
                    SoilType = "tiefgründig, durchlässig, kalkhaltig"
                },

                new ()
                {
                    Name = "Forellenbegonie",
                    Latin = "Begonia maculata",
                    Description = "Eine exotische Zimmerpflanze mit auffällig gepunkteten Blättern.",
                    ImageName = "forellenbegonie",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Helles, indirektes Licht",
                    LeafColor = "Grün mit weißen Punkten",
                    BloomingPeriod = "Frühling bis Herbst",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,6,8 },
                    WateringCycle = new short[] { 4,5,6,7,8 },
                    SoilType = "luftig, leicht feucht"
                },

                new ()
                {
                    Name = "Aloe Vera",
                    Latin = "Aloe barbadensis miller",
                    Description = "Eine sukkulente Heilpflanze, deren Gel oft für Hautpflege verwendet wird. Giftig für Haustiere.",
                    ImageName = "aloevera",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = true,
                    HardyInWinter = false,
                    LightRequirement = "Sonnig",
                    LeafColor = "Grün",
                    BloomingPeriod = "Sommer",
                    HarvestMonths = new short[] { 5,6,7,8 },
                    FertilizingCycle = new short[] { 4,7 },
                    WateringCycle = new short[] { 5,6,7,8 },
                    SoilType = "sandig, gut drainiert, kaktuserde"
                },

                   new ()
                {
                    Name = "Gummibaum",
                    Latin = "Ficus elastica",
                    Description = "Eine pflegeleichte Zimmerpflanze mit großen, glänzenden Blättern.",
                    ImageName = "gummibaum",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Helles, indirektes Licht, Halbschattig",
                    LeafColor = "Dunkelgrün",
                    BloomingPeriod = "Selten",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,6,8 },
                    WateringCycle = new short[] { 4,5,6,7,8 },
                    SoilType = "locker, gut durchlässig"
                },

                new ()
                {
                    Name = "Glücksfeder",
                    Latin = "Zamioculcas zamiifolia",
                    Description = "Sehr robuste Pflanze, überlebt auch bei wenig Licht und Wasser.",
                    ImageName = "glücksfeder",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Halbschattig bis schattig",
                    LeafColor = "Dunkelgrün",
                    BloomingPeriod = "Selten",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,8 },
                    WateringCycle = new short[] { 3,5,7 },
                    SoilType = "gut drainiert, kaktusähnlich"
                },

                new ()
                {
                    Name = "Einblatt",
                    Latin = "Spathiphyllum",
                    Description = "Bekannt für ihre weißen Blüten und luftreinigende Wirkung.",
                    ImageName = "einblatt",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Halbschattig",
                    LeafColor = "Grün",
                    BloomingPeriod = "Frühling bis Herbst",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,6,8 },
                    WateringCycle = new short[] { 4,5,6,7,8 },
                    SoilType = "feucht, humos, gut durchlässig"
                },

                new ()
                {
                    Name = "Fensterblatt",
                    Latin = "Monstera adansonii",
                    Description = "Verwandt mit der klassischen Monstera, aber mit kleinen, durchlöcherten Blättern.",
                    ImageName = "fensterblatt",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Indirektes Licht, Halbschattig",
                    LeafColor = "Grün",
                    BloomingPeriod = "Sehr selten",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,6,8 },
                    WateringCycle = new short[] { 3,4,5,6,7,8,9 },
                    SoilType = "torfhaltig, durchlässig"
                },

                new ()
                {
                    Name = "Schwiegermutterzunge",
                    Latin = "Sansevieria trifasciata",
                    Description = "Extrem pflegeleicht, ideal für Anfänger. Benötigt kaum Wasser.",
                    ImageName = "schwiegermutterzunge",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Sonnig, halbschattig, schattig",
                    LeafColor = "Grün mit gelben Rändern",
                    BloomingPeriod = "Selten",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 3,7 },
                    WateringCycle = new short[] { 4,7 },
                    SoilType = "sandig, kaktusgeeignet"
                },

                new ()
                {
                    Name = "Bogenhanf Zwergform",
                    Latin = "Sansevieria cylindrica",
                    Description = "Sehr pflegeleicht, verträgt auch längere Trockenzeiten.",
                    ImageName = "bogenhanf_cylindrica",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Sonnig bis schattig",
                    LeafColor = "Graugrün",
                    BloomingPeriod = "Sehr selten",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 3,8 },
                    WateringCycle = new short[] { 14,21 },
                    SoilType = "kaktusgeeignet, gut durchlässig"
                },

                new ()
                {
                    Name = "Zamioculcas",
                    Latin = "Zamioculcas zamiifolia",
                    Description = "Extrem genügsam, ideal für wenig Licht.",
                    ImageName = "zamioculcas",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Schattig",
                    LeafColor = "Dunkelgrün, glänzend",
                    BloomingPeriod = "Selten",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 6,10 },
                    WateringCycle = new short[] { 10,20 },
                    SoilType = "gut durchlässig, leicht sandig"
                },

                new ()
                {
                    Name = "Grünlilie",
                    Latin = "Chlorophytum comosum",
                    Description = "Anspruchslos, bildet viele Ableger, gut zur Luftreinigung.",
                    ImageName = "gruenlilie",
                    Category = "Zimmerpflanze",
                    Poisonous = false,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Sonnig bis halbschattig",
                    LeafColor = "Grün mit weißem Rand",
                    BloomingPeriod = "Frühling bis Herbst",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,8 },
                    WateringCycle = new short[] { 3,6 },
                    SoilType = "lockere Blumenerde"
                },

                new ()
                {
                    Name = "Fensterblatt Mini",
                    Latin = "Monstera adansonii",
                    Description = "Kompaktere Monstera-Art mit typischen Lochblättern.",
                    ImageName = "monstera_adansonii",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Sonnig bis halbschattig",
                    LeafColor = "Grün",
                    BloomingPeriod = "Selten",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,7 },
                    WateringCycle = new short[] { 5,9 },
                    SoilType = "locker, humos"
                },

                new ()
                {
                    Name = "Kentia Palme",
                    Latin = "Howea forsteriana",
                    Description = "Elegante Zimmerpalme, sehr robust und langlebig.",
                    ImageName = "kentia_palme",
                    Category = "Zimmerpflanze",
                    Poisonous = false,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Hell bis halbschattig",
                    LeafColor = "Grün",
                    BloomingPeriod = "Frühjahr, jedoch selten im Haus",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,8 },
                    WateringCycle = new short[] { 5,10 },
                    SoilType = "palmengeeignete Erde"
                },

                new ()
                {
                    Name = "Farn Schwertfarn",
                    Latin = "Nephrolepis exaltata",
                    Description = "Beliebter Farn mit buschigem Wuchs, liebt hohe Luftfeuchte.",
                    ImageName = "schwertfarn",
                    Category = "Zimmerpflanze",
                    Poisonous = false,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Halbschattig",
                    LeafColor = "Hellgrün",
                    BloomingPeriod = "Nicht relevant (sporentragend)",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,8 },
                    WateringCycle = new short[] { 2,5 },
                    SoilType = "torfhaltig, locker"
                },

                new ()
                {
                    Name = "Flamingoblume",
                    Latin = "Anthurium andraeanum",
                    Description = "Dekorative Blüten, benötigt hohe Luftfeuchtigkeit.",
                    ImageName = "flamingoblume",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Hell, indirektes Licht",
                    LeafColor = "Dunkelgrün, glänzend",
                    BloomingPeriod = "Ganzjährig bei guter Pflege",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,7 },
                    WateringCycle = new short[] { 4,7 },
                    SoilType = "orchideengeeignet, luftig"
                },

                new ()
                {
                    Name = "Ficus Benjamini",
                    Latin = "Ficus benjamina",
                    Description = "Beliebter Zimmerbaum mit feinem Blattwerk, benötigt konstante Bedingungen.",
                    ImageName = "ficusbenjamini",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Hell, indirektes Licht, Schattig",
                    LeafColor = "Dunkelgrün",
                    BloomingPeriod = "Sehr selten in Innenräumen",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,8 },
                    WateringCycle = new short[] { 5,9 },
                    SoilType = "locker, humos"
                },

                new ()
                {
                    Name = "Korbmarante",
                    Latin = "Calathea orbifolia",
                    Description = "Dekorative Blätter, benötigt hohe Luftfeuchtigkeit und warmes Klima.",
                    ImageName = "korbmarante",
                    Category = "Zimmerpflanze",
                    Poisonous = false,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Halbschattig",
                    LeafColor = "Grün mit silbernen Streifen",
                    BloomingPeriod = "Selten",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,7 },
                    WateringCycle = new short[] { 3,5 },
                    SoilType = "torfhaltig, locker"
                },

                new ()
                {
                    Name = "Pfeilblatt",
                    Latin = "Alocasia amazonica",
                    Description = "Exotische Pflanze mit kontrastreichen, pfeilförmigen Blättern.",
                    ImageName = "pfeilblatt",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Halbschattig",
                    LeafColor = "Dunkelgrün mit weißen Adern",
                    BloomingPeriod = "Selten",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,7 },
                    WateringCycle = new short[] { 4,7 },
                    SoilType = "leicht sauer, humos"
                },

                new ()
                {
                    Name = "Zwergpfeffer",
                    Latin = "Peperomia obtusifolia",
                    Description = "Kompakte, pflegeleichte Zimmerpflanze, ideal für kleine Räume.",
                    ImageName = "zwergpfeffer",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Hell bis halbschattig",
                    LeafColor = "Dunkelgrün, fleischig",
                    BloomingPeriod = "Sommer",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 5,9 },
                    WateringCycle = new short[] { 5,10 },
                    SoilType = "locker, leicht sandig"
                },

                new ()
                {
                    Name = "Flamingo-Lilie Rosa",
                    Latin = "Anthurium clarinervium",
                    Description = "Auffallende Herzblätter mit hellen Blattadern.",
                    ImageName = "anthurium_clarinervium",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Halbschattig",
                    LeafColor = "Dunkelgrün mit weißen Adern",
                    BloomingPeriod = "Ganzjährig möglich",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,7 },
                    WateringCycle = new short[] { 4,7 },
                    SoilType = "luftig, orchideengeeignet"
                },

                new ()
                {
                    Name = "Birkenfeige Mini",
                    Latin = "Ficus microcarpa Ginseng",
                    Description = "Bonsai-ähnliche Zimmerpflanze mit dicken Wurzeln.",
                    ImageName = "ficus_ginseng",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Halbschattig",
                    LeafColor = "Grün",
                    BloomingPeriod = "Sehr selten",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,7 },
                    WateringCycle = new short[] { 4,8 },
                    SoilType = "bonsaigeeignet"
                },

                new ()
                {
                    Name = "Schefflera",
                    Latin = "Schefflera arboricola",
                    Description = "Robuste Strahlenaralie, gut geeignet für helle Räume.",
                    ImageName = "schefflera",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Hell bis halbschattig",
                    LeafColor = "Grün",
                    BloomingPeriod = "Selten",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,8 },
                    WateringCycle = new short[] { 5,9 },
                    SoilType = "lockere Blumenerde"
                },

                new ()
                {
                    Name = "Jadebaum",
                    Latin = "Crassula ovata",
                    Description = "Sehr langlebige Sukkulente, ideal für sonnige Fensterplätze.",
                    ImageName = "crassula_ovata",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Sonnig",
                    LeafColor = "Hellgrün, fleischig",
                    BloomingPeriod = "Winter bis Frühling",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 4,8 },
                    WateringCycle = new short[] { 10,20 },
                    SoilType = "sukkulentengeeignet"
                },

                new ()
                {
                    Name = "Usambaraveilchen",
                    Latin = "Saintpaulia ionantha",
                    Description = "Beliebte Blühpflanze für Innenräume, kompakt und farbenfroh.",
                    ImageName = "usambaraveilchen",
                    Category = "Zimmerpflanze",
                    Poisonous = true,
                    Edible = false,
                    HardyInWinter = false,
                    LightRequirement = "Halbschattig",
                    LeafColor = "Dunkelgrün, weich",
                    BloomingPeriod = "Ganzjährig bei guter Pflege",
                    HarvestMonths = Array.Empty<short>(),
                    FertilizingCycle = new short[] { 3,7 },
                    WateringCycle = new short[] { 3,6 },
                    SoilType = "leicht sauer, locker"
                }

            };



            context.Plants.AddRange(plants);
            context.SaveChanges();
        }
    }

}

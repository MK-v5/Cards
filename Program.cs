namespace Cards
{
    internal class Program
    {
        /*
        * Maak een kaartspel template met een class of struct 
        * voor een kaart en een class voor een deck
        * (een set van een x-aantal kaarten).
        * 
        *-=================================================================-
        *
        * Zorg voor logische invullingen van beide classes en/of structs.
        * Wanneer een deck geinstantieerd wordt
        * moet het gevuld worden met de juiste 52 kaarten.
        * 
        *-=================================================================-
        *
        * Zorg voor duidelijk commentaar op de juiste plekken.
        * Vraag om de speler naam en gebruik
        * deze in je communicatie met de speler.
        * 
        *-=================================================================-
        *
        * Zorg voor een game loop die pas ophoudt als de speler de
        * >>esc-toets<< indrukt,
        * dit is de enige mogelijkheid om de applicatie te laten eindigen. 
        */

        //var 1:
        //Maak op basis van de card en deck classes
        //een spel waarbij je na iedere getrokken kaart moet raden
        //of de volgende kaart hoger of lager is
        static int lives = 0;
        static int guess;

        //(of van welke soort(harten, ruiten, klaveren, schoppen) de kaart is).
        //Voor iedere kaart die de speler goed raadt krijgt hij een punt.

        //Na alle kaarten in het deck gehad te hebben
        //heeft de speler een bepaalde score behaald,
        //deze laat je zien.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

using System.Diagnostics;

namespace Pokemon;
/*
    CONSIGNES
    1. Déclarer un tableau contenant les six Pokémon suivants :
       - Pikachu
       - Dracaufeu
       - Tortank
       - Florizarre
       - Ectoplasma
       - Ronflex
   2. Utiliser une boucle for pour parcourir le tableau.
   3. Afficher chaque Pokémon avec sa position dans l'équipe.
   4. Afficher le nombre total de Pokémon.
*/
class Program
{
    static void Main(string[] args)
    {
        string [] pokemon = {"Pikachu", "Dracaufeu", "Tortank", "Florizarre", "Ectoplasm", "Ronflex"} ;
        for ( int tableau=0 ; tableau <pokemon.Length; tableau++)
        {
            Console.WriteLine((tableau+1).ToString() + ". " + pokemon[tableau]);
        }
        
        Console.WriteLine("Il y a " + pokemon.Length + " pokémons");
    }
}
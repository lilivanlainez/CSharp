using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String frase = "Mi nombre es Ivan y mi numero de telefono es (+503) 71179004 y mi codigo postal es 503";

            string patron = "[I]";

            Regex miRegex = new Regex(patron);

            MatchCollection matches = miRegex.Matches(frase);
            if (matches.Count > 0) Console.WriteLine("Se ha encontrado una I");
            else Console.WriteLine("No se ha encontrado una J");
            
            
            
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }

        }
    }
}

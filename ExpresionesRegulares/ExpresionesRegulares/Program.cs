using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String frase = "Mi nombre es Ivan y mi numero de telefono es (+503) 71179004 y mi codigo postal es 503";

            String buscarNumero = @"\+503|\+34";
            string patron = "[I]";

            Regex miRegex = new Regex(patron);
            Regex miRegex2 = new Regex(buscarNumero);

            MatchCollection matches = miRegex.Matches(frase);
            if (matches.Count > 0) Console.WriteLine("Se ha encontrado una I");
            else Console.WriteLine("No se ha encontrado una J");
       
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
            MatchCollection matches2 = miRegex2.Matches(frase);
            if (matches.Count > 0) Console.WriteLine("Se ha encontrado un zipcode");
            else Console.WriteLine("No se ha encontrado un zipcode");

            foreach (Match match in matches2)
            {
                Console.WriteLine(match);
            }
        }
    }
}

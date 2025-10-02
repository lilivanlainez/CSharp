using System;
using AvisosVaios;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrrafico aviso1 = new AvisosTrrafico();
            aviso1.mostrarAviso();
            AvisosTrrafico aviso2 = new AvisosTrrafico("Ayuntamiento de Madrid", "Corte de tráfico en la calle Mayor por evento deportivo", "15/10/2023");
            aviso2.mostrarAviso();
        }
    }
}

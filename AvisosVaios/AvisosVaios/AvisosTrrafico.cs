using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVaios
{
    internal class AvisosTrrafico : IAvisos
    {
        public AvisosTrrafico()
        {
            remitente = "Dirección General de Tráfico";
            mensaje = "Hay un accidente en la carretera A-1, por favor evite la zona.";
            fecha = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public AvisosTrrafico(string remitente, string menaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = menaje;
            this.fecha = fecha;
        }
        public void mostrarAviso()
        {
            Console.WriteLine("Mensaje {0} he sido enviado por {1} el dia {2}", mensaje, remitente, fecha);
        }
        public string getFecha()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        private string remitente;
        private string mensaje;
        private string fecha;
       
    }
}

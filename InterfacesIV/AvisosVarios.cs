using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesIV
{
    class AvisosVarios : IAvisos
    {
        private string remitente;
        private string mensaje;
        private string fecha;

        public AvisosVarios()
        {
            remitente = "DGT";
            mensaje = "Sanción cometida. Pague antes de 3 días y se beneficiará de una reducción en la sanción del 50%";
            fecha = "";
        }
        public AvisosVarios(string remitente,string mensaje,string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
        public string getFecha()
        {
            return fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el día {2}", mensaje,remitente,fecha);
        }
    }
}

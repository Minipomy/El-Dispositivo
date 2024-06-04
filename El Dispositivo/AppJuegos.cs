using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Dispositivo
{
    public class AppJuegos : Aplicacion
    {
        protected override int Tamanio => this.Tamanio;

        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo, int tamanio) : base(nombre, sistemaOperativo, tamanio) { }
    }
}

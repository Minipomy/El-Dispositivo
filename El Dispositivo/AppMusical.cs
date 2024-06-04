using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Dispositivo
{
    public class AppMusical : Aplicacion
    {
        private List<string> _listaCanciones;
        protected override int Tamanio => this.Tamanio + (2 * _listaCanciones.Count);

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial) : base(nombre, sistemaOperativo, tamanioInicial)
        {

        }
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial, List<string> listaCanciones) : this(nombre, sistemaOperativo, tamanioInicial)
        {
            _listaCanciones = listaCanciones;
        }

        public string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lista de canciones");
            foreach (string canciones in _listaCanciones)
            {
                sb.AppendLine($"{canciones}");
            }

            return sb.ToString();
        }
    }
}

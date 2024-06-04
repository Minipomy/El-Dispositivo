using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace El_Dispositivo
{
    public abstract class Aplicacion
    {
        protected string _nombre;
        protected SistemaOperativo _sistemaOperativo;
        protected int _tamanioMb;
        protected abstract int Tamanio { get; }
        public SistemaOperativo SistemaOperativo { get => _sistemaOperativo; }
        public override string ToString()
        {
            return _nombre;
        }
        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            _nombre = nombre;
            _sistemaOperativo = sistemaOperativo;
            _tamanioMb = tamanioMb;
        }



        public static bool operator ==(List<Aplicacion> aplicacion, Aplicacion app)
        {
            return aplicacion.Contains(app);
        }
        public static bool operator !=(List<Aplicacion> aplicacion, Aplicacion app)
        {
            return !(aplicacion == app);
        }
        public static bool operator +(List<Aplicacion> list_app, Aplicacion app)
        {
            if (list_app != app)
            {
                list_app.Add(app);
                return true;
            }
            return false;
        }
        public static implicit operator Aplicacion(List<Aplicacion> apps)
        {
            int tamanioTemp = 0;
            bool flag = true;
            Aplicacion app_temporal = null;
            foreach (Aplicacion app_list in apps)
            {
                if (app_list.Tamanio > tamanioTemp && flag == true)
                {
                    tamanioTemp = app_list.Tamanio;
                    app_temporal = app_list;
                    flag = false;
                }
                else
                {
                    if (tamanioTemp < app_list.Tamanio)
                    {
                        tamanioTemp = app_list.Tamanio;
                        app_temporal = app_list;
                    }
                }
            }
            return app_temporal;
        }
        public string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {_nombre}");
            sb.AppendLine($"Sistema Operativo: {SistemaOperativo}");
            sb.AppendLine($"Tamaño MBs: {_tamanioMb}");

            return sb.ToString();
        }
    }
}

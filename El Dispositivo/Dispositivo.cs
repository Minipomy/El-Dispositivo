using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace El_Dispositivo
{
    public static class Dispositivo
    {
        private static List<Aplicacion> _apps;
        private static SistemaOperativo _sistemaOperativo;
        static Dispositivo()
        {
            _apps = new List<Aplicacion>();
            _sistemaOperativo = SistemaOperativo.ANDROID;
        }

        public static bool InstalarApp(Aplicacion app)
        {
            if (app.SistemaOperativo == _sistemaOperativo) 
            {
                _apps.Add(app);
                return true;
            }
            return false;
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DISPOSITIVO: {_sistemaOperativo}");
            foreach (Aplicacion app in _apps)
            {
                sb.AppendLine($"Aplicaciones instalada: {app}");
            }

            return sb.ToString();
        }
    }
}

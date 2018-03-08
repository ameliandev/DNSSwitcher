using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DNSSwitcher.Clases
{
    class AppCulture
    {
        public static string AppCultureName { get; set; }

        internal static string GetButtonText(bool status)
        {
            if (AppCultureName.Contains("es-") || AppCultureName.Contains("Es-"))
            {
                return status ? "DESACTIVAR" : "ACTIVAR";
            }
            else
            {
                return status ? "OFF" : "ON";
            }
        }

        internal static string GetBallonMessage(bool status)
        {
            if (AppCultureName.Contains("es-") || AppCultureName.Contains("Es-"))
            {
                return string.Format("Las DNS configuradas han sido {0}", status ? "Activadas" : "Desactivadas");
            }
            else
            {
                return string.Format("Configured DNS has been switched {0}", status ? "On" : "Off");
            }
        }

        internal static string GetConfigurationText(bool status)
        {
            if (AppCultureName.Contains("es-") || AppCultureName.Contains("Es-"))
            {
                return status ? "Mostrar configuración" : "Ocultar configuración";
            }
            else
            {
                return status ? "Show configuration" : "Hide configuration";
            }
        }

        internal static string GetToolInformationStatusText(bool status)
        {
            if (AppCultureName.Contains("es-") || AppCultureName.Contains("Es-"))
            {
                return status ? "Estado = Activado" : "Estado = Desactivado";
            }
            else
            {
                return status ? "Status = Off" : "Status = On";
            }
        }

        internal static string GetToolInactiveText()
        {
            if (AppCultureName.Contains("es-") || AppCultureName.Contains("Es-"))
            {
                return "Desactivar";
            } else
            {
                return "Deactivate";
            }
        }

        internal static string GetToolActiveText()
        {
            if (AppCultureName.Contains("es-") || AppCultureName.Contains("Es-"))
            {
                return "Activar";
            }
            else
            {
                return "Activate";
            }
        }
    }
}

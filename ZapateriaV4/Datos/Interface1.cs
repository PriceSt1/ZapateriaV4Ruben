using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaV4.Datos
{
    interface IAcceso<obj>
    {
        bool insertarZapato(obj objeto);
        bool borrarZapato(obj objeto);
        Object buscarZapato(String nombre);
        List<object> obtenerZapatos();
        bool modificarZapato(obj objeto);
    }
}

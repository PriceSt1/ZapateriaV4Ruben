using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapateriaV4.Models;

namespace ZapateriaV4.Datos
{
    class UtilSQL
    {
        public static String sqlInsertarZapato(Zapato obZapato)
        {
            return "INSERT INTO `tzapato` (`marca`, `nombre`, `color`, `tipo`, `precio`, `formatouno`, `formatodos`, `formatotres`, estado`, `borrado`) VALUES ('"
                    + obZapato.Marca + "' , '" + obZapato.Nombre + "' , '" + obZapato.Color + "' , '"
                    + obZapato.Tipo + "' , '" + obZapato.Precio + "' , '" + obZapato.Formatouno + "' , '" + obZapato.Formatodos + "' , '"
                    + obZapato.Formatotres + "' , '" + obZapato.Estado + "')";
        }

        public static String sqlBorrarZapato(String nombre)
        {
            return "DELETE FROM `tzapato` WHERE `Nombre` = '" + nombre + "'";
        }

        public static String sqlBuscarZapato(String nombre)
        {
            return "SELECT * FROM `tzapato` WHERE `Nombre` = '"
                    + nombre + "'";
        }

        public static String sqlObtenerZapato()
        {
            return "SELECT * FROM `tzapato`";

        }

        public static String sqlModificarZapato(Zapato obZapato)
        {
            return "UPDATE `tzapato` SET `Marca`= '" + obZapato.Marca + "' ,`Nombre`= '" + obZapato.Nombre
                    + "' ,`Color`= '" + obZapato.Color + "' ,`Tipo`= '" + obZapato.Tipo + "' ,`Precio`= '" + obZapato.Precio + "' ,`Formatouno`= '"
                    + obZapato.Formatouno + "' ,`Formatodos`= '" + obZapato.Formatodos + "' ,`Formatotres`= '"
                    + obZapato.Formatotres + "' ,`Estado`= '" + obZapato.Estado + "'  WHERE `Nombre` = '"
                    + obZapato.Nombre + "'";
        }
    }
}

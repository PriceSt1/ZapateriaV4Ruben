using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapateriaV4.Models;

namespace ZapateriaV4.Datos
{
    public class AccesoZapato : AccesoBD, IAcceso<Zapato>
    {

        public Boolean insertarZapato(Zapato obZapato)
        {
            try
            {
                return ejecutarUpdate(UtilSQL.sqlInsertarZapato(obZapato));
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public Boolean borrarZapato(Zapato obZapato)
        {
            try
            {
                return ejecutarUpdate(UtilSQL.sqlBorrarZapato(obZapato.Nombre));
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public object buscarZapato(string nombre)
        {

            try
            {
                // El método First nos devuelve el primer objeto de la colección.
                return ejecutarConsulta(UtilSQL.sqlBuscarZapato(nombre), new Zapato()).First();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public List<object> obtenerZapatos()
        {

            try
            {
                return ejecutarConsulta(UtilSQL.sqlObtenerZapato(), new Zapato());
            }
            catch (Exception e)
            {
                throw;
            }
        }


        public Boolean modificarZapato(Zapato obZapato)
        {
            try
            {
                return ejecutarUpdate(UtilSQL.sqlModificarZapato(obZapato));
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
using Eventos.BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class BitacoraEventos
    {
        //Definicion de propiedades
        private BitacoraEventos _bitacora;

        //Constructor
        private BitacoraEventos()
        {

        }
        private BitacoraEventos Bitacora()
        {
            if (_bitacora == null)
            {
                _bitacora = new BitacoraEventos();
            }
            return _bitacora;
        }
        public static void InsertaEvento(string p_usuario, string p_proceso, string p_accion, string p_informacion)
        {
            try
            {

                DataAccses data = new DataAccses();
                data.bitacora(p_usuario, p_proceso, p_accion, p_informacion, "Definiendo-Horizontes");
            }
            catch (Exception es)
            {
                Console.WriteLine(es.Message);
            }
        }

        public static void InsertaError(string p_usuario, string p_proceso, string p_accion, string p_informacion)
        {
            try
            {

                DataAccses data = new DataAccses();
                data.bitacora(p_usuario, p_proceso, p_accion, p_informacion, "Definiendo-Horizontes");
            }
            catch (Exception es)
            {
                Console.WriteLine(es.Message);
            }
        }
    }
}

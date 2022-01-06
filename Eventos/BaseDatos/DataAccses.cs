using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Eventos.BaseDatos
{
    public class DataAccses
    {
        //private string conexion = @"Data Source=L03036903L01\SQLEXPRESS;Initial Catalog=BitacoraErrorWeb;Integrated Security=True;Connect Timeout=3000; MultipleActiveResultSets=True;";
        //private string conexion = @"Data Source=pprd022azdb07.svcs.itesm.mx;Initial Catalog=BitacoraErrorWebQA;User ID=implementacion;Password=UZ4w67ytQa;Connect Timeout=3000; MultipleActiveResultSets=True;";
        private string conexion = @"Data Source=pprd022azdb07.svcs.itesm.mx;Initial Catalog=BitacoraErrorWebQA;User ID=implementacion;Password=UZ4w67ytQa;Connect Timeout=3000; MultipleActiveResultSets=True;Encrypt=False;";

        private BaseDatos bases = new BaseDatos();
        public void bitacora(string usuario, string proceso, string accion, string informacion, string aplicacion)
        {
            bool bandera = false;
            DataTable tabla = new DataTable();

            SqlParameter[] parameters =
                {
                  new SqlParameter("@UsuarioId ", SqlDbType.VarChar) { Value =usuario  },
                  new SqlParameter("@Proceso", SqlDbType.VarChar) { Value = proceso },
                  new SqlParameter("@Accion", SqlDbType.VarChar) { Value = accion },
                  new SqlParameter("@Informacion", SqlDbType.VarChar) { Value = informacion },
                  new SqlParameter("@Aplicacion", SqlDbType.VarChar) { Value = aplicacion }

            };



            if (bases.ExecSp(conexion, "ps_bitacora", parameters, ref tabla))
            {
                if (tabla.Rows.Count > 0)
                {
                    bandera = true;
                }
            }
            else
            {
                var error = bases.Error;
            }

        }
    }
}

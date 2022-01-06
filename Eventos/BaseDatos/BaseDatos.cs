using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.BaseDatos
{
    public class BaseDatos
    {
        private int contador;
        private SqlCommand comando;
        private SqlConnection conecta;
        private SqlDataAdapter adapto;
        public string Error;

        public bool ExecSp(string conexion, string Procedimiento, SqlParameter[] Valores, ref DataTable Dt)
        {
            bool bandera = false;
            conecta = new SqlConnection(conexion);
            try
            {
                this.contador = 0;
                this.comando = new SqlCommand();
                this.comando.Connection = this.conecta;
                this.comando.CommandType = System.Data.CommandType.StoredProcedure;
                while (contador < Valores.Length)
                {
                    comando.Parameters.Add(Valores[contador]);
                    contador++;
                }
                comando.CommandText = Procedimiento;
                comando.CommandTimeout = 36000;
                adapto = new SqlDataAdapter(comando);
                Dt = new System.Data.DataTable();
                adapto.Fill(Dt);
                bandera = true;
            }
            catch (SqlException es)
            {
                this.Error = es.Message;
                bandera = false;
            }
            finally
            {
                conecta.Close();
            }
            return bandera;

        }

        public bool ExecSp(string conexion, string Procedimiento, List<SqlParameter> Valores, ref DataTable Dt, int timeout)
        {
            bool bandera = false;
            conecta = new SqlConnection(conexion);
            try
            {
                this.contador = 0;
                this.comando = new SqlCommand();
                this.comando.Connection = this.conecta;
                this.comando.CommandType = System.Data.CommandType.StoredProcedure;
                while (contador < Valores.Count)
                {
                    comando.Parameters.Add(Valores[contador]);
                    contador++;
                }
                comando.CommandText = Procedimiento;
                comando.CommandTimeout = timeout;
                adapto = new SqlDataAdapter(comando);
                Dt = new System.Data.DataTable();
                adapto.Fill(Dt);
                bandera = true;
            }
            catch (SqlException es)
            {
                this.Error = es.Message;
                bandera = false;
            }
            finally
            {
                conecta.Close();
            }
            return bandera;

        }
    }
}

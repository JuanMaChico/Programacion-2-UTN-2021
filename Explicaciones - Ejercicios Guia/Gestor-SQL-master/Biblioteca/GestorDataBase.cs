using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public delegate void Actualizador(DataTable datos);
    public delegate void Informador(string excepciones);
    public class GestorDataBase
    {        
        private SqlConnection sqlConexion;
        private Thread hilo;
        public event Actualizador EventoActualizarBaseDedatos;
        public event Informador EventoInformarBaseDeDatos;
        private SqlCommand sqlCommand;
        private string servidor;
        private string usuario;
        private string password;
        private string baseDeDatos;

        public GestorDataBase(string servidor, string baseDeDatos, string usuario, string password)
        {
            this.servidor = servidor;
            this.usuario = usuario;
            this.password = password;
            this.baseDeDatos = baseDeDatos;
            this.sqlConexion = new SqlConnection($"Server={this.servidor};Database={this.baseDeDatos};User Id={this.usuario};Password={this.password};Connect Timeout=600");
            this.hilo = new Thread(LeerRegistros);
        }

        public string Sentencia
        {
            set
            {
                string stringAux = value.ToLower();
                if(!stringAux.Contains("delete") && !stringAux.Contains("insert"))
                {
                    this.sqlCommand = new SqlCommand(value, this.sqlConexion);
                }
                else
                {
                    throw new Exception("No se puede ejecutar la sentencia indicada");
                }
            }
        }
        public bool Activar
        {
            get
            {
                bool returnAux = false;
                if (!object.ReferenceEquals(this.hilo, null))
                {
                    returnAux = this.hilo.IsAlive;
                }
                return returnAux;
            }
            set
            {
                if (value && !object.ReferenceEquals(this.hilo, null) && !this.hilo.IsAlive)
                {
                    if (this.hilo.ThreadState == ThreadState.Aborted || this.hilo.ThreadState == ThreadState.Stopped)
                    {
                        this.hilo = new Thread(LeerRegistros);
                    }
                    this.hilo.Start();
                }
                else if (!object.ReferenceEquals(this.hilo, null) && !value)
                {
                    this.hilo.Abort();
                }
            }
        }

        private void LeerRegistros()
        {
            try
            {
                this.EventoActualizarBaseDedatos.Invoke(this.LeerDesdeBD());
            }
            catch (Exception ex)
            {
                this.EventoInformarBaseDeDatos.Invoke(ex.Message);
            }
        }


        private DataTable LeerDesdeBD()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                sqlDataAdapter.Fill(dataTable);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if (this.sqlConexion != null && this.sqlConexion.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConexion.Close();
                }
            }
            return dataTable;
        }
    }
}

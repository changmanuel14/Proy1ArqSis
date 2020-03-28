using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class DataAccess
    {
        #region atributos
        private SqlConnection cn { get; set; }
        private SqlTransaction transaction;
        private string sCadena = string.Empty;
        #endregion

        #region builder
        public DataAccess()
        {
            sCadena = "Data Source = QQUIROA; Initial Catalog = inventarioDB; User ID = sa; Password = database;";
            cn = new SqlConnection(sCadena);
        }
        #endregion

        #region method
        public int executeCommand(string sCommand)
        {
            int result = -1;
            SqlCommand cm = null;
            try
            {
                cm = new SqlCommand(sCommand, cn);
                cm.Connection.Open();
                result = cm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al ejecutar comando: " + ex.ErrorCode);
            }
            finally
            {
                cm.Connection.Close();
            }
            return result;
        }

        public DataTable fillDataTable(string sQuery)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sQuery, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al consultar datos: " + ex.ErrorCode);
            }
        }

        public void beginTransaction()
        {
            transaction = cn.BeginTransaction();
        }

        public void commitTransaction()
        {
            transaction.Commit();
        }

        public void RollBackTransaction()
        {
            transaction.Rollback();
        }

        #endregion
    }
}

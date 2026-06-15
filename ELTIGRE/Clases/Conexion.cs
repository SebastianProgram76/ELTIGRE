using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ELTIGRE.Clases
{
    internal class Conexion
    {
        protected SqlConnection cxndb;
        
        protected bool Conectar()
        {
            try
            {
                cxndb = new SqlConnection(Properties.Settings.Default.CNN);
                cxndb.Open();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR Conexion: No se pudo establecer enlace con la db, llamar al mostro de sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        protected bool Desconectar()
        {
            try
            {
                if(cxndb.State == ConnectionState.Open)
                {
                    cxndb.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}

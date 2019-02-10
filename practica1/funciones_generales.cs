using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bibliotecas para SQL
using System.Data.Sql;
using System.Data.SqlClient;
//Bibliotecas para usar los formularios
using System.Configuration;
using System.Windows.Forms;

namespace practica1
{
    class funciones_generales
    {
        //Variables de conexión
        public SqlConnection SG906;
        public SqlDataReader dr;
        //public SqlDataAdapter da;
        ////public int usertype;
        //public int userid;
        public String username;
        public SqlCommand cmd;

        //Esta función establece la conexión con la base de datos PV906
        public void configurar_conexion()
        {
            SG906 = new SqlConnection(ConfigurationManager.ConnectionStrings["PV906"].ConnectionString);
        }

        //cerrar y abrir la conexión (Por seguridad)
        public void cerrar_abrir_conexion()
        {
            SG906.Close();
            SG906.Open();
        }

        //Función que permite confirmar la salida del sistema desde el botón de cierre del formulario
        public void salir_aplicacion_formulario(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                
            }
        }

        //Función que permite confirmar la salida del sistema desde un botón creado para salir
        public void salir_aplicacion_boton()
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;

namespace practica1
{
    public partial class form_acceso : Form
    {

        funciones_generales fg = new funciones_generales();
        public form_acceso()
        {
            InitializeComponent();
            fg.configurar_conexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Llene los campos faltantes");
            }
            else
            {
                string consulta = "select * from Usuario where usuario_nombre='"+txt_usuario.Text+"' and usuario_pass='"+txt_pass.Text+"'";
                fg.cmd = new SqlCommand(consulta,fg.SG906);
                fg.cerrar_abrir_conexion();
                if (fg.cmd.ExecuteScalar() != null)
                {
                    //Ejecuta la lectura del comando
                    fg.dr = fg.cmd.ExecuteReader();
                    if (fg.dr.Read())
                    {  
                        //fg.userid = fg.dr.GetInt16(0);
                        fg.username = fg.dr.GetString(1);
                        //fg.usertype = fg.dr.GetInt32(2);
                        this.Hide();
                        MenuProyecto menu = new MenuProyecto();
                        menu.Show();
                        MessageBox.Show("Sesión iniciada como '" + txt_usuario.Text + "'.", "Bienvendido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    fg.dr.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta","Error");
                }
                
            }

            /*
            String nombre, pass;
            nombre = txt_usuario.Text;
            pass   = txt_pass.Text;

            if (verificar_datos(nombre, pass))
            {
                MessageBox.Show("Enviar Ventana nueva");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }*/
            
        }
        private Boolean verificar_datos(String nombre, String pass)
        {
            //Comparamos nombre y contraseña
            if (nombre.Equals("Fer") && pass.Equals(""))
            {
                return true;
            }
            else
                return false;
        }

        private void txt_cancel_Click(object sender, EventArgs e)
        {
            //Limpiamos cajas de texto
            txt_usuario.Clear();
            txt_pass.Clear();

            txt_usuario.Focus();
            fg.salir_aplicacion_boton();
        }

        private void form_acceso_FormClosing(object sender, FormClosingEventArgs e)
        {
            fg.salir_aplicacion_formulario(sender,e);
        }
    }
}

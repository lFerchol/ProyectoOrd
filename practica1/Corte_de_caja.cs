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
    public partial class Corte_de_caja : Form
    {
        public int accion;
        funciones_generales fg = new funciones_generales();
        public Corte_de_caja()
        {
            InitializeComponent();
            fg.configurar_conexion();
            //Verificar error
            string consulta = "select cajas_nombre from caja";
            fg.cmd = new SqlCommand(consulta, fg.SG906);
            fg.cerrar_abrir_conexion();
            fg.dr = fg.cmd.ExecuteReader();
            while (fg.dr.Read()){
                comboBox1.Items.Add(fg.dr["cajas_nombre"].ToString());
            }
        }

        private void lbl_seleccionar_caja_Click(object sender, EventArgs e)
        {
            
        }
        private void limpiar()
        {
            txt_usuario.Text = "";
            txt_pass.Text= "";
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                btn_abrir_caja.Enabled = true;
            }
            else
            {
                btn_abrir_caja.Enabled = false;
            }

        }

        int usuario_id=0;

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

            if (txt_usuario.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Llene los campos faltantes");
            }
            else
            {
                    string consulta = "select * from Usuario where usuario_nombre='" + txt_usuario.Text + "' and usuario_pass='" + txt_pass.Text + "' and usuario_rol in (0,1,2,7)";
                    fg.cmd = new SqlCommand(consulta, fg.SG906);
                    fg.cerrar_abrir_conexion();
                    if (fg.cmd.ExecuteScalar() != null)
                    {
                        //Ejecuta la lectura del comando
                        fg.dr = fg.cmd.ExecuteReader();
                        if (fg.dr.Read())
                        {
                            //usuario_id = fg.dr.GetInt32(0);
                            btn_abrir_caja.Visible = true;
                            if (comboBox1.Text == "")
                            {
                                MessageBox.Show("Seleccione una caja");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usted no tiene permisos de operar una caja", "Permiso denegado");
                        }
                        fg.dr.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta", "Error");
                        limpiar();
                    }
                
                

            }
        }

        public void consultaCajaAbierta()
        {
            //verificar consulta
            String consulta2 = "select cajas_nombre from caja where cajas_status=1";
            //MessageBox.Show("Consulta: " + consulta2);
            fg.cmd = new SqlCommand(consulta2, fg.SG906);
            fg.cerrar_abrir_conexion();
            fg.dr = fg.cmd.ExecuteReader();
            if (fg.dr.Read())
            {
                comboBox1.Text = fg.dr["cajas_nombre"].ToString();
            }
        }
        private void btn_abrir_caja_Click(object sender, EventArgs e)
        {

            if (accion == 1)
            {
                //verificar consulta
                String consulta2 = "select cajas_status from caja where cajas_nombre ='" + comboBox1.Text + "' and cajas_status=0";
                MessageBox.Show("Consulta: "+consulta2);
                fg.cmd = new SqlCommand(consulta2, fg.SG906);
                fg.cerrar_abrir_conexion();
                fg.dr = fg.cmd.ExecuteReader();
                if (fg.dr.Read())
                {
                    MessageBox.Show(fg.dr["cajas_status"].ToString());
                    consulta2 = "update caja set cajas_status=1, cajas_operador=" + usuario_id + " where cajas_nombre='" + comboBox1.Text + "'";
                    MessageBox.Show("Consulta dentro del if: " + consulta2);
                    fg.cmd = new SqlCommand(consulta2, fg.SG906);
                    fg.cerrar_abrir_conexion();
                    fg.cmd.ExecuteNonQuery();
                    MessageBox.Show("" + comboBox1.Text + " abierta");
                    fg.dr.Close();
                    fg.SG906.Close();
                    this.Close();
                    this.Dispose();
                    //groupBox1.Visible = true;
                }
                else
                {
                    //groupBox1.Visible = true;
                    MessageBox.Show("La caja que desea abrir está en uso");
                    fg.dr.Close();
                    fg.SG906.Close();
                }
            }
            else if(accion == 2)
            {
                groupBox1.Visible = true;
            }
            //Aplication.restart
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Corte_de_caja_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Dispose();
        }
            
    }
        

}

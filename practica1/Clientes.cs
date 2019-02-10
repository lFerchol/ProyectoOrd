using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class Clientes : Form
    {
        public int action=0;
        funciones_generales fg = new funciones_generales();

        public Clientes()
        {
            InitializeComponent();
            fg.configurar_conexion();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //action == 0 Alta
            //action == 1 Baja
            //action == 2 Modificación
            try {
                fg.cerrar_abrir_conexion();
                if (action == 0)
                {
                    if (verificarCamposVacios() && MessageBox.Show("¿Desea agregar el Cliente?", "Agregar", MessageBoxButtons.YesNo) == DialogResult.Yes)   
                    {
                        string cadena = "Insert into Cliente values ((select cast(case when(max(IdCliente)+1)is null then 1 else max(IdCliente)+1 END as int)"
                        + "from Cliente)"
                        + ",'" + txt_razon.Text + "','" + txt_correo.Text + "','" + txt_telefono.Text + "','" + txt_domicilio.Text + "','" + txt_proveedor.Text + "')";
                        //MessageBox.Show(cadena);
                        fg.cmd = new SqlCommand(cadena, fg.SG906);
                        fg.cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente ingresado exitosamente");
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Tiene campos vacíos");
                    }
                }
                if (action == 1)
                {
                    if (txt_razon.Text != "" && MessageBox.Show("¿Desea Eliminar el Cliente?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                        try
                        {
                            string consulta = "delete from Cliente where razon_social = '" + txt_razon.Text + "'";
                            //MessageBox.Show(consulta);
                            fg.cerrar_abrir_conexion();
                            fg.cmd = new SqlCommand(consulta, fg.SG906);
                            fg.cmd.ExecuteNonQuery();
                            MessageBox.Show("Cliente eliminado exitosamente", "Éxito");
                            limpiarCampos();
                        }
                        catch (Exception exe)
                        {
                            MessageBox.Show(exe.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese su razón social");
                    }
                }
                if (action == 2)
                {
                    if (txt_razon.Text != "" && MessageBox.Show("¿Desea Modificar el Cliente?", "Modificar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            /*
                    txt_razon.Text = fg.dr["razon_social"].ToString();
                    txt_correo.Text = fg.dr["correo_electronico"].ToString();
                    txt_telefono.Text = fg.dr["telefono"].ToString();
                    txt_domicilio.Text = fg.dr["domicilio"].ToString();
                    txt_proveedor.Text = fg.dr["proveedor"].ToString();

                             */
                            string consulta = "update cliente  set " +
                                "correo_electronico='" + txt_correo.Text + "'," +
                                "telefono='" + txt_telefono.Text + "'," +
                                "domicilio='" + txt_domicilio.Text + "'," +
                                "proveedor='" + txt_proveedor.Text + "' "  +
                                "where razon_social = '" + txt_razon.Text + "'";
                            //MessageBox.Show(consulta);
                            fg.cerrar_abrir_conexion();
                            fg.cmd = new SqlCommand(consulta, fg.SG906);
                            fg.cmd.ExecuteNonQuery();
                            MessageBox.Show("Cliente actualizado exitosamente", "Éxito");
                            limpiarCampos();
                            inhabilitar_cajas();
                        }
                        catch (Exception exe)
                        {
                            MessageBox.Show(exe.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese su razón social");
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        private void limpiarCampos()
        {
            txt_razon.Text = "";
            txt_correo.Text = "";
            txt_telefono.Text = "";
            txt_domicilio.Text = "";
            txt_proveedor.Text = "";
        }

        private bool verificarCamposVacios()
        {
            if (txt_razon.Text != "" && txt_correo.Text != "" && txt_telefono.Text != "" && txt_domicilio.Text != "" && txt_proveedor.Text != "")
                return true;
            else
                return false;
        }
        public void inhabilitar_cajas()
        {
            txt_correo.Enabled = false;
            txt_domicilio.Enabled = false;
            txt_proveedor.Enabled = false;
            txt_telefono.Enabled = false;
        }
        public void habilitar_cajas()
        {
            txt_correo.Enabled = true;
            txt_domicilio.Enabled = true;
            txt_proveedor.Enabled = true;
            txt_telefono.Enabled = true;
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_razon.Text != "")
            {
                string consulta = "select * from Cliente where razon_social='" + txt_razon.Text + "'";
                fg.cmd = new SqlCommand(consulta, fg.SG906);
                fg.cerrar_abrir_conexion();
                fg.dr = fg.cmd.ExecuteReader();
                if (fg.dr.Read())
                {
                    txt_razon.Text = fg.dr["razon_social"].ToString();
                    txt_correo.Text = fg.dr["correo_electronico"].ToString();
                    txt_telefono.Text = fg.dr["telefono"].ToString();
                    txt_domicilio.Text = fg.dr["domicilio"].ToString();
                    txt_proveedor.Text = fg.dr["proveedor"].ToString();
                }
                else
                {
                    if (action != 0) {
                        MessageBox.Show("El elemento no se encuentra en la BD", "Información");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("El elemento está vacío", "Información");
            }
            if (action == 2)
            {
                habilitar_cajas();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}

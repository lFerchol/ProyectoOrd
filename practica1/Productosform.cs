using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using System.Data.Sql;
using System.Data.SqlClient;
namespace practica1
{
    public partial class Productosform : Form
    {
        //Delimita la accion del btn_ (guardar, eliminar, modificar)
        public int bandera;
        funciones_generales fg = new funciones_generales();
        public Productosform()
        {
            InitializeComponent();
            fg.configurar_conexion();
            actualizacion_codigos();
            
        }
        public void actualizacion_codigos()
        {
            if (bandera != 1)
            {
                fg.cerrar_abrir_conexion();
                //Verificar error
                string consulta = "select * from producto";
                fg.cmd = new SqlCommand(consulta, fg.SG906);
                fg.dr = fg.cmd.ExecuteReader();
                combo_box_codigo.Items.Clear();
                while (fg.dr.Read())
                {
                    combo_box_codigo.Items.Add(fg.dr["codigo_producto"].ToString());
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar_cajas();
        }

        private void limpiar_cajas()
        {
            txt_costo_estandar.Clear();
            txt_descripcion.Clear();
            txt_descripcion_corta.Clear();
            txt_nombre.Clear();
            txt_nombre_alterno.Clear();
            txt_precio_sin_iva.Clear();
            txt_precio_venta.Clear();
            combo_box_codigo.Text = "";
            combo_box_cod_alterno.Text = "";
            combo_box_codigo.Focus();
            //combo_box_cod_alterno
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //bandera == 1 Almacena
            //bandera == 2 Elimina
            //bandera == 3 Modifica
            String consulta;
            if (bandera == 1)
            {
                if (combo_box_codigo.Text!="" && txt_nombre.Text!="" && txt_descripcion.Text!="" && txt_costo_estandar.Text!="" && txt_precio_venta.Text!="" && txt_precio_sin_iva.Text!="" && combo_box_cod_alterno.Text!="" && txt_nombre_alterno.Text!="" && txt_descripcion_corta.Text!="" )
                {
                    if (MessageBox.Show("¿Desea agregar el producto?", "Agregar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            if (verificar_si_producto_existe(combo_box_codigo.Text))
                            {
                                consulta = "insert into producto values ('" + combo_box_codigo.Text + "','" + txt_nombre.Text + "','" + txt_descripcion.Text + "'," + Convert.ToDecimal(txt_costo_estandar.Text) + "," + Convert.ToDecimal(txt_precio_venta.Text) + "," + Convert.ToDecimal(txt_precio_sin_iva.Text) + ",'" + combo_box_cod_alterno.Text + "','" + txt_nombre_alterno.Text + "','" + txt_descripcion_corta.Text + "')";
                                //MessageBox.Show(consulta);
                                fg.cerrar_abrir_conexion();
                                fg.cmd = new SqlCommand(consulta, fg.SG906);
                                fg.cmd.ExecuteNonQuery();
                                MessageBox.Show("Producto dado de alta exitosamente", "Éxito");
                                limpiar_cajas();
                            }
                            else
                            {
                                MessageBox.Show("Cambie el codigo de producto, el actual se encuentra en uso", "Advertencia");
                            }
                        }
                        catch (Exception exe)
                        {
                            MessageBox.Show(exe.ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingresar todos los camppos","falta información");
                }
            }
            else if (bandera == 2)
            {
                if (MessageBox.Show("¿Desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        consulta = "delete from producto where codigo_producto = '"+combo_box_codigo.Text+"'";
                        //MessageBox.Show(consulta);
                        fg.cerrar_abrir_conexion();
                        fg.cmd = new SqlCommand(consulta, fg.SG906);
                        fg.cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto eliminado exitosamente", "Éxito");
                        limpiar_cajas();
                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show(exe.ToString());
                    }
                }
            }
            else if (bandera == 3)
            {
                if (MessageBox.Show("¿Desea actualizar los datos el producto?", "Actualizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        /*
                         !="" 
                         !="" 
                         txt_precio_sin_iva.Text!="" 
                         combo_box_cod_alterno.Text!="" 
                         txt_nombre_alterno.Text!="" 
                         txt_descripcion_corta.Text!=""
                         */
                        consulta = "update producto  set " +
                            "nombre='"+txt_nombre.Text+"'," +
                            "descripcion='"+txt_descripcion.Text+"'," +
                            "costo_estandar=" + txt_costo_estandar.Text + "," +
                            "precio_venta=" + txt_precio_venta.Text + "," +
                            "precio_sin_iva=" + txt_precio_sin_iva.Text + "," +
                            "codigo_alterno='" + combo_box_cod_alterno.Text + "'," +
                            "nombre_alterno='" + txt_nombre_alterno.Text + "'," +
                            "descripcion_corta='" + txt_descripcion_corta.Text + "' " +
                            "where codigo_producto = '" + combo_box_codigo.Text + "'";
                        //MessageBox.Show(consulta);
                        fg.cerrar_abrir_conexion();
                        fg.cmd = new SqlCommand(consulta, fg.SG906);
                        fg.cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto actualizado exitosamente", "Éxito");
                        limpiar_cajas();
                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show(exe.ToString());
                    }
                }
            }
        }

        private bool verificar_si_producto_existe(string p)
        {
            fg.cerrar_abrir_conexion();
            //Verificar error
            string consulta = "select * from producto where codigo_producto = '"+p+"'";
            fg.cmd = new SqlCommand(consulta, fg.SG906);
            fg.dr = fg.cmd.ExecuteReader();
            if (fg.dr.Read())
            {
                return false;
            }
            return true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (combo_box_codigo.Text != "")
            {
                string consulta = "select * from producto where codigo_producto='"+combo_box_codigo.Text+"'";
                fg.cmd = new SqlCommand(consulta, fg.SG906);
                fg.cerrar_abrir_conexion();
                fg.dr = fg.cmd.ExecuteReader();
                if (fg.dr.Read())
                {
                    txt_nombre.Text = fg.dr["nombre"].ToString();
                    txt_descripcion.Text = fg.dr["descripcion"].ToString();
                    txt_costo_estandar.Text = Convert.ToString(Convert.ToDecimal(fg.dr["costo_estandar"].ToString()));
                    txt_precio_venta.Text = Convert.ToString(Convert.ToDecimal(fg.dr["precio_venta"].ToString()));
                    txt_precio_sin_iva.Text = Convert.ToString(Convert.ToDecimal(fg.dr["precio_sin_iva"].ToString()));
                    combo_box_cod_alterno.Text = fg.dr["codigo_alterno"].ToString();
                    txt_nombre_alterno.Text = fg.dr["nombre_alterno"].ToString();
                    txt_descripcion_corta.Text = fg.dr["descripcion_corta"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Selecciona el código de un producto en el menú desplegable","Información");
            }
        }
        public void inhabilitar_cajas()
        {
            txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;
            txt_costo_estandar.Enabled = false;
            txt_precio_venta.Enabled = false;
            combo_box_cod_alterno.Enabled = false;
            txt_nombre_alterno.Enabled = false;
            txt_descripcion_corta.Enabled = false;
            txt_precio_sin_iva.Enabled = false;
        }

        private void btn_informe_Click(object sender, EventArgs e)
        {
            ReporteProductos rp = new ReporteProductos();
            this.Hide();
            rp.Show();
        }
    }
}

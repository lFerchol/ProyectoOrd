using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.OleDb;
using System.Data.SqlTypes;

namespace practica1
{
    public partial class Ventas : Form
    {
        funciones_generales fg = new funciones_generales();
        funciones_generales fg2 = new funciones_generales();
        ReportDataSource rds = new ReportDataSource();
        //String sql;
        /*
         * 
         */
        decimal var_iva = 1 * (Convert.ToDecimal(.15));
        public Ventas()
        {
            InitializeComponent();
            fg.configurar_conexion();
            fg2.configurar_conexion();
            try
            {
                cmb_producto.Items.Clear();
                string consulta = "select * from producto";
                fg.cmd = new SqlCommand(consulta, fg.SG906);
                fg.cerrar_abrir_conexion();
                fg.dr = fg.cmd.ExecuteReader();
                while (fg.dr.Read())
                {
                    cmb_producto.Items.Add(fg.dr["codigo_producto"].ToString());
                }
            }catch(Exception mm){
                MessageBox.Show(mm.Message);       
            }
        }   

       /*
       Cargar el read
        * sqlcommand amd ) new sql commando ("select",cn)
        * sqldataadapter da = new sqldataadapter(cmd)
        * data set ds = new dataset();
        * da.fill.ds;
        * data griweview1. data source = ds.tables[0];
        * cn.close
        */

        private void Ventas_Load(object sender, EventArgs e)
        {
            generar_reporte();
            // TODO: esta línea de código carga datos en la tabla 'SG906DataSet1.ventas_detalle_temporal' Puede moverla o quitarla según sea necesario.
            //this.ventas_detalle_temporalTableAdapter.Fill(this.SG906DataSet1.ventas_detalle_temporal);

            //this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            dg_productos.Visible = true;
            dg_productos2.Visible = false;
            string producto = cmb_producto.Text, cantidad = txt_cantidad.Text;
            string c="", n = "", d, c_e = "", p_v, p_s_i, c_a, n_a, d_c,idd="";//,fol="";
            string consulta = "";
            if (checkCodAlter.Checked)
            {
                consulta = "select * from producto where codigo_alterno = '" + producto + "'";
            }
            else
            {
                consulta = "select * from producto where codigo_producto = '" + producto + "'";
            }
            try
            {
                fg.cmd = new SqlCommand(consulta, fg.SG906);
                fg.cerrar_abrir_conexion();
                fg.dr = fg.cmd.ExecuteReader();
                if (fg.dr.Read())
                {
                    c = fg.dr["codigo_producto"].ToString();
                    n = fg.dr["nombre"].ToString();
                    d = fg.dr["descripcion"].ToString();
                    c_e = fg.dr["costo_estandar"].ToString();
                    p_v = fg.dr["precio_venta"].ToString();
                    p_s_i = fg.dr["precio_sin_iva"].ToString();
                    c_a = fg.dr["codigo_alterno"].ToString();
                    n_a = fg.dr["nombre_alterno"].ToString();
                    d_c = fg.dr["descripcion_corta"].ToString();
                }
                else
                {
                    MessageBox.Show("No tiene este elemento el la BD");
                }
            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.Message);
            }
            consulta = "select max(id_detalle_temp) as idd from ventas_detalle_temporal";
            try
            {
                fg.cmd = new SqlCommand(consulta, fg.SG906);
                fg.cerrar_abrir_conexion();
                fg.dr = fg.cmd.ExecuteReader();
                if (fg.dr.Read())
                {
                    idd = fg.dr["idd"].ToString();

                    //fol = fg.dr["folio"].ToString();
                }
                else
                {
                    MessageBox.Show("No tiene este elemento el la BD");
                }
            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.Message);
            }
            //Almacenando en la BD
            try
            {


                consulta = "insert into ventas_detalle_temporal values ( "
                    +idd+" + 1"+
                    "   ,  "+idd+" + 1  ,"+
                    "'" + c + "'  ,   "+""
                    + cantidad + "   ,   "+"" 
                    + (Convert.ToDecimal(cantidad) * Convert.ToDecimal(c_e)) + "," 
                    + var_iva + "   ,   " 
                    + cantidad + "    ,   " 
                    + ((Convert.ToDecimal(cantidad) * Convert.ToDecimal(c_e))*var_iva - 0)+ "    ,    '" 
                    + label9.Text + "')";
                    //MessageBox.Show(consulta);
                    fg.cerrar_abrir_conexion();
                    fg.cmd = new SqlCommand(consulta, fg.SG906);
                    fg.cmd.ExecuteNonQuery();
                    //MessageBox.Show("Producto dado de alta exitosamente "+consulta, "Éxito");
                
            }
            catch (Exception exe)
            {
                txt_total_compra.Text = "" + consulta;
                MessageBox.Show(exe.ToString()+" Consulta "+consulta);
            }

            generar_reporte();
        }

        private void generar_reporte()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["PV906"].ConnectionString);
            fg.cerrar_abrir_conexion();
            SqlCommand cmd = new SqlCommand("select * from ventas_detalle_temporal", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dg_productos.DataSource = ds.Tables[0];
            cn.Close();

            dg_productos.Columns[0].Visible = false;
            dg_productos.Columns[1].Visible = false;
            dg_productos.Columns[2].HeaderCell.Value = "Código de Producto";
            dg_productos.Columns[3].HeaderCell.Value = "Cantidad";
            dg_productos.Columns[4].HeaderCell.Value = "Importe";
            dg_productos.Columns[4].DefaultCellStyle.Format = "N2";
            dg_productos.Columns[5].HeaderCell.Value = "IVA %";
            dg_productos.Columns[6].HeaderCell.Value = "Descuento";
            dg_productos.Columns[7].HeaderCell.Value = "Total";
            dg_productos.Columns[8].HeaderCell.Value = "N° Caja";

            /*
             Cliente
             * id_cliente primary
             * cliente_nombres
             * cliente_apellido_pat
             * cliente_apellido_mat
             * cliente_razon_social
             * cliente_RFC
             * cliente_telefono
             * 
             * Cliente detalle
             * id_detalle primary
             * cliente_id foranea
             * cliente_detalle_domicilio
             * cliente_detalle_credito
             * cliente_detalle_limite_de_credito
             * cliente_detalle_adeudo
             * cliente_detalle_referencias
             * 
             * modificar la tabla de productos
             * las columnas son
             * 
             * codigo_producto
             * producto_nombre
             * producto_descripcion
             * producto_costo_estandar
             * producto_precio_venta
             * producto_precio_SINIVA
             * producto_IVA_porcentaje
             * producto_descuento_porcentaje
             * producto_producto_alterno
             * producto_nombre_alterno
             * producto_descripicon corta
             * 
             * 
             * crear productos_detalle
             * 
             * id_detalle
             * productos_detalle_codigo_producto
             * producto_detalle_color
             * producto_detalle_acabado
             * producto_detalle_concepto
             * producto_detalle_clasificacion
             * producto_detalle_marca
             * producto_detalle_linea
             */
            //this.ventas_detalle_temporalTableAdapter.Fill(this.SG906DataSet1.ventas_detalle_temporal);
            //this.reportViewer1.RefreshReport();
        }
        public DataTable llenar_tabla(String consulta)
        {
            DataTable Tabla = new DataTable("Tmp");
            try
            {
                int i;
                fg.cerrar_abrir_conexion();
                SqlCommand CMD = new SqlCommand(consulta, fg.SG906);
                SqlDataReader REG = CMD.ExecuteReader();
                for (i = 0; i < REG.FieldCount; i++)
                {
                    Tabla.Columns.Add(REG.GetName(i), REG.GetFieldType(i));
                }

                while (REG.Read())
                {
                    DataRow ROWS = Tabla.NewRow();
                    for (i = 0; i < REG.FieldCount; i++)
                    {
                        ROWS.SetField(i, REG[i]);
                    }
                    Tabla.Rows.Add(ROWS);
                }
                REG.Close();
                fg.SG906.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Verifique la cadena de conexión", "Error en la cadena de conexión");
                MessageBox.Show(e.ToString());
            }
            return Tabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imprimir_ticket();
        }

        private void imprimir_ticket()
        {
            Ticket ticker = new Ticket();
            ticker.AbreCajon();

            ticker.TextoCentro("Universidad");
            ticker.TextoCentro("de la Sierra Sur");
            ticker.TextoCentro("NOTA DE VENTA");
            ticker.TextoCentro("3RA DE HUERTAS");
            ticker.TextoCentro("RFC: SAML960728HOHNRS01");
            ticker.TextoCentro("PERSONA FÍSICA CON ACTIVIDAD EMPRESARIAL");
            ticker.TextoCentro("");
            ticker.TextoCentro("EXPEDIDO EN:");
            ticker.TextoCentro("");
            ticker.TextoCentro("Tienda: C++");
            ticker.TextoCentro("DIREC: MIAHUATLÁN LOCAL #5");
            ticker.TextoCentro("COLONIA LA ARENA CP: 70800");
            ticker.TextoCentro("MIAHUATLAN, OAXACA");
            ticker.TextoCentro("TELEFONO: 9512746236");
            ticker.TextoCentro("");
            ticker.TextoCentro("CAJA #:" + label11.Text);

            ticker.TextoCentro("Atendió: Luis");
            ticker.TextoCentro("Cliente: Fer");
            ticker.TextoCentro("Método de pago: Efectivo");
            ticker.TextoCentro("");
            ticker.TextoCentro("FECHA: " + DateTime.Now.ToShortDateString());
            ticker.TextoCentro("Hora: " + DateTime.Now.ToShortTimeString());

            //Artículos a vender
            ticker.EncabezadoVenta();
            ticker.lineasAsteriscos();
            /*int suma_de_articulos=0;
            decimal precio = 0;
            decimal importe = 0;
            double descuento = 0;
            decimal acumuladoimporte = 0;
            */
            ticker.TextoCentro("Solo se aceptan devoluciones.");
            ticker.TextoCentro("por garantía.");

            ticker.CortaTicket();
            ticker.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
            ticker.AbreCajon();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar_producto();
            cmb_producto.DroppedDown = true;
        }

        private void buscar_producto()
        {
            dg_productos.Visible = false;
            dg_productos2.Visible = true;
            DataView dataview1 = null;
            string consulta = "" ;
            if (checkCodAlter.Checked == true)
            {
                
                MessageBox.Show("Buscando por código alterno");
                string cod = " * ";
                consulta = "select " + cod + "  from producto where codigo_alterno LIKE '%" + cmb_producto.Text + "%'";
                SqlCommand CMD = new SqlCommand(consulta, fg.SG906);
                SqlDataAdapter dt = new SqlDataAdapter(CMD);
                DataTable dtable = new DataTable();
                dt.Fill(dtable);

                dataview1 = dtable.DefaultView;
                dataview1.RowFilter = "codigo_alterno LIKE '%"+cmb_producto.Text+"%'";
                cmb_producto.Items.Clear();
                foreach (DataRowView dr in dataview1)
                {
                    cmb_producto.Items.Add(dr["codigo_alterno"].ToString());
                }
            }
            else
            {
                string cod = " * ";
                consulta = "select " + cod + "  from producto where codigo_producto LIKE '%" + cmb_producto.Text + "%'";
                try
                {
                    SqlCommand CMD = new SqlCommand(consulta, fg.SG906);
                    SqlDataAdapter dt = new SqlDataAdapter(CMD);
                    DataTable dtable = new DataTable();
                    dt.Fill(dtable);
                    dataview1 = dtable.DefaultView;
                    dataview1.RowFilter = "codigo_producto LIKE '%" + cmb_producto.Text + "%'";
                    cmb_producto.Items.Clear();
                    foreach (DataRowView dr in dataview1)
                    {
                        cmb_producto.Items.Add(dr["codigo_producto"].ToString());
                    }
                }
                catch (Exception we)
                {
                    MessageBox.Show(we.ToString());
                }
                
            }
            MessageBox.Show(consulta);

            dg_productos2.DataSource = null;
            dg_productos2.Refresh();
            dg_productos2.DataSource = dataview1;
            dg_productos2.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idd="";
            string consulta = "select max(folio) as idd from ventas_detalle";
            try
            {
                fg.cmd = new SqlCommand(consulta, fg.SG906);
                fg.cerrar_abrir_conexion();
                fg.dr = fg.cmd.ExecuteReader();
                if (fg.dr.Read())
                {
                    idd = fg.dr["idd"].ToString();

                    //fol = fg.dr["folio"].ToString();
                }
                else
                {
                    MessageBox.Show("No tiene este elemento el la BD");
                }
            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.Message);
            }

            consulta = "select * from ventas_detalle_temporal";
            string insertar="";
            try
            {
                if (idd == "")
                {
                    idd = "0";
                }
                fg.cmd = new SqlCommand(consulta, fg.SG906);
                fg.cerrar_abrir_conexion();
                fg.dr = fg.cmd.ExecuteReader();
                while (fg.dr.Read())
                {
                    insertar = "insert into ventas_detalle values (1+" + idd + ",'" + fg.dr["producto"].ToString() + "'," + fg.dr["cantidad"].ToString() + "," + fg.dr["importe"].ToString() + "," + fg.dr["iva"].ToString() + "," + fg.dr["descuento"].ToString() + "," + fg.dr["importe_total"].ToString() + ",'" + fg.dr["caja_nombre"].ToString()+"')";
                    MessageBox.Show(insertar);
                    
                    fg2.cmd = new SqlCommand(insertar, fg2.SG906);
                    fg2.cerrar_abrir_conexion();
                    fg2.cmd.ExecuteNonQuery();
                     
                }
                
                insertar = "delete from ventas_detalle_temporal";
                fg2.cmd = new SqlCommand(insertar, fg2.SG906);
                fg2.cerrar_abrir_conexion();
                fg2.cmd.ExecuteNonQuery();
                
                
                generar_reporte();
                MessageBox.Show("Venta exitosa");
            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.Message);
            }
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            string consulta;
            if (!checkCodAlter.Checked)
            {
                consulta = "delete from ventas_detalle_temporal where producto='" + cmb_producto.Text + "'";
            }
            else
            {
                consulta = "delete from ventas_detalle_temporal where producto in (select codigo_producto from producto where codigo_alterno='"+cmb_producto.Text+"')";
            }
            MessageBox.Show(consulta);
            fg2.cmd = new SqlCommand(consulta, fg2.SG906);
            fg2.cerrar_abrir_conexion();
            fg2.cmd.ExecuteNonQuery();
            generar_reporte();
            MessageBox.Show("Elemento eliminado correctamente");


        }

    }
}

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

using Microsoft.Reporting.WinForms;
namespace practica1
{
    public partial class ReporteProductos : Form
    {
        funciones_generales fg = new funciones_generales();
        ReportDataSource rds = new ReportDataSource();
        String sql;
        public ReporteProductos()
        {
            InitializeComponent();
            fg.configurar_conexion();
        }

        private void ReporteProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SG906DataSet.producto' Puede moverla o quitarla según sea necesario.
            //this.productoTableAdapter.Fill(this.SG906DataSet.producto);

            //this.reportViewer1.RefreshReport();

            cargando_reporte_completo();
        }

        private void cargando_reporte_completo()
        {
            rds.Name = "DataSet1";
            sql = "select * from producto";
            rds.Value = llenar_tabla(sql);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
            llenar_combo_box();
        }

        private void llenar_combo_box()
        {
            combo_box_codigo.Items.Clear();
            string consulta = "select distinct codigo_producto from producto";
            fg.cmd = new SqlCommand(consulta, fg.SG906);
            fg.cerrar_abrir_conexion();
            fg.dr = fg.cmd.ExecuteReader();
            while (fg.dr.Read())
            {
                combo_box_codigo.Items.Add(fg.dr["codigo_producto"].ToString());
            }

            combo_box_cod_alterno.Items.Clear();
            consulta = "select distinct codigo_alterno from producto";
            fg.cmd = new SqlCommand(consulta, fg.SG906);
            fg.cerrar_abrir_conexion();
            fg.dr = fg.cmd.ExecuteReader();
            while (fg.dr.Read())
            {
                combo_box_cod_alterno.Items.Add(fg.dr["codigo_alterno"].ToString());
            }
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

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            if (combo_box_codigo.Text != "" 
        ||            txt_nombre.Text != "" 
        ||    txt_costo_estandar.Text != "" 
        || combo_box_cod_alterno.Text != ""
        ||      txt_precio_venta.Text != ""
        ||    txt_precio_sin_iva.Text != "")
            {
                String sql1 = "", sql2 = "", sql3 = "", sql4 = "", sql5 = "", sql6 = "";

                if (combo_box_codigo.Text != "")
                {
                    sql1 = " codigo_producto = '"+combo_box_codigo.Text+"'";
                }
                if(txt_nombre.Text != "")
                {
                    if (sql1.Trim() == "")
                    {
                        sql2 = " nombre = '" + txt_nombre.Text + "'";
                    }
                    else
                    {
                        sql2 = " and nombre = '" + txt_nombre.Text + "'";
                    }
                }
                if (txt_costo_estandar.Text != "")
                {
                    if (sql1.Trim() == "" && sql2.Trim() == "")
                    {
                        sql3 = " costo_estandar = " + txt_costo_estandar.Text + "";
                    }
                    else
                    {
                        sql3 = " and costo_estandar = " + txt_costo_estandar.Text + "";
                    }
                }
                if (combo_box_cod_alterno.Text != "")
                {
                    if (sql1.Trim() == "" && sql2.Trim() == "" && sql3.Trim() == "")
                    {
                        sql4 = " codigo_alterno = '" + combo_box_cod_alterno.Text + "'";
                    }
                    else
                    {
                        sql4 = " and codigo_alterno = '" + combo_box_cod_alterno.Text + "'";
                    }
                }
                if (txt_precio_venta.Text != "")
                {
                    if (sql1.Trim() == "" && sql2.Trim() == "" && sql3.Trim() == "" && sql4.Trim() == "")
                    {
                        sql5 = " precio_venta = " + txt_precio_venta.Text + "";
                    }
                    else
                    {
                        sql5 = " and precio_venta = " + txt_precio_venta.Text + "" ;
                    }
                }
                if (txt_precio_sin_iva.Text != "")
                {
                    if (sql1.Trim() == "" && sql2.Trim() == "" && sql3.Trim() == "" && sql4.Trim() == "" && sql5.Trim() == "")
                    {
                        sql6 = " precio_sin_iva = " + txt_precio_sin_iva.Text + "";
                    }
                    else
                    {
                        sql6 = " and precio_sin_iva = " + txt_precio_sin_iva.Text + "";
                    }
                }


                // sql3 = " and usuario_rol in (select rol_id from roles where rol_nombre='" + cb_rol.Text + "')";
                  
                sql = "select * from producto where " + sql1 + sql2 + sql3 + sql4 + sql5 + sql6;
                MessageBox.Show(sql, "consulta");
                rds.Name = "DataSet1";

                rds.Value = llenar_tabla(sql);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            else
            {
                cargando_reporte_completo();
            }
        }
    }
}

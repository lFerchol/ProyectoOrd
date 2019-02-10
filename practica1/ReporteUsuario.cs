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
//como se crea un reporte de la tabla con estos campos// pasos
namespace practica1
{
    public partial class ReporteUsuario : Form
    {
        funciones_generales fg = new funciones_generales();
        ReportDataSource rds = new ReportDataSource();
        String sql;

        public ReporteUsuario()
        {
            InitializeComponent();
            fg.configurar_conexion();
        }

        private void ReportePrueba_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SG906DataSet.Usuario' Puede moverla o quitarla según sea necesario.
            //this.UsuarioTableAdapter.Fill(this.SG906DataSet.Usuario);
            //this.reportViewer1.RefreshReport();

            cargando_reporte_completo();
        }

        private void cargando_reporte_completo()
        {
            rds.Name = "DataSet1";
            sql = "select * from usuario";
            rds.Value = llenar_tabla(sql);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
            llenar_combo_box();
        }

        private void llenar_combo_box()
        {
            cb_rol.Items.Clear();
            string consulta = "select distinct rol_nombre from roles,usuario where  rol_id = usuario_rol";
            fg.cmd = new SqlCommand(consulta, fg.SG906);
            fg.cerrar_abrir_conexion();
            fg.dr = fg.cmd.ExecuteReader();
            while (fg.dr.Read())
            {
                cb_rol.Items.Add(fg.dr["rol_nombre"].ToString());
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
                    Tabla.Columns.Add(REG.GetName(i),REG.GetFieldType(i));
                }

                while(REG.Read())
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
            }catch(Exception e){
                MessageBox.Show("Verifique la cadena de conexión","Error en la cadena de conexión");
                MessageBox.Show(e.ToString());
            }
            return Tabla;
        }

        private void gb_controles_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_idUsuario.Text != "" || txt_nombreUsuario.Text != "" || cb_rol.Text != "")
            {
                String sql1 = "", sql2 = "", sql3 = "";

                //hacer los filtros combinados
                if (txt_idUsuario.Text != "")
                {
                    sql1 = " usuario_id='" + txt_idUsuario.Text + "'";
                }
                if (txt_nombreUsuario.Text != "")
                {
                    if (sql1.Trim() == "")
                    {
                        sql2 = " usuario_nombre='" + txt_nombreUsuario.Text + "'";
                    }
                    else
                    {
                        sql2 = " and usuario_nombre='" + txt_nombreUsuario.Text + "'";
                    }
                }

                if (cb_rol.Text != "")
                {
                    if (sql1.Trim() == "" && sql2.Trim() == "")
                    {
                        sql3 = " usuario_rol in (select rol_id from roles where rol_nombre='" + cb_rol.Text + "')";
                    }
                    else
                    {
                        sql3 = " and usuario_rol in (select rol_id from roles where rol_nombre='" + cb_rol.Text + "')";
                    }
                }

                sql = "select * from usuario where " + sql1 + sql2 + sql3;
                //MessageBox.Show(sql, "consulta");
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

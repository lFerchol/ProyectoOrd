using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace practica1
{
    public partial class prueba_excel : Form
    {
        SqlConnection SG906;
        public prueba_excel()
        {
            InitializeComponent();
        }

        private void prueba_excel_Load(object sender, EventArgs e)
        {

        }

        private void btn_importar_Click(object sender, EventArgs e)
        {
            new importar_excel().ImportarExcel(dataGridView1, "Hoja1");
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            exportar_excel exp = new exportar_excel();
            exp.ExportarDataGridViewExcel(dataGridView1);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PV906"].ConnectionString;
            SG906 = new SqlConnection(connectionString);
            SG906.Close();
            SG906.Open();

            DataTable data = (DataTable)(dataGridView1.DataSource);

            try
            {
                SqlCommand cmd = new SqlCommand("delete from productos",SG906);
                cmd.ExecuteNonQuery();
                SqlBulkCopy exportar = default(SqlBulkCopy);
                exportar = new SqlBulkCopy(SG906);
                exportar.DestinationTableName = "producto";
                exportar.WriteToServer(data);
                SG906.Close();
                MessageBox.Show("Almacenado exitosamente");
            }catch(Exception ee){
                MessageBox.Show(ee.ToString());
            }
        }
    }
}

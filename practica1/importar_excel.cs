using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace practica1
{
    class importar_excel
    {
        OleDbConnection conn;
        public OleDbDataAdapter MyDataAdapter;
        DataTable dt;

        public void ImportarExcel(  DataGridView dgv,string nombreHoja)
        {
            string ruta="";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files | *.xlsx";
                openfile1.Title = "Selecciona un arhivo de Excel";
                if (openfile1.FileName.Equals("") == false)
                {
                    ruta = openfile1.FileName;
                }
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source="+ruta+";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                MyDataAdapter = new OleDbDataAdapter("select * from ["+nombreHoja+"$]",conn);
                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Revisa el archivo que trataste de importar");
                MessageBox.Show(e.ToString());
            }
        }
    }
}

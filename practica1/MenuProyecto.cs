using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class MenuProyecto : Form
    {
        
        funciones_generales fg = new funciones_generales();
        public MenuProyecto()
        {
            InitializeComponent();

        }

        private void MenuProyecto_Load(object sender, EventArgs e)
        {

        }

        private void MenuProyecto_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MenuProyecto_FormClosing(object sender, FormClosingEventArgs e)
        {
            fg.salir_aplicacion_formulario(sender, e);
        }

        private void ventasPorClasificacióToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inicairCorteDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Corte_de_caja cj = new Corte_de_caja();
            cj.Show();
            cj.accion = 1;
        }

        private void terminarCorteDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Corte_de_caja cj = new Corte_de_caja();
            cj.Show();
            cj.comboBox1.Enabled = false;
            cj.consultaCajaAbierta();
            cj.btn_abrir_caja.Text = "Cerrar caja"; 
            cj.accion = 2;

        }
        

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productosform pf = new Productosform();

            pf.btn_buscar.Visible = false;
            pf.btn_buscar.Enabled = false;
            pf.btn_eliminar.Text = "Guardar";
            pf.bandera = 1;
            pf.Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productosform pf = new Productosform();
            pf.btn_eliminar.Text = "Eliminar";
            pf.bandera = 2;
            pf.inhabilitar_cajas();
            pf.actualizacion_codigos();
            pf.Show();
        }

        private void modificacioonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productosform pf = new Productosform();
            pf.btn_eliminar.Text = "Modificar";
            pf.bandera = 3;
            pf.actualizacion_codigos();
            pf.Show();
        }

        private void ventasPorFacturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas vvv = new Ventas();
            vvv.Show();
        }

        private void capturarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prueba_excel p_e = new prueba_excel();
            p_e.Show();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clientes cl = new Clientes();
            cl.action = 0;
            cl.btn_buscar.Visible = false;
            cl.btn_agregar.Text = "Agregar";
            cl.Show();
        }

        private void bajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clientes cl = new Clientes();
            cl.action = 1;
            cl.inhabilitar_cajas();
            cl.btn_buscar.Visible = true;
            cl.btn_agregar.Text = "Eliminar";
            cl.Show();
        }

        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes cl = new Clientes();
            cl.action = 2;
            cl.inhabilitar_cajas();
            cl.btn_buscar.Visible = true;
            cl.btn_agregar.Text = "Modificar";
            cl.Show();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Proveedores cl = new Proveedores();
            cl.action = 0;
            cl.btn_buscar.Visible = false;
            cl.btn_agregar.Text = "Agregar";
            cl.Show();
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Proveedores cl = new Proveedores();
            cl.action = 1;
            cl.inhabilitar_cajas();
            cl.btn_buscar.Visible = true;
            cl.btn_agregar.Text = "Eliminar";
            cl.Show();
        }

        private void modificaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedores cl = new Proveedores();
            cl.action = 2;
            cl.inhabilitar_cajas();
            cl.btn_buscar.Visible = true;
            cl.btn_agregar.Text = "Modificar";
            cl.Show();
        }
    }
}

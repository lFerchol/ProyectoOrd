namespace practica1
{
    partial class ReporteProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gp_productos = new System.Windows.Forms.GroupBox();
            this.combo_box_codigo = new System.Windows.Forms.ComboBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_costo_estandar = new System.Windows.Forms.TextBox();
            this.txt_precio_sin_iva = new System.Windows.Forms.TextBox();
            this.txt_precio_venta = new System.Windows.Forms.TextBox();
            this.combo_box_cod_alterno = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.SG906DataSet = new practica1.SG906DataSet();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new practica1.SG906DataSetTableAdapters.productoTableAdapter();
            this.gp_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SG906DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.productoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "practica1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(998, 489);
            this.reportViewer1.TabIndex = 0;
            // 
            // gp_productos
            // 
            this.gp_productos.Controls.Add(this.btn_filtrar);
            this.gp_productos.Controls.Add(this.txt_costo_estandar);
            this.gp_productos.Controls.Add(this.txt_precio_sin_iva);
            this.gp_productos.Controls.Add(this.txt_precio_venta);
            this.gp_productos.Controls.Add(this.combo_box_cod_alterno);
            this.gp_productos.Controls.Add(this.label7);
            this.gp_productos.Controls.Add(this.label6);
            this.gp_productos.Controls.Add(this.label5);
            this.gp_productos.Controls.Add(this.label4);
            this.gp_productos.Controls.Add(this.txt_nombre);
            this.gp_productos.Controls.Add(this.lbl_nombre);
            this.gp_productos.Controls.Add(this.combo_box_codigo);
            this.gp_productos.Controls.Add(this.lbl_codigo);
            this.gp_productos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gp_productos.Location = new System.Drawing.Point(0, 389);
            this.gp_productos.Name = "gp_productos";
            this.gp_productos.Size = new System.Drawing.Size(998, 100);
            this.gp_productos.TabIndex = 1;
            this.gp_productos.TabStop = false;
            this.gp_productos.Text = "Productos";
            // 
            // combo_box_codigo
            // 
            this.combo_box_codigo.FormattingEnabled = true;
            this.combo_box_codigo.Location = new System.Drawing.Point(121, 22);
            this.combo_box_codigo.Name = "combo_box_codigo";
            this.combo_box_codigo.Size = new System.Drawing.Size(207, 21);
            this.combo_box_codigo.TabIndex = 1;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(12, 25);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(103, 13);
            this.lbl_codigo.TabIndex = 2;
            this.lbl_codigo.Text = "Código de producto:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(121, 49);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(207, 20);
            this.txt_nombre.TabIndex = 4;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(68, 51);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_costo_estandar
            // 
            this.txt_costo_estandar.Location = new System.Drawing.Point(121, 75);
            this.txt_costo_estandar.Name = "txt_costo_estandar";
            this.txt_costo_estandar.Size = new System.Drawing.Size(207, 20);
            this.txt_costo_estandar.TabIndex = 9;
            // 
            // txt_precio_sin_iva
            // 
            this.txt_precio_sin_iva.Location = new System.Drawing.Point(440, 75);
            this.txt_precio_sin_iva.Name = "txt_precio_sin_iva";
            this.txt_precio_sin_iva.Size = new System.Drawing.Size(207, 20);
            this.txt_precio_sin_iva.TabIndex = 13;
            // 
            // txt_precio_venta
            // 
            this.txt_precio_venta.Location = new System.Drawing.Point(440, 49);
            this.txt_precio_venta.Name = "txt_precio_venta";
            this.txt_precio_venta.Size = new System.Drawing.Size(207, 20);
            this.txt_precio_venta.TabIndex = 11;
            // 
            // combo_box_cod_alterno
            // 
            this.combo_box_cod_alterno.FormattingEnabled = true;
            this.combo_box_cod_alterno.Location = new System.Drawing.Point(440, 22);
            this.combo_box_cod_alterno.Name = "combo_box_cod_alterno";
            this.combo_box_cod_alterno.Size = new System.Drawing.Size(207, 21);
            this.combo_box_cod_alterno.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CODIGO ALTERNO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio sin IVA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Percio de venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Costo estandar:";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(679, 25);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 16;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // SG906DataSet
            // 
            this.SG906DataSet.DataSetName = "SG906DataSet";
            this.SG906DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.SG906DataSet;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 489);
            this.Controls.Add(this.gp_productos);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteProductos";
            this.Text = "ReporteProductos";
            this.Load += new System.EventHandler(this.ReporteProductos_Load);
            this.gp_productos.ResumeLayout(false);
            this.gp_productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SG906DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox gp_productos;
        private System.Windows.Forms.ComboBox combo_box_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_costo_estandar;
        private System.Windows.Forms.TextBox txt_precio_sin_iva;
        private System.Windows.Forms.TextBox txt_precio_venta;
        private System.Windows.Forms.ComboBox combo_box_cod_alterno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private SG906DataSet SG906DataSet;
        private SG906DataSetTableAdapters.productoTableAdapter productoTableAdapter;
    }
}
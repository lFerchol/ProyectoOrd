namespace practica1
{
    partial class Ventas
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
            this.ventas_detalle_temporalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SG906DataSet1 = new practica1.SG906DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_producto = new System.Windows.Forms.ComboBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.dg_productos = new System.Windows.Forms.DataGridView();
            this.iddetalletempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importetotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajanombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.txt_descuento_total = new System.Windows.Forms.TextBox();
            this.txt_total_compra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chb_promo3 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chb_promo2 = new System.Windows.Forms.CheckBox();
            this.chb_promo1 = new System.Windows.Forms.CheckBox();
            this.ventas_detalle_temporalTableAdapter = new practica1.SG906DataSet1TableAdapters.ventas_detalle_temporalTableAdapter();
            this.sG906DataSet2 = new practica1.SG906DataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.checkCodAlter = new System.Windows.Forms.CheckBox();
            this.dg_productos2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ventas_detalle_temporalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SG906DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_productos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sG906DataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_productos2)).BeginInit();
            this.SuspendLayout();
            // 
            // ventas_detalle_temporalBindingSource
            // 
            this.ventas_detalle_temporalBindingSource.DataMember = "ventas_detalle_temporal";
            this.ventas_detalle_temporalBindingSource.DataSource = this.SG906DataSet1;
            // 
            // SG906DataSet1
            // 
            this.SG906DataSet1.DataSetName = "SG906DataSet1";
            this.SG906DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto";
            // 
            // cmb_producto
            // 
            this.cmb_producto.FormattingEnabled = true;
            this.cmb_producto.Location = new System.Drawing.Point(67, 166);
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.Size = new System.Drawing.Size(325, 21);
            this.cmb_producto.TabIndex = 2;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(453, 168);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 3;
            this.txt_cantidad.Text = "1";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(649, 165);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Location = new System.Drawing.Point(730, 165);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(75, 23);
            this.btn_quitar.TabIndex = 5;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // dg_productos
            // 
            this.dg_productos.AutoGenerateColumns = false;
            this.dg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddetalletempDataGridViewTextBoxColumn,
            this.folioDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.ivaDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn,
            this.importetotalDataGridViewTextBoxColumn,
            this.cajanombreDataGridViewTextBoxColumn});
            this.dg_productos.DataSource = this.ventas_detalle_temporalBindingSource;
            this.dg_productos.Location = new System.Drawing.Point(15, 193);
            this.dg_productos.Name = "dg_productos";
            this.dg_productos.Size = new System.Drawing.Size(790, 228);
            this.dg_productos.TabIndex = 6;
            // 
            // iddetalletempDataGridViewTextBoxColumn
            // 
            this.iddetalletempDataGridViewTextBoxColumn.DataPropertyName = "id_detalle_temp";
            this.iddetalletempDataGridViewTextBoxColumn.HeaderText = "id_detalle_temp";
            this.iddetalletempDataGridViewTextBoxColumn.Name = "iddetalletempDataGridViewTextBoxColumn";
            // 
            // folioDataGridViewTextBoxColumn
            // 
            this.folioDataGridViewTextBoxColumn.DataPropertyName = "folio";
            this.folioDataGridViewTextBoxColumn.HeaderText = "folio";
            this.folioDataGridViewTextBoxColumn.Name = "folioDataGridViewTextBoxColumn";
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            // 
            // ivaDataGridViewTextBoxColumn
            // 
            this.ivaDataGridViewTextBoxColumn.DataPropertyName = "iva";
            this.ivaDataGridViewTextBoxColumn.HeaderText = "iva";
            this.ivaDataGridViewTextBoxColumn.Name = "ivaDataGridViewTextBoxColumn";
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "descuento";
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            // 
            // importetotalDataGridViewTextBoxColumn
            // 
            this.importetotalDataGridViewTextBoxColumn.DataPropertyName = "importe_total";
            this.importetotalDataGridViewTextBoxColumn.HeaderText = "importe_total";
            this.importetotalDataGridViewTextBoxColumn.Name = "importetotalDataGridViewTextBoxColumn";
            // 
            // cajanombreDataGridViewTextBoxColumn
            // 
            this.cajanombreDataGridViewTextBoxColumn.DataPropertyName = "caja_nombre";
            this.cajanombreDataGridViewTextBoxColumn.HeaderText = "caja_nombre";
            this.cajanombreDataGridViewTextBoxColumn.Name = "cajanombreDataGridViewTextBoxColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Folio #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(101, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Subtotal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(637, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descuento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(634, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total:";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(705, 8);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(100, 20);
            this.txt_subtotal.TabIndex = 12;
            // 
            // txt_descuento_total
            // 
            this.txt_descuento_total.Location = new System.Drawing.Point(705, 34);
            this.txt_descuento_total.Name = "txt_descuento_total";
            this.txt_descuento_total.Size = new System.Drawing.Size(100, 20);
            this.txt_descuento_total.TabIndex = 13;
            // 
            // txt_total_compra
            // 
            this.txt_total_compra.Location = new System.Drawing.Point(705, 92);
            this.txt_total_compra.Name = "txt_total_compra";
            this.txt_total_compra.Size = new System.Drawing.Size(100, 20);
            this.txt_total_compra.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cliente:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(271, 8);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(357, 21);
            this.cmb_cliente.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chb_promo3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.chb_promo2);
            this.groupBox1.Controls.Add(this.chb_promo1);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 77);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promociones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(77, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "0";
            // 
            // chb_promo3
            // 
            this.chb_promo3.AutoSize = true;
            this.chb_promo3.Location = new System.Drawing.Point(482, 45);
            this.chb_promo3.Name = "chb_promo3";
            this.chb_promo3.Size = new System.Drawing.Size(62, 17);
            this.chb_promo3.TabIndex = 2;
            this.chb_promo3.Text = "Promo3";
            this.chb_promo3.UseVisualStyleBackColor = true;
            this.chb_promo3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Caja #";
            // 
            // chb_promo2
            // 
            this.chb_promo2.AutoSize = true;
            this.chb_promo2.Location = new System.Drawing.Point(303, 45);
            this.chb_promo2.Name = "chb_promo2";
            this.chb_promo2.Size = new System.Drawing.Size(62, 17);
            this.chb_promo2.TabIndex = 1;
            this.chb_promo2.Text = "Promo2";
            this.chb_promo2.UseVisualStyleBackColor = true;
            // 
            // chb_promo1
            // 
            this.chb_promo1.AutoSize = true;
            this.chb_promo1.Location = new System.Drawing.Point(139, 45);
            this.chb_promo1.Name = "chb_promo1";
            this.chb_promo1.Size = new System.Drawing.Size(62, 17);
            this.chb_promo1.TabIndex = 0;
            this.chb_promo1.Text = "Promo1";
            this.chb_promo1.UseVisualStyleBackColor = true;
            // 
            // ventas_detalle_temporalTableAdapter
            // 
            this.ventas_detalle_temporalTableAdapter.ClearBeforeFill = true;
            // 
            // sG906DataSet2
            // 
            this.sG906DataSet2.DataSetName = "SG906DataSet";
            this.sG906DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(705, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(661, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "IVA %:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Crear ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(151, 427);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 43);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formas de pago";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(234, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(38, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "T. ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(120, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "T. credito";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Efectivo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(568, 166);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 22;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // checkCodAlter
            // 
            this.checkCodAlter.AutoSize = true;
            this.checkCodAlter.Location = new System.Drawing.Point(67, 143);
            this.checkCodAlter.Name = "checkCodAlter";
            this.checkCodAlter.Size = new System.Drawing.Size(159, 17);
            this.checkCodAlter.TabIndex = 20;
            this.checkCodAlter.Text = "¿Buscar por código alterno?";
            this.checkCodAlter.UseVisualStyleBackColor = true;
            // 
            // dg_productos2
            // 
            this.dg_productos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_productos2.Location = new System.Drawing.Point(15, 193);
            this.dg_productos2.Name = "dg_productos2";
            this.dg_productos2.Size = new System.Drawing.Size(790, 228);
            this.dg_productos2.TabIndex = 23;
            this.dg_productos2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 32);
            this.button2.TabIndex = 24;
            this.button2.Text = "Realizar Venta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dg_productos2);
            this.Controls.Add(this.checkCodAlter);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_total_compra);
            this.Controls.Add(this.txt_descuento_total);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg_productos);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.cmb_producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventas_detalle_temporalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SG906DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_productos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sG906DataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_productos2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.DataGridView dg_productos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.TextBox txt_descuento_total;
        private System.Windows.Forms.TextBox txt_total_compra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chb_promo3;
        private System.Windows.Forms.CheckBox chb_promo2;
        private System.Windows.Forms.CheckBox chb_promo1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource ventas_detalle_temporalBindingSource;
        private SG906DataSet1 SG906DataSet1;
        private SG906DataSet1TableAdapters.ventas_detalle_temporalTableAdapter ventas_detalle_temporalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetalletempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importetotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajanombreDataGridViewTextBoxColumn;
        private SG906DataSet sG906DataSet2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.CheckBox checkCodAlter;
        private System.Windows.Forms.DataGridView dg_productos2;
        private System.Windows.Forms.Button button2;
    }
}
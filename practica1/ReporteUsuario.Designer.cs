namespace practica1
{
    partial class ReporteUsuario
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SG906DataSet = new practica1.SG906DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UsuarioTableAdapter = new practica1.SG906DataSetTableAdapters.UsuarioTableAdapter();
            this.gb_controles = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idUsuario = new System.Windows.Forms.TextBox();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_rol = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SG906DataSet)).BeginInit();
            this.gb_controles.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsuarioBindingSource
            // 
            this.UsuarioBindingSource.DataMember = "Usuario";
            this.UsuarioBindingSource.DataSource = this.SG906DataSet;
            // 
            // SG906DataSet
            // 
            this.SG906DataSet.DataSetName = "SG906DataSet";
            this.SG906DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.UsuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "practica1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(904, 483);
            this.reportViewer1.TabIndex = 0;
            // 
            // UsuarioTableAdapter
            // 
            this.UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // gb_controles
            // 
            this.gb_controles.Controls.Add(this.button1);
            this.gb_controles.Controls.Add(this.cb_rol);
            this.gb_controles.Controls.Add(this.label3);
            this.gb_controles.Controls.Add(this.txt_nombreUsuario);
            this.gb_controles.Controls.Add(this.label2);
            this.gb_controles.Controls.Add(this.txt_idUsuario);
            this.gb_controles.Controls.Add(this.label1);
            this.gb_controles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_controles.Location = new System.Drawing.Point(0, 383);
            this.gb_controles.Name = "gb_controles";
            this.gb_controles.Size = new System.Drawing.Size(904, 100);
            this.gb_controles.TabIndex = 1;
            this.gb_controles.TabStop = false;
            this.gb_controles.Text = "Controles";
            this.gb_controles.Enter += new System.EventHandler(this.gb_controles_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "idUsuario";
            // 
            // txt_idUsuario
            // 
            this.txt_idUsuario.Location = new System.Drawing.Point(81, 47);
            this.txt_idUsuario.Name = "txt_idUsuario";
            this.txt_idUsuario.Size = new System.Drawing.Size(163, 20);
            this.txt_idUsuario.TabIndex = 1;
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(370, 46);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(186, 20);
            this.txt_nombreUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rol:";
            // 
            // cb_rol
            // 
            this.cb_rol.FormattingEnabled = true;
            this.cb_rol.Location = new System.Drawing.Point(632, 44);
            this.cb_rol.Name = "cb_rol";
            this.cb_rol.Size = new System.Drawing.Size(169, 21);
            this.cb_rol.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportePrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 483);
            this.Controls.Add(this.gb_controles);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePrueba";
            this.Text = "ReportePrueba";
            this.Load += new System.EventHandler(this.ReportePrueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SG906DataSet)).EndInit();
            this.gb_controles.ResumeLayout(false);
            this.gb_controles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UsuarioBindingSource;
        private SG906DataSet SG906DataSet;
        private SG906DataSetTableAdapters.UsuarioTableAdapter UsuarioTableAdapter;
        private System.Windows.Forms.GroupBox gb_controles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_rol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idUsuario;
        private System.Windows.Forms.Label label1;
    }
}
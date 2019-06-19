namespace AgenciaCars.formularios
{
    partial class listados
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.datosListasEstadisticasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosListasEstadisticas = new AgenciaCars.datos.datosListasEstadisticas();
            this.datosListasEstadisticas2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosListasEstadisticas2 = new AgenciaCars.datos.datosListasEstadisticas();
            this.EstadisticasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtPatron = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_buscar_prod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpatroproduc = new System.Windows.Forms.TextBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.agenciaCarsDataSet = new AgenciaCars.AgenciaCarsDataSet();
            this.agenciaCarsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListadoClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosListasEstadisticas1 = new AgenciaCars.datos.datosListasEstadisticas();
            this.datosListasEstadisticas1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ListadoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticasBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datosListasEstadisticasBindingSource
            // 
            this.datosListasEstadisticasBindingSource.DataSource = this.datosListasEstadisticas;
            this.datosListasEstadisticasBindingSource.Position = 0;
            // 
            // datosListasEstadisticas
            // 
            this.datosListasEstadisticas.DataSetName = "datosListasEstadisticas";
            this.datosListasEstadisticas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosListasEstadisticas2BindingSource
            // 
            this.datosListasEstadisticas2BindingSource.DataSource = this.datosListasEstadisticas2;
            this.datosListasEstadisticas2BindingSource.Position = 0;
            // 
            // datosListasEstadisticas2
            // 
            this.datosListasEstadisticas2.DataSetName = "datosListasEstadisticas";
            this.datosListasEstadisticas2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EstadisticasBindingSource
            // 
            this.EstadisticasBindingSource.DataMember = "Estadisticas";
            this.EstadisticasBindingSource.DataSource = this.datosListasEstadisticas;
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = "";
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.txtPatron);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.datosListasEstadisticasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AgenciaCars.reporte.listadoClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-4, 66);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(789, 408);
            this.reportViewer1.TabIndex = 3;
            // 
            // txtPatron
            // 
            this.txtPatron.Location = new System.Drawing.Point(98, 23);
            this.txtPatron.Name = "txtPatron";
            this.txtPatron.Size = new System.Drawing.Size(100, 20);
            this.txtPatron.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargar Patron";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(204, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 22);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_buscar_prod);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtpatroproduc);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_buscar_prod
            // 
            this.btn_buscar_prod.Location = new System.Drawing.Point(217, 19);
            this.btn_buscar_prod.Name = "btn_buscar_prod";
            this.btn_buscar_prod.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_prod.TabIndex = 3;
            this.btn_buscar_prod.Text = "Buscar";
            this.btn_buscar_prod.UseVisualStyleBackColor = true;
            this.btn_buscar_prod.Click += new System.EventHandler(this.btn_buscar_prod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cargar filtro";
            // 
            // txtpatroproduc
            // 
            this.txtpatroproduc.Location = new System.Drawing.Point(91, 22);
            this.txtpatroproduc.Name = "txtpatroproduc";
            this.txtpatroproduc.Size = new System.Drawing.Size(100, 20);
            this.txtpatroproduc.TabIndex = 1;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "Productosdataset";
            reportDataSource2.Value = this.datosListasEstadisticas2BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "AgenciaCars.reporte.ListadoProductos.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(-4, 59);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(789, 419);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(781, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Proveedores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(781, 474);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vendedores";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(781, 474);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Facturas";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(781, 474);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Productos Vendidos";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // agenciaCarsDataSet
            // 
            this.agenciaCarsDataSet.DataSetName = "AgenciaCarsDataSet";
            this.agenciaCarsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agenciaCarsDataSetBindingSource
            // 
            this.agenciaCarsDataSetBindingSource.DataSource = this.agenciaCarsDataSet;
            this.agenciaCarsDataSetBindingSource.Position = 0;
            // 
            // ListadoClientesBindingSource
            // 
            this.ListadoClientesBindingSource.DataMember = "ListadoClientes";
            this.ListadoClientesBindingSource.DataSource = this.datosListasEstadisticas;
            // 
            // datosListasEstadisticas1
            // 
            this.datosListasEstadisticas1.DataSetName = "datosListasEstadisticas";
            this.datosListasEstadisticas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosListasEstadisticas1BindingSource
            // 
            this.datosListasEstadisticas1BindingSource.DataSource = this.datosListasEstadisticas1;
            this.datosListasEstadisticas1BindingSource.Position = 0;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.datosListasEstadisticas;
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "Productos";
            this.productosBindingSource1.DataSource = this.datosListasEstadisticas;
            // 
            // productosBindingSource2
            // 
            this.productosBindingSource2.DataMember = "Productos";
            this.productosBindingSource2.DataSource = this.datosListasEstadisticas1BindingSource;
            // 
            // ListadoProductoBindingSource
            // 
            this.ListadoProductoBindingSource.DataMember = "ListadoProducto";
            this.ListadoProductoBindingSource.DataSource = this.datosListasEstadisticas;
            // 
            // listados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "listados";
            this.Text = "Listados";
            this.Load += new System.EventHandler(this.listados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticasBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtPatron;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource ListadoClientesBindingSource;
        private datos.datosListasEstadisticas datosListasEstadisticas;
        private AgenciaCarsDataSet agenciaCarsDataSet;
        private System.Windows.Forms.BindingSource agenciaCarsDataSetBindingSource;
        private System.Windows.Forms.BindingSource datosListasEstadisticasBindingSource;
        private System.Windows.Forms.BindingSource datosListasEstadisticas1BindingSource;
        private datos.datosListasEstadisticas datosListasEstadisticas1;
        private System.Windows.Forms.BindingSource EstadisticasBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_buscar_prod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpatroproduc;
        private System.Windows.Forms.BindingSource datosListasEstadisticas2BindingSource;
        private datos.datosListasEstadisticas datosListasEstadisticas2;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private System.Windows.Forms.BindingSource productosBindingSource2;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private System.Windows.Forms.BindingSource ListadoProductoBindingSource;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
    }
}
namespace AgenciaCars.formularios
{
    partial class Indicadores
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indicadores));
            this.EstadisticasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosListasEstadisticas = new AgenciaCars.datos.datosListasEstadisticas();
            this.datosListasEstadisticasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.agenciaCarsDataSet = new AgenciaCars.AgenciaCarsDataSet();
            this.agenciaCarsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListadoClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosListasEstadisticas1 = new AgenciaCars.datos.datosListasEstadisticas();
            this.datosListasEstadisticas1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticasBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EstadisticasBindingSource
            // 
            this.EstadisticasBindingSource.DataMember = "Estadisticas";
            this.EstadisticasBindingSource.DataSource = this.datosListasEstadisticas;
            // 
            // datosListasEstadisticas
            // 
            this.datosListasEstadisticas.DataSetName = "datosListasEstadisticas";
            this.datosListasEstadisticas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosListasEstadisticasBindingSource
            // 
            this.datosListasEstadisticasBindingSource.DataSource = this.datosListasEstadisticas;
            this.datosListasEstadisticasBindingSource.Position = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 567);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(805, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes por Localidades";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EstadisticasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AgenciaCars.reporte.estadisticasClientesProvincias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-4, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(813, 545);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportUno_Load);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(805, 541);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Ventas por Vendedor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.EstadisticasBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "AgenciaCars.reporte.estadisticasVentasVendedor.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(-4, -2);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(813, 545);
            this.reportViewer2.TabIndex = 1;
            this.reportViewer2.Load += new System.EventHandler(this.reportDos_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(805, 541);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Ventas por Cliente";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.EstadisticasBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "AgenciaCars.reporte.estadisticasVentasCliente.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(-4, -2);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(813, 545);
            this.reportViewer3.TabIndex = 2;
            this.reportViewer3.Load += new System.EventHandler(this.reportViewer3_Load);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(805, 541);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Autos por Marca";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.EstadisticasBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "AgenciaCars.reporte.estadisticasProductosMarca.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(-4, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(813, 543);
            this.reportViewer4.TabIndex = 3;
            this.reportViewer4.Load += new System.EventHandler(this.reportViewer4_Load);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(805, 541);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Compras por Mes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            this.reportViewer5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.EstadisticasBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "AgenciaCars.reporte.estadisticasComprasMes.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(-4, -1);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.Size = new System.Drawing.Size(813, 543);
            this.reportViewer5.TabIndex = 4;
            this.reportViewer5.Load += new System.EventHandler(this.reportViewer5_Load);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.reportViewer6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(805, 541);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Ventas por Mes";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // reportViewer6
            // 
            this.reportViewer6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.EstadisticasBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "AgenciaCars.reporte.estadisticasVentasMes.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(-4, -1);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.Size = new System.Drawing.Size(813, 543);
            this.reportViewer6.TabIndex = 5;
            this.reportViewer6.Load += new System.EventHandler(this.reportViewer6_Load);
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
            // Indicadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 568);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Indicadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indicadores";
            this.Load += new System.EventHandler(this.listados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticasBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource ListadoClientesBindingSource;
        private datos.datosListasEstadisticas datosListasEstadisticas;
        private AgenciaCarsDataSet agenciaCarsDataSet;
        private System.Windows.Forms.BindingSource agenciaCarsDataSetBindingSource;
        private System.Windows.Forms.BindingSource datosListasEstadisticasBindingSource;
        private System.Windows.Forms.BindingSource datosListasEstadisticas1BindingSource;
        private datos.datosListasEstadisticas datosListasEstadisticas1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EstadisticasBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
    }
}
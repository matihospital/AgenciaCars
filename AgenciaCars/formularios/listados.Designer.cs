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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtPatron = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.agenciaCarsDataSet = new AgenciaCars.AgenciaCarsDataSet();
            this.agenciaCarsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosListasEstadisticasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosListasEstadisticas = new AgenciaCars.datos.datosListasEstadisticas();
            this.ListadoClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosListasEstadisticas1 = new AgenciaCars.datos.datosListasEstadisticas();
            this.datosListasEstadisticas1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EstadisticasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 498);
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
            this.tabPage1.Size = new System.Drawing.Size(778, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.datosListasEstadisticasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AgenciaCars.reportes.listadoClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-4, 66);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(786, 406);
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
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes por Localidades";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.EstadisticasBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "AgenciaCars.reportes.estadisticasClientesProvincias.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(-4, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(786, 476);
            this.reportViewer2.TabIndex = 0;
            // 
            // EstadisticasBindingSource
            // 
            this.EstadisticasBindingSource.DataMember = "Estadisticas";
            this.EstadisticasBindingSource.DataSource = this.datosListasEstadisticas;
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosListasEstadisticas1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtPatron;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource ListadoClientesBindingSource;
        private datos.datosListasEstadisticas datosListasEstadisticas;
        private AgenciaCarsDataSet agenciaCarsDataSet;
        private System.Windows.Forms.BindingSource agenciaCarsDataSetBindingSource;
        private System.Windows.Forms.BindingSource datosListasEstadisticasBindingSource;
        private System.Windows.Forms.BindingSource datosListasEstadisticas1BindingSource;
        private datos.datosListasEstadisticas datosListasEstadisticas1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource EstadisticasBindingSource;
    }
}
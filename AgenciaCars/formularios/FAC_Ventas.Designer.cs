namespace AgenciaCars.formularios
{
    partial class FAC_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAC_Ventas));
            this.label1 = new System.Windows.Forms.Label();
            this.lOCALIDADESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agenciaCarsDataSet = new AgenciaCars.AgenciaCarsDataSet();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lOCALIDADESTableAdapter = new AgenciaCars.AgenciaCarsDataSetTableAdapters.LOCALIDADESTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACTURASDETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURASDETTableAdapter = new AgenciaCars.AgenciaCarsDataSetTableAdapters.FACTURASDETTableAdapter();
            this.label01 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.fecha = new System.Windows.Forms.MaskedTextBox();
            this.tipoComprobante = new System.Windows.Forms.TextBox();
            this.textBox018 = new AgenciaCars.clases.TextBox01();
            this.textBox013 = new AgenciaCars.clases.TextBox01();
            this.cliente = new AgenciaCars.clases.TextBox01();
            this.IdFactura = new AgenciaCars.clases.TextBox01();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lOCALIDADESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURASDETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Factura de Venta";
            // 
            // lOCALIDADESBindingSource
            // 
            this.lOCALIDADESBindingSource.DataMember = "LOCALIDADES";
            this.lOCALIDADESBindingSource.DataSource = this.agenciaCarsDataSet;
            // 
            // agenciaCarsDataSet
            // 
            this.agenciaCarsDataSet.DataSetName = "AgenciaCarsDataSet";
            this.agenciaCarsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_nuevo.FlatAppearance.BorderSize = 2;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_nuevo.Location = new System.Drawing.Point(12, 520);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(100, 29);
            this.btn_nuevo.TabIndex = 19;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_salir.FlatAppearance.BorderSize = 2;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_salir.Location = new System.Drawing.Point(224, 520);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(100, 29);
            this.btn_salir.TabIndex = 20;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lOCALIDADESTableAdapter
            // 
            this.lOCALIDADESTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(118, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Anular";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordenDataGridViewTextBoxColumn,
            this.idFacturaDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.dataGridView1.DataSource = this.fACTURASDETBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 262);
            this.dataGridView1.TabIndex = 23;
            // 
            // ordenDataGridViewTextBoxColumn
            // 
            this.ordenDataGridViewTextBoxColumn.DataPropertyName = "orden";
            this.ordenDataGridViewTextBoxColumn.HeaderText = "Orden";
            this.ordenDataGridViewTextBoxColumn.Name = "ordenDataGridViewTextBoxColumn";
            // 
            // idFacturaDataGridViewTextBoxColumn
            // 
            this.idFacturaDataGridViewTextBoxColumn.DataPropertyName = "idFactura";
            this.idFacturaDataGridViewTextBoxColumn.HeaderText = "idFactura";
            this.idFacturaDataGridViewTextBoxColumn.Name = "idFacturaDataGridViewTextBoxColumn";
            this.idFacturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "Cod. Prod.";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "precioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "Pcio.Unit.";
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descripcion";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Total";
            this.Column2.Name = "Column2";
            // 
            // fACTURASDETBindingSource
            // 
            this.fACTURASDETBindingSource.DataMember = "FACTURASDET";
            this.fACTURASDETBindingSource.DataSource = this.agenciaCarsDataSet;
            // 
            // fACTURASDETTableAdapter
            // 
            this.fACTURASDETTableAdapter.ClearBeforeFill = true;
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.ForeColor = System.Drawing.SystemColors.Control;
            this.label01.Location = new System.Drawing.Point(31, 69);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(16, 13);
            this.label01.TabIndex = 24;
            this.label01.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(303, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "P.V.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(387, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(88, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Comprobante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(512, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(599, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(31, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(219, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Vendedor";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextBox1.Location = new System.Drawing.Point(303, 88);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(81, 26);
            this.maskedTextBox1.TabIndex = 25;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextBox2.Location = new System.Drawing.Point(390, 88);
            this.maskedTextBox2.Mask = "00000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(119, 26);
            this.maskedTextBox2.TabIndex = 25;
            // 
            // fecha
            // 
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fecha.Location = new System.Drawing.Point(515, 88);
            this.fecha.Mask = "00/00/0000";
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(100, 26);
            this.fecha.TabIndex = 25;
            this.fecha.ValidatingType = typeof(System.DateTime);
            // 
            // tipoComprobante
            // 
            this.tipoComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tipoComprobante.Location = new System.Drawing.Point(91, 88);
            this.tipoComprobante.Name = "tipoComprobante";
            this.tipoComprobante.Size = new System.Drawing.Size(206, 26);
            this.tipoComprobante.TabIndex = 26;
            // 
            // textBox018
            // 
            this.textBox018._campo = null;
            this.textBox018._mensaje_error = null;
            this.textBox018._nombre_tabla = null;
            this.textBox018._tipo = AgenciaCars.clases.TextBox01.tipo_dato.texto;
            this.textBox018._validable = false;
            this.textBox018.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox018.Location = new System.Drawing.Point(654, 453);
            this.textBox018.Name = "textBox018";
            this.textBox018.Size = new System.Drawing.Size(100, 26);
            this.textBox018.TabIndex = 22;
            // 
            // textBox013
            // 
            this.textBox013._campo = null;
            this.textBox013._mensaje_error = null;
            this.textBox013._nombre_tabla = null;
            this.textBox013._tipo = AgenciaCars.clases.TextBox01.tipo_dato.texto;
            this.textBox013._validable = false;
            this.textBox013.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox013.Location = new System.Drawing.Point(219, 142);
            this.textBox013.Name = "textBox013";
            this.textBox013.Size = new System.Drawing.Size(182, 26);
            this.textBox013.TabIndex = 22;
            // 
            // cliente
            // 
            this.cliente._campo = null;
            this.cliente._mensaje_error = null;
            this.cliente._nombre_tabla = null;
            this.cliente._tipo = AgenciaCars.clases.TextBox01.tipo_dato.texto;
            this.cliente._validable = false;
            this.cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cliente.Location = new System.Drawing.Point(31, 142);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(182, 26);
            this.cliente.TabIndex = 22;
            // 
            // IdFactura
            // 
            this.IdFactura._campo = null;
            this.IdFactura._mensaje_error = null;
            this.IdFactura._nombre_tabla = null;
            this.IdFactura._tipo = AgenciaCars.clases.TextBox01.tipo_dato.texto;
            this.IdFactura._validable = false;
            this.IdFactura.Enabled = false;
            this.IdFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IdFactura.Location = new System.Drawing.Point(31, 88);
            this.IdFactura.Name = "IdFactura";
            this.IdFactura.Size = new System.Drawing.Size(54, 26);
            this.IdFactura.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Location = new System.Drawing.Point(407, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 26);
            this.button2.TabIndex = 20;
            this.button2.Text = "Productos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // FAC_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tipoComprobante);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label01);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox018);
            this.Controls.Add(this.textBox013);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.IdFactura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAC_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOCALIDADESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURASDETBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_salir;
        private AgenciaCarsDataSet agenciaCarsDataSet;
        private System.Windows.Forms.BindingSource lOCALIDADESBindingSource;
        private AgenciaCarsDataSetTableAdapters.LOCALIDADESTableAdapter lOCALIDADESTableAdapter;
        private System.Windows.Forms.Button button1;
        private clases.TextBox01 IdFactura;
        private clases.TextBox01 textBox018;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fACTURASDETBindingSource;
        private AgenciaCarsDataSetTableAdapters.FACTURASDETTableAdapter fACTURASDETTableAdapter;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private clases.TextBox01 cliente;
        private System.Windows.Forms.Label label2;
        private clases.TextBox01 textBox013;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox fecha;
        private System.Windows.Forms.TextBox tipoComprobante;
        private System.Windows.Forms.Button button2;
    }
}
namespace AgenciaCars.formularios
{
    partial class BUSQ_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BUSQ_Clientes));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLocalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agenciaCarsDataSet = new AgenciaCars.AgenciaCarsDataSet();
            this.ck_id = new System.Windows.Forms.RadioButton();
            this.ck_nroDoc = new System.Windows.Forms.RadioButton();
            this.ck_apellido = new System.Windows.Forms.RadioButton();
            this.ck_nombre = new System.Windows.Forms.RadioButton();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.cLIENTESTableAdapter = new AgenciaCars.AgenciaCarsDataSetTableAdapters.CLIENTESTableAdapter();
            this.btn_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_busqueda.Location = new System.Drawing.Point(260, 72);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(444, 26);
            this.txt_busqueda.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(72, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Patrón de Búsqueda";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_buscar.FlatAppearance.BorderSize = 2;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_buscar.Location = new System.Drawing.Point(604, 102);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(100, 29);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.idTipoDocDataGridViewTextBoxColumn,
            this.nroDocDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.calleDataGridViewTextBoxColumn,
            this.nroDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.idLocalidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(696, 229);
            this.dataGridView1.TabIndex = 14;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Width = 43;
            // 
            // idTipoDocDataGridViewTextBoxColumn
            // 
            this.idTipoDocDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idTipoDocDataGridViewTextBoxColumn.DataPropertyName = "idTipoDoc";
            this.idTipoDocDataGridViewTextBoxColumn.HeaderText = "Tipo Doc.";
            this.idTipoDocDataGridViewTextBoxColumn.Name = "idTipoDocDataGridViewTextBoxColumn";
            this.idTipoDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipoDocDataGridViewTextBoxColumn.Width = 79;
            // 
            // nroDocDataGridViewTextBoxColumn
            // 
            this.nroDocDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nroDocDataGridViewTextBoxColumn.DataPropertyName = "nroDoc";
            this.nroDocDataGridViewTextBoxColumn.HeaderText = "Nro. Doc";
            this.nroDocDataGridViewTextBoxColumn.Name = "nroDocDataGridViewTextBoxColumn";
            this.nroDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroDocDataGridViewTextBoxColumn.Width = 75;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 69;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 69;
            // 
            // calleDataGridViewTextBoxColumn
            // 
            this.calleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.calleDataGridViewTextBoxColumn.DataPropertyName = "calle";
            this.calleDataGridViewTextBoxColumn.HeaderText = "Calle";
            this.calleDataGridViewTextBoxColumn.Name = "calleDataGridViewTextBoxColumn";
            this.calleDataGridViewTextBoxColumn.ReadOnly = true;
            this.calleDataGridViewTextBoxColumn.Width = 55;
            // 
            // nroDataGridViewTextBoxColumn
            // 
            this.nroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nroDataGridViewTextBoxColumn.DataPropertyName = "nro";
            this.nroDataGridViewTextBoxColumn.HeaderText = "Nro.";
            this.nroDataGridViewTextBoxColumn.Name = "nroDataGridViewTextBoxColumn";
            this.nroDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroDataGridViewTextBoxColumn.Width = 52;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 74;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 57;
            // 
            // idLocalidadDataGridViewTextBoxColumn
            // 
            this.idLocalidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idLocalidadDataGridViewTextBoxColumn.DataPropertyName = "idLocalidad";
            this.idLocalidadDataGridViewTextBoxColumn.HeaderText = "idLocalidad";
            this.idLocalidadDataGridViewTextBoxColumn.Name = "idLocalidadDataGridViewTextBoxColumn";
            this.idLocalidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLocalidadDataGridViewTextBoxColumn.Width = 86;
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.agenciaCarsDataSet;
            // 
            // agenciaCarsDataSet
            // 
            this.agenciaCarsDataSet.DataSetName = "AgenciaCarsDataSet";
            this.agenciaCarsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ck_id
            // 
            this.ck_id.AutoSize = true;
            this.ck_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_id.ForeColor = System.Drawing.SystemColors.Control;
            this.ck_id.Location = new System.Drawing.Point(261, 105);
            this.ck_id.Name = "ck_id";
            this.ck_id.Size = new System.Drawing.Size(39, 20);
            this.ck_id.TabIndex = 15;
            this.ck_id.TabStop = true;
            this.ck_id.Text = "ID";
            this.ck_id.UseVisualStyleBackColor = true;
            // 
            // ck_nroDoc
            // 
            this.ck_nroDoc.AutoSize = true;
            this.ck_nroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_nroDoc.ForeColor = System.Drawing.SystemColors.Control;
            this.ck_nroDoc.Location = new System.Drawing.Point(312, 105);
            this.ck_nroDoc.Name = "ck_nroDoc";
            this.ck_nroDoc.Size = new System.Drawing.Size(123, 20);
            this.ck_nroDoc.TabIndex = 16;
            this.ck_nroDoc.TabStop = true;
            this.ck_nroDoc.Text = "Nro. Documento";
            this.ck_nroDoc.UseVisualStyleBackColor = true;
            // 
            // ck_apellido
            // 
            this.ck_apellido.AutoSize = true;
            this.ck_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_apellido.ForeColor = System.Drawing.SystemColors.Control;
            this.ck_apellido.Location = new System.Drawing.Point(441, 106);
            this.ck_apellido.Name = "ck_apellido";
            this.ck_apellido.Size = new System.Drawing.Size(76, 20);
            this.ck_apellido.TabIndex = 17;
            this.ck_apellido.TabStop = true;
            this.ck_apellido.Text = "Apellido";
            this.ck_apellido.UseVisualStyleBackColor = true;
            // 
            // ck_nombre
            // 
            this.ck_nombre.AutoSize = true;
            this.ck_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.ck_nombre.Location = new System.Drawing.Point(523, 106);
            this.ck_nombre.Name = "ck_nombre";
            this.ck_nombre.Size = new System.Drawing.Size(75, 20);
            this.ck_nombre.TabIndex = 18;
            this.ck_nombre.TabStop = true;
            this.ck_nombre.Text = "Nombre";
            this.ck_nombre.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_nuevo.FlatAppearance.BorderSize = 2;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_nuevo.Location = new System.Drawing.Point(12, 383);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(100, 29);
            this.btn_nuevo.TabIndex = 19;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_salir.FlatAppearance.BorderSize = 2;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_salir.Location = new System.Drawing.Point(118, 383);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(100, 29);
            this.btn_salir.TabIndex = 20;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_actualizar.FlatAppearance.BorderSize = 2;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_actualizar.Location = new System.Drawing.Point(625, 373);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(83, 29);
            this.btn_actualizar.TabIndex = 21;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // BUSQ_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(720, 424);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.ck_nombre);
            this.Controls.Add(this.ck_apellido);
            this.Controls.Add(this.ck_nroDoc);
            this.Controls.Add(this.ck_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BUSQ_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.BUSQ_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton ck_id;
        private System.Windows.Forms.RadioButton ck_nroDoc;
        private System.Windows.Forms.RadioButton ck_apellido;
        private System.Windows.Forms.RadioButton ck_nombre;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_salir;
        private AgenciaCarsDataSet agenciaCarsDataSet;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private AgenciaCarsDataSetTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_actualizar;
    }
}
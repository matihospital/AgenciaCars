﻿namespace AgenciaCars.formularios
{
    partial class BUSQ_Provincias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BUSQ_Provincias));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.agenciaCarsDataSet = new AgenciaCars.AgenciaCarsDataSet();
            this.pROVINCIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROVINCIASTableAdapter = new AgenciaCars.AgenciaCarsDataSetTableAdapters.PROVINCIASTableAdapter();
            this.idProvinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVINCIASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(147, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Provincias";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProvinciaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.idPaisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROVINCIASBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(488, 281);
            this.dataGridView1.TabIndex = 14;
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
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_salir.FlatAppearance.BorderSize = 2;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_salir.Location = new System.Drawing.Point(400, 383);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(100, 29);
            this.btn_salir.TabIndex = 20;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // agenciaCarsDataSet
            // 
            this.agenciaCarsDataSet.DataSetName = "AgenciaCarsDataSet";
            this.agenciaCarsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROVINCIASBindingSource
            // 
            this.pROVINCIASBindingSource.DataMember = "PROVINCIAS";
            this.pROVINCIASBindingSource.DataSource = this.agenciaCarsDataSet;
            // 
            // pROVINCIASTableAdapter
            // 
            this.pROVINCIASTableAdapter.ClearBeforeFill = true;
            // 
            // idProvinciaDataGridViewTextBoxColumn
            // 
            this.idProvinciaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idProvinciaDataGridViewTextBoxColumn.DataPropertyName = "idProvincia";
            this.idProvinciaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idProvinciaDataGridViewTextBoxColumn.Name = "idProvinciaDataGridViewTextBoxColumn";
            this.idProvinciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProvinciaDataGridViewTextBoxColumn.Width = 43;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Provincias";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPaisDataGridViewTextBoxColumn
            // 
            this.idPaisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idPaisDataGridViewTextBoxColumn.DataPropertyName = "idPais";
            this.idPaisDataGridViewTextBoxColumn.HeaderText = "idPais";
            this.idPaisDataGridViewTextBoxColumn.Name = "idPaisDataGridViewTextBoxColumn";
            this.idPaisDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPaisDataGridViewTextBoxColumn.Width = 60;
            // 
            // BUSQ_Provincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(513, 424);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BUSQ_Provincias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provincias";
            this.Load += new System.EventHandler(this.BUSQ_Provincias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaCarsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVINCIASBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_salir;
        private AgenciaCarsDataSet agenciaCarsDataSet;
        private System.Windows.Forms.BindingSource pROVINCIASBindingSource;
        private AgenciaCarsDataSetTableAdapters.PROVINCIASTableAdapter pROVINCIASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProvinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaisDataGridViewTextBoxColumn;
    }
}
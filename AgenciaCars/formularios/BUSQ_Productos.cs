﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaCars.clases;

namespace AgenciaCars.formularios
{
    public partial class BUSQ_Productos : Form
    {
        productos obj_productos = new productos();

        public BUSQ_Productos()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //Abrir ABM
            ABM_Productos frm = new formularios.ABM_Productos();
            frm.ShowDialog();
        }

        private void BUSQ_Productos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = this.obj_productos.buscarProductos();

            if (tabla.Rows.Count != 0)
            {
                dataGridView1.DataSource = tabla;
            }
        }

        private void actualizarGrilla()
        {
            DataTable tabla = new DataTable();
            tabla = this.obj_productos.buscarProductos();
            dataGridView1.DataSource = tabla;

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (this.txt_busqueda.Text == "")
            {
                MessageBox.Show("El campo de búsqueda está vacío");
                this.txt_busqueda.Focus();    
                return;
            }
            else
            {
                DataTable tabla = new DataTable();

                //Busco segun lo seleccionado
                if (this.ck_id.Checked)
                {
                    tabla = this.obj_productos.buscarPorParametro("idCliente", this.txt_busqueda.Text);
                }
                else if (this.ck_modelo.Checked)
                {
                    tabla = this.obj_productos.buscarPorParametro("idModelo", this.txt_busqueda.Text);
                }
                else if (this.ck_anio.Checked)
                {
                    tabla = this.obj_productos.buscarSiContiene("anio", this.txt_busqueda.Text);
                }
                else if (this.ck_color.Checked)
                {
                    tabla = this.obj_productos.buscarSiContiene("color", this.txt_busqueda.Text);
                }
                else { return; }

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos");
                    this.txt_busqueda.Focus();
                    return;
                }
                dataGridView1.DataSource = tabla;               
            }
     
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
            this.txt_busqueda.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Busco los datos del producto
            DataTable pro = new DataTable();
            pro = this.obj_productos.buscar_por_id(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            ABM_Productos producto = new formularios.ABM_Productos(pro.Rows[0]["idEstado"].ToString(),
                                                                   pro.Rows[0]["idMarca"].ToString(),
                                                                   pro.Rows[0]["idModelo"].ToString(),
                                                                   pro.Rows[0]["idPais"].ToString(),
                                                                   pro.Rows[0]["idProveedor"].ToString());

            //Cargo los datos del producto
            producto.txt_id.Text = pro.Rows[0]["Id"].ToString();
            producto.txt_descripcion.Text = pro.Rows[0]["Observaciones"].ToString();
            producto.txt_anio.Text = pro.Rows[0]["Año"].ToString();
            producto.txt_color.Text = pro.Rows[0]["Color"].ToString();
            producto.txt_precio.Text = pro.Rows[0]["Precio"].ToString();
            producto.txtTitulo.Text = "Modificar Producto";
            

            //Abro la pantalla
            producto.ShowDialog();
        }
    }
}

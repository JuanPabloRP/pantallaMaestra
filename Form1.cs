﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace pantallaMaestra
{
    public partial class frmPantallaMaestra : Form
    {
        /// <summary>
        /// Juan Pablo Roldan Patiño
        /// 2023
        /// Aplicación de CRUD de datos 
        /// </summary>

        //
        private static string DBName = "crudProductos";
        private static string TableName = "tbl_product";

        
        public frmPantallaMaestra()
        {
            InitializeComponent();
        }

        public static int verificarIDUnico(SQLiteConnection _conexionsqlite)
        {
            Random n = new Random();
            int id;
            bool idRepetido;
            do
            {
                idRepetido = false;
                id = n.Next(1000000, 9999999);

                try
                {

                    string checkIDUnico = string.Format("SELECT COUNT(*) FROM {1} WHERE id={0}", id, TableName);
                    

                    SQLiteCommand cmd_checkIDUnico = new SQLiteCommand(checkIDUnico, _conexionsqlite);


                    if (Convert.ToInt32(cmd_checkIDUnico.ExecuteScalar()) > 0)
                    {
                        idRepetido = true;
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error (sql): " + ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

            } while (idRepetido == true);


            return id;
        }

        public static SQLiteCommand getDatos()
        {
            SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();
            conexionDB.Open();
            try
            {
                string getProductos = string.Format("SELECT * FROM {0}", TableName);

                SQLiteCommand cmd_getProducts = new SQLiteCommand(getProductos, conexionDB);



                return cmd_getProducts;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error obteniendo los datos desde la base de datos\n" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }

            conexionDB.Close();
            return null;

        }

        public SQLiteCommand createDato()
        {
            SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();
            conexionDB.Open();

            try
            {
                if (!string.IsNullOrEmpty(txtNombreProducto.Text) && !string.IsNullOrEmpty(txtPrecioProducto.Text))
                {
                    //verificamos que el nombre no se repita
                    string checkUniqueName = string.Format("SELECT COUNT(name) FROM {0} WHERE name=@name", TableName);

                    SQLiteCommand cmd_checkName = new SQLiteCommand(checkUniqueName, conexionDB);
                    cmd_checkName.Parameters.AddWithValue("@name", txtNombreProducto.Text);

                    if (Convert.ToInt32(cmd_checkName.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Error el nombre del producto ya existe");
                        return null;
                    }

                    //si no se repite entonces creamos el prod
                    int id = verificarIDUnico(conexionDB);

                    string createProducto = string.Format("INSERT INTO tbl_product (id, name, price) VALUES(@id, @nombre, @precio);", TableName);

                    SQLiteCommand cmd_createProduct = new SQLiteCommand(createProducto, conexionDB);
                    cmd_createProduct.Parameters.AddWithValue("@id", id);
                    cmd_createProduct.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
                    cmd_createProduct.Parameters.AddWithValue("@precio", txtPrecioProducto.Text);

                    MessageBox.Show("Producto creado con exito");
                    return cmd_createProduct;
                }
                else
                {
                    MessageBox.Show("Por favor ingrese el nombre del producto y su precio");
                }
                
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error creando el producto\n" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }

            conexionDB.Close();
            return null;

        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            SQLiteCommand cmd_getProducts = getDatos();

            SQLiteDataReader datareader_sqlite = cmd_getProducts.ExecuteReader();


            dgvDatos.Rows.Clear();
            dgvDatos.Columns.Clear();


            dgvDatos.Columns.Add("idProd", "ID");
            dgvDatos.Columns.Add("nameProd", "Producto");
            dgvDatos.Columns.Add("idPrice", "Price");

            while (datareader_sqlite.Read())
            {
                //Mostrando los datos

                int idProd = datareader_sqlite.GetInt32(0);
                string nameProd = datareader_sqlite.GetString(1);
                float priceProd = datareader_sqlite.GetFloat(2);
                

                dgvDatos.Rows.Add(idProd, nameProd, priceProd);

            }
            datareader_sqlite.Close();

            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand cmd_createProduct = createDato();
                if (cmd_createProduct != null && cmd_createProduct.GetType() == typeof(SQLiteCommand)) {
                    SQLiteDataReader reader_createProduct = cmd_createProduct.ExecuteReader();

                    reader_createProduct.Close();
                }
                
                

                
                
            }
            catch (SQLiteException ex) {
                MessageBox.Show("Error: " + ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }




        }



        
    }
}
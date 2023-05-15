using System;
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
        private static string tableName = "tbl_product";

        //para poder abrir la conexion desde un metodo y poder cerralo en otro metodo, me tocó poner este objeto como global
        //SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();

        public frmPantallaMaestra()
        {
            InitializeComponent();
        }


        /*
         
            Metodos propios 

        */

        //se crea y se verifica un ID no repetido
        public int verificarIDUnico()
        {
            Random n = new Random();
            int id;
            bool idRepetido;
            SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();
            conexionDB.Open();

            do
            {
                idRepetido = false;
                id = n.Next(1000000, 9999999);

                try
                {

                    string checkIDUnico = string.Format("SELECT COUNT(*) FROM {1} WHERE id={0}", id, tableName);
                    

                    SQLiteCommand cmd_checkIDUnico = new SQLiteCommand(checkIDUnico, conexionDB);


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

            conexionDB.Close();
            return id;
        }


        //se obtienen los datos de la DB
        public SQLiteCommand getDatos()
        {
            try
            {
                    SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();
                    //se abre conexionDB (se cierra en updateDgv)
                    conexionDB.Open();

                    string getProductos = string.Format("SELECT * FROM {0}", tableName);

                    SQLiteCommand cmd_getProducts = new SQLiteCommand(getProductos, conexionDB);

                    //cada vez que obtengamos los datos tambien actualizamos los combo box
                    llenarCombobox(cbProdAEliminar);
                    llenarCombobox(cbIdAEditar);
                
                    
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
            return null;

        }


        //para actualizar/mostrar los datos de la DB por si hay algun cambio, ya sea un create, update, delete o solo si se quiere obtener los elementos
        //este metodo muestra los datos en el dgv ya sea la primera vez o si hay alguna actualizacion
        public void updateDgv()
        {
            
            try
            {
                SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();
                
                SQLiteCommand cmd_getDatos = getDatos();

                //volviendo a abrir la DB
                
                SQLiteDataReader datareader_sqlite = cmd_getDatos.ExecuteReader();


                dgvDatos.Rows.Clear();
                dgvDatos.Columns.Clear();


                dgvDatos.Columns.Add("idProd", "ID");
                dgvDatos.Columns.Add("nameProd", "Producto");
                dgvDatos.Columns.Add("idPrice", "Price");

                while (datareader_sqlite.Read())
                {
                    //Obtenemos los datos
                    int idProd = datareader_sqlite.GetInt32(0);
                    string nameProd = datareader_sqlite.GetString(1);
                    float priceProd = datareader_sqlite.GetFloat(2);

                    //los colocamos en el dgv
                    dgvDatos.Rows.Add(idProd, nameProd, priceProd);

                }
                datareader_sqlite.Close();
                conexionDB.Close();                

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error (DB - mostrando los datos en el dgv):\n" + ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error (mostrando los datos en el dgv):\n" + ex);
            }




        }



        //creando un dato
        public SQLiteCommand createDato()
        {
            
            try
            {
                SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();
                conexionDB.Open();

                float precio;

                if (!string.IsNullOrEmpty(txtPrecioProducto.Text) && !float.TryParse(txtPrecioProducto.Text, out precio)) {
                    MessageBox.Show("Error: el precio debe de ser un valor numerico");
                    return null;
                }
                
                if (!string.IsNullOrEmpty(txtNombreProducto.Text) && !string.IsNullOrEmpty(txtPrecioProducto.Text))
                {
                    //verificamos que el nombre no se repita
                    string checkUniqueName = string.Format("SELECT COUNT(name) FROM {0} WHERE name=@name", tableName);

                    SQLiteCommand cmd_checkName = new SQLiteCommand(checkUniqueName, conexionDB);
                    cmd_checkName.Parameters.AddWithValue("@name", txtNombreProducto.Text);

                    if (Convert.ToInt32(cmd_checkName.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Error el nombre del producto ya existe");
                        return null;
                    }

                    //si no se repite entonces creamos el prod
                    int id = verificarIDUnico();

                    string createProducto = string.Format("INSERT INTO tbl_product (id, name, price) VALUES(@id, @nombre, @precio);", tableName);

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

            
            return null;

        }


        //llenar comboBox y updateDato
        
        //se llena los comboBox con los ids (sirve para el metodo de actualizar y eliminar)

        public void llenarCombobox(ComboBox comboBox)
        {
            //llenamos los combobox con los ids disponibles
            try
            {
                SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();

                conexionDB.Open();
                string getIDs = string.Format("SELECT id FROM {0}", tableName);

                SQLiteCommand cmd_getIDs = new SQLiteCommand(getIDs, conexionDB);

                SQLiteDataReader datareader_sqlite = cmd_getIDs.ExecuteReader();

                comboBox.Items.Clear();


                 while (datareader_sqlite.Read())
                {
                    //Obtenemos los ids
                    int idProd = datareader_sqlite.GetInt32(0);
                        
                    //los colocamos en el comboBox
                    comboBox.Items.Add(idProd);

                }
                


                MessageBox.Show("El combo box ha sido llenado");
                    datareader_sqlite.Close();

                    conexionDB.Close();

                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error (sql): " + ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

            
        }

        // updateDato
        
        public SQLiteCommand updateDato()
        {
            string queryActualizar;


            SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();
            conexionDB.Open();
            //dependiendo de los datos ingresados se hace un query u otro

            float nuevoPrecio;
            if (!string.IsNullOrEmpty(txtNuevoPrecio.Text) && !float.TryParse(txtNuevoPrecio.Text, out nuevoPrecio))
            {
                MessageBox.Show("Error: el precio debe de ser un valor numerico");
                return null;
            }

            if (cbIdAEditar.SelectedIndex == -1)
            {
                MessageBox.Show("Error: debes de seleccionar un id de un producto para modificar\n" +
                    "Prueba con traer los productos para ver los ids disponibles");
                return null;
            }


            if (!string.IsNullOrEmpty(txtNuevoNombre.Text) && !string.IsNullOrEmpty(txtNuevoPrecio.Text))
            {
                queryActualizar = string.Format("update {0} set name=@name, price=@price where id=@id", tableName);
            }
            else if (!string.IsNullOrEmpty(txtNuevoNombre.Text) && string.IsNullOrEmpty(txtNuevoPrecio.Text))
            {
                queryActualizar = string.Format("update {0} set name=@name where id=@id", tableName);
               
            }
            else if (string.IsNullOrEmpty(txtNuevoNombre.Text) && !string.IsNullOrEmpty(txtNuevoPrecio.Text))
            {
                queryActualizar = string.Format("update {0} set price=@price where id=@id", tableName);
            }
            else
            {
                MessageBox.Show("Ingrese al menos un nuevo nombre o precio");
                return null;
            }

            //se crea el comando con uno de los querys de arriba
            SQLiteCommand cmd_actualizar = new SQLiteCommand(queryActualizar, conexionDB);


            if (cbIdAEditar.SelectedIndex != -1)
            {
                cmd_actualizar.Parameters.AddWithValue("@id", Convert.ToInt32(cbIdAEditar.SelectedItem.ToString()));

                // se agrega una u otra o las dos opciones dependiendo de los que ingrese o no el usuario
                if (!string.IsNullOrEmpty(txtNuevoNombre.Text))
                {
                    cmd_actualizar.Parameters.AddWithValue("@name", txtNuevoNombre.Text);
                }
                if (!string.IsNullOrEmpty(txtNuevoPrecio.Text))
                {
                    cmd_actualizar.Parameters.AddWithValue("@price", txtNuevoPrecio.Text);
                }

            }
            else
            {
                MessageBox.Show("Seleccione un ID");
                return null;
            }

            return cmd_actualizar;
        }

        
        //No funciona todavia xd
        public int deleteDato()
        {
            string queryEliminarProducto = string.Format("delete from {0} where id=@id", tableName);

            using (SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB())
            {
                conexionDB.Open();
                using (SQLiteCommand cmd_deleteDato = new SQLiteCommand(queryEliminarProducto, conexionDB))
                {
                    if (cbProdAEliminar.SelectedIndex == -1)
                    {
                        MessageBox.Show("Error, selecciona un ID para eliminar un producto");
                        return 0;
                    }

                    cmd_deleteDato.Parameters.AddWithValue("@id", Convert.ToInt32(cbProdAEliminar.SelectedItem.ToString()));
                    int filasAfectadas = cmd_deleteDato.ExecuteNonQuery();
                    return filasAfectadas;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {

                using (SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB()) {


                    int filasAfectadas = deleteDato();

                    conexionDB.Open();


                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Producto eliminado con exito");
                    }
                    else
                    { 
                        MessageBox.Show("Error al eliminar el producto");
                    }

                    updateDgv();
                    

                    conexionDB.Close();
                }

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error (sql):\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex);
            }
        }


        /*
            
            Metodos de cada componente
         
         */


        private void btnRead_Click(object sender, EventArgs e)
        {
            updateDgv();
            //se cierra conexionDB que se abrio en getDatos
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                
                //crear el producto
                SQLiteCommand cmd_createProduct = createDato();
                if (cmd_createProduct != null && cmd_createProduct.GetType() == typeof(SQLiteCommand)) {
                    SQLiteDataReader reader_createProduct = cmd_createProduct.ExecuteReader();

                    reader_createProduct.Close();

                    updateDgv();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                SQLiteConnection conexionDB = new ConexionDB(DBName).ConectarDB();

                SQLiteCommand cmd_updateDato = updateDato();


                if (cmd_updateDato != null && cmd_updateDato.GetType() == typeof(SQLiteCommand))
                {
                    conexionDB.Open();
                    int filasAfectadas = cmd_updateDato.ExecuteNonQuery();
                    MessageBox.Show("Producto modificado con exito");

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("se realizaron actualizaciones");
                    }
                    else
                    {
                        MessageBox.Show("No se realizaron actualizaciones X");

                    }

                    updateDgv();
                }
                else
                {

                    MessageBox.Show("Error al modificar el producto");

                }

                conexionDB.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error (sql):\n" + ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex);
            }

        }

        //No funciona todavia xd
        
    }
}

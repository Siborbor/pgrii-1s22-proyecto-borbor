using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrearTarea;
using MongoDB.Bson;

namespace TareaGestor
{
    public partial class Form1 : Form
    {
        static MongoClient client = new MongoClient("mongodb+srv://Siborbor:kq4EGsjPm68t4dp5@cluster0.d3jmp.mongodb.net/test");
        static IMongoDatabase database = client.GetDatabase("Gestor_TareaDB");
        static IMongoCollection<Tarea> collection = database.GetCollection<Tarea>("TareaCollection");

        
        public Form1()
        {
            InitializeComponent();
            MostrarDocumento();
        }
        public void MostrarDocumento()
        {
            List<Tarea> lista = collection.AsQueryable().ToList<Tarea>();
            dgTareas.DataSource = lista;
        }

        public void LimpiarDatos()
        {
            //encerando
            txtId.Text = "";
            txtBox_Nombre.Text = "";
            txtBox_Descripcion.Text = "";
            dtCreacion.Text = "";
            dtLimite.Text = "";
            txtEstado.Text = "";
            dtBuscarFecha.Text = "";
            txtBuscarEstado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtEstado.Text.ToUpper() == "CREADA") || (txtEstado.Text.ToUpper() == "EN EJECUCION") || (txtEstado.Text.ToUpper() == "COMPLETADA"))
            {
                Tarea t = new Tarea(txtBox_Nombre.Text, txtBox_Descripcion.Text, dtCreacion.Text, dtLimite.Text, txtEstado.Text.ToUpper());
                collection.InsertOne(t);
                MostrarDocumento();
                LimpiarDatos();

                string message = "Tarea Agregada con exito";
                string title = "aviso";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Exclamation);

            }
            else
            {
                string message = "Estado incorrecto(creada/en ejecucion/completada)";
                string title = "aviso";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtEstado.Text.ToUpper() == "CREADA" )
            {
                var updateCampos = Builders<Tarea>.Update
                .Set("name", txtBox_Nombre.Text)
                .Set("descripcion", txtBox_Descripcion.Text)
                .Set("fechaCreacion", dtCreacion.Text)
                .Set("fechaLimite", dtLimite.Text)
                .Set("estado", txtEstado.Text);
                collection.UpdateOne(s => s.ID == txtId.Text, updateCampos);
                MostrarDocumento();
                LimpiarDatos();

                string message = "Tarea editada con exito";
                string title = "aviso";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Exclamation);
            }
            else
            {
                string message = "Seleccione una tarea con estado Creada para editar";
                string title = "aviso";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
            
        }

        private void dgTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgTareas.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBox_Nombre.Text = dgTareas.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBox_Descripcion.Text = dgTareas.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtCreacion.Text = dgTareas.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtLimite.Text = dgTareas.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEstado.Text = dgTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {

            collection.DeleteOne(s => s.ID == txtId.Text);
            MostrarDocumento();
            LimpiarDatos();
            string message = "Tarea Borrada con exito";
            string title = "aviso";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            var filterFecha = Builders<Tarea>.Filter.Eq(s => s.FechaCreacion, dtBuscarFecha.Text);
            var tareaFecha = collection.Find(filterFecha).ToList();
            dgTareas.DataSource = tareaFecha;
            LimpiarDatos();


        }

        private void btBuscarEstado_Click(object sender, EventArgs e)
        {
            var filterEstado = Builders<Tarea>.Filter.Eq(s => s.Estado, txtBuscarEstado.Text.ToUpper());
            var tareaEstado = collection.Find(filterEstado).ToList();
            dgTareas.DataSource = tareaEstado;
            LimpiarDatos();
        }

        private void btTerminarBusqueda_Click(object sender, EventArgs e)
        {
            MostrarDocumento();
            LimpiarDatos();
        }
    }
}

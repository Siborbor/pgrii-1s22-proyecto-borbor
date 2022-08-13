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

        private void button1_Click(object sender, EventArgs e)
        {
            Tarea t = new Tarea(txtBox_Nombre.Text,txtBox_Descripcion.Text, dtCreacion.Text, dtLimite.Text, txtEstado.Text);
            collection.InsertOne(t);
            MostrarDocumento();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var updateCampos = Builders<Tarea>.Update
                .Set("name", txtBox_Nombre.Text)
                .Set("descripcion", txtBox_Descripcion.Text)
                .Set("fechaCreacion", dtCreacion.Text)
                .Set("fechaLimite", dtLimite.Text)
                .Set("estado", txtEstado.Text);
            collection.UpdateOne(s => s.ID == txtId.Text,updateCampos);
            MostrarDocumento();
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                var filterFecha = Builders<Tarea>.Filter.Eq(s => s.FechaCreacion, dtBuscarFecha.Text);
                var tareaFecha = collection.Find(filterFecha).ToList();
                dgTareas.DataSource = tareaFecha;
          
            
            
            

        }

        private void btBuscarEstado_Click(object sender, EventArgs e)
        {
            var filterEstado = Builders<Tarea>.Filter.Eq(s => s.Estado, txtBuscarEstado.Text);
            var tareaEstado = collection.Find(filterEstado).ToList();
            dgTareas.DataSource = tareaEstado;
        }

        private void btTerminarBusqueda_Click(object sender, EventArgs e)
        {
            MostrarDocumento();
        }
    }
}

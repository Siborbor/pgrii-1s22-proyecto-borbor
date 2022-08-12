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
            /*LeerDocumento();*/
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Tarea t = new Tarea(txtBox_Nombre.Text,txtBox_Descripcion.Text, dtCreacion.Text, dtLimite.Text, txtEstado.Text);
            collection.InsertOne(t);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

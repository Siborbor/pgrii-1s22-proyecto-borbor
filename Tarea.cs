using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CrearTarea
    {
        public class Tarea
        {
            private string id;
            private string nombre;
            private string description;
            private string fecha_creacion;
            private string fecha_limite_tarea;
            private string estado;

    
              public Tarea(string name, string descripcion, string fechaCreacion, string fechaLimite, string estado_inicial)
            {
                nombre = name;
                description = descripcion;
                fecha_creacion = fechaCreacion;
                fecha_limite_tarea = fechaLimite;
                estado = estado_inicial;
            }
           
            [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
            public string ID
            {
                get { return id; }
                set { id = value; }
            }
            
            [BsonElement("name")]
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            [BsonElement("descripcion")]
             public String Description
            {
                get { return description; }
                set { description = value; }
            }
            [BsonElement("fechaCreacion")]
            public string FechaCreacion
            {
                get { return fecha_creacion; }
                set { fecha_creacion = value; }
            }
            [BsonElement("fechaLimite")]
            public string FechaLimiteTarea
            {
                get { return fecha_limite_tarea; }
                set { fecha_limite_tarea = value; }
            }
            [BsonElement("estado")]
            public string Estado
            {
                get { return estado; }
                set { estado = value; }
            }
        }
    }

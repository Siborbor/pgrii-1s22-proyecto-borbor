using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearTarea
{
    internal class Tarea
    {
        private String id ;
        private string nombre;
        private string description;
        private string fecha_creacion;
        private string fecha_limite_tarea;
        private string estado;
      
        public Tarea()
        {
            id = Guid.NewGuid().ToString(); 
            nombre = "";
            description = "";
            fecha_creacion = "";
            fecha_limite_tarea = "";
            estado = "Creada";
        }

        public Tarea(String nombre, string descripcion, string fechaCreacion, string fechaLimite )
        {
            id = Guid.NewGuid().ToString();
            nombre = nombre;
            description = descripcion;
            fecha_creacion = fechaCreacion;
            fecha_limite_tarea = fechaLimite ;
            estado = "Creada";
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; } 
            set { nombre = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public string FechaCreacion
        {
             get { return fecha_creacion; }
             set { fecha_creacion = value; }
        }

        public string FechaLimiteTarea
        {
            get { return fecha_limite_tarea; }
            set { fecha_limite_tarea = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}


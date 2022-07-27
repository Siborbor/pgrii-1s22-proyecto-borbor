using CrearTarea;

DateTime thisDate1 = new DateTime(2022, 7, 22);
DateTime thisDate2 = new DateTime(2022, 7, 26);
Tarea t1 = new Tarea();

t1.ID = 12345678;
t1.Nombre = "Tarea de Matematica";
t1.Description = "esta es una tarea de prueba";
t1.FechaCreacion = thisDate1.ToString("dd-MM-yyyy");
t1.FechaLimiteTarea = thisDate2.ToString("dd-MM-yyyy");
t1.Estado = "CREADA";

Console.WriteLine($"ID: {t1.ID}" );
Console.WriteLine($"NOMBRE: {t1.Nombre}");
Console.WriteLine($"DESCRIPCION: {t1.Description}");
Console.WriteLine($"FECHA DE CREACION: {t1.FechaCreacion}");
Console.WriteLine($"fECHA LIMITE DE TAREA: {t1.FechaLimiteTarea}");
Console.WriteLine($"ESTADO DE LA TAREA: {t1.Estado}");

using CrearTarea;

DateTime thisDate1 = new DateTime(2022, 7, 22);
DateTime thisDate2 = new DateTime(2022, 7, 26);
Tarea t1 = new Tarea();
Tarea t2 = new Tarea();


t1.Nombre = "Tarea de Matematica";
t1.Description = "esta es una tarea de prueba";
t1.FechaCreacion = thisDate1.ToString("dd-MM-yyyy");
t1.FechaLimiteTarea = thisDate2.ToString("dd-MM-yyyy");

t2.Nombre = "Tarea de Fisica";
t2.Description = "esta es una tarea de prueba";
t2.FechaCreacion = thisDate1.ToString("dd-MM-yyyy");
t2.FechaLimiteTarea = thisDate2.ToString("dd-MM-yyyy");



Console.WriteLine($"ID: {t1.ID}");
Console.WriteLine($"NOMBRE: {t1.Nombre}");
Console.WriteLine($"DESCRIPCION: {t1.Description}");
Console.WriteLine($"FECHA DE CREACION: {t1.FechaCreacion}");
Console.WriteLine($"fECHA LIMITE DE TAREA: {t1.FechaLimiteTarea}");
Console.WriteLine($"ESTADO DE LA TAREA: {t1.Estado}");

Console.WriteLine($"ID: {t2.ID}");
Console.WriteLine($"NOMBRE: {t2.Nombre}");
Console.WriteLine($"DESCRIPCION: {t2.Description}");
Console.WriteLine($"FECHA DE CREACION: {t2.FechaCreacion}");
Console.WriteLine($"fECHA LIMITE DE TAREA: {t2.FechaLimiteTarea}");
Console.WriteLine($"ESTADO DE LA TAREA: {t2.Estado}");

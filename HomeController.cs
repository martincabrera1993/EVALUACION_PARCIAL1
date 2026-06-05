using Diseño_Empleados.Views;
using Diseño_Empleados.Views.Home;
using System;
using System.Collections.Generic;

internal class HomeController
{
    static void Main(string[] args)
    {
        List<Empleado> Empleado = new List<Empleado>();
        List<Departamento> Departamento = new List<Departamento>();
        List<Departamento> asignaciones = new List<Departamento>();

        // Crear empleado
        Empleado.Add(new Empleado
        {
            Empleado_Id = 1,
            Nombre = "Martin",
            Apellido = "Cabrera",
            Email = "martin@mail.com",
            Telefono = "095873963"
        });

        // Crear departamento
        Departamento.Add(new Departamento
        {
            Departamento_Id = 1,
            Nombre = "IT",
            Ubicacion = "Quito",
            Jefe_Departamento = "Gerente",
            Extension = "101"
        });

        // Asignar empleado a departamento
        object value = Diseño_Empleados.Views.Departamento.Add(new Departamento
        {
            Empleado_Id = 1,
            Departamento_Id = 1
        });

        // Mostrar datos
        Console.WriteLine("Empleado: " + Empleado[0].Nombre);
        Console.WriteLine("Departamento: " + Departamento[0].Nombre);
    }
}

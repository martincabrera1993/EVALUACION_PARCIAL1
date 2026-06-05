namespace Diseño_Empleados.Views
{
    public class Departamento
    {
        public int Departamento_Id;
        public required string Nombre;
        public required string Ubicacion;
        public required string Jefe_Departamento;
        public required string Extension;

        public int Empleado_Id { get; internal set; }

        internal static object Add(Departamento departamento)
        {
            throw new NotImplementedException();
        }
    }
}

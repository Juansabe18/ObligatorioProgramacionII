
namespace Dominio
{
    public class Peon : Empleado
    {
        private bool _residenteEnEstancia;
        private List<Tarea> _tareas;

        public Peon(string email, string pass, string nombre, DateTime fechaDeIngreso, bool residenteEnEstancia) : base(email, pass, nombre, fechaDeIngreso) { 
            _residenteEnEstancia = residenteEnEstancia;
            _tareas = new List<Tarea>(); ;
        }

        private string MostrarTareas() {
            string tareas = "";
            foreach (Tarea tareaActual in _tareas)
                tareas += tareaActual.ToString() + '\n' ;
            return tareas;
        }

        public override string ToString()
        {
            return base.ToString() + $"Residente en estancia: {_residenteEnEstancia : 'Si' ? 'No'} Tareas: {MostrarTareas()}";
        }

    }
}

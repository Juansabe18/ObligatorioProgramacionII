

namespace Dominio
{
    public class Capataz : Empleado, IValidar
    {
        private int _cantPersonasACargo;
        //private List<Empleado> _personasACargo;

        public Capataz(string email, string pass, string nombre, DateTime fechaDeIngreso, int cantPersonasACargo) : base (email, pass, nombre, fechaDeIngreso) { 
            _cantPersonasACargo = cantPersonasACargo;
            //_personasACargo = new List<Empleado>();
        }

        public int CantPersonasACargo { get { return _cantPersonasACargo; } }

        //TODO Preguntar si realmente es necesario almacenar que Empleados tiene a cargo el capataz o solo se interesa registrar el numero

        /* public void AddEmpleado(Empleado e) {
             if (e != null)
                 _personasACargo.Add(e);

         }*/

        public override string ToString()
        {
            return base.ToString() + $"Cantidad de personas a cargo: {_cantPersonasACargo}";
            //return base.ToString() + $"Cantidad de personas a cargo: {_personasACargo.Count}";
        }

    }
}

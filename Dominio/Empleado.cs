
namespace Dominio
{
    public class Empleado : IValidar
    {
        private string _email;
        private string _pass;
        private string _nombre;
        private DateTime _fechaDeIngreso;

        public Empleado (string email, string pass, string nombre, DateTime fechaDeIngreso) { 
            _email = email;
            _pass = pass;   
            _nombre = nombre;   
            _fechaDeIngreso = fechaDeIngreso;
        }
        public void Validar()
        {
            ValidarEmail();
            ValidarPass();
            ValidarNombre();
        }

        private void ValidarEmail() {
            if (string.IsNullOrEmpty(_email)) throw new Exception("Email no puede estar vacío");            
        }

        private void ValidarPass() {
            if (string.IsNullOrEmpty(_pass) || _pass.Length < 8) throw new Exception("La contraseña puede estar vacía y debe tener minimo 8 caracteres");
        }

        private void ValidarNombre() {
            if (string.IsNullOrEmpty(_pass)) throw new Exception("Nombre no puede estar vacío");
        }

        public override string ToString() {
            return $"Nombre del Emplado: {_nombre}, email: {_email}, contraseña: {_pass}, fecha de ingreso: {_fechaDeIngreso}";
        }

        public override bool Equals(object obj)
        {
            Empleado empleado = obj as Empleado;
            return empleado != null && empleado._email == _email;
        }
    }
}

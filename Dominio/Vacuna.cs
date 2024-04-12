
namespace Dominio
{
    public class Vacuna : IValidar
    {
        private string _nombre;
        private string _descripcion;
        private string _patogeno;

        public Vacuna(string nombre, string descripcion, string patogeno) {
            _nombre = nombre;
            _descripcion = descripcion;
            _patogeno = patogeno;
        }

        public string Nombre { get{ return _nombre; } }

        public void Validar() {
            ValidarNombre();
            ValidarDescripcion();
            ValidarPatogeno();        
        }

        private void ValidarNombre() {
            if (string.IsNullOrEmpty(_nombre)) throw new Exception("Nombre no puede estar vacío");
        }

        private void ValidarDescripcion() {
            if (string.IsNullOrEmpty(_descripcion)) throw new Exception("Descripcion no puede estar vacío");
        }
        private void ValidarPatogeno() {
            if (string.IsNullOrEmpty(_patogeno)) throw new Exception("Patogeno no puede quedar vacío");
        }

        public override string ToString()
        {
            return $"Nombre vacuna: {_nombre}, descripcion: {_descripcion}, patogeno: {_patogeno}";
        }

        public override bool Equals(object obj)
        {
            Vacuna vacuna = obj as Vacuna;
            return vacuna != null && vacuna.Nombre == _nombre;
        }

    }
}

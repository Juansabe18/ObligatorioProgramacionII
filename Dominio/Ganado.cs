

namespace Dominio
{
    public class Ganado
    {
        private string _idCaravana;
        private bool _sexo;
        private string _raza;
        private DateTime _fechaNacimiento;
        private double _costoAdquisicion;
        private double _costoAlimentacion;
        private double _peso;
        private bool _esHibrido;
        private List<VacunaGanadoImp> _vacunas;
        private bool _esLibre = false;

        public Ganado(string idCaravana, bool sexo, string raza, DateTime fechaNacimiento, double costoAdquisicion, double costoAlimentacion, double peso)
        {
            _idCaravana = idCaravana;
            _sexo = sexo;
            _raza = raza;
            _fechaNacimiento = fechaNacimiento;
            _costoAdquisicion = costoAdquisicion;
            _costoAlimentacion = costoAlimentacion;
            _peso = peso;
        }

        public void Validar() {
            ValidarRaza();
            ValidarCostoAdquisicion();
            ValidarCostoAlimentacion();
            ValidarPeso();
        }

        private void ValidarRaza() {
            if (string.IsNullOrEmpty(_raza)) throw new Exception("");
        }

        private void ValidarCostoAdquisicion() { 
        }

        private void ValidarCostoAlimentacion() { }

        private void ValidarPeso() { }




    }
}

                      
                     
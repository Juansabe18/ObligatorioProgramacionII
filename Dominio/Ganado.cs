

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
        private bool _esLibre = true;

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
            if (string.IsNullOrEmpty(_raza)) throw new Exception("La raza no puede quedar vacía");
        }

        private void ValidarCostoAdquisicion() {
            if (_costoAdquisicion <= 0) throw new Exception("Costo de adquisicion debe ser mayor a 0");
        }

        private void ValidarCostoAlimentacion() {
            if (_costoAlimentacion <= 0) throw new Exception("Costo de adquisicion debe ser mayor a 0");
        }


        private void ValidarPeso() { }




    }
}

                      
                     
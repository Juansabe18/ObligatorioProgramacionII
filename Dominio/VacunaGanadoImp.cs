

namespace Dominio
{
    public class VacunaGanadoImp
    {
        private Vacuna _vacuna;
        private DateTime _fechaRecibida;

        public VacunaGanadoImp(Vacuna vacuna, DateTime fechaRecibida) { 
            _vacuna = vacuna;
            _fechaRecibida = fechaRecibida;
        }

        public DateTime CalcularVencimiento() {
            DateTime fecha = _fechaRecibida.AddYears(1);
            return fecha;
        }

        public override string ToString()
        {
            return $"Vacuna dada: {_vacuna} fecha recibida: {_fechaRecibida}";
        }

    }
}

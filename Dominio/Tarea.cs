
namespace Dominio
{
    public class Tarea : IValidar
    {
        private int _id;
        private static int _contadorId;
        private string _descripcion;
        private DateTime _fechaPactada;
        private DateTime _fechaCierre;
        private bool _tareaCompletada = false;
        private string _comentario;

        public Tarea(string descripcion, DateTime fechaPactada, DateTime fechaCierre, string comentario) { 
            _descripcion = descripcion;
            _fechaPactada = fechaPactada;
            _fechaCierre = fechaCierre;
            _comentario = comentario;
            _id = _contadorId;
            _contadorId++;
        }

        public string Descripcion { get { return _descripcion; } }

        public DateTime FechaPactada { get {  return _fechaPactada; } }

        public DateTime FechaCierre { get { return _fechaCierre; } }

        public bool TareaCompletada { get { return _tareaCompletada; } }

        public string Comentario { get { return _comentario; } }


        public void Validar() {
            ValidarDescipcion();
            ValidarComentario();
            ValidarFecha();
        }       

        private void ValidarDescipcion() {
            if (string.IsNullOrEmpty(_descripcion)) throw new Exception("La descripcion no puede estar vacía");
        }

        private void ValidarComentario() {
            if (string.IsNullOrEmpty(_comentario)) throw new Exception("El comentario no puede estar vacío");
        }

        private void ValidarFecha() {
            if (_fechaCierre < _fechaPactada) throw new Exception("La fecha de cierre debe ser mayor que la fecha pactada");
        }

        public override string ToString()
        {
            return $"Id tarea: {_id} - Descripcion: {_descripcion} - Fecha Pactada: {_fechaPactada} - Fecha Cierre: {_fechaCierre} - Tarea completada: {_tareaCompletada} - Comentario: {_comentario}";
        }
    }
}

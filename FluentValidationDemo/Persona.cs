
namespace FluentValidationDemo
{
    public class Persona
    {
        public string Nombre { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Edad { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
    }
}

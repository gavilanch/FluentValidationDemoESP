using FluentValidation;

namespace FluentValidationDemo
{
    public class ValidacionesPersona: AbstractValidator<Persona>
    {
        public ValidacionesPersona()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El campo {PropertyName} es requerido");

            RuleFor(x => x.Email).EmailAddress();

            RuleFor(x => x.Edad).InclusiveBetween(18, 150);

            RuleFor(x => x.FechaInicial).Must((persona, _) =>
            {
                return persona.FechaInicial < persona.FechaFinal;
            }).WithMessage("La fecha inicial debe ser anterior a la fecha final");
        }
    }
}

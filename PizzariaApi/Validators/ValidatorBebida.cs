using FluentValidation;
using Pizzaria.Models;

namespace Pizzaria.Validators;

    public class ValidatorBebida : AbstractValidator<Tb_bebida> {
        public ValidatorBebida() {

            RuleFor(a => a.Id)
                .Null().WithMessage("Campo [Id] deve ser null");

            RuleFor(a => a.Nome_bebida)
                .NotEmpty().WithMessage("Nome inv�lido");

            RuleFor(a => a.Valor_bebida)
                .NotEmpty().WithMessage("Valor inv�lido");

            RuleFor(a => a.Descricao_bebida)
                .NotEmpty().WithMessage("Campo [Descricao] n�o pode estar vaz�o");

            RuleFor(a => a.Is_alcoolica)
                .NotNull().WithMessage("Campo [Is_alcoolica] n�o pode estar vaz�o");
        }
    }
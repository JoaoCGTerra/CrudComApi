using FluentValidation;
using Pizzaria.Models;

namespace Pizzaria.Validators {

    public class ValidatorFilial : AbstractValidator<Tb_filiais> {
        public ValidatorFilial() {

            RuleFor(a => a.Id)
                .Null().WithMessage("Campo [Id] deve ser null");

            RuleFor(a => a.Nome_filial)
                .NotEmpty().WithMessage("Nome inv�lido");

            RuleFor(a => a.Endereco_Filial)
                .NotEmpty().WithMessage("Endere�o inv�lido");

            RuleFor(a => a.Telefone_Filial)
                .NotEmpty().WithMessage("Campo [Telefone] n�o pode estar vaz�o");

            RuleFor(a => a.Descricao_filial)
                .NotEmpty().WithMessage("Campo [Descri��o] n�o pode estar vaz�o");
        }
    }
}
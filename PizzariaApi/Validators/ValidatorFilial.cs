using FluentValidation;
using Pizzaria.Models;

namespace Pizzaria.Validators {

    public class ValidatorFilial : AbstractValidator<Tb_filiais> {
        public ValidatorFilial() {

            RuleFor(a => a.Id)
                .Null().WithMessage("Campo [Id] deve ser null");

            RuleFor(a => a.Nome_filial)
                .NotEmpty().WithMessage("Nome inválido");

            RuleFor(a => a.Endereco_Filial)
                .NotEmpty().WithMessage("Endereço inválido");

            RuleFor(a => a.Telefone_Filial)
                .NotEmpty().WithMessage("Campo [Telefone] não pode estar vazío");

            RuleFor(a => a.Descricao_filial)
                .NotEmpty().WithMessage("Campo [Descrição] não pode estar vazío");
        }
    }
}
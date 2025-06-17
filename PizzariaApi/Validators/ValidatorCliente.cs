using FluentValidation;
using Pizzaria.Models;

namespace Pizzaria.Validators {

    public class ValidatorCliente : AbstractValidator<Tb_cliente> {
        public ValidatorCliente() {

            RuleFor(a => a.Nome_cliente)
                .NotEmpty().WithMessage("Nome inválido");

            RuleFor(a => a.Email_cliente)
                .NotEmpty().EmailAddress();

            RuleFor(a => a.Rua_cliente)
                .NotEmpty().WithMessage("Campo [Rua] não pode estar vazío");

            RuleFor(a => a.Numero_rua_cliente)
                .NotEmpty().WithMessage("Campo [Numero rua] não pode estar vazío");

            RuleFor(a => a.Cidade_cliente)
                .NotEmpty().WithMessage("Campo [Cidade] não pode estar vazío");

            RuleFor(a => a.Estado_cliente)
                .NotEmpty().WithMessage("Campo [Estado] não pode estar vazío");

            RuleFor(a => a.Cep_cliente)
                .NotEmpty().WithMessage("Campo [Cep] não pode estar vazío");

            RuleFor(a => a.Hash_senha_cliente)
                .NotEmpty().WithMessage("Campo [Hash] não pode estar vazío");

            RuleFor(a => a.Is_admin)
                .NotNull().InclusiveBetween(0, 1).WithMessage("Campo deve ser 0 ou 1");

        }
    }
}
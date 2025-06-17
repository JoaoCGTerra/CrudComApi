using FluentValidation;
using Pizzaria.Models;

namespace Pizzaria.Validators {

    public class ValidatorCliente : AbstractValidator<Tb_cliente> {
        public ValidatorCliente() {

            RuleFor(a => a.Nome_cliente)
                .NotEmpty().WithMessage("Nome inv�lido");

            RuleFor(a => a.Email_cliente)
                .NotEmpty().EmailAddress();

            RuleFor(a => a.Rua_cliente)
                .NotEmpty().WithMessage("Campo [Rua] n�o pode estar vaz�o");

            RuleFor(a => a.Numero_rua_cliente)
                .NotEmpty().WithMessage("Campo [Numero rua] n�o pode estar vaz�o");

            RuleFor(a => a.Cidade_cliente)
                .NotEmpty().WithMessage("Campo [Cidade] n�o pode estar vaz�o");

            RuleFor(a => a.Estado_cliente)
                .NotEmpty().WithMessage("Campo [Estado] n�o pode estar vaz�o");

            RuleFor(a => a.Cep_cliente)
                .NotEmpty().WithMessage("Campo [Cep] n�o pode estar vaz�o");

            RuleFor(a => a.Hash_senha_cliente)
                .NotEmpty().WithMessage("Campo [Hash] n�o pode estar vaz�o");

            RuleFor(a => a.Is_admin)
                .NotNull().InclusiveBetween(0, 1).WithMessage("Campo deve ser 0 ou 1");

        }
    }
}
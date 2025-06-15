namespace Pizzaria.Models {
    public class Tb_cliente {
        public int Id { get; set; }
        public required string Nome_cliente { get; set; }
        public required string Email_cliente { get; set; }
        public required string Rua_cliente { get; set; }
        public required string Numero_rua_cliente { get; set; }
        public required string Cidade_cliente { get; set; }
        public required string Estado_cliente { get; set; }
        public required string Cep_cliente { get; set; }
        public required string Hash_senha_cliente { get; set; }
        public required int Is_admin { get; set; }
    }
}
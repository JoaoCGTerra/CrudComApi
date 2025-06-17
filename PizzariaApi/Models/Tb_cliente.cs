namespace Pizzaria.Models {
    public class Tb_cliente {
        public int Id { get; set; }
        public string? Nome_cliente { get; set; }
        public string? Email_cliente { get; set; }
        public string? Rua_cliente { get; set; }
        public string? Numero_rua_cliente { get; set; }
        public string? Cidade_cliente { get; set; }
        public string? Estado_cliente { get; set; }
        public string? Cep_cliente { get; set; }
        public string? Hash_senha_cliente { get; set; }
        public int Is_admin { get; set; } = 0;
    }
}
namespace Pizzaria.Models {
    public class tb_cadastro_cliente {
        public int Id { get; set; }
        public string nome_cliente { get; set; }
        public string email_cliente { get; set; }
        public string rua_cliente { get; set; }
        public string numero_rua_cliente { get; set; }
        public string cidade_cliente { get; set; }
        public string estado_cliente { get; set; }
        public string cep_cliente { get; set; }
        public string hash_senha_cliente { get; set; }
        public string is_admin { get; set; }
    }
}
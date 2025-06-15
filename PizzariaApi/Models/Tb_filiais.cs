namespace Pizzaria.Models {
    public class Tb_filiais {
        public int Id { get; set; }
        public required string Nome_filial { get; set; }
        public required string Endereco_Filial { get; set; }
        public required string Telefone_Filial { get; set; }
        public required string Descricao_filial{ get; set; }
    }
}
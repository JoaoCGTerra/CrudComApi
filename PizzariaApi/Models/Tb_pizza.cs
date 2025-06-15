namespace Pizzaria.Models {
    public class Tb_pizza {
        public int Id { get; set; }
        public required string Nome_pizza { get; set; }
        public required float Valor_pizza { get; set; }
        public required string Descricao_pizza { get; set; }
        public required int Is_salgada { get; set; }
    }
}
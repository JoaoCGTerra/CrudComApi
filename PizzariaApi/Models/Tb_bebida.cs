namespace Pizzaria.Models {
    public class Tb_bebida {
        public int Id { get; set; }
        public required string Nome_bebida { get; set; }
        public required float Valor_bebida { get; set; }
        public required string Descricao_bebida { get; set; }
        public required int Is_alcoolica { get; set; }
    }
}
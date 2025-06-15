namespace Pizzaria.Models {
    public class Tb_sobremesa {
        public int Id { get; set; }
        public required string Nome_sobremesa { get; set; }
        public required float Valor_sobremesa { get; set; }
        public required string Rua_cliente { get; set; }
    }
}
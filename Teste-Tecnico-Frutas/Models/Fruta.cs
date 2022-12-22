using System.ComponentModel.DataAnnotations;

namespace Teste_Tecnico_Frutas.Models
{
    public class Fruta
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int A { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int B { get; set; }
        public double? Resultado { get; set; }
    }
}

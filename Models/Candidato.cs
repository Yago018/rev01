using System.ComponentModel.DataAnnotations;


namespace rev01.Models
{
    public class Candidato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Turma { get; set; }
        public string Descricao { get; set; }
        public int NumeroCandidato { get; set; }
    }
}
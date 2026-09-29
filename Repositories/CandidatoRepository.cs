using rev01.Models;

namespace rev01.Repositories
{
    public class CandidatoRepository
    {
        private static List<Candidato> ListaCandidato = new List<Candidato>();
        public void Cadastrar(Candidato candidato)
        {
            ListaCandidato.Add(candidato);
        }
    }
}
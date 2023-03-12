namespace InqueritoWeb.Models
{
    public class Repositorio
    {
        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta> Respostas { get { return respostas; } } // Nao permite remover ou editar
        public static void AdicionarResposta(Resposta resposta)
        {
            respostas.Add(resposta);
        }

        static Repositorio()
        {
            respostas.Add(new Resposta()
            { Nome = "Maria", Email = "maria@gmail.com", Sim = false });
            respostas.Add(new Resposta()
            { Nome = "José", Email = "jose@gmail.com", Sim = true });
            respostas.Add(new Resposta()
            { Nome = "João", Email = "joao@gmail.com", Sim = false });
        }
    }
}

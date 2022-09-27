namespace Project.NetCore.Models
{
    public class Batalha
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInicio { get; set; }
        //um Heroi tem vairas armas
        public List<Arma> armas { get; set; }
        public DateTime DtFim { get; set; }
        //agora um heroi esta para varias batalhas
        public List<HeroiBatalha> heroisBatalhas { get; set; }
    }
}

namespace Project.NetCore.Models
{
    public class Heroi
    //temos uma relação de heroi, batalha e armas
    //nossa arma é uma relação de um para um, qual é o heroi que tem uma determinada arma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        //colocando nossa identidade na nossa classe Heroi
        public IdentidadeSecreta Identidade { get; set; }

        //agora um heroi esta para varias batalhas
        public List<HeroiBatalha> heroisBatalhas { get; set; }


        // public Batalha Batalha { get; set; } //relação com batalha
        // public int BatalhaId { get; set; } //batalha q ele participou
    }
}

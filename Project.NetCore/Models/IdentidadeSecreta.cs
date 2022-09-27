namespace Project.NetCore.Models
{
    //relação de um para um 
    public class IdentidadeSecreta
    {
        public int Id { get; set; }
        public int nomeReal { get; set; }
        //colocando nosso relacionamento de Heroi aqui na classe
        public int HeroiId { get; set; }
        public int Heroi { get; set; } // não vamos colocar no pluras pq é só um heroi para cada armas
    }
}

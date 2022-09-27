namespace Project.NetCore.Models
{
    public class HeroiBatalha
    {
        //outro meio de criar muitos para muitos many to many
        //meu heroi vai estar em varias batalha
        public int HeroiId { get; set; }
        public Heroi Heroi { get; set; } //primeiro relacionamento
        public int BatalhaId { get; set; }
        public Batalha  Batalha { get; set; }
    }
}

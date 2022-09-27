using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Project.NetCore.Models
{
    
    public class Arma
    {
        //nossa arma é uma relação de um para um, qual é o heroi que tem uma determinada arma
      
        public int Id { get; set; }
        public string Name { get; set; }
        public Heroi Heroi { get; set; } // relação com heroi
        public int HeroiId { get; set; }

    }
}

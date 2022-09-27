﻿using Microsoft.EntityFrameworkCore;
using Project.NetCore.Models;

namespace Project.NetCore.Data
{
    public class HeroiContext : DbContext
    {
        //usamos o contexto para encpsular todas as nossas Entidades
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        //temos q informa ao entideFrameWorks que temos um muitos para muitos
        //temos que especificar uma chave composta
        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadeSecretas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=123456;Persist Security Info=True;User ID=javasim;Initial Catalog=HeroApp;Data Source=EUDES_GOMES");
        }

        //temos que especificar uma chave composta
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   /*estamos especificando para o entide oq ele tem q fazer no 
             banco de dados, ele temque considerar que essas duas chaves 
            a batalha e o heroi dentro de heroi batalha é a minha chave composta*/
            modelBuilder.Entity<HeroiBatalha>(entity =>
            {
                entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
            }); //modelBuilder, quem estamos recebendo como parametro
        }
    }
}

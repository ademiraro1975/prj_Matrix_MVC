using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities.Pizzaria;

namespace matriz.Infra.Data.Context
{
    public class PizzariaContext : DbContext
    {
        public PizzariaContext(DbContextOptions<PizzariaContext> options) : base(options) { }

        public virtual DbSet<FotoPizza> FotoPizzas { get; set; }
        public virtual DbSet<FotoRefrigerante> FotoRefrigerantes { get; set; }
        public virtual DbSet<Ingrediente> Ingredientes { get; set; }
        public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<PizzaDetalhe> PizzaDetalhes { get; set; }
        public virtual DbSet<PizzaIngrediente> PizzaIngredientes { get; set; }
        public virtual DbSet<Refrigerante> Refrigerantes { get; set; }
        public virtual DbSet<RefrigeranteDetalhe> RefrigeranteDetalhes { get; set; }
        public virtual DbSet<TabelaPreco> TabelaPrecos { get; set; }
        public virtual DbSet<Tamanho> Tamanhos { get; set; }
        public virtual DbSet<Tipo> Tipos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.UseCollation("Latin1_General_CI_AI");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PizzariaContext).Assembly);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace matriz.Core.Application.DTOs.Pizzaria
{
    public class PizzaDTO
    {
        public PizzaDTO()
        {
            _fotopizzas = new List<FotoPizzaDTO> { };
        }
        public PizzaDTO(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public PizzaDTO(int pizzaId, string nome, string descricao)
        {
            PizzaId = pizzaId;
            Nome = nome;
            Descricao = descricao;
        }

        public PizzaDTO(int pizzaId, int fotoPizzaId, string foto)
        {
            PizzaId = pizzaId;
            FotoPizzaId = fotoPizzaId;
            Foto = foto;
        }

        public int PizzaId { get; set; }

        public string Nome { get; set; } = null!;

        public string Descricao { get; set; } = null!;
        public int FotoPizzaId { get; set; }
        public string Foto { get; set; } = null!;

        public int TipoId { get; set; }

        public int TamanhoId { get; set; }
        public int TabelaPrecoId { get; set; }

        public int IngredienteId { get; set; }


        private List<FotoPizzaDTO> _fotopizzas;
        public List<FotoPizzaDTO> FotoPizzas
        {
            get
            {
                return _fotopizzas;
            }

            set
            {
                _fotopizzas = value;
            }
        }
    }
}
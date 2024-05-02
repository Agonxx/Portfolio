﻿namespace Restaurante.Shared.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo {  get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}

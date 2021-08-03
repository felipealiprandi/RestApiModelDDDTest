using System;

namespace RestApiModelDDD.Domain.Entities
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsActive { get; set; }
        public int id { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagerApi.Models
{
    public class BookModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; } = string.Empty;
        public DateTime DataPublicacao { get; set; }

        public BookModel(string nome, string genero, string autor)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Genero = genero;
            Autor = autor;
            DataPublicacao = DateTime.UtcNow;
        }
    }
}
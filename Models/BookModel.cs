using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagerApi.Models
{
    public class BookModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Nome não pode estar vazio!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Genero não pode estar vazio!")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O Autor não pode estar vazio!")]
        public string Autor { get; set; }
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
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megev.Domain.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Sobrenome { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Senha { get; set; }

        public decimal SaldoConta { get; set; }

        [StringLength(255)]
        public string UserImage { get; set; }

        public ICollection<Produto> Produtos { get; set; }

        public Usuario(string nome, string sobrenome, string email, string senha, decimal saldoConta, string userImage)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Senha = senha;
            SaldoConta = saldoConta;
            UserImage = userImage;
            Produtos = new List<Produto>();
        }
    }
}

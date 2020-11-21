﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório.")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo quantidade é obrigatório.")]
        [Range(1,10, ErrorMessage ="Valor fora da faixa. (1 à 10)")]
        public int Quantidade { get; set; }

        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}

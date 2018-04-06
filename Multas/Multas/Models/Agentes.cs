using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Agentes
    {
        //criar o construtor
        public Agentes() {
            ListaMultas = new HashSet<Multas>();
        }

        [Key]
        public int ID { get; set; } //chave primaria

        //dados do Agente
        [Required(ErrorMessage ="O {0} é de preenchimento obrigatório")]
        [RegularExpression("[A-ZÂÁÓÉÍ] [a-záéíóúàèìòùâêîôûãõçäëïöüñ]+(( | e | de | da | das | do | d'|-)[A-ZÂÁÓÉÍ] [a-záéíóúàèìòùâêîôûãõçäëïöüñ]+){1,3}", ErrorMessage ="O {0} só aceita letras. Cada nome deve começar por uma maiuscula seguida de minúsculas...")]
        [StringLength(40, ErrorMessage ="O {0} só aceita {1} caractéres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        public string Fotografia { get; set; }

        //local de trabalho do Agente
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        [RegularExpression("[A-Za-z0-9ç -]+", ErrorMessage ="Escreva um nome valido para a {0}")]
        public string Esquadra { get; set; }

        //Criar uma lista de multas
        //aplicadas pelo Agente
        // virtual - dados so sao carreados na memoria se necessario
        public virtual ICollection<Multas> ListaMultas { get; set; }

    }
}
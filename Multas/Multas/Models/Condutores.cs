﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Condutores
    {

        //criar o construtor
        public Condutores()
        {
            ListaMultas = new HashSet<Multas>();
        }

        public int ID { get; set; } //pk

        public string Nome { get; set; }

        public string BI { get; set; }

        public string Telemovel  { get; set; }

        public DateTime DataNascimento { get; set; }

        public string NumCartaConducao { get; set; }

        public string LocalEmissao { get; set; }

        public DateTime DataValidadeCarta { get; set; }

        //Criar uma lista de multas
        //aplicadas ao Condutor
        // virtual - dados so sao carreados na memoria se necessario
        public virtual ICollection<Multas> ListaMultas { get; set; }

    }
}
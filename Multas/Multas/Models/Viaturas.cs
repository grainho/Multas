using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Viaturas
    {

        //criar o construtor
        public Viaturas()
        {
            ListaMultas = new HashSet<Multas>();
        }

        public int ID { get; set; }


        //descrição da viatura
        public string Matricula { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        //descrição do dono da viatura
        public string NomeDono { get; set; }

        public string MoradaDono { get; set; }

        public string CodPostalDono { get; set; }

        //Criar uma lista de multas
        //aplicadas à viatura
        // virtual - dados so sao carreados na memoria se necessario
        public virtual ICollection<Multas> ListaMultas { get; set; }
    }
}
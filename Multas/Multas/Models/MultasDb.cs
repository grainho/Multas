﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class MultasDb : DbContext
    {

        //criar o construtor
        public MultasDb() :base("MultasDbConnectionString")
        { }

        //definir as 'tabelas da minha base de dados
        public virtual DbSet<Viaturas> Viaturas { get; set; }
        public virtual DbSet<Condutores> Condutores { get; set; }
        public virtual DbSet<Agentes> Agentes { get; set; }
        public virtual DbSet<Multas> Multas { get; set; }

        //nao esquecer de ir ao web.config criar uma refencia ah localizacao da bd
        //consala de gerenciador de pacote -> Enable-Migrations -EnableAutomaticMigrations -> Update-Database 

    }
}
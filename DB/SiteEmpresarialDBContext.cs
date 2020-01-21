using SiteEmpresarial.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SiteEmpresarial.DB
{
    public class SiteEmpresarialDBContext : DbContext
    {
        public static string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\di3909\\source\\repos\\SiteEmpresarial\\SiteEmpresarial\\App_Data\\SiteEmpresarialDB.mdf;Integrated Security=True";

        public SiteEmpresarialDBContext() : base(conexao)
        {

        }
        public DbSet<Contato> Contatos { get; set; }

    }
}
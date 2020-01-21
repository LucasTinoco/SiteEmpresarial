using SiteEmpresarial.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace SiteEmpresarial.Classes
{
    public static class RotinasWeb
    {
        public static void ContatoGravar(Contato contato)
        {
            string arquivo = HttpContext.Current.Server.MapPath("~/App_Data/Contatos.txt");
            using (var sw = new StreamWriter(arquivo,true, Encoding.UTF8))
            {
                sw.WriteLine(DateTime.Now);
                sw.WriteLine(contato.Nome);
                sw.WriteLine(contato.Email);
                sw.WriteLine(contato.Assunto);
                sw.WriteLine(contato.Mensagem);
                sw.WriteLine(new string('-', 30));
            }
        }
    }
}
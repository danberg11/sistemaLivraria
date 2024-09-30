using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sistemaLivraria.Model
{
    internal class Conexao ()
    {
          public static string Conectar()
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\daniel.bnoliveira\source\repos\sistemaLivraria\sistemaLivraria\Dados\bdlivraria.mdf;Integrated Security=True";
            }
        }
    }


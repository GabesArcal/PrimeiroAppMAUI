using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    class Pessoa
    {
        // Esse public é para que as outras páginas possam ver a lista de pessoas, e o static serve para que quando trocar de página as infor
        public static List<Pessoa> lista = new List<Pessoa>();

        //flot é usado para número quebrado e int para número inteiro
        public string nome { get; set; }
        public int idade { get; set; }
        
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasseMetodo.Classes
{
    /// <summary>
    /// exemplo de classe concreta
    /// </summary>
    internal class Carro
    {
        /// <summary>
        /// exemplo de declaração de variáveis
        /// de escopo global
        /// </summary>
        //public string _marca;
        //public string _modelo;
        private string _marca;
        private string _modelo;

        /// <summary>
        /// Método construtor
        /// contendo as variaveis marca e modelo de escopo local,
        /// ou seja, existem apenas no método construtor
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        public Carro(string marca, string modelo) 
        {
            _marca = marca;
            _modelo = modelo;
        }

        /// <summary>
        /// Exemplo de método
        /// </summary>
        public void Ligar()
        {
            Console.WriteLine($"Carro {_marca} - {_modelo}: Ligado");
        }
    }
}

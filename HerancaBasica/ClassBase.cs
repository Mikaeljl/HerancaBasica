﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaBasica
{
    public class Animal
    {
        public string Nome {  get; set; }

        public void Comer()
        {
            Console.WriteLine($"{Nome} esta comendo");

        }



    }
}

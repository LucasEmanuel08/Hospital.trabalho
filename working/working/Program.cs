﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente p1 = new Paciente();

            p1.cadastrarPaciente();

            Console.ReadKey();
        }
    }
}

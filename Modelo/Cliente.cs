﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string fone { get; set; }
        public DateTime nascimento { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaLivraria.Model
{
    internal class ItensPedido
    {
        private static int codigoItensPed;
        private static int codigoLivFK;
        private static int qtdItensPed;
        private static decimal totalItensPed;

        public static int CodigoItensPed { get => codigoItensPed; set => codigoItensPed = value; }
        public static int CodigoLivFK { get => codigoLivFK; set => codigoLivFK = value; }
        public static int QtdItensPed { get => qtdItensPed; set => qtdItensPed = value; }
        public static decimal TotalItensPed { get => totalItensPed; set => totalItensPed = value; }
    }
}

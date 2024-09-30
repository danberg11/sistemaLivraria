using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaLivraria.Model
{
    internal class Pedidos
    {
        private static int codigoPed;
        private static int codigoItenspedFK;
        private static DateTime dataPed;
        private static decimal valortotalPed;
        private static int codigoCliFK;
        private static int codigoFunFK;
        private static int situacaoPed;

        public static int CodigoPed { get => codigoPed; set => codigoPed = value; }
        public static int CodigoItenspedFK { get => codigoItenspedFK; set => codigoItenspedFK = value; }
        public static DateTime DataPed { get => dataPed; set => dataPed = value; }
        public static decimal ValortotalPed { get => valortotalPed; set => valortotalPed = value; }
        public static int CodigoCliFK { get => codigoCliFK; set => codigoCliFK = value; }
        public static int CodigoFunFK { get => codigoFunFK; set => codigoFunFK = value; }
        public static int SituacaoPed { get => situacaoPed; set => situacaoPed = value; }
    }
}

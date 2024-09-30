using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaLivraria.Model
{
    internal class Estoques
    {
        private static int codigoEst;
        private static int codigoLivEst;
        private static int qtdEst;
        private static int tipoSituacao;
        private static int qtdSituacao;
        private static DateTime dataSituacao;
        private static int codigoFunFK;

        public static int CodigoEst { get => codigoEst; set => codigoEst = value; }
        public static int CodigoLivEst { get => codigoLivEst; set => codigoLivEst = value; }
        public static int QtdEst { get => qtdEst; set => qtdEst = value; }
        public static int TipoSituacao { get => tipoSituacao; set => tipoSituacao = value; }
        public static int QtdSituacao { get => qtdSituacao; set => qtdSituacao = value; }
        public static DateTime DataSituacao { get => dataSituacao; set => dataSituacao = value; }
        public static int CodigoFunFK { get => codigoFunFK; set => codigoFunFK = value; }
    }
}

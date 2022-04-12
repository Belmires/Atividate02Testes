using System;
using Xunit;

namespace SuperCodigo.TestesUnidade
{
    public class OperacoesTeste
    {
        [Theory]
        [InlineData("ISOSCELES", 2, 2, 3)]
        [InlineData("ESCALENO", 4, 2, 3)]

        [InlineData("ISOSCELES", 2, 3, 3)]
        [InlineData("EQUILATERO", 2, 2, 2)]
        [InlineData("INEXISTENTE", 2, 5, 2)]
        [InlineData("INEXISTENTE", 2, -5, 2)]
        public void verificarDeterminarTipoTriangulo(String expectativa, int v1, int v2, int v3)
        {

            Assert.Equal(expectativa, Operacoes.DeterminarTipoTriangulo(v1, v2, v3));

        }

        [Theory]
        [InlineData("Cadeia Inválida.", "", "s")]
        [InlineData("Caractere inválido.", "ssddfbd", "ssd")]
        public void verificarObterPosicaoCaractere(String exception, String cadeiaValor, String caractereValor)
        {
            var erro = new ArgumentException(exception);
            var result = Assert.Throws<ArgumentException>(()  => Operacoes.ObterPosicaoCaractere(cadeiaValor, caractereValor));
            Assert.Equal(erro.Message, result.Message);

        }

        [Theory]
        [InlineData(3, "dbsfdb", "s")]
        [InlineData(-1, "dbsfdb", "g")]
        public void verificarObterPosicaoCaractere2(int esperado, String cadeiaValor, String caractereValor)
        {
            
            int result = Operacoes.ObterPosicaoCaractere(cadeiaValor, caractereValor);
            Assert.Equal(esperado.ToString(), result.ToString());

        }

        [Theory]
        [InlineData("n deve ser maior que zero.", 0)]
        public void verificarObterElementoFibonnaci(String exception, int nValor)
        {
            var erro = new ArgumentException(exception);
            var result = Assert.Throws<ArgumentException>(() => Operacoes.ObterElementoFibonnaci(nValor));
            Assert.Equal(erro.Message, result.Message);

        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(5, 5)]
        public void verificarObterElementoFibonnaci2(int esperado, int nValor )
        {

            Assert.Equal(esperado.ToString(), Operacoes.ObterElementoFibonnaci(nValor).ToString());

        }


    }
}
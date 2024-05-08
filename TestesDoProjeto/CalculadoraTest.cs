using System.Security.Cryptography.X509Certificates;
using TDD;

namespace TestesDoProjeto
{
    public class TestesDoProjet
    {
        private readonly Calculadora _calcValidation;

        public  Calculadora ConstruirClasse() 
        {
            string data = "02/02/2024";
            Calculadora _calc = new Calculadora(data);
            return _calc;
        }

        public TestesDoProjet()
        {
            this._calcValidation = this.ConstruirClasse();
        }

        [Theory]
        [InlineData(10, 5, 15)]
        public void Somar10Com5Retornar15(int n1, int n2, int inlineResultado)
        {

            //Arguments 
            //int n1 = 10; // Vem por o inline data 
            //int n2 = 5;  // Vem por Inline Data

            //Act
            int resultado = _calcValidation.Somar(n1, n2);

            //Assert
            Assert.Equal(inlineResultado, resultado);
        }

        [Theory]
        [InlineData(1,10)]
        [InlineData(2,9)]
        [InlineData(3,8)]
        [InlineData(4,7)]
        [InlineData(5,6)]
        public void Somar2NumerosQueResultaEm11(int n1, int n2)
        {
           // Argumnets // Já passados
           // 
           //Act
            int resultado = _calcValidation.Somar(n1, n2);

            //Asset
            Assert.Equal(11, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {

            //Execepion em Test
            Assert.Throws<DivideByZeroException>(() => _calcValidation.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            _calcValidation.Somar(2, 4);
            _calcValidation.Somar(4, 6);
            _calcValidation.Somar(3, 8);
            _calcValidation.Somar(5, 1);

            var lista = _calcValidation.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

    }
}
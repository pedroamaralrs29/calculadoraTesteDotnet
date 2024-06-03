using Calculadora.Services;

namespace CalculadoraTeste;

public class CalculadoraTestes
{

    private CalculadoraImplementacao _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImplementacao();
    }
    [Fact]
    public void DeveSomar1Com1ERetornar2()
    {
        // Arrange
        int num1 = 1;
        int num2 = 1;
        // Act
        int resultado = _calc.Somar(num1, num2);
        // Assert
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;
        // Act
        int resultado = _calc.Somar(num1, num2);
        // Assert
        Assert.Equal(20, resultado);
    }

    [Fact]

    public void DeveVerificarSe4EhPar()
    {
    //Arrange
    int num = 4;
    //Act
    bool resultado = _calc.ehPar(num);
    //Assert
    Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] {2,4,6})]
    [InlineData(new int[] {6,8,10})]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        //Act /Assert
        Assert.All(numeros, num => Assert.True(_calc.ehPar(num)));
    }

    [Theory]
    [InlineData(4,2,2)]
    [InlineData(6,3,2)]
    public void TesteDeDivisao(int num1, int num2, int resultado)
    {
    //Arrange //Act
    int resultadoCalculadora = _calc.Dividir(num1, num2);
    //Assert
    Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]

    public void TesteDivisaoPorZero()
    {
        //Arrange
        int num1 = 4;
        int num2 = 0;

        //Act // Assert
        Assert.Throws<DivideByZeroException>(()=> _calc.Dividir(num1, num2));
    }

    [Theory]
    [InlineData(3,3,9)]
    [InlineData(5,5,25)]
    public void TesteDeMultiplicacao(int num1, int num2, int resultado)
    {
        //Arrange // Act
        int resultadoCalculadora = _calc.Multiplicar(num1, num2);
        //Assert
        Assert.Equal(resultado,resultadoCalculadora);
    }

    [Theory]
    [InlineData(4,2,2)]
    [InlineData(10,5,5)]
    public void TesteSubtracao(int num1, int num2, int resultado)
    {
        //Arrange //Act
        int resultadoCalculadora = _calc.Subtrair(num1, num2);
        //Assert
        Assert.Equal(resultado,resultadoCalculadora);
    }
}

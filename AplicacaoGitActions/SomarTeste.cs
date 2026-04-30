using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AplicacaoGitActions
{
    internal class SomarTeste
    {
        [Fact]
        public void Somar_DoisNumeros_RetornaSoma()
        {
            // Arrange
            var calculadora = new Calculador();
            int numero1 = 6;
            int numero2 = 15;
            // Act
            int resultado = calculadora.Somar(numero1, numero2);
            
            Assert.Equal(21, resultado);
        }

    }
}

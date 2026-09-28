using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuPrimeiroTeste.App; 

namespace MeuPrimeiroTeste.Tests
{
    public class HelloWorldServiceTests
    {
        [Fact]
public void GerarSaudacao_DeveRetornarSaudacaoPadrao_QuandoNomeForNuloOuVazio()
{
// Arrange (Preparação)
var service = new HelloWorldService();
// Act (Ação)
var resultado = service.GerarSaudacao(null);
// Assert (Verificação)
Assert.Equal("Hello World!", resultado);
}
    }
}
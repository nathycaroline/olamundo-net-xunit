# olamundo-net-xunit

Projeto de estudo em **C# / .NET** que demonstra um serviço simples de saudação ("Hello World") e seus **testes unitários** com xUnit, seguindo o padrão **AAA (Arrange, Act, Assert)**.

## 📁 Estrutura do projeto

```
OlaMundoNet/
├── MeuPrimeiroTeste.App/            # Aplicação principal
│   ├── HelloWorldService.cs         # Serviço que gera a saudação
│   ├── Program.cs                   # Ponto de entrada
│   └── MeuPrimeiroTeste.App.csproj
├── MeuPrimeiroTeste.Tests/          # Projeto de testes
│   ├── HelloWorldServiceTests.cs    # Testes do HelloWorldService
│   ├── UnitTest1.cs
│   └── MeuPrimeiroTeste.Tests.csproj
├── MeuPrimeiroTeste.slnx            # Solução
├── .gitignore
├── LICENSE
└── README.md
```

## 🚀 Tecnologias

- C#
- .NET
- xUnit (testes unitários)
- Git / GitHub
- Visual Studio Code

## ✅ Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado (versão compatível com os `.csproj` do projeto)
- Git

Para conferir a instalação:

```bash
dotnet --version
```

## ▶️ Como executar

Clone o repositório e entre na pasta:

```bash
git clone <url-do-repositorio>
cd OlaMundoNet
```

Compile a solução:

```bash
dotnet build
```

Execute a aplicação:

```bash
dotnet run --project MeuPrimeiroTeste.App
```

## 🧪 Como rodar os testes

```bash
dotnet test
```

### Exemplo de teste

O teste abaixo verifica que o serviço retorna a saudação padrão quando o nome é nulo ou vazio:

```csharp
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
```


## 📄 Licença

Este projeto está sob a licença descrita no arquivo [LICENSE](LICENSE).

## 👩‍💻 Autora

**Nathaly Caroline**

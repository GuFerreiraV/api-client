# ClientAPI .NET 8 (WPF)

Este é um projeto simples de **Client API** (semelhante a um Postman simplificado) desenvolvido em **WPF** com **.NET 8**, utilizando o padrão **MVVM** e **Injeção de Dependência**.

## Sobre o Código

> **Arquitetura MVVM (Model-View-ViewModel)**
> O projeto separa a interface gráfica (`MainWindow.xaml`) da lógica de negócios (`MainViewModel`), facilitando testes e manutenção.
> A comunicação entre a View e a ViewModel é feita através de **Data Binding** e **Commands** do pacote `CommunityToolkit.Mvvm`.

> **Injeção de Dependência (DI)**
> Utilizamos o `Microsoft.Extensions.Hosting` para configurar um contêiner de DI.
> O `App.xaml.cs` remove o fluxo padrão do WPF (`StartupUri`) e inicializa manualmente a janela, injetando o `HttpClientFactory` e a `MainViewModel` necessários.

> **Interface Gráfica (Material Design)**
> A UI é construída com o pacote `MaterialDesignThemes` para um visual moderno.
> Recursos como `Converters` (ex: `InverseBoolConverter`) são usados para controlar a visibilidade e habilitação de elementos dinamicamente (bloquear botão durante requisição).

> **Http Client**
> As requisições são feitas usando `IHttpClientFactory`, que é uma prática recomendada em .NET para gerenciar instâncias de `HttpClient` de forma eficiente, evitando exaustão de sockets.

## Instalação e Execução

Para rodar este projeto, você precisará do **.NET 8 SDK** instalado.

1. Clone o repositório:
```bash
git clone <url-do-repositorio>
cd ClientAPI
```

2. Instale as dependências:
> O projeto utiliza os seguintes pacotes NuGet:
```bash
dotnet add package MaterialDesignThemes
dotnet add package CommunityToolkit.Mvvm
dotnet add package Microsoft.Extensions.Hosting
dotnet add package Microsoft.Extensions.Http
```

3. Compile e execute o projeto:
```bash
dotnet build
dotnet run --project ClientAPI
```

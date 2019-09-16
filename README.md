# projetoIntegrador2019_webapi
Projeto de auxilio a criacao de web api para o projeto integrador ministrado na FGP

Irá ser criado um projeto webapi e será utilizado o projetoprojetoIntegrador2019_ef como base de geração de classes baseada em Code First.

## Para Saber mais

Pesquise sobre os conceitos envolvidos neste hands-on.

- APIs REST
- Protocolo HTTP
- Ingestão de Dependência (DI)
- Padrão de projeto Repository

### Softwares necessários:
- .Net Core 2.2
- Visual Studio Code
- Plugins:
    - C# for Visuaal Sudio Code (powered by OminSharp)
    - C# IDE Extensions (jchannon)
- MS SQL Server, MySQL ou SQLite 
- Cliente de acesso ao BD de sua escolha
- Postman (https://www.getpostman.com/downloads/)
- SQLite Gerenciador (https://sqlitebrowser.org/dl/)

### Etapas para rodar o projeto a partir desse repositório:

Na pasta do projeto, digite:
>  -  dotnet restore
> -   dotnet ef database update (Efetua o versionamento no banco, gerando/alterando as tabelas)
>  -  dotnet build
>  -  dotnet run


### Etapas de criaçao do projeto do ZERO:

#### (Aula 1 - EAD) Seguir a sequência de passos: 

1. Criar um novo projeto webapi:
Na pasta do projeto, digite:
> -    dotnet new webapi --no-https 

Veja que o dotnet cria automaticamente uma estrutura própria de API incluindo um controller que já pode ser testado.

Digite:
> -    code .           (Para abrir o projeto no Visual Studio Code)

2. No terminal, digitar:
> -    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
> -    dotnet add package Microsoft.EntityFrameworkCore.Sqlite
> -    dotnet add package Microsoft.EntityFrameworkCore.Tools 

    Será adicionado o driver do banco MSSQL Server e a lib de geração de entidades do .net core, respectivamente.

3. No terminal, digitar:
> -    dotnet restore    - (opcional) util para baixar dependências (libs)
> -    dotnet build      - (opcional) Verifica se há um erro de código
e
> -    dotnet run        - para rodar o projeto

Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.

Abra o endereço http://localhost:5000/api/values no browser e veja a aplicação web rodando.
Pressione Ctrl+C para parar o servidor Web sempre que necessário.

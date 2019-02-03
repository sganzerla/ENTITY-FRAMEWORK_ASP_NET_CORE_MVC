# ASP_NET_CORE-ENTITY-FRAMEWORK

Comandos pelo terminal

Criando Solução 
"dotnet new sln"

Criando projeto MVC
"dotnet new mvc -o MVC"

Adicionando projeto a solução
"dotnet sln add .\MVC\MVC.csproj"

Criando projeto com biblioteca de classes p/ domínio
"dotnet new classlib -o Dominio"

Adicionando projeto a solução
"dotnet sln add .\Dominio\Dominio.csproj"

Criando projeto de biblioteca de classes p/ dados
"dotnet new classlib -o Dados"

Adicionando projeto a solução
"dotnet sln add .\Dados\Dados.csproj"

Build da solução
"dotnet build"

Adicionando dependências dentro projeto Dados
"cd .\Dados\"

  EntityFramework Core 
  "dotnet add package Microsoft.EntityFrameworkCore"

  Driver do SQLSERVER
  "dotnet add package Microsoft.EntityFrameworkCore.SqlServer"

  Tools
  "dotnet add package Microsoft.EntityFrameworkCore.Tools"
  
  Adicionando referência do projeto Domínio dentro do projeto Dados
  "dotnet add reference ../Dominio/Dominio.csproj"

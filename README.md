# Desenvolvimento_de_Software_Visual_Projeto_1

Repositório para o Projeto 1 das aulas de DDS visual.

## Sobre o Projeto

Este projeto é uma aplicação ASP.NET Core com uma API para gerenciar serviços e áreas de atuação, desenvolvido para as aulas de Desenvolvimento de Software Visual (DDS). Ele utiliza `Entity Framework Core` para manipulação de dados e `SQLite` como banco de dados.

## Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Ferramentas de CLI do `Entity Framework Core`:
`dotnet tool install --global dotnet-ef`

## Executando o Projeto

Siga os passos abaixo para executar o projeto:

1. **Atualizar o Banco de Dados**: Crie e aplique as migrações para atualizar o banco de dados;

`dotnet ef database update`

2. **Compilar o Projeto**: Compile o código para verificar se não há erros:
`dotnet build`

3. **Executar o Projeto**: Inicie a aplicação:
`dotnet run`


4. **Acessar a Aplicação**: Depois de iniciar o projeto, a aplicação estará disponível em:
`http://localhost:5000/`

## Endpoints da API

> **Nota**: Até o momento, os endpoints estão disponíveis apenas em `/api/`.

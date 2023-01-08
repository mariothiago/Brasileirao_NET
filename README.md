<h1 align="center"> API Brasileirão </h1>
API para cadastro, visualização de palpites e partidas do campeonato Brasileiro.

## 💻 Pré-requisitos

Antes de começar, verifique se você atendeu aos seguintes requisitos:
* SDK 7.0 do Microsoft .NET instalada
* Visual Studio 2022 ou Visual Studio Coode

## 🚀 Clonando projeto na sua máquina
Para clonar o repositório em sua máquina local, abra o git bash na pasta desejada e execute o comando git clone https://github.com/mariothiago/Brasileirao_NET.git

## :arrow_forward: Executando projeto na sua máquina
Utilizando o Visual Studio (Backend):
- Após clonar o repositório em sua máquina local, abra a pasta backend e nela clique duas vezes na solution Brasileirao_NET.sln
- No visual studio, procure a barra de executável do projeto (provavelmente estará setado para IIS Express com padrão)
- Altere o projeto para Brasileirao.API.
- Execute e a página do swagger irá abrir automaticamente na porta 5001.

## :triangular_ruler: Arquitetura da API
Foi usada a arquitetura DDD para construção da API.

## 🛠 Tecnologias utilizadas
- [.NET 7.0](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [ASPNET Core](https://dotnet.microsoft.com/en-us/apps/aspnet)
- Dapper - ORM
- [MySql](https://www.mysql.com/)
- [Swagger](https://swagger.io/)

## :game_die: Modelagem de Dados
Utilizando o modelo entidade-relacionamento, foi utilizado o banco de dados MySql

## 📝 Sobre o projeto
Esse projeto tem como objetivo desenvolver um sistema para vsualizar e cadastrar palpites e partidas do campeonato brasileiro. 

Andamento do que foi desenvolvido e do que ainda será desenvolvido:
- [x] Criação de partidas por rodada
- [x] Criação de palpites
- [x] Buscar partidas por rodada
- [x] Buscar palpites por rodada
- [ ] Login para cadastro de usuários

Integrante: André Coelho Solér - RM98827

🌐 FutureOfWork API
API RESTful para gerenciamento de Trabalhadores e Vagas – Global Solution FIAP

Este repositório contém uma API completa construída em C# .NET 8, seguindo boas práticas de arquitetura, versionamento de rotas, integração com banco de dados SQL Server e testes via Swagger.

A API foi desenvolvida para gerenciar dois recursos principais:

Workers (Trabalhadores)

Jobs (Vagas de Emprego)

🚀 Tecnologias Utilizadas

C# .NET 8

ASP.NET Core Web API

Entity Framework Core

SQL Server Express

Swagger (OpenAPI) para testes

Visual Studio Code

📌 Funcionalidades
🔹 Workers (V1 e V2)

A API permite:

Criar novo trabalhador

Listar trabalhadores

Buscar por ID

Atualizar trabalhador

Excluir trabalhador

🔹 Jobs (V1)

A API permite:

Criar vagas

Listar vagas

Buscar vaga por ID

Atualizar vaga

Excluir vaga

🗂 Estrutura das Rotas
📍 Workers – Versão 1 (V1)
Método	Rota	Descrição
GET	/api/v1/Workers	Lista todos os trabalhadores
GET	/api/v1/Workers/{id}	Busca trabalhador por ID
POST	/api/v1/Workers	Cria trabalhador
PUT	/api/v1/Workers/{id}	Atualiza trabalhador
DELETE	/api/v1/Workers/{id}	Remove trabalhador
🧪 Exemplo de JSON – POST Worker
{
  "name": "Carlos Almeida",
  "email": "carlos@gmail.com",
  "mainSkill": "Python",
  "preferredWorkMode": "Remoto",
  "yearsOfExperience": 5
}

📍 Workers – Versão 2 (V2)

A versão 2 retorna informações detalhadas, incluindo os Jobs relacionados ao Worker.

Método	Rota	Descrição
GET	/api/v2/Workers	Lista trabalhadores com seus Jobs
GET	/api/v2/Workers/{id}	Busca trabalhador com Jobs
📍 Jobs – Versão 1
Método	Rota	Descrição
GET	/api/v1/Jobs	Lista todas as vagas
GET	/api/v1/Jobs/{id}	Busca vaga por ID
POST	/api/v1/Jobs	Cria vaga
PUT	/api/v1/Jobs/{id}	Atualiza vaga
DELETE	/api/v1/Jobs/{id}	Remove vaga
🧪 Exemplo de JSON – POST Job
{
  "title": "Analista de Dados",
  "company": "TechFlow",
  "workMode": "Remoto",
  "requiredSkill": "SQL, Power BI",
  "salaryFrom": 3500.00,
  "salaryTo": 7000.00,
  "workerId": null
}

🛢 Banco de Dados

A aplicação utiliza:

SQL Server Express (localdb ou SQLEXPRESS)

Migrations geradas via EF Core

Estrutura básica das tabelas:

🧱 Workers
Campo	Tipo
Id	int
Name	string
Email	string
MainSkill	string
PreferredWorkMode	string
YearsOfExperience	int
🧱 Jobs
Campo	Tipo
Id	int
Title	string
Company	string
WorkMode	string
RequiredSkill	string
SalaryFrom	decimal
SalaryTo	decimal
WorkerId	int?
▶️ Como Executar o Projeto
1️⃣ Clonar repositório
git clone https://github.com/andre-soler/global-solution-c--git

2️⃣ Restaurar pacotes
dotnet restore

3️⃣ Aplicar migrations
dotnet ef database update

4️⃣ Executar API
dotnet run

5️⃣ Acessar Swagger

👉 http://localhost:5046/swagger

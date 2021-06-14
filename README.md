# Music-API
A Restful API to fetch and input data about Songs. Built with .NET 6.0 and C#.

# Projeto DotNet 6.0 Crud
Este projeto foi construído como uma segunda etapa para aprender e desmistificar como o 
Backend funciona nos bastidores em uma arquitetura RESTful. Esta API só aceita solicitações GET e POST 
e não tem autenticação, então todos que encontrarem isso, podem simplesmente testar sua usabilidade
e obter um melhor entendimento da infraestrutura RESTful. Bem, como eu disse, a API só aceita métodos 
GET e POST, então é apenas um CR de um aplicativo CRUD.
O motivo:para que não seja excuídos os dados ja inseridos.

# Dependências
- Azure.Core
- Azure.Storage.Blobs
- Microsoft.Azure.Storage.Blob
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Swashbuckle.AspNetCore

# Crie o LocalDB digitando os comandos:
- Add-Migration InitialMigration

- Update-Database

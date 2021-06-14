# Music-API
A Restful API to fetch and input data about Songs. Built with .NET 6.0 and C#.

# Projeto DotNet 6.0 Crud
Este projeto foi constru�do como uma segunda etapa para aprender e desmistificar como o 
Backend funciona nos bastidores em uma arquitetura RESTful. Esta API s� aceita solicita��es GET e POST 
e n�o tem autentica��o, ent�o todos que encontrarem isso, podem simplesmente testar sua usabilidade
e obter um melhor entendimento da infraestrutura RESTful. Bem, como eu disse, a API s� aceita m�todos 
GET e POST, ent�o � apenas um CR de um aplicativo CRUD.
O motivo:para que n�o seja excu�dos os dados ja inseridos.

# Depend�ncias
- Azure.Core
- Azure.Storage.Blobs
- Microsoft.Azure.Storage.Blob
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Swashbuckle.AspNetCore

# Crie o LocalDB digitando os comandos:
- Add-Migration InitialMigration

- Update-Database

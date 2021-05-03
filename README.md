# AspNetCoreWebAPI
Projeto do Curso de Formação para Dev Full Stack

Entity Framework Core net5.0

Para rodar a aplicação, basta que você navegue até a pasta SuperMarket.API, via terminal e digite "dotnet run" ou "dotnet watch run".
Use um verificador de rotas, aqui usei o Postman com as rotas: 

http://localhost:5000/api/authentication
http://localhost:5000/api/purchase
http://localhost:5000/api/product
http://localhost:5000/api/company
 
 Nas rotas de purchase,product e company, não esqueça de estabelecer uma Key e Value no Headers.
 Em Key coloque Authorization e em Value coloque Bearer com o token que foi gerado.
 Exemplo para Value : Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6(...).

Projeto Loja do seu Manoel

Commando para rodar o projeto 

bash start.sh

abrir localhost na rota a seguir

Rota: http://localhost:5122/swagger/index.html

Via Docker

comando para dar build do docker:

docker build -t loja-seu-manoel -f Loja.WebApi/Dockerfile .

comando para criar imagem da aplicação:

docker run -d -p 5122:5122 --name loja-seu-manoel-api loja-seu-manoel

abrir localhost na rota a seguir

Rota: http://localhost:5122/swagger/index.html
# Projeto Loja do seu Manoel

O projeto foi elaborado usando principíos da **Clean Arch** e **DDD** em cima do **.Net Core 8**.

*Demorei um pouco pra pensar se seguia o caminho das APIs tradicionais ou se seguiria o projeto por Minimal API, pois na minha cabeça o projeto da loja cabia em uma Minimal API. <br /><br />... Porém, todavia, entretanto,...<br /><br /> Optei pelo caminho tradicional.* 😀​

A camada de aplicação usa os pacotes **AutoMapper** e **FluentValidation**.

A camada de persistencia eu criei, mas acabei **NÃO** persistindo os dado por conta do tempo.

A camada de teste possui os pacotes **Moq**, **Xunit**, **FluentAssertions** e **AutoFixture**.

A camada de apresentação possui o pacote **Swagger** para documentar as rotas da API

## Commando para rodar o projeto 

### Via Bash
```
bash start.sh

abrir localhost na rota a seguir

Rota: http://localhost:5122/swagger/index.html
```
### Via Docker
```
comando para dar build do docker:

docker build -t loja-seu-manoel -f Loja.WebApi/Dockerfile .

comando para criar imagem da aplicação:

docker run -d -p 5122:5122 --name loja-seu-manoel-api loja-seu-manoel

abrir localhost na rota a seguir

Rota: http://localhost:5122/swagger/index.html
```
----

*OBS 1: O arquivo Dockerfile se encontra dentro do projeto de api.*


*OBS 2: Fica o meu agradecimento por participar do processo seletivo, foi bem desafiador e me diverti e me estressei bastante com ele.*



*Atenciosamente: **RMG***

----
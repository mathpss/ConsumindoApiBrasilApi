# 📦 Consumindo Api de 3° - BrasilApi

Projeto desenvolvido para o aprendizado de como consumir uma api, o projeto foi feito em conjunto com o [vídeo](https://www.youtube.com/watch?v=Xl9VYiUSArU&t=1987s).

## 🧪 Como Executar o Projeto Localmente

### Clone o repositório
```
git clone https://github.com/mathpss/ConsumindoApiBrasilApi.git
```
### Navegue até o diretório do projeto
```
cd ConsumindoApiBrasilApi
```
### Restaure os pacotes
```
dotnet restore
```
### Rode a aplicação
```
dotnet run
```

## 🌐 Swagger API

Acesse ``` http://localhost/swagger/index.html ``` para visualizar a documentação interativa da API.

## 📦 Endpoints

GET ``` /api/v1/Banco/busca/todos ``` Trazer uma lista com o nome de todos os bancos.

GET ``` /api/v1/Banco/busca/{codigoBanco}``` Trazer um banco baseado no seu código.

- exemplo: ``` /api/v1/Banco/busca/70 ```

  GET ``` /api/v1/Endereco/busca/{cep} ``` Trazer dados do CEP informado.

  - exemplo: ``` /api/v1/Endereco/busca/13454001 ```

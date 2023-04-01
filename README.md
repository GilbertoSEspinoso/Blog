# Documentação da API
Este repositório contém a implementação de uma API para um blog, que permite gerenciar Categorias e Posts.

## API BaltaBlog:
Para acessar esse projeto clique nesse link: http://webappblogbalta2812.azurewebsites.net/

## Endpoints

### Categories

***`GET /v1/categories`*** 

*Retorna uma lista com todas as categorias cadastradas.*

***Parâmetros***

* Nenhum

***Exemplo de resposta:***


```json
   {
      "success": true,
      "data": [
        {
          "id": 1,
          "name": "Tecnologia",
          "slug": "tecnologia"
        },
        {
          "id": 2,
          "name": "Esportes",
          "slug": "esportes"
        }
      ]
   }  

```

***`GET /v1/categories/{id}`***

*Retorna os detalhes de uma categoria específica através do número do Id fornecido.*

***Parâmetros:***

* id (obrigatório): ID da categoria a ser consultada.

Exemplo de resposta:

```json
   {
      "success": true,
      "data": {
        "id": 1,
        "name": "Tecnologia",
        "slug": "tecnologia"
      }
   }  

```

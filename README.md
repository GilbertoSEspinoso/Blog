# Documentação da API
Este repositório contém a implementação de uma API para um blog, que permite gerenciar Categorias e Posts.

## API BaltaBlog:
Para acessar esse projeto clique nesse link: http://webappblogbalta2812.azurewebsites.net/

## Endpoints

### Categories

***`GET /v1/categories`***

* *Retorna uma lista com todas as categorias cadastradas.*

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

* *Retorna os detalhes de uma categoria específica através do número do Id fornecido.*

***Parâmetros:***

* id (obrigatório): ID da categoria a ser consultada.

***Exemplo de resposta:***

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

***`POST /v1/categories`***

* *Cria uma nova categoria.*

***Parâmetros:***

* `name` (obrigatório): Nome da categoria.
* `slug` (obrigatório): Slug da categoria (deve ser único).

***Exemplo de requisição:***

```json
    {
      "name": "Política",
      "slug": "politica"
    }

```

***Exemplo de resposta:***

```json
    {
      "success": true,
      "data": {
        "id": 3,
        "name": "Política",
        "slug": "politica"
      }
    }

```

***`PUT /v1/categories/{id}`***

* *Atualiza os dados de uma categoria existente.*

***Parâmetros:***

* `id`  (obrigatório): ID da categoria a ser atualizada.
* `name` (opcional): Novo nome da categoria.
* `slug` (opcional): Novo slug da categoria (deve ser único).

***Exemplo de requisição:***

```json
    {
      "name": "Tecnologia e Inovação",
      "slug": "tecnologia-e-inovacao"
    }

```

***Exemplo de resposta:***

```json
    {
      "success": true,
      "data": {
        "id": 1,
        "name": "Tecnologia e Inovação",
        "slug": "tecnologia-e-inovacao"
      }
    } 
```

***`DELETE /v1/categories/{id}`***

* *Exclui uma categoria existente.*

***Parâmetros:***

* id (obrigatório): ID da categoria a ser excluída.

***Exemplo de resposta:***

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

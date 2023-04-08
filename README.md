# Blog Balta
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/GilbertoSEspinoso/Blog/blob/main/LICENCE)

# Sobre o projeto

http://webappblogbalta2812.azurewebsites.net/index.html

Blog Balta é uma API Rest construída durante o curso **Carreira Desenvolvedor Backend .NET - (Fundamentos do ASP.NET 6 e
Fundamentos do Azure, Git, GitHub e DevOps)**, cursos oferecidos pelo site [Balta.io](https://balta.io/player "Site da Balta.io")

A aplicação consiste em uma API que permite gerenciar Categorias e Posts de um Blog, além de possuir autenticação JWT e gerenciamento de usuários. Com essa API, é possível criar usuários, fazer login e gerenciar imagens de perfil.

> * A documentação da API foi gerada automaticamente pelo `Swagger` e para acessar a documentação, 
basta clicar no link que disponibilizei logo acima.
> * Esta APi está na sua primeira versão `v1` e novas implementações ainda serão realizadas e atualizadas. 

# Tecnologias utilizadas

## Back end
- C#
- ASP.NET 6
- Entity Framework Core (ORM)
- SQL server

## Padrões
- API REST
- MVC
- JWT

## Ferramentas utilizadas
- Visual Studio Code
- Azure Data Studio
- Docker (para gerenciamento do banco de dados localmente).]
- Postman (para testes dos endpoints da API)

## Implantação em produção
- Back end: Azure
- Banco de dados: SQL server

# Como executar o projeto

Pré-requisitos: .NET 6.0

```bash
# clonar repositório
git clone https://github.com/GilbertoSEspinoso/Blog.git

# entrar na pasta do projeto Blog
cd Blog

# executar o projeto
dotnet run
```

> Para usar a API, você precisará enviar as requisições utilizando a URL correta e os parâmetros necessários.
A seguir, um exemplo de rota disponível na API:


## Criação de usuário:

* Método HTTP: POST
* URL: `POST /v1/accounts/`
* Body:
    * `"name"` (string) : `"Nome do usuário"`
    * `"email"` (string) : `"email do usuário"`
* Resposta de sucesso:
    * Código HTTP: 200 (OK)
    * Response:
```json
  {
    "data": {
        "user": "email do usuário",
        "password": "senha gerada aleatoriamente"
    }
  }
```
## Endpoints da API
### Categories
` GET /v1/categories `
* <sub>Retorna uma lista com todas as categorias cadastradas.</sub>

` GET /v1/categories/{id} `
* <sub>Retorna os detalhes de uma categoria específica através do número do Id fornecido.</sub>

` POST /v1/categories `
* <sub>Cria uma nova categoria.</sub>

` PUT /v1/categories/{id} `
* <sub>Atualiza os dados de uma categoria existente.</sub>

` DELETE /v1/categories/{id} `
* <sub>Exclui uma categoria existente.</sub>

### Post
` GET /v1/posts `
* <sub>Retorna uma lista paginada de posts em ordem decrescente de atualização, com informações sobre a categoria e o autor de cada post.</sub>

` GET /v1/posts/{id} `
* <sub>Retorna informações detalhadas sobre um post específico com o ID correspondente, incluindo informações sobre o autor do post e a categoria a que ele pertence.</sub>

` POST /v1/posts/categories/{category} `
* <sub>Retorna uma lista paginada de posts com base na categoria correspondente, com informações sobre a categoria e o autor de cada post.</sub>


# Autor

Gilberto da Silva Espinoso

https://www.linkedin.com/in/gilbertoespns/

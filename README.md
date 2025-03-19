# BookManagerApi

API RESTful para gerenciamento de livros.

## Descrição

A BookManagerApi é uma API RESTful construída com .NET 8 para fornecer funcionalidades CRUD (Criar, Ler, Atualizar, Deletar) para livros.

## Tecnologias utilizadas

* [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
* [ASP.NET Core Web API](https://learn.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-8.0)
* [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/) (opcional, para persistência de dados)
* [Swagger/OpenAPI](https://swagger.io/) (para documentação da API)

## Pré-requisitos

* [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
* [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/) (opcional)

## Endpoints

### Criar um livro (POST)

* **URL:** `/api/books`
* **Método:** `POST`
* **Corpo da requisição:**
    * Envie um objeto JSON com os detalhes do livro (Nome, gênero, autor).
* **Resposta:**
    * A API retorna o livro criado com sucesso.

### Obter todos os livros (GET)

* **URL:** `/api/books`
* **Método:** `GET`
* **Resposta:**
    * A API retorna uma lista de todos os livros no banco de dados.

### Obter um livro por ID (GET)

* **URL:** `/api/books/{id}`
* **Método:** `GET`
* **Resposta:**
    * A API retorna os detalhes do livro com o ID especificado.

### Atualizar um livro (PUT)

* **URL:** `/api/books/{id}`
* **Método:** `PUT`
* **Corpo da requisição:**
    * Envie um objeto JSON com os detalhes atualizados do livro.
* **Resposta:**
    * A API retorna o livro atualizado com sucesso.

### Deletar um livro (DELETE)

* **URL:** `/api/books/{id}`
* **Método:** `DELETE`
* **Resposta:**
    * A API retorna uma confirmação de que o livro foi deletado com sucesso.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests.

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).

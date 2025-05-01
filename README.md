# 🚗 CP2 - Locadora de Carros com API REST em ASP.NET Core

Este projeto foi desenvolvido como parte da avaliação CP2 da disciplina de Desenvolvimento Web com ASP.NET Core. O objetivo é demonstrar os conhecimentos em ASP.NET Core, Entity Framework Core com Oracle e lógica de programação orientada a objetos, por meio da construção de uma API RESTful funcional para gerenciamento de carros e cálculo de locações.

---

## 📚 Tecnologias Utilizadas

- ASP.NET Core Web API
- Entity Framework Core
- Banco de Dados Oracle
- C#
- Visual Studio
- Postman (para testes)
- Swagger
- 
---

## 🎯 Funcionalidades

### 🚘 Carros
- ✅ Cadastro de novos carros
- ✅ Listagem de carros
- ✅ Atualização de dados do carro
- ✅ Exclusão de carros

### 🔢 Locação
- ✅ Endpoint para calcular o valor da locação de um carro com base no número de dias
- ✅ Aplicação de descontos progressivos:
  - 10% para locações de 7 dias ou mais
  - 5% para locações de 3 a 6 dias
  - Sem desconto para menos de 3 dias

---

## 📦 Endpoints Disponíveis

### 📌 Carros (CRUD)
- `GET /api/carros` — Lista todos os carros
- `GET /api/carros/{id}` — Retorna um carro específico
- `POST /api/carros` — Cadastra um novo carro
- `PUT /api/carros/{id}` — Atualiza um carro
- `DELETE /api/carros/{id}` — Remove um carro

### 📌 Locação
- `POST /api/locacoes/calcular` — Calcula o valor da locação

#### 🔸 Exemplo de Entrada
```json
{
  "carroId": 1,
  "dataInicio": "2025-04-25",
  "dataFim": "2025-04-30"
}
````

#### 🔸 Exemplo de Saída

```json
{
  "carro": "Civic",
  "marca": "Honda",
  "dataInicio": "2025-04-25",
  "dataFim": "2025-04-30",
  "valorDiaria": 150.00,
  "subtotal": 900.00,
  "desconto": "10%",
  "valorFinal": 810.00
}
````

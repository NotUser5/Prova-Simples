# Aplicação ASP.NET Core Prova


## Descrição

Para a prova foi criada uma aplicação ASP.NET Core projetada para lidar com pedidos relacionados a ativos financeiros, como ações ou títulos. Ela inclui funcionalidades para criar e gerenciar pedidos de compra e venda de ativos.

### Ambiente de Desenvolvimento

Esta aplicação foi desenvolvida e configurada usando o Visual Studio 2022 como a IDE de desenvolvimento principal. Para contribuir ou executar a aplicação em seu ambiente local, é recomendável ter o Visual Studio 2022 instalado. Foi utilizado o Swagger para fazer os testes dos endpoints.

### Banco de Dados

A aplicação utiliza o SQL Server como banco de dados e pode ser configurada por meio do SQL Server Management Studio (SSMS). Certifique-se de ter o SQL Server instalado e o SSMS configurado para acessar o banco de dados da aplicação.

### Strings de Conexão

A conexão do banco de dados da aplicação é configurada no arquivo `appsettings.json`. É necessario mudar o "Nome do servidor" para o nome que estiver em seu SSMS

```json
{
  "ConnectionStrings": {
    "WebApiDatabase": "Data Source="Nome do servidor";Database=Prova_Simples;Trusted_Connection=True;TrustServerCertificate=True"
  },
  // Outras configurações...
}
```

### Migração de Banco de Dados

Para criar ou atualizar o banco de dados com base nas migrações definidas em seu projeto, siga estas etapas:

1.  Abra o Visual Studio 2022.

2.  Abra a janela do Console do Gerenciador de Pacotes. Para fazer isso, vá para Ferramentas > Gerenciador de Pacotes NuGet > Console do Gerenciador de Pacotes.

3.  No Console do Gerenciador de Pacotes, certifique-se de que o projeto padrão seja o projeto que contém suas migrações do Entity Framework.

4.  Execute o comando `update-database` seguir para aplicar as migrações e criar ou atualizar o banco de dados.

Isso executará as migrações pendentes e garantirá que o esquema do banco de dados esteja sincronizado com o modelo de entidade do seu projeto.

### Exemplo de Objeto

Aqui está um exemplo de um objeto que você pode usar ao fazer solicitações para a API:

Compra
```json
{
  "id": 1,
  "codeId": "EMBR3",
  "type": 1,
  "qty": 0,
  "value": 0,
}
```
Em compra o é `"type": 1`

Já em venda ele é `"type": 2`

Venda
```json
{
  "id": 2,
  "codeId": "EMBR3",
  "type": 2,
  "qty": 0,
  "value": 0,
}
```
O codigo não salvara no banco caso o type ou o codeId estejam errados.

* id: inteiro (Possuiu auto incremento)
* codeId: string (É a chave estrangeira que interliga o ativo e a ordem)
* tipo: inteiro
  * 1 para Compra
  * 2 para Venda
* quantidade: inteiro
* valor: decimal

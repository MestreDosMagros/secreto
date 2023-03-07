# Teste proeficiência

### Tipo: C# .Net
### Duração: 25 min

---

## Enunciado

### Considere que você foi desiginado a uma tarefa que tem as seguintes especificações:

1. Precisamos implementar a integração com um sistema de vagas de emprego externo por meio de uma API REST;
2. Foi notado que a API externa em questão não respeita os códigos HTTP padrão, e mesmo acontecendo um erro na integração o resultado sempre retorna 200 OK, porém o status da solicitação é informado no Json de retorno da solicitação;
3. A validação de sucesso/erro deve ser feita através do Json retornado;
4. Caso a integração tenha ocorrido com sucesso, o endpoint deve retornar um corpo de resposta vazio;
5. Caso a integração tenha ocorrido com sucesso, deve ser gerado uma mensagem no rabbitMQ informando o sucesso da operacao;
6. Caso a integração tenha ocorrido com falhas, o endpoint deve retornar a mensagem de erro original;
7. Caso ocorra algum erro não esperado o endpoint deve retornar a mensagem: "Ocorreu um erro não esperado" no corpo;

### Observações

- Para a execução do projeto é necessario ter uma imagem do RabbitMQ rodando no localhost da sua máquina, pode ser usado o comando: docker run -d --name RabbitMQ -p 5672:5672 -p 15672:15672 rabbitmq:3.9-management para instanciar um novo container com a imagem do RabbitMQ;
- Todas as classes e rotinas podem ser alteradas conforme necessidade;
- Os padroes utilizados devem seguir os ja criados no projeto base;
- Sinta-se livre para melhorar o código apresentado e adicionar padrões, funcionalidades, logging ou o que mais achar necessário;

## Boa sorte!
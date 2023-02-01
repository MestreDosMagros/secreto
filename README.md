# Teste proeficiência

### Tipo: C# .Net
### Duração: 15 min

---

## Enunciado

### Considere que você foi desiginado a uma tarefa que tem as seguintes especificações:

1. Precisamos implementar a integração com um sistema de vagas de emprego externo por meio de uma API REST;
2. Foi notado que a API externa em questão não respeita os códigos HTTP padrão, e mesmo acontecendo um erro na integração o resultado sempre retorna 200 OK, porém o status da solicitação é informado no Json de retorno da solicitação;
3. A validação de sucesso/erro deve ser feita através do Json retornado;
4. Caso a integração tenha ocorrido com sucesso, o endpoint deve retornar um corpo de resposta vazio;
5. Caso a integração tenha ocorrido com falhas, o endpoint deve retornar a mensagem de erro original;
6. Caso ocorra algum erro não esperado o endpoint deve retornar a mensagem: "Ocorreu um erro não esperado" no corpo;

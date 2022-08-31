# Threads e Parallelismo 

Aplicando conceitos aprendidos sobre Threads e programação paralela com exercícios do Módulo 05 - Técnicas de Programação , da Lets Code utilizando Console.

## Exercicio 1 - Simular chamada a API

Criar um aplicativo que simule uma chamada à uma API. Utilize Sleep para definir o tempo de 2 segundos para uma chamada. Utilizando paralelismo (for ou foreach), execute essa chamada 100 vezes utilizando no máximo 7 threads. Exiba uma mensagem de finalização ao terminar cada chamada. Exiba o tempo gasto para toda a operação em segundos.

### Resolução
Eu simulei com um Dictionary uma base de dados que fornece informações de saldo de uma conta bancária de um determinado cliente. 
O método GetBalance busca o saldo da conta do cliente informado. 

Existe um método (PegarNomeAleatorio) que sorteia aleatoriamente os clientes na chamada da API. Assim, os saldos de clientes que são exibidos são aleatórios.

![image](https://user-images.githubusercontent.com/38474570/187750639-41c566cb-bf7c-4360-871c-e05ab6dc0909.png)


## Exercicio 2 - Tarefas

Criar um aplicativo que possua 3 métodos:

AcertarBaseDeDados
EnviarEmail
LimparArquivosTemporarios
Cada método terá seu tempo de execução definido por Sleep (no máximo 4 segundos). Faça com que os 3 métodos sejam executados em paralelo. Utilize um quarto método que fará a execução dos demais e faça com que ele espere um parâmetro onde será informada a quantidade de threads a serem utilizadas na execução. Exiba do tempo gasto em milissegundos.

### Resolução

![image](https://user-images.githubusercontent.com/38474570/187750866-93a72cbf-b20d-470a-abed-878da340fc0e.png)

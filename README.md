# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
No método AdicionarVeiculo(), utilizei o método ".Add(Console.ReadLine().ToUpper())" para inserir em uma string da lista "veiculos" a placa digitada pelo usuário e automaticamente converter para letras maiúsculas, permitindo que eu retirasse as conversões que já estavam presentes no código por redundância.
Em seguida, no método RemoverVeiculo(), utilizei novamente "Console.ReadLine().ToUpper()" e armazenei em uma string "placa", que será utilizada como parâmetro para o if seguinte, onde caso a placa esteja na lista "veiculos" o usuário insere a quantidade de horas que o veículo permaneceu no estacionamento, faz o cálculo e informa a placa removida seguido do valor final.
Por fim, no método ListarVeiculos() utilizei o laço de repetição "foreach" e como parâmetro "(string veiculo in veiculos)", o que faz com que cada item armazenado na lista "veiculos" seja copiado para a string "veiculo" e, em seguida, imprimido através do "Console.WriteLine(veiculo)"

<div id="top"></div>
<br />

<!-- PROJECT SHIELDS -->
<div align="center">
 
[![Stargazers][stars-shield]][stars-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

</div>

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <h1 align="center">DEVin Bank</h1>
  <p align="center">
    O DEVin Bank é uma aplicação desenvolvida em C# para ser executada em console. A aplicação é uma representação de um sistema bancário que implementa as contas dos tipos poupança, corrente e investimentos, e comtempla as principais operações bancárias.
    <br />
    <br />
    <br />
    <br />
    <a href="#sobre-o-projeto">Sobre este projeto </a>
    •
    <a href="#comece-a-usar">Comece a usar </a>
    •
    <a href="#roteiro-do-projeto">Roteiro do projeto </a>
   <br />
  </p>
</div>


#

<!-- ABOUT THE PROJECT -->
### Sobre o projeto
A proposta do projeto é aplicar na prática os conceitos estudados durante o módulo de Back-End com C# do curso DEVinHouse. Esta é primeira atividade avaliativa dentre as exigidas no módulo.

##### A aplicação deveria:
- Ser desenvolvida em C#;
- Seguir o <a href="#roteiro-do-projeto">roteiro</a> da Aplicação;
- Aprensentar as mensagens de saída de acordo com a ação do usuário;
- Capturar a interação do usuário via entrada padrão;
- Ser apresentado diretamente na linha de comando;

##### Desenvolvimento
Foram 5 semanas intensas de estudos de C# antes do ínicio deste projeto. Para pôr à prova todo o conteúdo e o que pudemos absorver dele, o desafio foi lançado e nos dado o prazo de 2 semanas para desenvolvê-lo.
Precisei de uns dois dias para conseguir abstrair tudo e planejar o que seria feito. Implementar primeiro os fluxos de interação me permitiu ter uma visão mais ampla e com isso pude me antecipar à alguns problemas.

###### Dificuldades:
Dúvidas em relação a padrões de projeto, técnicas de abstração e o conhecimento ainda reduzido sobre as ferramentas disponibilizadas pelo framework.

###### Impressões:
O projeto se mostrou complexo, principalmente por conta das dificuldades apontadas. Em alguns momentos pensei que não conseguiria concluí-lo. Apesar de tudo, conforme a implementação ganhava forma, as coisas ficavam mais claras e, inclusive, conceitos de POO começavam a fazer mais sentido. Foi desafiador e gratificante.


<p align="right">(<a href="#top">back to top</a>)</p>


<!-- GETTING STARTED -->
### Comece a usar

Para conseguir uma cópia da aplicação, abra o command e siga as instruções como sugerido:
- Navegue até a pasta onde deseja salvar o projeto...
```
$ echo %cd%
```
>/users/myusername/
```
$ cd documents
$ mkdir copia-projeto
$ cd copia-projeto
```
```
$ echo %cd%
```
>/users/myusername/documents/copia-projeto

- Faça o clone do projeto na pasta destino...
```
$ git clone https://github.com/deywid/DevinBank.git
```

Para executar localmente a aplicação:
- Abra a pasta onde a cópia do projeto foi salva e execute o arquivo de solução ```DevinBank.sln```. É pré-requisto ter o Microsoft Visual Studio instalado. 


<p align="right">(<a href="#top">back to top</a>)</p>


<!-- USAGE EXAMPLES -->
### Roteiro do projeto

A fintech DEVinBank deseja automatizar todo o seu sistema de armazenamento de informações referentes aos seus clientes. O sistema deve conter os seguintes tipos de contas, cada uma com suas características:

##### Conta corrente
>- Na conta corrente o cliente tem direito ao cheque especial, ou seja, poderá ficar negativo durante um período de tempo. O sistema deve definir o total do cheque especial, conforme a renda mensal do correntista (10% da renda mensal).
>- Extrato das transações.

##### Conta poupança
>- Na conta poupança o cliente poderá simular quanto o seu valor renderá em um determinado tempo. Para isso, o cliente deve informar a quantidade de tempo (em meses) e a rentabilidade anual da poupança.
>- Extrato das transações

##### Conta investimento
>- Neste tipo de conta o cliente poderá escolher um tipo de investimento e o sistema deverá apresentar o rendimento anual do investimento solicitado, conforme os valores abaixo:
>>- LCI: 8% ao ano. Tempo mínimo de aplicação: 6 meses
>>- LCA: 9% ao ano. Tempo mínimo de aplicação: 12 meses
>>- CDB: 10% ao ano. Tempo mínimo de aplicação: 36 meses
>- O cliente pode realizar uma simulação do valor aplicado, para isso, ele deve indicar:
>>- Valor que será aplicado.
>>- Tempo que ficará aplicado o valor (em meses).
>>- Ao final, apresentar mensagem perguntando se deseja efetuar o investimento.
>- Extrato das transações.
>> Neste caso, sempre que o cliente efetuar uma transação deve-se armazenar:
>>- Valor aplicado.
>>- Tipo da aplicação.
>>- Data da aplicação.
>>- Data da retirada do valor.

Obs. o rendimento do valor aplicado sempre será diário. Por exemplo, se escolher uma aplicação que renda 10% ao ano, é preciso verificar o rendimento diário sobre o valor aplicado.

#### Regras de Negócio

Todas as contas devem ser derivadas da classe Conta, que possui os seguintes atributos e métodos:

###### Atributos
>- Nome
>- CPF (é necessário validar o CPF)
>- Endereço
>- Renda mensal
>- Saldo
>- Conta (o sistema deverá gerar um número da conta de forma sequencial)
>- Agência
>>- Atualmente o banco possui essas agências:
>>- 001 - Florianópolis
>>- 002 - São José
>>- 003 - Biguaçu

###### Métodos
>- Saque
>- Depósito
>- Saldo
>- Extrato
>- Transferência
>- Alterar dados cadastrais (Exceto CPF)

> A fintech também deseja manter um histórico das transferências, que deverá armazenar (utilizar conceitos de composição):
>- Dados Conta Origem
>- Dados Conta Destino
>- Valor
>- Data (pegar a data e hora do sistema)

> O sistema também deverá apresentar os seguintes relatórios:
>- Listar todas as contas
>- Contas com saldo negativo
>- Total do valor investido
>- Todas as transações de um determinado cliente

> É importante que algumas transações não possam ser executadas em caso de problemas percebidos em suas operações:
>- Transferência entre contas cujo montante supera o saldo acrescido do limite do cheque especial da conta de origem  
>- Operações em momentos anteriores ao dia/hora da transação
>- Transferências durante o final de semana (sábado ou domingo)
>- Não é possível fazer transferências para si próprio

Observação: O sistema deve iniciar no dia do seu sistema operacional e você deve pegar essa informação de forma automática. Para simular os valores de investimentos, faça uma função que adiante o tempo no seu algoritmo. Por exemplo: Adiantar em 1 ano o sistema bancário.


<p align="right">(<a href="#top">back to top</a>)</p>




<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[stars-shield]: https://img.shields.io/github/stars/deywid/DevinBank.svg?style=for-the-badge
[stars-url]: https://github.com/deywid/DevinBank/stargazers
[license-shield]: https://img.shields.io/github/license/deywid/DevinBank.svg?style=for-the-badge
[license-url]: https://github.com/deywid/DevinBank/blob/main/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/deywid

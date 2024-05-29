# Projeto final do Bootcamp .NET Developer da plataforma Digital Innovation One

[www.dio.me](http://www.dio.me/)

## Contexto

O aprendizado de línguas inclui o desenvolvimento de diversas habilidades para se atingir a fluência. Parte desse processo consiste em reter o vocabulário aprendido de forma que não se esqueça do que se aprendeu anteriormente. Uma das técnicas utilizadas para a memorização do aprendizado do vocabulário é a técnica da Repetição Espaçada em que consiste em criar diversos baralhos de estudos que são revisados em períodos diferentes. Ou seja, palavras recém-aprendidas ou que ainda não foram memorizadas devem ser revisadas diariamente, a medida que essas palavras vão passando da memória de curto prazo para a memória de longo prazo, a frequência de revisão vai se tornando cada vez mais espaçada, caso alguma palavra seja esquecida durante esse processo, ela deve retornar para o baralho de revisão anterior, o que faz com que a frequência de revisão dessa palavra aumente.

<img src="/Imagem/RepeticaoEspacada.png" alt="Imagem ilustrativa demonstrando o funcionamento da técnica de memorização por repetição espaçada, em que 4 baralhos distintos são colocados um ao lado do outro. Cada carta do baralho possui uma pergunta e uma resposta. Entre o 1º e o 2º baralhos há um espaçamento de revisão de 1 dia. Entre o 2º e o 3º, um espaçamento de revisão de 5 dias. Entre o 3º e o 4º há um espaçamento de revisão de 19 dias. Cada vez que se obtém uma resposta incorreta, a carta deve retornar ao baralho imediatamente anterior.">

## Requisitos para elaboração do projeto

- O projeto deverá ser em C# com Web API com [ASP.NET](http://asp.net/) Core.
- Deve estar vinculado ao SQL Server para persistência dos dados.

## Banco de dados

Nome do banco de dados: Palavra

Nome da tabela: Palavras

| Column Name | Data Type | Nullable |
| --- | --- | --- |
| Id | int | No |
| PalavraLinguaEstrangeira | varchar(50) | Yes |
| PalavraTraduzida | varchar(50) | Yes |
| Aprendido | bool | Yes |
| DiaAtual | DateTime2 | Yes |
| ProximaRevisao | DateTime2 | Yes |
| NivelRevisao | bool | Yes |

## Endpoints
| VERBO | ENDPOINT | PARÂMETRO |
| --- | --- | --- |
| POST | /Palavra | n/a |
| GET | /Palavra/ObterPorId/{id} | id |
| GET | /Palavra/ObterPalavraEstrangeira/{palavraEstrangeira} | palavra na língua estrangeira |
| GET | /Palavra/ObterPalavraTraduzida/{palavraTraduzida} | palavra na língua portuguesa |
| GET | /Palavra/ObterTodos | n/a |
| PUT | /Palavra/{id} | id |
| DELETE | /Palavra/{id} | id |

<img src="/Imagem/Swagger.png" alt="Imagem mostrando a tela do Swagger com os respectivos endpoints da API.">


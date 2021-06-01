# Introdução ao projeto

Projeto Responsável por gerir um churrasco, tendo como necessidade principal: 
 - Incluir um novo churrasco com data, descrição e observações adicionais;
 - Adicionar e remover participantes (colocando o seu valor de contribuição); 
 - Colocar um valor sugerido por usuário de contribuição (valor com e sem bebida inclusa); 
 - Visualizar os detalhes do churrasco, total de participantes e valor arrecadado.

## *_Churras.Projec.API_* :

Projeto responsável por fornecer acesso as regras do domínio do negócio.

## *_Churras.Projec.Domain_* :

Projeto contendo as regras necessárias para resolver o problema.

## *_Churras.Projec.Db_* :

Projeto responsável por manipular acesso ao banco de dados.

## *_Churras.Projec.Shared.Domain_* :

Projeto contendo classes bases para auxiliar o projeto principal,
abstraindo a responsabilidade do domínio e simplificando o desenvolvimento.

## *_Churras.Projec.Shared.Logger_* :

*Não Implementado ainda* Projeto responsável por abstrair componentes relacionados
aos logs gerados pelo sistema.

## *_Melhorias a serem feitas_*

 - Implementação da abstração de logs
 - Inclusão de um projeto para abstração da camada de Mensagería
 - Inclusão de Dockerfile
 - Inclusão do docker-compose
 - Implementação de testes de Unidade

## *_Tecnologias Utilizadas_*

 - Net5 (Utilizado como framework base)
 - Swashbuckle (utilizado para documentação da api)
 - FluentValidation, FluentValidation.AspNetCore (Utilizado para validações de objetos de entrada)
 - MediatR (Utilizado para desacoplar responsabilidades entre projetos)
 
 
 

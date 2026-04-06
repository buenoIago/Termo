# TERMO



## INTRODUÇÃO

Este projeto consiste em um jogo digital inspirado no **Termo (Wordle)**, desenvolvido em C# para execução via Console. O objetivo é adivinhar uma palavra secreta de 5 letras com base em dicas de cores a cada tentativa.

Desenvolvido por Iago na Academia do Programador.

* O sistema escolhe uma palavra aleatória.
* O jogador digita uma tentativa.
* O programa analisa cada letra e retorna cores indicando o resultado.
* O jogo continua até o jogador acertar a palavra.

## FUNCIONALIDADES

* Interface interativa via Console para entrada de palavras.

* Seleção aleatória de uma palavra de 5 letras.

* Sistema de tentativa contínua até o acerto (5 tentativas).

* Comparação letra por letra entre a palavra digitada e a palavra secreta.

* Exibição do resultado com cores:

  🟩 Verde → letra correta na posição correta
  🟨 Amarelo → letra existe, mas em posição errada
  ⬛ Cinza → letra não existe na palavra

* Feedback visual após cada tentativa.

## 🎮 COMO JOGAR

1. Execute o programa.
2. Digite uma palavra de 5 letras.
3. Observe as cores exibidas.
4. Use as dicas para tentar novamente.
5. Continue até acertar!

## COMO UTILIZAR O PROGRAMA

1. Clone o repositório ou baixe o código em .zip.
2. Abra o terminal e navegue até a pasta do projeto.
3. Restaure as dependências:

```
dotnet restore
```

4. Execute o projeto:

```
dotnet run
```

## REQUISITOS

* .NET SDK 10.0
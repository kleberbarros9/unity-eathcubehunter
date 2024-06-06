# Earth - Cosmic Cube Hunter

## Descrição
"Earth - Cosmic Cube Hunter" é um jogo onde o jogador controla uma esfera com a textura da Terra que rola pela Via Láctea. O **objetivo** é coletar cubos de energia espalhados, necessários para a sobrevivência e expansão da humanidade pela galáxia. O jogo termina quando o jogador coleta 10 cubos de energia, levando para a tela de créditos. 

## Instalação

### Pré-requisitos
- Unity versão 2020.1 LTS

### Passos
1. Clone o repositório:
    ```sh
    git clone https://github.com/kleberbarros9/unity-eathcubehunter.git
    ```
2. Abra o projeto no Unity:
    - Abra o Unity Hub
    - Clique em "Add"
    - Selecione a pasta onde você clonou o repositório

## Uso
1. Para rodar o jogo:
    - Abra a cena principal: `Assets/Scenes/StartScene.unity`
    - Pressione o botão "Play" no Unity

2. Controles do jogo:
    - `WASD` para mover a esfera
    - `Enter` ou `Espaço` na tela de créditos para ir à tela de game over
    - `ESC` em qualquer tela para voltar ao menu inicial

## Estrutura do Projeto
- `Assets/Scripts`: Scripts C#
- `Assets/Scenes`: Cenas do jogo
- `Assets/Prefabs`: Prefabs
- `Assets/Sounds`: Arquivos de áudio
- `Assets/Images`: Texturas usadas no jogo


## Fluxo do Jogo
1. **Tela de Menu**:
    - Arte da Terra e vários cubos
    - Botões:
        - **Start**: Inicia o jogo
        - **Créditos**: Mostra a tela de créditos

    ![Menu inicial](/img/StartScene.png)


2. **Tela de Jogo**:
    - Jogador controla uma esfera com a textura da Terra
    - Coleta cubos de energia na Via Láctea
    - Se cair do plano da Via Láctea o jogo reinicia e a contagem dos cubos volta a zero
    - Jogo termina ao coletar 10 cubos, levando à tela de créditos

    ![Tela do jogo](/img/GameScene.png)
3. **Tela de Créditos**:
    - Mostra a equipe de desenvolvimento:
        - Kleber Barros (01691348)
        - Pedro Henrique (01351837)
        - Tiffany Almeida (01533205)
        - Ylgner Cavalcanti (01237934)
    - `Enter` ou `Espaço` leva à tela de game over

    ![Tela do Créditos](/img/CreditScene.png)
4. **Tela de Game Over**:
    - Pressione `ESC` para voltar ao menu
    ![Tela do jogo](/img/GameOverScene.png)

**Obs.**: Todas as telas possuem músicas temáticas.

## Contribuição
1. Fork o repositório
2. Crie um branch para sua feature (`git checkout -b feature/nova-feature`)
3. Commit suas mudanças (`git commit -m 'Adicionei nova feature'`)
4. Push para o branch (`git push origin feature/nova-feature`)
5. Abra um Pull Request

## Licença
Este projeto está licenciado sob a Licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

## Contato
Nome - [knnob9@hgmail.com](mailto:knnob9@hgmail.com)
LinkedIn - [kleber-barros-4236](https://www.linkedin.com/in/kleber-barros-42369712b/)
GitHub - [kleberbarros9](https://github.com/kleberbarros9)

<div align="center">
    <h1>Pathfinding - AI</h1>
    <p>Pathfindings feitos na Unity usando NavMesh, Grid e Waypoints.</p>
</div>

### Sobre o projeto

O projeto consiste em aplicar três maneiras de se utilizar o pathfinding na Unity. Os métodos utilizados foram movimentações com NavMesh, da própria Unity, Grid e Waypoints.

**Versão da Unity:** 2022.3.12f1
**Pacote Utilizado:** A* Pathfinding (versão gratuita) - Aron Granberg
**Link do pacote:** https://arongranberg.com/astar

### NavMesh

Foram criadas algumas paredes para funcionarem como obstáculos no cenário. Também foram adicionadas rampas para que se tivesse um relevo no mapa com a finalidade de incrementar o projeto.

A ferramenta de NavMesh foi adicionada por meio do *Pack Manager* da Unity, localizado na aba "Window" ou "Janela" na parte superior do editor. Após a adição de tal ferramenta, foi atribuído às paredes a *tag* de "*Not Walkable*" e para o chão e rampas, a de "*Walkable*". Essas *tags* servem para indicar o que o objeto (personagem, jogador, inimigo, etc..) pode andar sobre e o que deve ser desviado.

Em seguida, foi atríbuido um simples *script* para a IA (chamada de "*character*" no projeto), em que se identifica a posição do alvo (posição em que o *character* precisa chegar) e então se passa a instrução de mover-se até o alvo. 

Por último, foi adicionado um componente chamado de "*Nav Agent*" ao objeto do personagem, em que automaticamente o editor já o reconhece como um "*Humanoid*", ou seja, a entidade que se moverá pelo cenário. Nesse componente é possível mudar alguns atributos, como a velocidade do personagem, aceleração, distância de detecção dos obstáculos e do alvo, entre outros.

**Caminho da Cena:** "/Assets/Scenes/NavMesh.unity" <br>
**Caminho do Script:** "/Assets/Scripts/NavMesh.cs"

### Grid

Para fazer o *pathfinding* em grade foi utilizado o pacote A* do desenvolvedor Aron Granberg, que possui um componente chamado "*Pathfinder*", a base do seu pacote.

Foi utilizada a opção de grade do *Pathfinder*, em que é possível atribuir a área em que o personagem poderá andar. Junto a isso, foram adicionados os script "AIPath" e "AI Destination Setter" ao personagem para atribuir um alvo, bem como outros atributos como velocidade, rotação, etc... 

**Caminho da Cena:** "/Assets/Scenes/Grid.unity"

### Waypoint

Para aplicar o método de *waypoints* também foi utilizado o mesmo pacote A* mencionado na sessão **Grid**.

Este método é bem mais simples de ser feito, uma vez que foi criado um objeto vazio que contém diversos objetos-filhos, chamados de *waypoint*, cada um com seu ID. A partir das posições dos waypoints, são traçadas as linhas que interligam os mesmos, configurando assim o caminho que o personagem irá traçar.

**Observação:** O pathfinding está funcionando, porém o alvo deve ser apontado manualmente, uma vez que não foi feito um *script* para alternar entre os pontos.


**Caminho da Cena:** "/Assets/Scenes/Waypoint.unity"
Olá! Bem vindos aos resultados da minha prova. Vou descrever cada classe e o objetivo dela.

## Pasta Pages
* HomePage - Mapeia os itens da tela principal, depois do login, conforme solicitado no exercício.
* LoginPage - Mapeia os itens de username(email) e Password(Senha) da tela inicial do sistema, contendo os métodos de inputs para escrever ambos. Contém também o botão de login para confirmar e acessar o sistema. O ultimo método é o método que valida que o sistema efetuou o login e carregou a tela principal do sistema existente em todos os métodos page implementados.
* MenuPage - Mapeia a parte do menu que possui as opções de Sign Out, Perfil e contato. Funcional em todas as páginas da mesma forma, então mapeado individualmente para fácil acesso em qualquer página.
* ProductPage - Estava tentando mapear um produto e adicioná-lo na lista de desejos (Wishlist) porém devido ao curto espaço de tempo não tive tempo de fazer o caminho completo.
* WishlistPage - Mapeei o botão que mostra a lista de itens salvos na lista de desejos. Clicando nele e validando que o usuário possui um item na lista previamente adicionado.

Faltou mapear um item e criar o método para adicioná-lo na lista de desejos.

## Pasta Workflows - Usamos para encapsulamento
* HomePageWF - Flow para clicar na wishlist e validar o carregamento da página.
* LoginPageWF - Flow para efetuar o login no sistema
* MenuPageWF - Flow para clicar no sign out
* WishlistPageWF - Flow para validar o item que existe na lista de desejos
* ProductPageWF - Não implementado, pretendia usar para criar o fluxo de adicionar um novo item na lista de desejos

TestFlow - Classe onde todos os passos do teste foram implementados. Cada workflow sendo chamado e excutando (e passando) os testes.

Ol�! Bem vindos aos resultados da minha prova. Vou descrever cada classe e o objetivo dela.

Pasta Pages:
- HomePage - Mapeia os itens da tela principal, depois do login, conforme solicitado no exerc�cio.
- LoginPage - Mapeia os itens de username(email) e Password(Senha) da tela inicial do sistema, contendo os m�todos de inputs para escrever ambos. Cont�m tamb�m o bot�o de login para confirmar e acessar o sistema. O ultimo m�todo � o m�todo que valida que o sistema efetuou o login e carregou a tela principal do sistema existente em todos os m�todos page implementados.
- MenuPage - Mapeia a parte do menu que possui as op��es de Sign Out, Perfil e contato. Funcional em todas as p�ginas da mesma forma, ent�o mapeado individualmente para f�cil acesso em qualquer p�gina.
- ProductPage - Estava tentando mapear um produto e adicion�-lo na lista de desejos (Wishlist) por�m devido ao curto espa�o de tempo n�o tive tempo de fazer o caminho completo.
- WishlistPage - Mapeei o bot�o que mostra a lista de itens salvos na lista de desejos. Clicando nele e validando que o usu�rio possui um item na lista previamente adicionado.

-- Faltou mapear um item e criar o m�todo para adicion�-lo na lista de desejos. 

Pasta Workflows - Usamos para encapsulamento
- HomePageWF - Flow para clicar na wishlist e validar o carregamento da p�gina.
- LoginPageWF - Flow para efetuar o login no sistema
- MenuPageWF - Flow para clicar no sign out
- WishlistPageWF - Flow para validar o item que existe na lista de desejos
- ProductPageWF - N�o implementado, pretendia usar para criar o fluxo de adicionar um novo item na lista de desejos

TestFlow - Classe onde todos os passos do teste foram implementados. Cada workflow sendo chamado e excutando (e passando) os testes.
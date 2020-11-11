- O projeto tem por finalidade de busca de informacoes no site do http://www.sebrae.com.br/canaldofornecedor 
- O site foi escolhido sem nenhum criterio espeficico.
- Ao executar o projeto atraves do F5, sera executado o console, onde utilizaremos do Browser Chrome para a busca das informacoes da pagina.
- Para a busca foi utilizado Selenium WebDriver e Selenium WebDriver ChromeDriver
- Foi desenvolvida a parte que realiza a busca das informacoes na pagina como forma de solucao ao desafio passado.
- Nao foi desenvolvida a solucao de extracao para arquivo/front-end ou disponibilizacao da solucao como servico.
- A mesma solucao pode ser aplicada as outras URLs apos ajuste dos parametros da solucao.

Explicacao do projeto
- Inicialmente instanciamos o Browser atraves do Selenium
- Solicitamos ao driver a abertura da URL
- Buscamos pelo elemento do botao na pagina atraves do nome do mesmo, porem com parametro de timeout de 10 segundos
- Na sequencia solicitamos que seja clicado para realizacao da pesquisa
- Buscamos pelo elemento que indica que a pesquisa foi realizada e entao realizamos a busca de todos os elementos para uma lista
- Populamos um array de string com o retorno da pesquisa feita na pagina em questao.
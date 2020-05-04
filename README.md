# projeto-menu-restaurante
Terceiro projeto proposto pelo professor Takeshi da Universidade Positivo em Londrina. Projeto realizado com o intuito de aprender o design pattern Iterator utilizando conceitos de herança e polimorfismo. Foi utilizado C# para o desenvolvimento do trabalho. 

O Iterrator é um design-pattern que visa universalizar coleções de de dados. Durante o desenvolvimento de um software, diferentes tipos de coleções de dados podem ser implementadas. Desta forma, estas coleções acabam ficando despadronizadas.

A proposta é utilizar o Design Pattern Itearator para resolver a problemática referida, de forma a padronizar as coleções de dados.

Atividade realizada:

------------------------------------------------------------------------------------

Um restaurante contratou programadores para implementar um menu para os seus
pratos. O restaurante trabalha com café da manhã e almoço e deseja fazer um menu
para cada refeição. Porém para cada tipo de menu, foram contratados dois
programadores diferentes. O programador responsável pelo menu do café da manhã
implementou a lista de pratos com uma collection (List). Já o programador responsável
pelo menu do almoço implementou a lista de pratos com vetor estático. Percebe-se a
falta de comunicação entre os programadores deste sistema. O código do projeto
implementado encontra-se no projeto do VisualStudio (em anexo) denominado
ProjetoMenuRestaurante. Porém como os programadores são meio ‘teimosos’, ninguém
quer alterar o código que fez e a estrutura de dados de listas que implementaram.

a) As classes implementadas pelos programadores são MenuCafeDaManha que
utiliza List e o MenuAlmoco que utiliza vetor estático. Implemente o padrão
Iterator nestas duas classes.

b) Na classe Program (que tem o método Main()) contém algumas listagens dos
menus. Repare que como a implementação de listas de ambos menus são
diferentes, o processo de percorrer a lista é diferente. De acordo com o padrão
implementado no item (a), modifique os laços de repetição de modo que utilize
os métodos do Iterator e o método de percurso da lista seja independente da
sua implementação. As funcionalidades que devem ser modificadas devem ser
os seguintes:

a. Imprimir o menu do café da manhã.
b. Imprimir o menu do almoço.
c. Imprimir todos os pratos vegetarianos do café da manhã e do almoço.

------------------------------------------------------------------------------------

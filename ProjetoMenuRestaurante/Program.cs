using System;
using System.Collections.Generic;

namespace ProjetoMenuRestaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuCafeDaManha cafeDaManha = new MenuCafeDaManha();
            MenuAlmoco almoco = new MenuAlmoco();

            List<MenuItem> lista1 = cafeDaManha.getMenu();
            MenuItem[] lista2 = almoco.getMenu();

            IteradorItem iteradorCafeDaManha = new IteradorItem(lista1);
            IteradorItem iteradorAlmoco = new IteradorItem(lista2);

            iteradorCafeDaManha.inicio();

            Console.WriteLine("\n*** MENU CAFÉ DA MANHÃ ***");

            while (!iteradorCafeDaManha.fim())
            {
                Console.WriteLine(iteradorCafeDaManha.itemAtual());
                iteradorCafeDaManha.proximo();
            }

            iteradorAlmoco.inicio();

            Console.WriteLine("\n*** MENU ALMOCO ***");

            while (!iteradorAlmoco.fim())
            {
                Console.WriteLine(iteradorAlmoco.itemAtual());
                iteradorAlmoco.proximo();
            }

            Console.WriteLine("\n*** TODOS OS PRATOS VEGETARIANOS (CAFE DA MANHA E ALMOCO) ***");

            iteradorCafeDaManha.inicio();
            iteradorAlmoco.inicio();

            while (!iteradorCafeDaManha.fim())
            {
                if (iteradorCafeDaManha.isVegetariano())
                {
                    Console.WriteLine(iteradorCafeDaManha.itemAtual());
                }

                iteradorCafeDaManha.proximo();
            }

            while (!iteradorAlmoco.fim())
            {
                if (iteradorAlmoco.isVegetariano())
                {
                    Console.WriteLine(iteradorAlmoco.itemAtual());
                }

                iteradorAlmoco.proximo();
            }

            Console.WriteLine("\n*** BOM APETITE!!! ***");
        }
    }
}

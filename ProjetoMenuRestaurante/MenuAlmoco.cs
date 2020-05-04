using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMenuRestaurante
{
    class MenuAlmoco
    {
        private static int MAX_ITENS = 7;
        private int numItens;
        private MenuItem[] menu;

        public MenuAlmoco()
        {
            this.menu = new MenuItem[MAX_ITENS];
            this.addItem("Bife à cavalo com arroz, feijão", false, 10.99);
            this.addItem("Salda mista com tomate, alface, pepino e cenoura", true, 4.99);
            this.addItem("Strogonoff de carne", false, 12.99);
            this.addItem("Strogonoff de frango", false, 11.99);
            this.addItem("Bife à parmegiana", false, 13.99);
            this.addItem("Omelete com arroz e feijão", true, 9.99);
            this.addItem("Picanha com arroz e feijão", false, 15.99);
        }

        public void addItem(String nome, bool vegetariano, double preco)
        {
            MenuItem item = new MenuItem(nome, vegetariano, preco);
            if (numItens >= MAX_ITENS)
            {
                Console.WriteLine("O menu está lotado!");
            }
            else
            {
                this.menu[this.numItens++] = item;
            }
        }

        public int getNumItens()
        {
            return numItens;
        }

        public MenuItem[] getMenu()
        {
            return menu;
        }
    }
}

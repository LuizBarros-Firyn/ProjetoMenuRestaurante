using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMenuRestaurante
{
    class MenuCafeDaManha
    {
        private List<MenuItem> menu;

        public MenuCafeDaManha()
        {
            this.menu = new List<MenuItem>();
            this.addItem("Panqueca de ovo", true, 2.99);
            this.addItem("Pão na chapa com manteiga", true, 1.99);
            this.addItem("Waffles com mel", true, 4.99);
            this.addItem("Pão com presunto e queijo", false, 4.99);
            this.addItem("Pão com mortadela", false, 3.99);
        }

        public void addItem(String nome, bool vegetariano, double preco)
        {
            MenuItem item = new MenuItem(nome, vegetariano, preco);
            this.menu.Add(item);
        }

        public List<MenuItem> getMenu()
        {
            return this.menu;
        }

    }
}

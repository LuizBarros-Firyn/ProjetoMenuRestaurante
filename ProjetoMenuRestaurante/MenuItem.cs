using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMenuRestaurante
{
    class MenuItem
    {
        private string nome;
        private bool vegetariano;
        private double preco;

        public MenuItem(string nome, bool vegetariano, double preco)
        {
            this.nome = nome;
            this.vegetariano = vegetariano;
            this.preco = preco;
        }

        /* Daqui para baixo são os getters e setters */
        public string getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public bool isVegetariano()
        {
            return vegetariano;
        }

        public void setVegetariano(bool vegetariano)
        {
            this.vegetariano = vegetariano;
        }

        public double getPreco()
        {
            return preco;
        }

        public void setPreco(double preco)
        {
            this.preco = preco;
        }

        public override string ToString()
        {
            string veg = (this.isVegetariano()) ? "sim" : "não";
            return nome + ". Vegetariano: " + veg + ". Preço: $"  + preco;
        }
    }
}

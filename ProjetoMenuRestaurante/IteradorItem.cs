using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMenuRestaurante
{
    class IteradorItem : Iterador
    {
        private MenuItem[] itens;
        private int indice;

        public IteradorItem(MenuItem[] itens)
        {
            this.itens = itens;
        }

        public IteradorItem(List<MenuItem> itens)
        {
            this.itens = itens.ToArray();
        }

        public bool fim()
        {
            if (this.indice < itens.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void inicio()
        {
            this.indice = 0;
        }

        public object itemAtual()
        {
            return this.itens[indice];
        }

        public bool isVegetariano() // Nao estava conseguindo chamar o metodo direto pelo program, dava erro de conversão pra object, se puder deixar um comentário explicando o porque do erro, ajudaria muito! Obrigado!
        {
            if (this.itens[indice].isVegetariano())
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public int returnIndex()
        {
            return indice;
        }

        public void proximo()
        {
            if (!fim())
                this.indice++;
        }
    }
}

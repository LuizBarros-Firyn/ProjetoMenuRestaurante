using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMenuRestaurante
{
    interface Iterador
    {
        void inicio();
        void proximo();
        bool fim();
        Object itemAtual();

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace atividade_3_encapsulamento
{
    interface Interacao
    {
        void usar();
        void carregar(string COR, int CARGA);

        void trocarCor(string COR);

        void trocarTexto(string TEXTO);
    }
}

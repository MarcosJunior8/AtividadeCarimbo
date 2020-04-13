using System;
using System.Collections.Generic;
using System.Text;

namespace atividade_3_encapsulamento
{
    class Caneta:Interacao
    {

        private string cor;
        private string texto;
        private int carga;


        public Caneta (string TEXTO)
        {
            trocarTexto(TEXTO);
        }

        private string Cor
        {
            get { return cor; }
            set { cor = value; }
            
        }

        private string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        private int Carga
        {
            get { return carga; }
            set { carga = value; }
        }


        public void usar()
        {
            if (carga >= 1)
            { 
                if (!string.IsNullOrEmpty(Cor))
                {
                    if (!string.IsNullOrEmpty(Texto))
                    {
                        Console.WriteLine("(" + Texto + ")" + " na cor " + Cor);
                        Carga--;
                    }
                    else { Console.WriteLine("Caneta sem Texto"); }
                   
                }
                else { Console.WriteLine("Caneta sem cor"); }
            }
            else { Console.WriteLine("Caneta sem carga"); }          
        }

        public void carregar(string COR , int CARGA)
        {
            trocarCor(COR);

            if(CARGA >= 1 && CARGA <= 10)
            {
                if(Carga + CARGA <= 10)
                {
                    Console.WriteLine("Carga realizada com sucesso!");
                    Carga += CARGA;
                }
                else { Console.WriteLine("Não é possivel encher tanto ! máximo de carga 10 , valor atual : " + Carga); }
            }
            else { Console.WriteLine("Valor de carga inválida , escolha de 1 a 10"); }
          
        }

        public void trocarCor(string COR)
        {
            if (COR == Cor)
            {
                Console.WriteLine("Já esta nessa cor.");
            }
            else
            {
               
                Cor = COR;
            }
        }

        public void trocarTexto(string TEXTO)
        {
            if(TEXTO == Texto)
            {
                Console.WriteLine("Esse texto já esta definido");
            }
            else
            {
               
                Texto = TEXTO;
            }
        }
    }
}

using System;

namespace Exemplosdotnet.Exemplos
{
    public class Pilha //nome da class Pilha ( conceito lifo)
    {
       
        Posicao primeiro; //propriedade (Posicao) - classe que chamou de primeiro 
        public void Empilha(object item) //metodo que recebe um obj
        {
            primeiro = new Posicao(primeiro, item); //primeiro é o item passado
        }

        public object Desempilha() 
        {
            if (primeiro == null)
            {
                //qualquer flha que ocorrer na execução é dispadado um erro

                throw new InvalidOperationException("A pilha está vazia!"); 
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo; //o proximo passa a ser o primeiro
            return resultado;
        }
        
        //subCasse dentro da Pilha
        class Posicao
        {
            public Posicao proximo;
            public object item;
            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        } 
    }
}
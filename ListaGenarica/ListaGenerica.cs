using System;
using System.Collections.Generic;
using System.Text;

namespace ListaGenarica
{
    class List<T>
    {
        class Celula
        {
            public T elemento;
            public Celula prox;
        }

        private int tam;
        public int Tam { get { return (this.tam); } }
        private Celula primeiro, ultimo, aux;

        public List()
        {
            this.tam = 0;
            this.primeiro = new Celula();
            this.primeiro.elemento = default(T);
            this.ultimo = this.primeiro;
        }

        public bool Vazia()
        {
            return (this.primeiro == this.ultimo);
        }

        public void AddUltimo(T Obj)
        {
            this.ultimo.prox = new Celula();

            this.ultimo.prox.elemento = Obj;
            this.ultimo = this.ultimo.prox;
            this.tam++;
        }

        public void AddPrimeiro(T Obj)
        {
            Celula novo = new Celula();

            novo.elemento = Obj;
            novo.prox = this.primeiro.prox;
            this.primeiro.prox = novo;

            if (this.Vazia())
            {
                this.ultimo = this.primeiro.prox;
            }

            this.tam++;

        }

        public T RetirarUltimo()
        {
            T retirado = default(T);

            if (!this.Vazia())
            {
                this.aux = this.primeiro.prox;
                Celula ant = this.primeiro;
                while (this.aux != this.ultimo)
                {
                    ant = this.aux;
                    this.aux = this.aux.prox;
                }

                retirado = this.aux.elemento;
                ant.prox = null;
                this.ultimo = ant;

                this.tam--;
            }
            else
            {
                Console.WriteLine("Lista Vazia!");
            }
            return (retirado);

        }

        public T RetirarPrimeiro()
        {
            T retirado = default(T);

            if (!this.Vazia())
            {
                retirado = this.primeiro.prox.elemento;

                this.primeiro.prox = this.primeiro.prox.prox;

                if (this.primeiro.prox == null)
                    this.ultimo = this.primeiro;

                this.tam--;
            }
            else
            {
                Console.WriteLine("Lista Vazia!");
            }
            return (retirado);
        }

        public void Percorrer()
        {
            this.aux = this.primeiro.prox;

            while (this.aux != null)
            {
                Console.WriteLine(this.aux.elemento);
                this.aux = this.aux.prox;
            }
        }

    }
}
}

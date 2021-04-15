using System;

namespace Classes.Heranca 
{
    public class Ponto 
    {
        public int x, y;
        public int distancia;
        public Ponto(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }
        protected void CalcularDistancia() 
        {
            // Faz Algo.
            CalcularDistancia2();
        }
        private void CalcularDistancia2() 
        {
            // Faz Algo.
        }
        public virtual void CalcularDistancia3() 
        {
            // Faz Algo.
        } 
    }
}
namespace ClassesEObjetosExemplo

{
    public class Ponto
    {
        public int x,y;
        private int distancia;

        public Ponto(int x, int y){
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia(){
            CalcularDistancia2();
        }

        private void CalcularDistancia2(){

        }

        // Virtual = Permite que uma classe filha sobrescreva esse metodo.
        public virtual void CalcularDistancia3(){
            //Faz algo na classe pai
        }
    }
}
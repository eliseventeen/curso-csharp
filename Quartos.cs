namespace estudosCSharp {
    class Quartos {

        public static int Sum(params int[] vetor) {
            int somar = 0;
            for(int i=0; i<vetor.Length; i++) {
                somar += vetor[i];
            }

            return somar;
        }

    }
}
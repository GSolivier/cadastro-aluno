using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastro_aluno
{
    public class Aluno
    {
        public string nome;
        public string curso;

        public string idade;
        public string rg;
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade;

        public void VerMediaFinal(){

            Console.WriteLine($"Média final: {mediaFinal}");
        }

        public float VerMensalidade()
        {
            if(bolsista == true && mediaFinal >= 8){

                return valorMensalidade / 2;
            }

            else if(bolsista == true && mediaFinal > 6)
            {
                return valorMensalidade * 0.7f;
            }
            
            else{
                return valorMensalidade;
            }
        }

          public string teste(string rg)
        {
            return Convert.ToUInt64(rg).ToString(@"00\.000\.000\-0");
        }
    
    }
}
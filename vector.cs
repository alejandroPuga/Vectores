using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercisio_vector
{
    class vector
    {

        //int a=1;

        private int[] vec;
        private int[] vec2;

        public void definir(int a)
        {
            vec = new int[a];
            vec2 = new int[a];
        }

        public void llenar(int a)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = a;
                a++;
            }
        }

        public string mostrar()
        {
            string a = "";
            for (int i = 0; i < vec.Length; i++)
            {
                a = a + " - " + vec[i];
            }
            return a;
        }

        /* public void llenar2(int a)
         {
             for (int i = 1; i < vec.Length; i++)
             {
                 vec[i] = a;
                 a++;


                 if (i == vec.Length-1)
                 {
                     vec[0] = a;
                 }

             }
         }
         */


        public void igualar(int a)
        {
            for (int i = 0; i < vec.Length; i++)
            {

                vec[i] = vec2[i];
                a++;

            }
        }

        public void girarArriva(int a)
        {
            int b = vec.Length - 1;
            int c;
            for (int i = 0; i < vec.Length; i++)
            {
                c = vec[i];
                vec[i] = vec[b];
                vec[b] = c;
                a++;
            }
        }

        public void Invertir(int a)
        {
            int b = vec.Length - 1;
            int c;
            for (int i = 0; i < vec.Length / 2; i++)
            {
                c = vec[i];
                vec[i] = vec[b];
                vec[b] = c;
                b--;
                a++;
            }
        }

        public void girarAbajo (int a)
        {
            int b = 0;
            int c;
            for (int i = vec.Length-1; i >=0 ; i--)
            {
                c = vec[i];
                vec[i] = vec[b];
                vec[b] = c;
                a++;
            }
        }
    }
}

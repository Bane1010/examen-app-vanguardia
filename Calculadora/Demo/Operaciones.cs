using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{

    public class Operaciones

    {

        public static int Res(int res1, int res2)
        {

            return res1 - res2;


        }
        public static int Suma(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }
        public static int Division(int dividendo,int divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("No se puedse dividir entre cero");
            return dividendo / divisor;
        }
        public static int Mul(int mul1, int mul2)
        {

            return mul1 * mul2;


        }

        public static double Raiz(double raiz1, double raiz2)
        {

             return Math.Sqrt(raiz1);

        }
        public static double Expo(double expo1, double expo2)
        {

            return Math.Pow(expo1,expo2);

        }


    }
}

using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceBase
    {
        private double _n1 { get; set; }
        private double _n2 { get; set; }
        private List<double> _numbers { get; set; }
        public ServiceBase()
        {
        }

        public ServiceBase(double n1, double n2)
        {
            this._n1 = n1;
            this._n2 = n2;
        }

        public ServiceBase(List<double> numbers)
        {
            this._numbers = new List<double>(numbers);            
        }

        public double Ajouter(double n1, double n2)
        {
            return Convert.ToDouble(n1 + n2);
        }

        private double Ajouter(double[] numberos)
        {
            double result = 0;

            for (int i = 0; i < numberos.Length; i++)
            {
                result = result + numberos[i];
            }                

            return result;
        }

        private double Soustraire(double n1, double n2)
        {
            return Convert.ToDouble(n1 - n2);
        }

        private double Soustraire(double[] numberos)
        {
            double result = 0;

            for (int i = 0; i < numberos.Length; i++)
            {
                result = result - numberos[i];
            }
            return result;
        }

        private double Multplier(double n1, double n2)
        {
            return Convert.ToDouble(n1 * n2);
        }

        private double Diviser(double n1, double n2)
        {
            try
            {
                return Convert.ToDouble(n1 / n2);
            }
            catch (Exception ex)
            {

                throw ex;
            }            
        }

        public double PrincipaleOperation(string exp)
        {
            char[] chaine = exp.ToArray();
            string[] numbers;
            List<char> opts = new List<char>();
            double resultat = 0;

            for (int i = 0; i < chaine.Length; i++)
            {
                if (chaine[i] == '+' || chaine[i] == '-' || chaine[i] == '*' || chaine[i] == '/')
                {
                    opts.Add(chaine[i]);
                }
            }

            if (opts.Count == 1)
            {
                //Operations simples
                numbers = exp.Split(opts[0]);

                switch (opts[0])
                {
                    case '+': return this.Ajouter(Convert.ToDouble(numbers[0]), Convert.ToDouble(numbers[1]));

                    case '-': return this.Soustraire(Convert.ToDouble(numbers[0]), Convert.ToDouble(numbers[1]));

                    case '*': return this.Multplier(Convert.ToDouble(numbers[0]), Convert.ToDouble(numbers[1]));

                    case '/': return this.Diviser(Convert.ToDouble(numbers[0]), Convert.ToDouble(numbers[1]));

                    default: return 11;
                }
            }
            else if (opts.Count == 2)
            {
                //Operations composés
                numbers = exp.Split(opts[0]);
                //TODO:
            }
            else
            {
                //TODO:
            }

            return 0;
        }
    }

}

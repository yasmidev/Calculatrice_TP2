using Calculatrice_TP2.Utilities;
using System;

// cette classe contient les méthodes pour effectuer les opérations de base (addition, soustraction, multiplication, division)
// et pour calculer le résultat d'une expression en utilisant les méthodes de la classe Outils pour séparer <
// l'expression en tokens et pour calculer le résultat à partir de ces tokens

namespace Calculatrice_TP2.Services
{
    public class CalculService
    {
        public double Addition(double a, double b) => a + b;

        public double Soustraction(double a, double b) => a - b;

        public double Multiplication(double a, double b) => a * b;

        public double Division(double a, double b)
        {
            if (b == 0)
                throw new Exception("Division par zéro!");

            return a / b;
        }

        public double CalculExpression(string expression)
        {
            var liste = Outils.Separateur(expression);
            return Outils.Calculer(liste);
        }
    }
}
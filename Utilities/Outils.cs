using System;
using System.Collections.Generic;


// cette classe ici n'a pas été changé depuis le TP1,
// elle contient les méthodes pour séparer l'expression en tokens et pour calculer le résultat à partir de ces tokens,
// elle utilise une approche de pile pour gérer les opérations et les parenthèses

namespace Calculatrice_TP2.Utilities
{
    public static class Outils
    {
        public static List<string> Separateur(string expression)
        {
            expression = expression.Replace(" ", "");

            List<string> result = new List<string>();
            string nombre = "";

            foreach (char c in expression)
            {
                if ("+-*/()^".Contains(c))
                {
                    if (nombre != "")
                    { 
                        result.Add(nombre);
                        nombre = "";
                    }
                    result.Add(c.ToString());
                }
                else
                {
                    nombre += c;
                }
            }

            if (nombre != "")
                result.Add(nombre);

            return result;
        }

        public static double Calculer(List<string> tokens)
        {
            return Eval(tokens);
        }

        private static double Eval(List<string> tokens)
        {
            Stack<double> valeurs = new Stack<double>();
            Stack<string> ops = new Stack<string>();

            int i = 0;

            while (i < tokens.Count)
            {
                string token = tokens[i];

                if (double.TryParse(token, out double val))
                {
                    valeurs.Push(val);
                }
                else if (token == "(")
                {
                    int j = i + 1;
                    int count = 1;

                    while (j < tokens.Count && count > 0)
                    {
                        if (tokens[j] == "(") count++;
                        if (tokens[j] == ")") count--;
                        j++;
                    }

                    var sub = tokens.GetRange(i + 1, j - i - 2);
                    valeurs.Push(Eval(sub));
                    i = j - 1;
                }
                else if ("+-*/^".Contains(token))
                {
                    while (ops.Count > 0 && Priorite(ops.Peek()) >= Priorite(token))
                    {
                        CalculerPile(valeurs, ops);
                    }
                    ops.Push(token);
                }

                i++;
            }

            while (ops.Count > 0)
            {
                CalculerPile(valeurs, ops);
            }

            return valeurs.Pop();
        }

        private static int Priorite(string op)
        {
            return op switch
            {
                "+" => 1,
                "-" => 1,
                "*" => 2,
                "/" => 2,
                "^" => 3,
                _ => 0
            };
        }

        private static void CalculerPile(Stack<double> valeurs, Stack<string> ops)
        {
            double b = valeurs.Pop();
            double a = valeurs.Pop();
            string op = ops.Pop();

            double res = op switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => a / b,
                "^" => Math.Pow(a, b),
                _ => 0
            };

            valeurs.Push(res);
        }
    }
}
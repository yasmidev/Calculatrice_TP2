namespace Calculatrice_TP2.Models
{
    public class Calcul // cette classe représente un calcul effectué, elle contient les propriétés pour stocker l'équation, le résultat et la date du calcul
    {
        public int Id { get; set; }
        public string Equation { get; set; } = "";
        public double Resultat { get; set; }
        public DateTime Date { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using Calculatrice_TP2.Models;

// cette classe est le ViewModel pour la vue de la calculatrice,

namespace Calculatrice_TP2.ViewModels
{
    public class CalculatriceViewModel
    {
        [Display(Name = "Expression")]
        public string Expression { get; set; } = "";

        public double? Resultat { get; set; }

        public string? MessageErreur { get; set; }

        public List<Calcul> Historique { get; set; } = new List<Calcul>();
    }
}
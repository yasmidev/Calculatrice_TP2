using Calculatrice_TP2.Data;
using Calculatrice_TP2.Models;
using Calculatrice_TP2.Services;
using Calculatrice_TP2.ViewModels;
using Microsoft.AspNetCore.Mvc;

//classe très importamte qui contient les actions pour afficher la page d'accueil,
//afficher l'historique des calculs et pour calculer une expression envoyée par le formulaire de la page d'accueil

namespace Calculatrice_TP2.Controllers
{
    public class CalculatriceController : Controller
    {
        private readonly CalculatriceContext _context;

        public CalculatriceController(CalculatriceContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var vm = new CalculatriceViewModel();
            return View(vm);
        }

        public IActionResult Historique()
        {
            var vm = new CalculatriceViewModel
            {
                Historique = _context.Calculs
                    .OrderByDescending(c => c.Date)
                    .ToList()
            };

            return View(vm);
        }
    

        // Action pour calculer l'expression envoyée par le formulaire
    [HttpPost]
        public IActionResult Calculer(CalculatriceViewModel vm)
        {
            try
            {
                var service = new CalculService();

                double resultat = service.CalculExpression(vm.Expression);

                vm.Resultat = resultat;

                _context.Calculs.Add(new Calcul
                {
                    Equation = vm.Expression,
                    Resultat = resultat,
                    Date = DateTime.Now
                });

                _context.SaveChanges();
            }
            catch
            {
                vm.MessageErreur = "Expression invalide.";
            }

            return View("Index", vm);
        }
    }
}
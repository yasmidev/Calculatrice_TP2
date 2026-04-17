# Calculatrice Web (.NET MVC)

## ---- Informations ----

* Noms : Yasmina Cabrera, Jaynelle Latortue-Raymond, Gia Bao Duong Ngo
* Matricule : 420-246-AH 

---

## ---- Description du projet ----

Ce projet est une application Web développée avec **ASP.NET Core MVC**.
Elle permet de réaliser des calculs mathématiques simples et complexes, tout en conserv*ant un historique des opérations effectuées.
Le projet est basé sur le TP1 (application console), qui a été adapté en version Web.
	 Yasmina : j'ai ajouté des commentaires dans le code pour expliquer les différentes parties, 
	 et j'ai également créé une interface utilisateur simple pour faciliter l'utilisation de la calculatrice.

---

## ---- Technologies utilisées ----

* C#
* ASP.NET Core MVC (.NET) - important pour la structure du projet et la gestion des requêtes web
* Entity Framework Core - important pour la gestion de la base de données et la sauvegarde des calculs
* SQLite
* HTML / CSS

---

## ---- Fonctionnalités ----

* Calculs simples (+, -, *, /)
* Calculs d’expressions complexes (parenthèses, puissances)
* Historique des calculs
* Sauvegarde des résultats en base de données
* Interface Web adaptative (ordinateur, tablette, mobile)

---

## ---- Structure du projet ----

* **Controllers** → gestion des requêtes web
* **Models** → structure des données
* **ViewModels** → données entre vue et contrôleur
* **Views** → interface utilisateur
* **Services** → logique métier
* **Utilities** → outils de calcul (parser d’expression)
* **Data** → base de données (DbContext)

---

## ---- TODO ----

* [ ] Interface HTML + CSS (RESPONSIVE)
* [ ] Créer le controller (Index, Calculer, Historique)
* [ ] Connecter le service de calcul
* [ ] Sauvegarder les calculs en base
* [ ] Afficher l’historique
* [ ] Ajouter validation des entrées
* [ ] Tester le projet complet
* [ ] Préparer la remise finale

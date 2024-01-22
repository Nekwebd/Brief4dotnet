# MovieMinimalAPI

## Contexte du projet

Après avoir créé une première version de la base de donnée de streaming, vous avez été en charge d'un autre projet. 

Le projet a été confié à un autre développeur qui a réalisé une première version d'[un front en react](https://github.com/simplon-lille-csharp-dotnet/MovieReactFront) et un back end en **minimal API** accessible dans ce dépôt.

En tant que Développeur .Net Junior, on vous demande de reprendre le projet et de faire fonctionner les appels du front au backend.

## Modalités pédagogiques

L'objectif est de faire fonctionner le front, c'est à dire implémenter les points de terminaison du back et ainsi répondre aux appels du front.

😥 Votre dépôt de base de donnée a malheureusement pas été égaré, il vous faut utiliser un autre dépôt de base de donnée réalisé par un autre développeur (celui dont vous avez revu le brief de streaming).

En voici la liste :
1. Obtenir les titre et date de sortie des films, du plus récent au plus ancien
	- Méthode HTTP : GET
	- URL : /films
	- Paramètres : Aucun
	- Description : Renvoie une liste de films triés par date de sortie, du plus récent au plus ancien.
2. Obtenir les titre et date de sortie d'un film en particulier
	- Méthode HTTP : GET
	- URL : /films/{idFilm}
	- Paramètres : Aucun
	- Description : Renvoie un film spécifique
3. Ajouter un film
	- Méthode HTTP : POST
	- URL : /films
	- Paramètres : Corps de la requête contenant les détails du film (titre, date de sortie, etc.)
	- Description : Ajoute un nouveau film à la base de données.
4. Ajouter un acteur/actrice
	- Méthode HTTP : POST
	- URL : /acteurs
	- Paramètres : Corps de la requête contenant les détails de l'acteur (nom, prénom, âge, etc.)
	- Description : Ajoute un nouvel acteur à la base de données.
5. Modifier un film
	- Méthode HTTP : PUT
	- URL : /films/{idFilm}
	- Paramètres : idFilm et corps de la requête avec les données modifiées du film
	- Description : Met à jour les informations d'un film spécifié.
6. Supprimer un acteur/actrice
	- Méthode HTTP : DELETE
	- URL : /acteurs/{idActeur}
	- Paramètres : idActeur (identifiant de l'acteur)
	- Description : Supprime l'acteur spécifié de la base de données.

## Modalités d'évaluation

Travail individuel

Démonstration à l'oral de votre travail (Schémas, Code, Repo Github).

### Critères

- **Code Source** : Propreté, organisation (1 fichier par classe), et documentation du code (nommage correct).
- **Vérification Git** : Commits conventionnels atomiques et réguliers, branches / issues / pull requests dans repo Github structurés.
- **Documentation** : Le fichier Readme.MD permet de comprendre ce qu'est votre projet, comment le récupérer et le lancer.

## Livrables

- Lien du repo GitHub contenant tout le code de l'application.
- Documentation détaillée du projet dans un fichier README.md.

## Critères de performance

- **Qualité du Code** : Clarté, efficacité et commentaires utiles.
- **Fonctionnalité** : Fiabilité et respect des fonctionnalités demandées.
- **Expérience Utilisateur** : Facilité d'utilisation et engagement.
- **Sécurité** : Bonne gestion des erreurs et des saisies utilisateur.
- **Versioning Git** : Utiliser des pratiques cohérentes et organisées.
- **Documentation** : Un fichier Readme.MD clair et précis.

# Ressources

- [Entrainement à la création d'API minimale avec des pizzas](https://learn.microsoft.com/fr-fr/training/modules/build-web-api-minimal-api)
- [Tutoriel : Créer une API minimale avec ASP.NET Core](https://learn.microsoft.com/fr-fr/aspnet/core/tutorials/min-web-api?view=aspnetcore-6.0)
- [Informations de référence "rapides" sur les API minimales](https://learn.microsoft.com/fr-fr/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-6.0)
- [Les méthodes d'extension sont magiques](https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)
- [Les middlewares dans ASP.net Core](https://learn.microsoft.com/fr-fr/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0)
- [Exemple d'utilisation du pilote MySql .Net](https://mysqlconnector.net/)

# API Semaine Productive  M1IL Sopra Steria Luca Franchini 2024/2025

![GitHub Workflow Status](https://img.shields.io/github/workflow/status/lfranchini31470/API_Semaine_Productive/CI)
![GitHub last commit](https://img.shields.io/github/last-commit/lfranchini31470/API_Semaine_Productive)
![GitHub contributors](https://img.shields.io/github/contributors/lfranchini31470/API_Semaine_Productive)
![GitHub language count](https://img.shields.io/github/languages/count/lfranchini31470/API_Semaine_Productive)
![GitHub top language](https://img.shields.io/github/languages/top/lfranchini31470/API_Semaine_Productive)
![License](https://img.shields.io/github/license/lfranchini31470/API_Semaine_Productive)

## 🎯 Aperçu du Projet

L'**API Semaine Productive** est une API RESTful conçue pour vous aider à gérer votre productivité quotidienne grâce à la gestion de tâches, enrichie potentiellement d'éléments inspirants (citations, défis positifs, inspirations). Elle est bâtie avec ASP.NET Core, offrant une architecture robuste et sécurisée.

Cette API est idéale pour les applications de bien-être, les tableaux de bord RH, les applications de productivité personnelle, ou tout projet nécessitant une gestion structurée de tâches avec une touche motivante.

## ✨ Fonctionnalités Clés

* **Gestion des Utilisateurs :** Inscription (`Register`) et connexion (`Login`) sécurisées via JWT (JSON Web Tokens).
* **Gestion des Tâches :** CRUD (Créer, Lire, Mettre à jour, Supprimer) pour vos tâches, permettant d'organiser et de suivre vos objectifs.
* **Authentification JWT :** Protection des endpoints d'API pour assurer que seules les requêtes autorisées puissent accéder aux ressources.
* **Base de données en mémoire :** Facilité de démarrage et de test grâce à une base de données en mémoire (parfait pour le développement et les démos).
* **Swagger/OpenAPI :** Documentation interactive de l'API pour faciliter l'exploration et le test des endpoints.

## 🚀 Technologies Utilisées

* **Backend :**
    * .NET 8.0 (ou .NET 9.0 si mis à jour)
    * ASP.NET Core Web API
    * Entity Framework Core (avec fournisseur In-Memory)
    * ASP.NET Core Identity (pour la gestion des utilisateurs et le hachage des mots de passe)
    * JWT (JSON Web Tokens) pour l'authentification
* **Outils de Développement :**
    * Visual Studio (recommandé) ou Visual Studio Code
    * .NET CLI

## 📋 Prérequis

Avant de commencer, assurez-vous d'avoir les éléments suivants installés sur votre machine :

* **SDK .NET 8.0** (ou le SDK .NET 9.0 si vous avez mis à jour le framework cible de votre projet). Vous pouvez le télécharger depuis [dot.net](https://dotnet.microsoft.com/download).
* Un éditeur de code : [Visual Studio](https://visualstudio.microsoft.com/) (édition Community gratuite) ou [Visual Studio Code](https://code.visualstudio.com/).
* Git (pour cloner le dépôt).

## 🚀 Installation et Démarrage Local

Suivez ces étapes pour configurer et exécuter le projet sur votre machine locale :

### 1. Cloner le Dépôt

Ouvrez votre terminal (CMD, PowerShell ou Bash) et exécutez la commande suivante :

```bash
git clone [https://github.com/lfranchini31470/API_Semaine_Productive.git](https://github.com/lfranchini31470/API_Semaine_Productive.git)
cd API_Semaine_Productive/API_Semaine_Productive # Naviguez vers le dossier du projet
# Itech.FolderInfo

## Description des projets de la solution

- **Itech.Domain.FolderInfo**
	Projet qui contient la logique de lecture du répertoire.
	Projet .Net Core 3.1

- **Itech.Domain.FolderInfo.Tests**
	Tests unitaires du projet FolderInfo
	Projet .Net Core 3.1

- **Itech.CLI**
	Ce projet est le projet command line qui permet, par ligne de commande, avoir le détail d'un répertoite.
	Projet .Net Core 3.1

- **Itech.FolderInfo.Api**
	Projet API qui encapsule l'utilisation de la libraire sous forme de service.
	Projet .Net Core 3.1

- **Itech.FolderInfo.App**
	Projet qui contient l'interface UI qui permet d'obtenir les informations sur un répertoire.
	Projet .Net Core 3.1 et Avalonia comme librairie visuelle.

## Installation 
1. Installer .Net Core sur Ubuntu 18.04
	https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu

## Compilation et exécution
1. Aller dans le répertoire de l'application, où se trouve le csproj, de l'application que vous voulez exécuter ( CLI ou App).
2. Dans un terminal, exécuter la commande suivante: `dotnet restore`.
3. Dans un terminal, exécuter la commande suivante: `dotnet run`.

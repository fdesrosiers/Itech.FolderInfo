# Itech.FolderInfo

## Description des projets de la solution

- **Itech.Domain.FolderInfo**
	Projet qui contient la logique de lecture du r�pertoire.
	Projet .Net Core 3.1

- **Itech.Domain.FolderInfo.Tests**
	Tests unitaires du projet FolderInfo
	Projet .Net Core 3.1

- **Itech.CLI**
	Ce projet est le projet command line qui permet, par ligne de commande, avoir le d�tail d'un r�pertoite.
	Projet .Net Core 3.1

- **Itech.FolderInfo.Api**
	Projet API qui encapsule l'utilisation de la libraire sous forme de service.
	Projet .Net Core 3.1

- **Itech.FolderInfo.App**
	Projet qui contient l'interface UI qui permet d'obtenir les informations sur un r�pertoire.
	Projet .Net Core 3.1 et Avalonia comme librairie visuelle.

## Installation 
1. Installer .Net Core sur Ubuntu 18.04
	https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu

## Compilation et ex�cution
1. Aller dans le r�pertoire de l'application, o� se trouve le csproj, de l'application que vous voulez ex�cuter ( CLI ou App).
2. Dans un terminal, ex�cuter la commande suivante: `dotnet restore`.
3. Dans un terminal, ex�cuter la commande suivante: `dotnet run`.

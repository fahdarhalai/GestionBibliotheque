# Gestion d'une Bibliotheque
## Description
Application Desktop WF (.NET) de gestion des livres et étagères dans une bibliothèque. Elle permet de traquer les livres et les étagères, avec possibilité d'ajout ou suppression.
Le projet utilise ainsi comme solution de stockage SQL Server Express LocalDB.
## Manuel
Pour tester et executer l'application il suffit de duppliquer ce projet Github en utilisant la commande:
```
git clone https://github.com/fahdarhalai/GestionBibliotheque.git
```
Vous devez d'abord se positionner dans le répertoire GestionLivres via la commande:
```
cd GestionBibliotheque/GestionLivres
```
Maintenant, il suffit de compiler le projet par la commande ```msbuild``` comme suit:
```
msbuild GestionLivres.csproj
```
Vous allez remarqué l'apparition des répertoire "bin" et "obj", il suffit de prendre l'executable (GestionLivres.exe) qui existe dans ```./bin/Debug/```, afin de tester les differentes fonctionnalités fournies par l'application.

## Screenshots
1- Mode Light:
<p align="center">
  <img src="https://user-images.githubusercontent.com/41004675/79070956-cba74400-7cd0-11ea-8c61-b618d1238a7b.PNG" width="85%">
</p>
2- Mode Dark:
<p align="center">
  <img src="https://user-images.githubusercontent.com/41004675/79070957-ccd87100-7cd0-11ea-8e29-a7a38d74ba60.PNG" width="85%">
</p>

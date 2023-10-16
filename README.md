

![Screenshot](ReadmeImage.png)
Forever 15


## Scenes principaux

Intro : Affiche notre logo 

Menu princpal : Permet de commencer le jeu, aller dans les paramètres et les modifier et de quitter le jeux 

Paramètre : Permet de modifier la résolution, mettre en plein écran, changer le volume  et la qualité

Level_1 : Joue une vidéo pendant 3 seconde avant de changer de scène

Level_2 : Fait rebondir une balle et au troisième bond change de scène

Level_3 : Vous jouer une balle qui dois se rendre au poteau rouge pour terminer le niveau

End_game : Affiche un message de victoire et propose au joueur de recommencer ou de quitter


## Scripts principaux
ButtonBehavior : Permet de gérer les clicks dans le menu

GlobalMusicPlayer : Permet de jouer de la musique dans tout le jouer

Parameter : Permet de gérer les changements des paramètres

GameTimer : Compte jusqu'a 3 avant de changer de scène

Ball : Compte le nombre de rebondissement, joue un son a chaque bond et change de scene au bout de 3 bond

CameraControl : Permet de faire bouger la camera avec le joueur

PLayerScript : Gére les inputs pour affecter le joueur

Input : Stocke les inputs du joueur

LevelLoader : Permet de changer de scene pour aller au menu

VictoryChooseLevel :  Permet de recommencer au level_1 ou de retourner au menu
## Autres Fichiers

UI_MainMenu et UI_Parameter : Permet de changer le ui des scènes sur lesquelles elles sont attribuées


## Controles

Pour le level_3 voici les controles : 

Flèches : Permet de controller la boules

Espace : Permet de sauter
## Fonctionnalité

Commencer le jeu

Modifier les paramètres

Jouer au jeu
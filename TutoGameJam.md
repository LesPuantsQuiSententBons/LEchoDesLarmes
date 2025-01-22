# Tuto pour les retardataires pour setup notre Game Jam

## Intro 
L'idée principale pour ce mini tuto ça va être d'essayer de setup tous les logiciels qu'on va utiliser, les comptes etc afin que tout le monde ait la même chose.
Déjà, je pars du principe que vous n'êtes PAS sur MacOS, vous êtes probablement sous Windows et c'est super (si vous êtes sur Linux wsh vous vous compliquez déjà assez la vie comme ça).

## Téléchargements
Voici tous les liens sur lesquels vous allez aller pour télécharger TOUS nos logiciels : 
- D'abord **Git**, qui servira de Google Drive à notre projet : https://git-scm.com/downloads ([Téléchargement Windows directement](https://github.com/git-for-windows/git/releases/download/v2.47.1.windows.2/Git-2.47.1.2-64-bit.exe))
- Ensuite, **Git LFS**, pour gérer les fichiers un peu gros sans problème : https://git-lfs.com/ ([Téléchargement Windows directement](https://github.com/git-for-windows/git/releases/download/v2.47.1.windows.2/Git-2.47.1.2-64-bit.exe))
- Maintenant, pour avoir une interface visuelle pour utiliser tout ça, **Github Desktop** : https://desktop.github.com/download/ ([Téléchargement Windows directement](https://desktop.githubusercontent.com/releases/3.4.15-3fea2a10/GitHubDesktopSetup-x64.exe))
- Il nous reste plus qu'à prendre la dernière version de **Unity** : https://unity.com/fr/download ([Téléchargement Windows directement](https://public-cdn.cloud.unity3d.com/hub/prod/UnityHubSetup.exe))

## Setup des applications
Maintenant que vous avez téléchargé l'entierté des fichiers dont on va avoir besoin, allons y pas à pas.

### Setup Git
D'abord, **lancez l'exécutable de Git** pour pouvoir le télécharger. Acceptez tout ce qu'il propose directement, pas besoin de l'emmerder plus que ça.
Ensuite, **lancez l'exécutable de Git LFS**, même chose, acceptez tout et faites
Maintenant, **lancez l'exécutable de Github Desktop** pour avoir l'interface visuelle. Une fois lancé, vous devrez sûrement créer votre compte Github, **souvenez-vous de l'adresse que vous utilisez**.
Il faudra ensuite que vous renseignez un email et un nom/prénom, pour qu'en gros on reconnaisse qui fait quoi sur le Git, l'équivalent du drive.

Voilà ! Git est setup, passons à la suite

### Ajout à l'organisation du projet
Si ce n'est pas déjà fait, envoyez moi votre **mail Github** dont vous devriez vous souvenir, afin que je vous ajoute à l'organisation Github (qui s'appelle *LesPuantsQuiSententBons*, pas de commentaire.).
Maintenant, vous avez officiellement accès au repository qui correspond au projet Unity, c'est merveilleux ! Vous pouvez donc revenir sur Github Desktop, et cloner un "repository" (c'est comme ça qu'on appelle le drive de Git) afin de mettre sur votre disque dur le projet.

### Setup Unity
Je crois que c'est déjà fait, mais dans le doute allons y : 
Il ne reste plus qu'à télécharger Unity et sa bonne version; pour se faire, il faut d'abord **lancer l'exécutable de Unity** qui téléchargerea le **Unity Hub**, application qui permet de répertorier vos différentes versions de Unity installées. Une fois dans l'accueil, il risque de vous proposer automatiquement d'installer la dernière version LTS, *6000.0.34f1*. Si ce n'est pas le cas, téléchargez cette version manuellement depuis l'appli. 
Une fois téléchargée, vous avez donc un éditeur que vous pouvez utiliser pour visualiser et utiliser le projet Unity. Donc, dans l'interface de Unity Hub, vous allez cliquer sur *Add -> Add Project from disk*, et ensuite naviguer **non pas** vers le gros dossier AxeCuirEtCookie contenant le répertoire Git, mais bien le dossier AxeCuirEtCookie **à l'intérieur** de celui ci, avec autour le dossier .git, le README.md...

## VOUS AVEZ FINI BRAVO WAOUH
---------------------------------------------------------------  ReadMe pour les mise à jour  --------------------------------------------------------------------

j'ai changer les informations de connexion pour me connecter vers mon instance de Server SQl dans le appsettings.json puis j'ai fait le push vers mon repos github
--------------------------------------------------------------------------------------------------------------------------------------------------------------
 1.)  Erreur 1  trouvé : aprés le lancement de l'application j'ai accéder à la page d'accueil puis j'ai voulu me connecter en tant que administrateur du coup je dois remplir le login et le password. Je me suis rendu compte que le 
   ### password n'est pas cacher #### 
   ## correction :  j'ai ajouter un input type="password" dans le Login.cshtml  ##
----------------------------------------------------------------------------------------------------------------------------------------------------------------
2.) Erreur 2 trouvé :Lors de la création d'un produit, les champs comme Nom, Prix et Stock sont obligatoires du coup si l'admin ne les rensigne pas il doit afficher des messages
### personalisés comme par exemple "veiller renseigner le nom du produit" ou même "veiller renseigner le prix du produit" etc..  au niveau du champ concernant  ###
 ## Correction:##
   # j'ai crée le fichier  Product.cs pour déclarer nos différents type d'ErrorMessage comme MissingName, MissingPrice etc.. , ensuite au niveau des fichiers .resx Faire la traduction de chaque type de message d'erreur  
  # Ensuite dans mon fichier Product/Create.cshtml  ajouter  <span asp-validation-for="Name" class="text-danger"></span>,  <span asp-validation-for="Stock" class="text-danger"></span> et  <span asp-validation-for="Price" class="text-danger"></span> aprés les Label Name, Price et Stock

---------------------------------------------------------------------------------------------------------------------------------------------------------
3.) Erreur 3 trouvé :
   ## Le stock doit etre un entier positif et non nul donc l'admin ne doit pas avoir la possibilité de saisir de lettres ou de caractères 
   ## Correction : Modifier le type="text" du input en type="number" pour le label Stock dans le fichier Product/Create.cshtml

-----------------------------------------------------------------------------------------------------------------------------------------------

4.) Erreur 4 trouvé : 
   ## Le prix doit etre un nombre decimal donc l'admin ne doit pas avoir la possibilité de saisir de lettres ou de caractères
   ## Correction : Ajouter un input type="number" aprés le Label Price dans Product/Create.cshtml

5.) Iternalisation du wolof 


6.) Test 

   













# DotNetEnglishP3
Dépôt de l’étudiant pour le projet 3 du parcours Développeur Back-End .NET. Afin d'être au plus proche d'une situation professionnelle réelle, le code dans ce dépôt est en anglais.

Ce projet possède une base de données intégrée qui sera créée lorsque l’application sera exécutée pour la première fois. Pour la créer correctement, vous devez satisfaire aux prérequis ci-dessous et mettre à jour les chaînes de connexion pour qu’elles pointent vers le serveur MSSQL qui est exécuté sur votre PC en local.

**Prérequis** : MSSQL Developer 2019 ou Express 2019 doit être installé avec Microsoft SQL Server Management Studio (SSMS).

MSSQL : https://www.microsoft.com/fr-fr/sql-server/sql-server-downloads

SSMS : https://docs.microsoft.com/fr-fr/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16

*Remarque : les versions antérieures de MSSQL Server devraient fonctionner sans problèmes, mais elles n’ont pas été testées.

*Dans le projet P3AddNewFunctionalityDotNetCore, ouvrez le fichier appsettings.json.*

Vous avez la section ConnectionStrings qui définit les chaînes de connexion pour les 2 bases de données utilisées dans cette application.

      "ConnectionStrings":
      {
        "P3Referential": "Server=.;Database=P3Referential-2f561d3b-493f-46fd-83c9-6e2643e7bd0a;Trusted_Connection=True;MultipleActiveResultSets=true",
        "P3Identity": "Server=.;Database=Identity;Trusted_Connection=True;MultipleActiveResultSets=true"
      }
  
**P3Referential** - chaîne de connexion à la base de données de l’application.

**P3Identity** - chaîne de connexion à la base de données des utilisateurs. Il s’agit d’une base de données indépendante, car une organisation utilise généralement plusieurs applications différentes. Au lieu
de laisser chaque application définir ses propres utilisateurs (et plusieurs identifiants et mots de passe différents pour un seul utilisateur), une organisation peut disposer d’une base de données utilisateur unique et utiliser des autorisations et des rôles pour définir les applications auxquelles l’utilisateur a accès. De cette façon, un utilisateur peut accéder à toutes les applications de l’organisation avec le même identifiant et le même mot de passe, mais il n’aura accès qu’aux bases de données et aux actions définies dans la base de données des utilisateurs.

Il existe des versions différentes de MSSQL (veuillez utiliser MSSQL pour ce projet et non une autre base de données). Lorsque vous configurez le serveur de base de données, diverses options modifient la configuration de sorte que les chaînes de connexion définies peuvent ne pas fonctionner.

Les chaînes de connexion définies dans le projet sont configurées pour MSSQL Server Standard 2019. L’installation n’a pas créé de nom d’instance, le serveur est donc simplement désigné par « . », qui désigne l’instance par défaut de MSSQL Server fonctionnant sur la machine actuelle. Pendant l’installation, c’est l’utilisateur intégré de Windows qui est configuré dans le serveur MSSQL par défaut.

Si vous avez installé MSSQL Express, la valeur à utiliser pour Server est très probablement .\SQLEXPRESS. Donc votre chaîne de connexion P3Referential serait :

    "P3Referential": "Server=.\SQLEXPRESS;Database=P3Referential-2f561d3b-493f-46fd-83c9-6e2643e7bd0a;Trusted_Connection=True;MultipleActiveResultSets=true"
  
Si vous avez des difficultés à vous connecter, essayez d’abord de vous connecter à l’aide de Microsoft SQL Server Management Studio (assurez-vous que le type d’authentification est « Authentification Windows »), ou consultez le site https://sqlserver-help.com/2011/06/19/help-whats-my-sql-server-name/.
Si le problème persiste, demandez de l’aide à votre mentor.






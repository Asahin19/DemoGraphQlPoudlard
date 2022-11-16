Pré-requis
Visual Studio
.Net Core 3
Microsoft SQL Studio

Etape 1 : Mise en place du projet 
Récupérer les sources du projet : git clone https://github.com/Asahin19/DemoGraphQlPoudlard.git
Publier la base de données en double cliquant sur le fichier Poudlard.Database.publish 
Jouer le contenu de ScriptInit sur votre base de données

Etape 2 : Une requête GraphQL
Après avoir démarré votre API rendez-vous à l'adresse : https://localhost:55579/ui/playground
Vous pouvez écrire vos première requête GraphQL; par exemple :
 query {students{firstName}}
Vous obtenez ainsi la liste des prénoms des étudiants. 

Etape 3 : Requêtez les Prénoms Nom de famille et Age de chaque étudiant

Etape 4 : Utiliser un paramètre avec la requête student
Après avoir démarré votre API rendez-vous à l'adresse : https://localhost:55579/ui/playground
Vous pouvez écrire vos première requête GraphQL; par exemple :
 Par exemple query {student(id:1){firstName}}
Vous obtenez ainsi la liste des prénoms des étudiants. 

Etape 5 : Première mutation GraphQL
Maintenant on va créer une mutation pour cela il faut renseigner les différentes informations . Voici un exemple
mutation{createStudent(house:Gryphondor, firstName:"Henry", lastName:"pierre", birthDate:"2000/07/10"){id, lastName, firstName, house {name}}}
Maintenant à vous de jouer !

Etape 6 : Réaliser une query qui expose la liste des professeurs et les maisons

Etape 7 : Réaliser une query qui expose un professeur filtré par son Id

Etape 8 : Réaliser une query qui expose les professeurs filtrés par un nom de famille

Etape 9 : Réaliser une mutation qui ajoute un professeur

Etape 10 Bonus :Dans l'histoire les professeurs attribuent ou retirent des points à chaque maison en fonction des bonnes ou mauvaises actions des élèves.Il faut créer une mutation qui permet d'ajouter un nombre de point à une maison.Et faire évoluer la requête sur les maisons pour que cette dernière expose un champ point qui correspond à la somme de l'ensemble des points obtenus par la maison. L'action d'ajout ou de retrait de point doit se faire via l'objet Reward qui correspond à une action d'un professeur.

Enfin il faudra implémenter le classement des maisons en fonction du nombre de points obtenus.



Pr�-requis
Visual Studio
.Net Core 3
Microsoft SQL Studio

Etape 1 : Mise en place du projet�
R�cup�rer les sources du projet :�git clone�https://github.com/Asahin19/DemoGraphQlPoudlard.git
Publier la base de donn�es en double cliquant sur le fichier�Poudlard.Database.publish�
Jouer le contenu de ScriptInit sur votre base de donn�es

Etape 2 : Une requ�te GraphQL
Apr�s avoir d�marr� votre API rendez-vous�� l'adresse : https://localhost:55579/ui/playground
Vous pouvez �crire vos premi�re requ�te GraphQL; par exemple :
�query {students{firstName}}
Vous obtenez ainsi la liste des pr�noms des �tudiants.�

Etape 3 : Requ�tez les Pr�noms Nom de famille et Age de chaque �tudiant

Etape 4 : Utiliser un param�tre avec la requ�te student
Apr�s avoir d�marr� votre API rendez-vous�� l'adresse : https://localhost:55579/ui/playground
Vous pouvez �crire vos premi�re requ�te GraphQL; par exemple :
�Par exemple query {student(id:1){firstName}}
Vous obtenez ainsi la liste des pr�noms des �tudiants.�

Etape 5 : Premi�re mutation�GraphQL
Maintenant on va cr�er une mutation pour cela il faut renseigner les diff�rentes informations . Voici un exemple
mutation{createStudent(house:Gryphondor, firstName:"Henry", lastName:"pierre", birthDate:"2000/07/10"){id, lastName, firstName, house {name}}}
Maintenant � vous de jouer !

Etape 6 : R�aliser une�query�qui expose la liste des professeurs et les maisons

Etape 7 : R�aliser une�query�qui expose un professeur filtr� par son Id

Etape 8 : R�aliser une�query�qui expose les professeurs filtr�s par un nom de�famille

Etape 9 : R�aliser une mutation qui ajoute un professeur

Etape 10 Bonus :Dans l'histoire les professeurs attribuent ou retirent des points � chaque maison en fonction des bonnes ou mauvaises actions�des �l�ves.Il faut cr�er une mutation qui permet d'ajouter un nombre de point � une maison.Et faire �voluer la requ�te sur les maisons pour que cette derni�re expose un champ point qui correspond � la somme de l'ensemble des points obtenus par la maison. L'action d'ajout ou de retrait de point doit se faire via l'objet Reward qui correspond � une action d'un professeur.

Enfin il faudra impl�menter le classement des maisons en fonction du nombre de points obtenus.



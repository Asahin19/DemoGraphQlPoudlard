INSERT INTO dbo.Houses ([Id], [Name])
VALUES 
(1, 'Gryffondor'),
(2, 'Serpentard'),
(3, 'Poufsouffle'),
(4, 'Serdaigle')

INSERT INTO dbo.Professors([Firstname], [Lastname])
VALUES 
('Minerva', 'McGonagall'),
('Severus', 'Rogue'),
('Albus', 'Dumbledore'),
('Remus', 'Lupin')


INSERT INTO dbo.Students ([Lastname], [Firstname], [BirthDate], [HouseId])
VALUES 
('Diggory', 'Cedric', '1977-09-01', 3),
('Malefoy', 'Drago', '1980-06-05', 2),
('Chang', 'Cho', '1979-03-12', 4),
('Londubat', 'Neville', '1980-07-30', 1)
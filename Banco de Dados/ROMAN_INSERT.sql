USE SENAI_ROMAN_DESAFIO_SIESG;

INSERT INTO USUARIO
VALUES ('adim@adim.com', 123, 'Administrador'), ('prof@prof.com', 123, 'Professor'), ('tadeu@tadeu.com', 123, 'Professor')

SELECT *FROM USUARIO

INSERT INTO GRUPO
VALUES ('Desenvolvimento'),('Redes')

SELECT *FROM GRUPO

INSERT INTO PROFESSOR
VALUES (2,'Tadeu',1),(3, 'Helena', 1)

SELECT *FROM PROFESSOR

INSERT INTO PROJETOS
VALUES ('Whislist','Lista de desejos','Desejos',1,0), ('Roman','Compartilhamento de projetos','Projetos',2,1)

SELECT * FROM PROJETOS

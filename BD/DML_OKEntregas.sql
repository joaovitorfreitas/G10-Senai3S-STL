USE OKEntregas

INSERT INTO Usuarios	(Nome, Sobrenome, Email, Senha, TipoUsuario)
VALUES                  ('Daniel', 'Ferreira', 'daniel@gmail.com', '123', 0),
						('Alan', 'Malu', 'alan@gmail.com', '123', 1)


INSERT INTO Empresa	(NomeEmpresa, NumeroDeFuncionarios, NumeroDeTelefone, EmailEmpresa, NomeFantasia, Cnpj, SegmentoDeMercado)
VALUES                  ('EmpresaStl1', 12, 11971697877,'EmStl1@gmail.com', 'STL1', '123456789123', 'Tecnologia'),
						('EmpresaStl2', 30, 11971697877,'EmStl2@gmail.com', 'STL2', '123456789123', 'Gastronomia'),
						('EmpresaStl3', 40, 11971697877,'EmStl3@gmail.com', 'STL3', '123456789123', 'Eletrica')

INSERT INTO UsuarioLeads	(Telefone, Email, statusLead, Cargo, Nome)
VALUES                  ('1140028922', 'Kleber@gmail.com', 'ativo','Dev FullStack', 'Kleber'),
						('1140028922', 'Alan@gmail.com', 'ativo','Dev FrontEnd', 'Alan'),
						('1140028922', 'Caic@gmail.com', 'ativo','Dev BackEnd', 'Caic')

INSERT INTO Leads	(Score, Necessidades, IdUsuarioLeads, IdEmpresa)
VALUES                  ('Medio', 'Analista Sistema',  1, 1),
						('Alto', 'Avaliador Industrial',  2, 2),
						('Baixo', 'Gerente de marketing', 2, 3)

							
INSERT INTO Reuniao	(DataInicio, DataTermino, ATA, IdUsuario, IdLeads)
VALUES                  ('2021-12-09 15:45:21' , '2021-12-09 16:00:08', 'FADWA1', 1, 1),
						('2021-11-09 15:45:21' , '2008-11-09 16:00:40', 'FADWA2', 1, 3),
						('2021-10-09 15:45:21' , '2008-10-09 16:00:21', 'FADWA3', 1, 2)


INSERT INTO WhatsAPP	(IdLeads, NumeroContato)
VALUES                  (1 , '1140028922'),
						(2 , '1140028922'),
						(3 , '1140028922')


INSERT INTO Email	(IdLeads, Email)
VALUES                  (1 , 'contato1@gmail.com'),
						(2 , 'contato2@gmail.com'),
						(3 , 'contato3@gmail.com')

INSERT INTO Linkedin	(IdLeads, Nome, NumeroTelefone)
VALUES                  (1 , 'Aldair', '1140028922'),
						(2 , 'Alduar', '1140028922'),
						(3 , 'Lua', '1140028922')
							
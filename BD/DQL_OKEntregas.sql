USE OKEntregas

SELECT IdUsuario,  Nome, Sobrenome, Email, Senha, TipoUsuario,VerificacaoEmail
FROM   Usuarios;

SELECT IdEmpresa,  NomeEmpresa, NumeroDeFuncionarios, NumeroDeTelefone, EmailEmpresa, NomeFantasia, Cnpj, SegmentoDeMercado
FROM   Empresa;

SELECT IdUsuarioLeads,  Telefone, Email, statusLead, Cargo, Nome
FROM   UsuarioLeads;

SELECT IdLeads,  Score, Necessidades,Telefone, Email, statusLead, Cargo , Nome,NomeEmpresa,NumeroDeFuncionarios, NumeroDeTelefone, EmailEmpresa, NomeFantasia,  Cnpj, SegmentoDeMercado
FROM   Leads
INNER JOIN UsuarioLeads ON UsuarioLeads.IdUsuarioLeads = Leads.IdUsuarioLeads
INNER JOIN Empresa ON  Empresa.IdEmpresa = Leads.IdEmpresa


SELECT IdReuniao,  DataInicio, DataTermino, ATA, Sobrenome, Email, Senha, TipoUsuario, Nome, Score, Necessidades, IdUsuarioLeads, IdEmpresa
FROM   Reuniao
INNER JOIN  Usuarios ON Reuniao.IdUsuario = Usuarios.IdUsuario
INNER JOIN  Leads ON  Leads.IdLeads =  Reuniao.IdLeads


SELECT IdContato,  NumeroContato, Score, Necessidades, IdUsuarioLeads,IdEmpresa
FROM   WhatsAPP
INNER JOIN  Leads ON Leads.IdLeads = WhatsAPP.IdLeads

SELECT IdEmail,  Email,Score, Necessidades, IdUsuarioLeads,IdEmpresa
FROM   Email
INNER JOIN  Leads ON Leads.IdLeads = Email.IdLeads


SELECT IdLinkedin,  Nome, NumeroTelefone, Score, Necessidades, IdUsuarioLeads,IdEmpresa
FROM   Linkedin
INNER JOIN  Leads ON Leads.IdLeads = Linkedin.IdLeads










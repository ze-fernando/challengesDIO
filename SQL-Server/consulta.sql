--01--
SELECT Nome, Ano FROM Filmes

--02--
SELECT Nome, Ano, Duracao FROM Filmes ORDER BY Ano

--03--
SELECT Nome, Ano, Duracao FROM Filmes WHERE Nome = 'De Volta para o Futuro'

--04--
SELECT Nome, Ano, Duracao FROM Filmes WHERE Ano = 1997

--05--
SELECT Nome, Ano, Duracao FROM Filmes WHERE Ano > 2000

--06--
SELECT Nome, Ano, Duracao FROM Filmes WHERE Duracao > 100 AND Duracao < 150 ORDER BY Duracao

--07--
SELECT Ano,	COUNT(1) Quantidade FROM Filmes GROUP BY Ano ORDER BY Quantidade DESC

--08--
SELECT * FROM Atores WHERE Genero = 'M'

--09--
SELECT * FROM Atores WHERE Genero = 'F' ORDER BY PrimeiroNome 

--10--
SELECT f.Nome, g.Genero FROM Filmes f INNER JOIN FilmesGenero fg ON f.Id = fg.IdFilme INNER JOIN Generos g ON fg.IdGenero = g.Id 

--11--
SELECT f.Nome, g.Genero FROM Filmes f INNER JOIN FilmesGenero fg ON f.Id = fg.IdFilme INNER JOIN Generos g ON fg.IdGenero = g.Id WHERE g.Genero = 'Mist�rio'

--12--
SELECT f.Nome, a.PrimeiroNome, a.UltimoNome, ef.Papel FROM Filmes f INNER JOIN ElencoFilme ef ON f.Id = ef.IdFilme INNER JOIN Atores a ON ef.IdAtor = a.Id
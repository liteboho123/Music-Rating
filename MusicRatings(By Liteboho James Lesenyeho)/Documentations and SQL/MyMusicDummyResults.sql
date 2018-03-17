insert into Genre values('Rock')
insert into Artist values('ben', 2)
insert into Track values('','gh','',1)

select * from Track
select * from Artist
select * from Genre
where ID = 3

delete from Track
delete from Artist 
delete from Genre
where ID = 1

select a.ID, a.ArtistName as [Artist Name], g.GenreType as [Genre], t.Rating, t.Song as Track, t.[Year] as [Year Established]
from Artist a inner join Genre g on g.ID = a.GenreID join Track t on a.ID = t.ArtistID
where a.ID = 1

update Artist set ArtistName = 'bobby' 
update Track set Rating = '4', Song = 'freak', [Year] = '2003'
update Genre set GenreType = 'hiphop'
where ID = 1

select a.ArtistName as [Artist Name]
from Artist a
where a.ArtistName like '%k%'
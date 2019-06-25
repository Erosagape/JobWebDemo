use JOB_WEB
go
alter table dbo.Job_WHTax add Branch1 varchar(5)
alter table dbo.Job_WHTax add Branch2 varchar(5)
alter table dbo.Job_WHTax add Branch3 varchar(5)
alter table dbo.Job_WHTaxDetail add PayRate float null
go
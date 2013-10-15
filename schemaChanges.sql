alter table StudentInformation add StudentId int identity(1,1) not null
go

truncate table OptionsprogramNew
go

alter table OptionsProgramNEW add StudentId int not null
go

alter table OptionsProgramNEW add OptionsId int identity(1,1) not null
go
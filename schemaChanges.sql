alter table StudentInformation add StudentId int identity(1,1) not null primary key
go

truncate table OptionsProgramNEW
alter table OptionsProgramNEW drop PK_DuplicateStudents5789
alter table OptionsProgramNEW drop column StudentFirstName
alter table OptionsProgramNEW drop column StudentMiddleName
alter table OptionsProgramNEW drop column StudentLastName
go

alter table OptionsProgramNEW add StudentId int not null 
alter table OptionsProgramNEW add OptionsId int identity(1,1) not null
go

alter table OptionsProgramNEW
	add constraint PK_OptionsProgramNEW_OptionsID primary key clustered (OptionsId)

truncate table OptionsCareerTemplate
alter table OptionsCareerTemplate drop PK_DuplicateStudents7843843985654
alter table OptionsCareerTemplate drop column StudentFirstName
alter table OptionsCareerTemplate drop column StudentMiddleName
alter table OptionsCareerTemplate drop column StudentLastName
alter table OptionsCareerTemplate add OptionsId int not null

truncate table OptionsTradeTemplate
alter table OptionsTradeTemplate drop PK_DuplicateStudents7654
alter table OptionsTradeTemplate drop column StudentFirstName
alter table OptionsTradeTemplate drop column StudentMiddleName
alter table OptionsTradeTemplate drop column StudentLastName
alter table OptionsTradeTemplate add OptionsId int not null

truncate table OptionsMilitaryTemplate
alter table OptionsMilitaryTemplate drop PK_DuplicateStudents785654
alter table OptionsMilitaryTemplate drop column StudentFirstName
alter table OptionsMilitaryTemplate drop column StudentMiddleName
alter table OptionsMilitaryTemplate drop column StudentLastName
alter table OptionsMilitaryTemplate add OptionsId int not null

truncate table OptionsMinistryTemplate
alter table OptionsMinistryTemplate drop PK_DuplicateStudents78985654
alter table OptionsMinistryTemplate drop column StudentFirstName
alter table OptionsMinistryTemplate drop column StudentMiddleName
alter table OptionsMinistryTemplate drop column StudentLastName
alter table OptionsMinistryTemplate add OptionsId int not null

truncate table OptionsCollegeTemplate
alter table OptionsCollegeTemplate drop PK_DuplicateStudents87657
alter table OptionsCollegeTemplate drop column StudentFirstName
alter table OptionsCollegeTemplate drop column StudentMiddleName
alter table OptionsCollegeTemplate drop column StudentLastName
alter table OptionsCollegeTemplate add OptionsId int not null


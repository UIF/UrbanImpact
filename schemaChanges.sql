alter table StudentInformation add StudentId int identity(1,1) not null primary key
go

create table Options (
	OptionsId int not null primary key identity(1,1),
	StudentId int not null,
	PrimaryBus varchar(50) null,
	Comment varchar(max) null,
	DriversLicense bit null,
	BirthCertificate bit null,
	PaIDCard bit null,
	HasGraduated bit null,
	BankAccount bit null,
	SocialSecurityCard bit null,
	AssessmentTesting datetime null,
	PrimaryMentor varchar(250) null,
	HSTranscript datetime null,
	HSGraduation datetime null,
	GPA varchar(50) null,
	GPADate datetime null,
	LastUpdatedBy varchar(50) not null,
	DateAdded datetime not null default getdate(),
	DateModified datetime not null default getdate() 
)
create table ActivityLog (
	ActivityId int not null primary key identity(1,1),
	ActivityArea varchar(50) not null,
	AreaId int not null,
	ActivityEntry varchar(max),
	LastUpdatedBy varchar(50) not null,
	DateAdded datetime not null default getdate(),
	DateModified datetime not null default getdate()
)

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


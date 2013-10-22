IF OBJECT_ID ( 'AddStudentToOptions', 'P' ) IS NOT NULL 
    DROP PROCEDURE AddStudentToOptions;
GO
CREATE PROCEDURE AddStudentToOptions 
    @StudentId int, 
    @LastUpdatedBy nvarchar(50) 
AS 
	insert into Options (StudentId, LastUpdatedBy) values (@StudentId, @LastUpdatedBy)
	insert into ActivityLog (ActivityArea, AreaId, ActivityEntry, LastUpdatedBy)
		values ('Options', SCOPE_IDENTITY(), 'Student Added to Options', @LastUpdatedBy)

GO
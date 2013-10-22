IF OBJECT_ID ( 'GetOptionsDetails', 'P' ) IS NOT NULL 
    DROP PROCEDURE GetOptionsDetails;
GO
CREATE PROCEDURE GetOptionsDetails 
    @OptionsID int
AS 
	select s.FirstName, s.LastName, o.PrimaryBus, o.Comment, o.DriversLicense,
		   o.BirthCertificate, o.PaIDCard, o.HasGraduated, o.BankAccount,
		   o.SocialSecurityCard, o.AssessmentTesting, o.PrimaryMentor,
		   o.HSTranscript, o.HSGraduation, o.GPA, o.GPADate		   
		from Options o
		join StudentInformation s on s.StudentId = o.StudentId
		where o.OptionsId = @OptionsID
		
	select ActivityId, ActivityEntry, LastUpdatedBy, DateModified
		from ActivityLog
		where ActivityArea = 'Options'
		and AreaId = @OptionsId

GO

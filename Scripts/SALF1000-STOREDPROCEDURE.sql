-- Batch submitted through debugger: SQLQuery6.sql|7|0|C:\Users\evisser\AppData\Local\Temp\1\~vs842E.sql
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SALF1000]
	-- Add the parameters for the stored procedure here
	@Param1 smallint
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
SELECT  EMPTABLE.EMP_COMPID, EMPTABLE.EMP_EMPLOYEENR, EMPTABLE.EMP_FIRSTNAME, EMPTABLE.EMP_LASTNAME, EMPTABLE.EMP_DEPARTMENT, DEPNAME, EMPTABLE.EMP_POSITION, EMPTABLE.EMP_STATUS, 
                         EMPTABLE.EMP_STARTDATE, EMPTABLE.EMP_ENDDATE
FROM            EMPTABLE INNER JOIN
                         DEPARTMENTS ON EMPTABLE.RecordNr = DEPARTMENTS.RecordNr
WHERE        (EMPTABLE.EMP_COMPID = @Param1)

END
 
 EXEC dbo.SALF1000 @param1 ='5000'

 /* Select EMP_COMPID,EMP_EMPLOYEENR,EMP_FIRSTNAME,EMP_LASTNAME,EMP_DEPARTMENT,EMP_POSITION,EMP_STATUS,EMP_STARTDATE,EMP_ENDDATE From EMPTABLE WHERE EMP_COMPID = @Param1 ORDER BY EMP_COMPID, EMP_EMPLOYEENR */
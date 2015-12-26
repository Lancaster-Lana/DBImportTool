
DECLARE @employerID int, 
				@salesdate datetime,
				@message varchar(max)

DECLARE empl_cursor CURSOR FOR 
				select [EmployerID],[Sales Effective Date] 
				from   [dbo].[SalesEffectiveDates]

OPEN   empl_cursor

FETCH NEXT FROM empl_cursor INTO @employerID, @salesdate

WHILE @@FETCH_STATUS = 0
	BEGIN
	    PRINT ' '
        SELECT @message = 
		        'UPDATE [dbo].[Employer] WITH(ROWLOCK) '
				+ '   SET [dbo].[Employer].[SalesPersonEffectiveDate] =''' + convert(VARCHAR, @salesdate, 112)+''''
				+ '	 WHERE [dbo].[Employer].[Employer]=' + convert(varchar, @employerID)
	
        PRINT  @message		
		
		FETCH NEXT FROM empl_cursor
			INTO  @employerID, @salesdate
	END
	
CLOSE empl_cursor
DEALLOCATE empl_cursor
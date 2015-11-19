USE [Reminder]
GO

/****** Object:  StoredProcedure [dbo].[SPT_DeleteAppointmets]    Script Date: 19.11.2015 10:32:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SPT_DeleteAppointmets]
(
	@Original_UniqueID int,
	@IsNull_Type Int,
	@Original_Type int,
	@IsNull_StartDate Int,
	@Original_StartDate smalldatetime,
	@IsNull_EndDate Int,
	@Original_EndDate smalldatetime,
	@IsNull_AllDay Int,
	@Original_AllDay bit,
	@IsNull_Subject Int,
	@Original_Subject nvarchar(50),
	@IsNull_Location Int,
	@Original_Location nvarchar(50),
	@IsNull_Status Int,
	@Original_Status int,
	@IsNull_Label Int,
	@Original_Label int,
	@IsNull_ResourceID Int,
	@Original_ResourceID int,
	@IsNull_LastEditTime Int,
	@Original_LastEditTime datetime,
	@IsNull_AddedTime Int,
	@Original_AddedTime datetime,
	@IsNull_ZOVReminderUsersID Int,
	@Original_ZOVReminderUsersID int,
	@IsNull_ZOVReminderUsers Int,
	@Original_ZOVReminderUsers nvarchar(4000),
	@IsNull_IsDeleted Int,
	@Original_IsDeleted bit
)
AS BEGIN
	SET NOCOUNT OFF;
	
	EXEC [dbo].[SP_ClearAppointmentsForUsers] @Original_UniqueID

	UPDATE A
		SET A.IsDeleted = 1
	FROM [ZOVAppointments] A
	WHERE (A.[UniqueID] = @Original_UniqueID)
/*
	DELETE FROM [ZOVAppointments] 
	WHERE (([UniqueID] = @Original_UniqueID))/* AND 
		  ((@IsNull_Type = 1 AND [Type] IS NULL) OR ([Type] = @Original_Type)) AND 
		  ((@IsNull_StartDate = 1 AND [StartDate] IS NULL) OR ([StartDate] = @Original_StartDate)) AND 
		  ((@IsNull_EndDate = 1 AND [EndDate] IS NULL) OR ([EndDate] = @Original_EndDate)) AND 
		  ((@IsNull_AllDay = 1 AND [AllDay] IS NULL) OR ([AllDay] = @Original_AllDay)) AND 
		  ((@IsNull_Subject = 1 AND [Subject] IS NULL) OR ([Subject] = @Original_Subject)) AND 
		  ((@IsNull_Location = 1 AND [Location] IS NULL) OR ([Location] = @Original_Location)) AND 
		  ((@IsNull_Status = 1 AND [Status] IS NULL) OR ([Status] = @Original_Status)) AND 
		  ((@IsNull_Label = 1 AND [Label] IS NULL) OR ([Label] = @Original_Label)) AND 
		  ((@IsNull_ResourceID = 1 AND [ResourceID] IS NULL) OR ([ResourceID] = @Original_ResourceID)) AND 
		  ((@IsNull_LastEditTime = 1 AND [LastEditTime] IS NULL) OR ([LastEditTime] = @Original_LastEditTime)) AND 
		  ((@IsNull_AddedTime = 1 AND [AddedTime] IS NULL) OR ([AddedTime] = @Original_AddedTime)) AND 
		  ((@IsNull_ZOVReminderUsersID = 1 AND [ZOVReminderUsersID] IS NULL) OR ([ZOVReminderUsersID] = @Original_ZOVReminderUsersID)) AND 
		  ((@IsNull_ZOVReminderUsers = 1 AND [ZOVReminderUsers] IS NULL) OR ([ZOVReminderUsers] = @Original_ZOVReminderUsers)) AND 
		  ((@IsNull_IsDeleted = 1 AND [IsDeleted] IS NULL) OR ([IsDeleted] = @Original_IsDeleted))) */
--*/
END

GO

/****** Object:  StoredProcedure [dbo].[SPT_UpdateAppointmets]    Script Date: 19.11.2015 10:32:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SPT_UpdateAppointmets]
(
	@Type int,
	@StartDate smalldatetime,
	@EndDate smalldatetime,
	@AllDay bit,
	@Subject nvarchar(50),
	@Location nvarchar(50),
	@Description nvarchar(MAX),
	@Status int,
	@Label int,
	@ResourceID int,
	@ResourceIDs nvarchar(MAX),
	@ReminderInfo nvarchar(MAX),
	@RecurrenceInfo nvarchar(MAX),
	@CustomField1 nvarchar(MAX),
	@LastEditTime datetime,
	@AddedTime datetime,
	@ZOVReminderUsersID int,
	@ZOVReminderUsers nvarchar(4000),
	@IsDeleted bit,
	@Original_UniqueID int,
	@IsNull_Type Int,
	@Original_Type int,
	@IsNull_StartDate Int,
	@Original_StartDate smalldatetime,
	@IsNull_EndDate Int,
	@Original_EndDate smalldatetime,
	@IsNull_AllDay Int,
	@Original_AllDay bit,
	@IsNull_Subject Int,
	@Original_Subject nvarchar(50),
	@IsNull_Location Int,
	@Original_Location nvarchar(50),
	@IsNull_Status Int,
	@Original_Status int,
	@IsNull_Label Int,
	@Original_Label int,
	@IsNull_ResourceID Int,
	@Original_ResourceID int,
	@IsNull_LastEditTime Int,
	@Original_LastEditTime datetime,
	@IsNull_AddedTime Int,
	@Original_AddedTime datetime,
	@IsNull_ZOVReminderUsersID Int,
	@Original_ZOVReminderUsersID int,
	@IsNull_ZOVReminderUsers Int,
	@Original_ZOVReminderUsers nvarchar(4000),
	@IsNull_IsDeleted Int,
	@Original_IsDeleted bit,
	@UniqueID int
)
AS BEGIN
	SET NOCOUNT OFF;
	UPDATE [ZOVAppointments] 
		SET [Type] = @Type, 
		    [StartDate] = @StartDate, 
			[EndDate] = @EndDate, 
			[AllDay] = @AllDay, 
			[Subject] = @Subject, 
			[Location] = @Location, 
			[Description] = @Description, 
			[Status] = @Status, 
			[Label] = @Label, 
			[ResourceID] = @ResourceID, 
			[ResourceIDs] = @ResourceIDs, 
			[ReminderInfo] = @ReminderInfo, 
			[RecurrenceInfo] = @RecurrenceInfo, 
			[CustomField1] = @CustomField1, 
			/*[LastEditTime] = @LastEditTime, 
			[AddedTime] = @AddedTime,*/ 
			[ZOVReminderUsersID] = @ZOVReminderUsersID, 
			[ZOVReminderUsers] = @ZOVReminderUsers, 
			[IsDeleted] = @IsDeleted 
	WHERE (([UniqueID] = @Original_UniqueID))-- AND ((@IsNull_Type = 1 AND [Type] IS NULL) OR ([Type] = @Original_Type)) AND ((@IsNull_StartDate = 1 AND [StartDate] IS NULL) OR ([StartDate] = @Original_StartDate)) AND ((@IsNull_EndDate = 1 AND [EndDate] IS NULL) OR ([EndDate] = @Original_EndDate)) AND ((@IsNull_AllDay = 1 AND [AllDay] IS NULL) OR ([AllDay] = @Original_AllDay)) AND ((@IsNull_Subject = 1 AND [Subject] IS NULL) OR ([Subject] = @Original_Subject)) AND ((@IsNull_Location = 1 AND [Location] IS NULL) OR ([Location] = @Original_Location)) AND ((@IsNull_Status = 1 AND [Status] IS NULL) OR ([Status] = @Original_Status)) AND ((@IsNull_Label = 1 AND [Label] IS NULL) OR ([Label] = @Original_Label)) AND ((@IsNull_ResourceID = 1 AND [ResourceID] IS NULL) OR ([ResourceID] = @Original_ResourceID)) AND ((@IsNull_LastEditTime = 1 AND [LastEditTime] IS NULL) OR ([LastEditTime] = @Original_LastEditTime)) AND ((@IsNull_AddedTime = 1 AND [AddedTime] IS NULL) OR ([AddedTime] = @Original_AddedTime)) AND ((@IsNull_ZOVReminderUsersID = 1 AND [ZOVReminderUsersID] IS NULL) OR ([ZOVReminderUsersID] = @Original_ZOVReminderUsersID)) AND ((@IsNull_ZOVReminderUsers = 1 AND [ZOVReminderUsers] IS NULL) OR ([ZOVReminderUsers] = @Original_ZOVReminderUsers)) AND ((@IsNull_IsDeleted = 1 AND [IsDeleted] IS NULL) OR ([IsDeleted] = @Original_IsDeleted)));

	EXEC [SP_ProcessIDFromString] @Original_UniqueID, @ZOVReminderUsers
	
	SELECT UniqueID, Type, StartDate, EndDate, AllDay, Subject, Location, Description, Status, Label, ResourceID, ResourceIDs, ReminderInfo, RecurrenceInfo, CustomField1, LastEditTime, AddedTime, ZOVReminderUsersID, ZOVReminderUsers, IsDeleted 
	FROM ZOVAppointments 
	WHERE (UniqueID = @UniqueID)
END

GO

/****** Object:  StoredProcedure [dbo].[SPT_InsertAppointmets]    Script Date: 19.11.2015 10:32:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SPT_InsertAppointmets]
(
	@Type int,
	@StartDate smalldatetime,
	@EndDate smalldatetime,
	@AllDay bit,
	@Subject nvarchar(50),
	@Location nvarchar(50),
	@Description nvarchar(MAX),
	@Status int,
	@Label int,
	@ResourceID int,
	@ResourceIDs nvarchar(MAX),
	@ReminderInfo nvarchar(MAX),
	@RecurrenceInfo nvarchar(MAX),
	@CustomField1 nvarchar(MAX),
	@LastEditTime datetime,
	@AddedTime datetime,
	@ZOVReminderUsersID int,
	@ZOVReminderUsers nvarchar(4000),
	@IsDeleted bit
)
AS BEGIN
	SET NOCOUNT OFF;
	INSERT INTO [ZOVAppointments] ([Type], [StartDate], [EndDate], [AllDay], [Subject], [Location], [Description], [Status], [Label], [ResourceID], [ResourceIDs], [ReminderInfo], [RecurrenceInfo], [CustomField1], [LastEditTime], [AddedTime], [ZOVReminderUsersID], [ZOVReminderUsers], [IsDeleted]) 
	--VALUES (@Type, @StartDate, @EndDate, @AllDay, @Subject, @Location, @Description, @Status, @Label, @ResourceID, @ResourceIDs, @ReminderInfo, @RecurrenceInfo, @CustomField1, @LastEditTime, @AddedTime, @ZOVReminderUsersID, @ZOVReminderUsers, @IsDeleted);
	VALUES (@Type, @StartDate, @EndDate, @AllDay, @Subject, @Location, @Description, @Status, @Label, @ResourceID, @ResourceIDs, @ReminderInfo, @RecurrenceInfo, @CustomField1, GetDate(), GetDate(), @ZOVReminderUsersID, @ZOVReminderUsers, @IsDeleted);

	DECLARE @ID int = SCOPE_IDENTITY()

	EXEC [SP_ProcessIDFromString] @ID, @ZOVReminderUsers
	
	SELECT UniqueID, [Type], StartDate, EndDate, AllDay, [Subject], Location, [Description], [Status], Label, ResourceID, ResourceIDs, ReminderInfo, RecurrenceInfo, CustomField1, LastEditTime, AddedTime, ZOVReminderUsersID, ZOVReminderUsers, IsDeleted 
	FROM ZOVAppointments 
	WHERE (UniqueID = @ID)
END

GO

/****** Object:  StoredProcedure [dbo].[SPT_SelectAppointmets]    Script Date: 19.11.2015 10:32:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SPT_SelectAppointmets]
AS BEGIN
	SET NOCOUNT ON;
	SELECT     
		UniqueID, 
		[Type], 
		StartDate, 
		EndDate, 
		AllDay, 
		[Subject], 
		Location, 
		[Description], 
		[Status], 
		Label, 
		ResourceID, 
		ResourceIDs, 
		ReminderInfo, 
		RecurrenceInfo, 
		CustomField1, 
        LastEditTime, 
		AddedTime, 
		ZOVReminderUsersID, 
		ZOVReminderUsers, 
		IsDeleted
	FROM ZOVAppointments
	WHERE (ISNULL(IsDeleted, 0) = 0)
END

GO



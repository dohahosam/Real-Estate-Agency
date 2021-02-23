USE [RSA]
GO

/****** Object:  StoredProcedure [dbo].[InsertBed]    Script Date: 07/05/2019 09:43:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertBed]
	-- Add the parameters for the stored procedure here
		@Housing# int,@OwnerUsername varchar(50), @AreaID int,@Availibility bit,
	 @Address varchar(MAX), @RentersGender varchar(50),@price int,
	 @RentalType varchar(50), @NoOfBeds int, @NoOfRooms int,
	@RentDuration int, @Furnished bit, @NaturalGas bit, @Room# int,
	 @InternetConnection bit, @AirConditioned bit, @Extra varchar(MAX)
	 , @RNumberOfBeds int, @RAvailibiluty bit, @RPrice int,
	@BPrice int, @BAvailibilty bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
INSERT INTO Housing(Housing#, OwnerUsername,AreaID,Availability,Address,RentersGender,Price,NoOfBeds,NoOfRooms,RentDurationInMonths,Furnished,RentalType,NaturalGas,InternetConnection,AirConditioned,Extra)
Values (@Housing#, @OwnerUsername,@AreaID,@Availibility,@Address,@RentersGender,@price, @NoOfBeds,@NoOfRooms,@RentDuration,
@Furnished, @RentalType,@NaturalGas,@InternetConnection,@AirConditioned,@Extra)


INSERT INTO Room(Room#, NoOfBeds,Availability,Price)
Values(@Room#, @RNumberOfBeds,@RAvailibiluty,@RPrice)

INSERT INTO Bed(Availability,Price)
Values(@BAvailibilty,@BPrice)
END
GO


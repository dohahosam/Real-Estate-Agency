USE [RSA]
GO

/****** Object:  StoredProcedure [dbo].[InsertHouse]    Script Date: 07/05/2019 09:44:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertHouse] 
	-- Add the parameters for the stored procedure here
	@Housing# int, @OwnerUsername varchar(50), @AreaID int,@Availibility bit,
	 @Address varchar(MAX), @RentersGender varchar(50),@price int,
	 @RentalType varchar(50), @NoOfBeds int, @NoOfRooms int,
	@RentDuration int, @Furnished bit, @NaturalGas bit,
	 @InternetConnection bit, @AirConditioned bit, @Extra varchar(MAX)
AS
BEGIN
	
	SET NOCOUNT ON;


INSERT INTO Housing(Housing#,OwnerUsername,AreaID,Availability,Address,RentersGender,Price,NoOfBeds,NoOfRooms,RentDurationInMonths,Furnished,RentalType,NaturalGas,InternetConnection,AirConditioned,Extra)
Values (@Housing#,@OwnerUsername,@AreaID,@Availibility,@Address,@RentersGender,@price, @NoOfBeds,@NoOfRooms,@RentDuration,
@Furnished, @RentalType,@NaturalGas,@InternetConnection,@AirConditioned,@Extra)
END
GO


CREATE PROCEDURE [HRAppDB].[GetCompanyAdressByCompanyID]
	@ID int
AS
SELECT com.[ID],
com.[Title],
com.[Description] ,
ad.loID as ID,
ad.Street,
ad.HouseNumber,
ad.[Block],
ad.ApartmentNumber,
ad.PostIndex,
ad.ciID as ID,
ad.ciName as [Name],
ad.couID as ID,
ad.couName as [Name]

From [HRAppDB].Companies as com
inner join 
	[HRAppDB].Companies_Locations as co_lo
on 
	com.ID = co_lo.CompanyID
inner join 
	(SELECT 
	cou.ID as couID,
	cou.[Name] as couName,
	ci.ID as ciID,
	ci.[Name] as ciName,
	lo.ID as loID,
	lo.Street,
	lo.HouseNumber,
	lo.[Block],
	lo.ApartmentNumber,
	lo.PostIndex
	FROM [HRAppDB].[Countries] as cou
	INNER JOIN 
		[HRAppDB].[Cities] as ci
	ON 
		cou.ID = ci.CountryID
	INNER JOIN 
		[HRAppDB].[Locations] as lo
	ON
		ci.ID=lo.CityID) as ad 
	ON 
		ad.loID = co_lo.LocationID

		where com.ID = @ID

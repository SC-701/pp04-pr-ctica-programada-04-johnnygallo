CREATE PROCEDURE ObtenerVehiculos
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        Vehiculo.Id, Vehiculo.IdModelo, Vehiculo.Color, Vehiculo.Placa, Vehiculo.Anio, Vehiculo.Precio, Vehiculo.CorreoPropietario, Vehiculo.TelefonoPropietario, Modelos.Nombre AS Modelo, Marca.Nombre AS Marca
FROM            Marca INNER JOIN
                         Modelos ON Marca.Id = Modelos.IdMarca INNER JOIN
                         Vehiculo ON Modelos.Id = Vehiculo.IdModelo
END
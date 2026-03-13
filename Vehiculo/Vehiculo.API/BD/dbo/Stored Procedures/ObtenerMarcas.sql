CREATE   PROCEDURE ObtenerMarcas
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Id,
        Nombre
    FROM dbo.Marca
END
# Solución del reto técnico

> Esta solución se implemento en una API con arquitectura DDD (domain driven design) NETCORE V3.1.1

## Video explicación - youtube

[![Alt text for your video](youtube.jpg)](https://www.youtube.com/watch?v=yDKO4aKslZc)


## Para ejecutar el API

 1. Primero restaure la base de datos:  
	 
	 - **Emigrar Entity Core:** Puede realizar emigración de la base de datos, creando una base de datos y cambiando el string de conexión en **presentation\api\appsettings.json** .
     Luego ubiquese en la ruta **presentation\api** y ejecute los siguientes comando en una **consola de comando**:
     - **dotnet tool install --global dotnet-ef** (opcional)
     - **dotnet ef database update  -p ..\..\infraestructure**
	 
 2. Arrancar el API
	 - Ubíquese en la raíz del proyecto e ejecute en una **consola de comando** : 
		- `cd presentation\api`
		- `dotnet restore`
		- `dotnet run`
    - Ingrese a la URL que le proporcione el ultimo comando.
    
 3. Adjunto archivo de postman
[Download File Postman](./GONZALO-TEST-API.postman_collection.json)
# EjercicioTecnico
Ejercicio técnico

Instrucciones para correr el programa:

1- Ejecutar el script de base de datos.

2- Abrir el archivo appsettings.json, reemplazar el valor de la clave EntityContext con la cadena de conexión de su base de datos.

3- Ejecutar el programa en modo consola.

Notas: Por una cuestión de tiempo obvie crear algunas capas de acceso a datos, así como también verificar la totalidad del funcionamiento en pantallas reponsive. La base de datos está preparada para hacer la eliminación mediante un campo "activo" pero por temas de tiempo utilizo el delete de EF. La tabla está hecha sin usar la datatable de bootstrap por temas de tiempo.

La Solución está estructurada de manera muy sencilla, utilizando EF Core para crear los accesos a datos, utilice un ViewModel para poder mostrar la información en el html, utilice ajax para comunicarme con el servidor, en ambos casos (para crear y para eliminar clientes).

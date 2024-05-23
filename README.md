#   OpenSpaceComarcal
Este proyecto está diseñado para acceder a una base de datos y permitir realizar modificaciones en los datos almacenados en ella de manera fácil y eficiente.

# Funcionamiento
El proyecto utiliza el lenguaje de programación C# junto con el framework .NET para interactuar con una base de datos relacional. Está estructurado en capas, siguiendo el patrón de arquitectura MVC (Modelo-Vista-Controlador), lo que facilita la separación de responsabilidades y el mantenimiento del código.

# Acceso a la base de datos:
El proyecto utiliza un sistema de gestión de bases de datos relacional (SQL Server) para almacenar y manipular los datos. Se establece una conexión a la base de datos utilizando las credenciales proporcionadas en la configuración de la aplicación.

# Requisitos del sistema
Para ejecutar este proyecto, se requiere tener instalado:

- Microsoft Visual Studio (o cualquier otro entorno de desarrollo compatible con .NET)
  Un sistema de gestión de bases de datos relacional SQL Server
- Microsoft Office, para la genereacion de diplomas en Word y Pdf, ademas de Excel para exportar e importar datos.

# Librerias utilizadas en el proyecto:

- EntityFramework
- DocX
- Microsoft.Office.Interop.Word
- Microsoft.Office.Excel

# PowerPoint -> Word

Para pasas un archivo PowerPoint a Word, deberemos hacer uso de la siguiente web: 
"https://online2pdf.com/es/convertir-powerpoint-a-word#"

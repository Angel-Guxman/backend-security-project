# FINOVA

## Sistema de Gestión Financiera - Backend

### Problemática
El manejo ineficiente de las finanzas personales es un problema común entre los adultos jóvenes que comienzan su vida laboral. La falta de educación financiera y la ausencia de herramientas accesibles para el control de ingresos y gastos pueden llevar a dificultades económicas, como la incapacidad de ahorrar, el sobreendeudamiento y la falta de planificación para imprevistos.

Ante esta problemática, se hace evidente la necesidad de una solución tecnológica que ayude a los jóvenes a gestionar sus finanzas de manera eficiente. Una aplicación web intuitiva y accesible, que permita registrar transacciones diarias, categorizar gastos y generar reportes visuales, podría contribuir significativamente a fomentar hábitos financieros saludables.

### Integrantes
**Grupo: IDYGS81**
- Usuario Git: Angel-Guxman - Nombre: Angel Manuel Guzman Hoil - 22393173
- [Nombre 2]
- [Nombre 3]
- [Nombre 4]
- [Nombre 5]

## Propósito
Brindar a los usuarios una herramienta intuitiva y eficiente que les permita llevar un control detallado de sus ingresos y egresos, facilitando la toma de decisiones financieras con base en los datos gestionados dentro de la aplicación.

## Objetivo General
Desarrollar una API REST con .NET que sirva como backend para la aplicación de gestión financiera, permitiendo administrar ingresos y egresos de manera eficiente, garantizando seguridad y rendimiento en el manejo de datos.

## Tecnologías y Librerías Utilizadas

### **Backend**
- **ASP.NET Core con C#**: Framework para desarrollar APIs de manera rápida y segura.
- **SQL Server**: Base de datos relacional para almacenar la información financiera de los usuarios.
- **Entity Framework Core**: ORM para la interacción con la base de datos.
- **JWT (JSON Web Tokens)**: Para autenticación y autorización segura.
- **Swagger (Swashbuckle.AspNetCore)**: Para documentar y probar la API.

### **Librerías Principales**
- **Microsoft.EntityFrameworkCore.SqlServer**: Proveedor de Entity Framework Core para SQL Server.
- **Microsoft.EntityFrameworkCore.Tools**: Herramientas para facilitar la migración y gestión de bases de datos.
- **Swashbuckle.AspNetCore**: Generación de documentación Swagger.
- **System.IdentityModel.Tokens.Jwt**: Manejo de tokens JWT para autenticación.
- **Microsoft.AspNetCore.Identity**: Framework para gestión de autenticación y usuarios.
- **Microsoft.Extensions.DependencyInjection**: Inyección de dependencias.
- **Microsoft.AspNetCore.Authentication.JwtBearer**: Implementación de autenticación basada en JWT.
- **Microsoft.AspNetCore.Identity.EntityFrameworkCore**: Implementación de Identity sobre Entity Framework Core.

## Arquitectura del Proyecto
El backend sigue una arquitectura basada en capas:

- **Presentation**: Contiene la API (controladores y rutas).
- **Application**: Lógica de negocio y casos de uso.
- **Domain**: Modelos de dominio y entidades principales.
- **Infrastructure**: Acceso a datos, repositorios e inyección de dependencias.

## Configuración y Ejecución
### **Instalación de Dependencias**
Ejecutar el siguiente comando en la terminal para instalar las dependencias del backend:

```sh
 dotnet restore
```

### **Ejecución del Servidor**
Para ejecutar la API en modo desarrollo, utilizar el siguiente comando:

```sh
 dotnet run
```

La API se ejecutará en `https://localhost:7101` (por defecto) o en el puerto configurado en el `appsettings.json`.

### **Migraciones y Base de Datos**
Para aplicar migraciones y actualizar la base de datos, 
primero en la consola debes seleccionar como proyecto predeterminado Infrastructure y luego ejecutar:

```sh
Add-Migration init
Update-Database
```

### **Documentación de la API con Swagger**
Al ejecutar el backend, se puede acceder a la documentación generada por Swagger en:

```
https://localhost:7101/swagger/index.html
```

## Seguridad y Autenticación
La API implementa autenticación basada en **JWT** para proteger los endpoints. Los usuarios deben autenticarse y recibir un token para realizar operaciones protegidas.

---


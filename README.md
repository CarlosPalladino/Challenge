# challenge Intuit

## Descripción del Proyecto

Este proyecto implementa una API para gestionar operaciones CRUD en una tabla de clientes. Está desarrollado utilizando .NET y sigue una arquitectura N-capas con los siguientes componentes:

- **Capa de Datos (`Data`)**: Define el acceso a la base de datos utilizando Entity Framework.
- **Capa de Servicios (`Service`)**: Contiene la lógica de negocio y los repositorios.
- **Capa de Contratos (`Contracts`)**: Define los DTOs utilizados para el intercambio de datos.
- **Capa de Presentación**: Implementa los controladores para exponer la API.

Se utiliza **AutoMapper** para mapear entre entidades y DTOs, y **NUnit** para realizar pruebas unitarias que demuestran la funcionalidad de los servicios sin depender de endpoints.

## Principales Características

- **CRUD de Clientes**: Permite realizar operaciones como obtener todos los clientes, buscar por ID o que contenga el nombre , insertar, actualizar y eliminar.


## Tecnologías Utilizadas

- **.NET 8**
- **Entity Framework Core**
- **AutoMapper**


## Endpoints Principales

1. **GET** `/api/clients`  
   Obtiene todos los clientes activos.

2 **GET** `/api/clients/{name}`  
   Obtiene a los clientes que contenga su nombre.
3. **GET** `/api/clients/{id}`  
   Obtiene un cliente específico por su ID.

4. **POST** `/api/clients`  
   Inserta un nuevo cliente.

5. **PUT** `/api/clients/{id}`  
   Actualiza un cliente existente.

6. **DELETE** `/api/clients/{dni}`  
   Marca un cliente como eliminado (`SoftDelete`).

## Lo imcompleto
 - Quedó por implementar
   1**Validar la unicidad del campo ID**
** Validar los datos**
** Nombres, apellidos, CUIT, teléfono celular, email -> que sean obligatorios**
** Que Fecha de nacimiento, Email y CUIT estén correctamente formateados **


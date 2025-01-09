# challenge Intuit

## Descripción del Proyecto

Este proyecto implementa una API para gestionar operaciones CRUD en una tabla de clientes. Está desarrollado utilizando .NET y sigue una arquitectura N-capas con los siguientes componentes:

- **Capa de Datos (`Data`)**: Define el acceso a la base de datos utilizando Entity Framework.
- **Capa de Servicios (`Service`)**: Contiene la lógica de negocio y los repositorios.
- **Capa de Contratos (`Contracts`)**: Define los DTOs utilizados para el intercambio de datos.
- **Capa de Presentación**: Implementa los controladores para exponer la API.

Se utiliza **AutoMapper** para mapear entre entidades y DTOs, y **NUnit** para realizar pruebas unitarias que demuestran la funcionalidad de los servicios sin depender de endpoints.

## Principales Características

- **CRUD de Clientes**: Permite realizar operaciones como obtener todos los clientes, buscar por ID, insertar, actualizar y eliminar.
- **SoftDelete**: Al eliminar un cliente, este no se elimina físicamente de la base de datos. En su lugar, se marca como eliminado mediante la columna `SoftDeleted`.
  - Clientes "eliminados" no aparecen en las listas normales.
  - Existe un método para obtener todos los clientes, incluidos los eliminados.
- **Testing Unitario**: Se implementaron tests para validar las operaciones de los servicios sin la necesidad de probar mediante endpoints.

## Tecnologías Utilizadas

- **.NET 7**
- **Entity Framework Core**
- **AutoMapper**
- **NUnit**


## Endpoints Principales

1. **GET** `/api/clients`  
   Obtiene todos los clientes activos.

2. **GET** `/api/clients/{id}`  
   Obtiene un cliente específico por su ID.

3. **POST** `/api/clients`  
   Inserta un nuevo cliente.

4. **PUT** `/api/clients/{id}`  
   Actualiza un cliente existente.

5. **DELETE** `/api/clients/{dni}`  
   Marca un cliente como eliminado (`SoftDelete`).

## Cómo Ejecutar

1. Clonar el repositorio.
2. Configurar la conexión a la base de datos en `appsettings.json`.
3. Ejecutar 
4 -Generar la consulta deseada y comprar si funciona

# Manual de usuario

## Sistema de Gestión Universitaria

**Tipo de aplicación:** Escritorio\
**Tecnología:** C# con Windows Forms\
**Versión documentada:** Proyecto entregado en el archivo
`SistemaGestionUniversitaria.zip`

------------------------------------------------------------------------

## 1. Introducción

El Sistema de Gestión Universitaria es una aplicación de escritorio
desarrollada para administrar información académica básica. Permite
registrar estudiantes y cursos, realizar matrículas, ingresar
calificaciones y consultar promedios e información académica.

La aplicación cuenta con una ventana principal organizada en cinco
pestañas: **Estudiantes, Cursos, Matrícula, Calificaciones y
Consultas**.

Las imágenes incluidas corresponden a capturas originales de las pantallas del proyecto.

Las imágenes incluidas corresponden a capturas originales de las pantallas del proyecto.

## 2. Requisitos para utilizar el sistema

-   Sistema operativo Windows.
-   Aplicación compilada o proyecto ejecutable desde Visual Studio.
-   Para ejecutar el proyecto desde el entorno de desarrollo, se
    requiere Visual Studio con soporte para .NET 8 y Windows Forms.

## 3. Inicio del sistema

1.  Abra la solución `SistemaGestionUniversitaria.sln` en Visual Studio,
    o ejecute la aplicación compilada en Windows.
2.  Inicie el programa.
3.  Se mostrará la ventana principal titulada **Sistema de Gestion
    Academica**.
4.  Seleccione la pestaña correspondiente a la operación que desea
    realizar.

> La ventana principal contiene las cinco pestañas descritas en este manual. Las capturas siguientes muestran cada sección de la aplicación.

## 4. Registro de estudiantes

Esta sección permite agregar estudiantes al sistema.

**Datos solicitados:** - **Cédula:** identificación del estudiante. -
**Nombre:** nombre del estudiante.

**Procedimiento:** 1. Abra la pestaña **Estudiantes**. 2. Escriba la
cédula en el campo correspondiente. 3. Escriba el nombre del estudiante.
4. Presione **Registrar estudiante**. 5. Si los datos son válidos, el
sistema muestra un mensaje de confirmación y agrega el estudiante a la
lista inferior.

El sistema no permite registrar campos vacíos ni una cédula que ya se
encuentre registrada. Después de un registro correcto, los campos se
limpian y las listas de selección se actualizan.

![Figura 1. Pestaña Estudiantes: campos para cédula y nombre, botón de registro y lista de estudiantes.](imagenes/estudiantes.jpeg)

## 5. Registro de cursos

Esta sección permite registrar cursos y consultarlos en la lista de
cursos activos.

**Datos solicitados:** - **Código:** identificador del curso. -
**Nombre:** nombre del curso.

**Procedimiento:** 1. Abra la pestaña **Cursos**. 2. Ingrese el código
del curso. 3. Ingrese el nombre. 4. Presione **Registrar curso**. 5. El
curso se agrega con estado activo y aparece en la lista **Cursos
activos**.

El sistema valida que ambos campos tengan información y que el código no
esté registrado previamente. Después de guardar correctamente, limpia
los campos y actualiza las listas del sistema.

![Figura 2. Pestaña Cursos: campos de código y nombre, botón de registro y lista de cursos activos.](imagenes/cursos.jpeg)

## 6. Matrícula de estudiantes

Esta sección permite asociar un estudiante con un curso.

**Procedimiento:** 1. Abra la pestaña **Matricula**. 2. Seleccione un
estudiante de la lista desplegable **Estudiante**. 3. Seleccione un
curso de la lista desplegable **Curso**. 4. Presione **Matricular**. 5.
El sistema muestra un mensaje cuando la matrícula se registra
correctamente.

Para realizar la matrícula, ambos elementos deben estar seleccionados.
El curso debe estar activo y no debe existir previamente una matrícula
del mismo estudiante en ese mismo curso.

![Figura 3. Pestaña Matrícula: selección de estudiante y curso, con mensaje de confirmación de matrícula.](imagenes/matricula.jpeg)

## 7. Registro de calificaciones

Esta sección permite registrar una o varias notas para un estudiante
matriculado en un curso.

**Datos solicitados:** - **Estudiante:** estudiante previamente
registrado. - **Curso:** curso activo previamente registrado. - **Nota
(0-100):** calificación numérica que se desea guardar.

**Procedimiento:** 1. Abra la pestaña **Calificaciones**. 2. Seleccione
el estudiante. 3. Seleccione el curso. 4. Escriba la nota en el campo
**Nota (0-100)**. 5. Presione **Registrar nota**. 6. Si la operación es
correcta, el sistema muestra un mensaje de confirmación y limpia el
campo de la nota.

El estudiante debe tener una matrícula registrada en el curso
seleccionado. La nota debe ser numérica y encontrarse entre 0 y 100,
incluidos ambos límites.

![Figura 4. Pestaña Calificaciones: selección de estudiante y curso, campo de nota y mensaje de confirmación.](imagenes/calificaciones.jpeg)

## 8. Consultas académicas

La pestaña **Consultas** permite consultar promedios e información
académica. Los resultados se muestran en un cuadro de texto de solo
lectura.

### 8.1 Promedio del estudiante

1.  En la sección **Estudiante**, seleccione un estudiante.
2.  Presione **Promedio del estudiante**.
3.  El sistema muestra el nombre del estudiante y su promedio general,
    calculado con todas las notas que tenga registradas en sus
    matrículas.
4.  Si no tiene calificaciones, se informa que no tiene calificaciones.

### 8.2 Información académica

1.  Seleccione un estudiante en la lista desplegable **Estudiante**.
2.  Presione **Informacion academica**.
3.  El sistema muestra el nombre y la cédula del estudiante, los cursos
    matriculados, el código y estado de cada curso y las notas
    registradas.
4.  Cuando existen notas, también se muestra el promedio correspondiente
    a cada matrícula. Si no existen, se indica que no hay
    calificaciones.

### 8.3 Promedio del curso

1.  En la sección **Curso**, seleccione un curso.
2.  Presione **Promedio del curso**.
3.  El sistema muestra el nombre del curso y el promedio general
    calculado con las notas registradas en las matrículas de ese curso.
4.  Si el curso no tiene calificaciones, se muestra el mensaje
    correspondiente.

![Figura 5. Pestaña Consultas: opciones para calcular promedios y consultar la información académica.](imagenes/consultas.jpeg)

## 9. Mensajes y validaciones

El sistema presenta ventanas de mensaje para informar operaciones
correctas o advertir sobre datos que impiden continuar.

Entre las validaciones implementadas se encuentran:

-   No dejar vacíos los campos de cédula y nombre del estudiante.
-   No registrar dos estudiantes con la misma cédula.
-   No dejar vacíos el código y nombre del curso.
-   No registrar dos cursos con el mismo código.
-   Seleccionar estudiante y curso antes de matricular.
-   No matricular dos veces al mismo estudiante en el mismo curso.
-   Verificar que exista una matrícula antes de registrar
    calificaciones.
-   Ingresar una nota numérica entre 0 y 100.
-   Seleccionar un estudiante o curso antes de ejecutar las consultas
    correspondientes.

Si aparece un mensaje de error, lea la indicación, corrija la
información o realice la selección solicitada y vuelva a intentar la
operación.

## 10. Consideraciones sobre los datos

La versión documentada almacena estudiantes, cursos, matrículas y notas
en listas que permanecen en memoria mientras la aplicación está abierta.
El proyecto revisado no contiene conexión a una base de datos ni un
mecanismo de guardado permanente.

Por esta razón, **los datos registrados se pierden al cerrar la
aplicación**. Para realizar consultas sobre la información, primero
deben registrarse nuevamente los datos durante la sesión actual.

## 11. Cierre

Para terminar, cierre la ventana principal de la aplicación. Recuerde
que, debido al almacenamiento en memoria, la información ingresada no se
conserva al cerrar el programa.
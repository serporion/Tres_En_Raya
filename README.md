# Proyecto Tres en Raya

Este es un proyecto .NET Framework 4.7.2 desarrollado en Visual Studio 2022 en lenguaje de programación CSharp.

## Descripcion

Juego de Tres en Raya desarrollado en un tablero de 3 X 3, donde gana quien consiga alinear 3 de sus fichas (X) o (O) o en horizontal, o en vertical o en diagonal. Incluye la opción de nombrar contrincantes y permitir que cuando pierda uno de ellos, sea él el que comience la siguiente partida. Al haber tablas se comienza de nuevo con el mismo contrincante que empezó la anterior partida.



## Estructura del Proyecto

- `TresEnRaya.sln`: Archivo de solución que necesita Visual Studio para cargar el proyecto. En realidad en un proyecto único de momento.
- `TresEnRaya/`: Directorio del proyecto que engloba todo lo necesario para su funcionamineto.
    - `/Properties/`: Directorio que contiene metadatos del ensamblado. Es parte del proyecto y contiene información importante sobre el ensamblado.
  - `App.config`: Archivo de configuración de la aplicación.
  - `TresEnRaya.csproj`: Archivo de proyecto que contiene la configuración y dependencias del proyecto.
  - `Program.cs`: Archivo principal del programa con el código fuente y el responsable de la ejecución del mismo.


## Requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) versión 7.0.100 o superior.
- [Entorno de desarrollo o de ejecución .NET Framework 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472).
- [Nutget](https://dist.nuget.org/win-x86-commandline/latest/nuget.exe) o actualiza tu versión (nuget update -self).
- [Visual Studio 2022](https://visualstudio.microsoft.com/).
- Visual Studio Code. Para ejecutar el proyecto con VS Code hay que generar varias archivos individuales en el directorio .vscode (task.json y launch.json) con las configuraciones correspondientes.



## Ejecución del proyecto.

### En línea de comandos


- Restaura las dependencias:

```sh
nuget restore TresEnRaya.sln
```

- Compila el proyecto

```sh
msbuild TresEnRaya.cs
```
[Asegúrate de tener MSBuild instalado y disponible en en PATH de tu sismtema](https://learn.microsoft.com/en-us/visualstudio/msbuild/msbuild?view=vs-2022).

- Ejecuta el proyecto:

```sh
Navega al directorio de salida (bin\Debug o bin\Release) y ejecuta el .exe.
```



### Con Visual Studio 2022

1. Abre la solución (.sln) en Visual Studio o el propio proyecto (.csproj).
2. Restaura las Dependencias (si es necesario):
    - En la Solution Explorer, haz clic derecho en la solución o el proyecto y selecciona Restore NuGet Packages.Visual Studio las restaura automáticamente, pero aquí está la forma de hacerlo manual).
3. Compila el proyecto.
    - Haz clic en Build > Build Solution. (Compilar > Compilar Solución)
4. Ejecuta el proyecto desde Visual Studio.

### Consideraciones Adicionales

- Versión de .NET:

  - Asegúrate de que la versión del SDK de .NET que utilizas es compatible con la versión especificada de este proyecto incluido en el archivo app.config. En este proyecto como se ha indicado anteriormente se una .NET Framework 4.7.2.,pudiendose usar versiones posteriores a NET Framework como la 4.8.
  - También se especifica la misma versión en el archivo .csproj en la etiqueta <TargetFrameworkVersion>v4.7.2</TargetFrameworkVersion>.


## Contribuciones

Las contribuciones son bienvenidas. Por favor, crea un fork del repositorio y envía un pull request o abre un nuevo issue.
Poneros en contacto conmigo si quereis que migre la aplicación a .NET (Core/5+/6/7).

## Licencia

Este proyecto está bajo la licencia MIT. Ver el archivo [LICENSE](LICENSE) para más detalles.


## Contacto y Soporte

Para más información, puedes consultar el documento de descripción del proyecto en la carpeta doc.

Puedes contactar de las siguientes maneras:

- **Nombre**: Oscar
- **Correo Electrónico**: [serporionGit@hotmail.com](mailto:serporionGit@hotmail.com)
- **GitHub**: [serporion](https://github.com/serporion)


Si tienes alguna pregunta, encuentras un problema o tienes una sugerencia, por favor, abre un issue en este repositorio. Seguiremos el progreso y las discusiones a través de los issues para mantener todo organizado.

Puedes abrir un nuevo issue [aquí](https://github.com/serporion/Tres_En_Raya/issues/new). Las contribuciones son bienvenidas




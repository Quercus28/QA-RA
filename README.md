# QA-RA

Proyecto desarrollado en Unity para la visualización y manipulación de objetos 3D dentro de una escena interactiva. El repositorio contiene una escena base y el conjunto de dependencias necesarias para trabajar con Unity y Vuforia.

## Descripción general

Este proyecto es un ejemplo inicial de desarrollo en Unity con foco en la creación de una escena 3D y la integración de tecnologías de realidad aumentada. Actualmente no incluye un script activo de rotación, por lo que la base del proyecto es una estructura limpia para continuar con nuevas funcionalidades y prototipos.

## Características principales

- Escena base en Unity (`Assets/Scenes/SampleScene.unity`)
- Estructura de proyecto configurada para Unity
- Integración con Vuforia en el manifiesto del proyecto
- Preparado para continuar con desarrollo de AR, interacción 3D o prototipos visuales
- Soporte básico con Input System, URP y paquetes modernos de Unity

## Estructura del proyecto

```text
QA-RA/
├── Assets/
│   ├── Scenes/
│   ├── Scripts/
│   ├── Materials/
│   ├── Resources/
│   └── ...
├── Packages/
│   ├── manifest.json
│   └── packages-lock.json
├── ProjectSettings/
├── Library/
├── Logs/
├── Temp/
├── UserSettings/
├── Assembly-CSharp.csproj
├── Assembly-CSharp-Editor.csproj
├── QA-RA.sln
├── README.md
└── ProjectVersion.txt
```

## Requisitos

- Unity Hub
- Unity 6000.6.0f1 o una versión compatible con este proyecto
- Visual Studio / editor de código con soporte C#
- Paquetes de Unity restaurados desde `Packages/manifest.json`

> La versión del editor definida en el proyecto es Unity 6000.6.0f1. Se recomienda abrir el proyecto con esa misma versión o con una compatible indicada por Unity Hub para evitar problemas de compatibilidad con paquetes y configuraciones del proyecto.

## Cómo ejecutar

1. Abre la carpeta del proyecto con Unity Hub.
2. Asegúrate de que Unity descargue e instale los paquetes pendientes.
3. Abre la escena principal `Assets/Scenes/SampleScene.unity`.
4. Presiona Play para ejecutar la escena.

## Dependencias relevantes

El proyecto incluye paquetes como:

- `com.ptc.vuforia.engine` para realidad aumentada
- `com.unity.inputsystem`
- `com.unity.render-pipelines.universal`
- `com.unity.postprocessing`
- `com.unity.timeline`
- `com.unity.visualscripting`

## Observaciones

Este proyecto parece ser un prototipo base o una prueba de concepto para interacción 3D y posible uso en aplicaciones de realidad aumentada. Es un punto de partida claro para ampliar funcionalidades como:

- detección de imagen con Vuforia
- interacción con marcadores AR
- UI y controles de escena
- animaciones y objetos 3D adicionales
- lógica de juego más completa

## Licencia

No se especifica una licencia en el repositorio. Si el proyecto será compartido o publicado, conviene definir una licencia apropiada antes de distribución.

## Créditos

Proyecto desarrollado en el contexto de la asignatura de Calidad de Software, con enfoque en prototipado Unity y tecnologías de interacción visual.

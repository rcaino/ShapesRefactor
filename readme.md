## El desafío a resolver
Tenemos un método que genera un reporte en base a una colección de formas geométricas, procesando algunos datos para presentar como reporte información extra. La firma del método es: 
```c#
public static string Imprimir(List<FormaGeometrica> formas, int idioma) 
```
 y se encuentra ubicado en la clase 
```c#
FormaGeometrica.cs
```
En consecuencia a como fue codificado este módulo, al equipo de desarrollo se le hace muy difícil el poder agregar una nueva forma geométrica o implementar la impresión del reporte en otro idioma. 
Nos gustaría poder dar soporte para que en el futuro los desarrolladores puedan agregar otros tipos de formas y obtener el reporte en otros idiomas con más agilidad. 

¿Nos podrías ayudar a refactorizar la clase FormaGeometrica?

Acompañando al proyecto encontrarás una serie de tests unitarios (librería NUnit) que describen el comportamiento actual del método Imprimir. 
Se puede modificar absolutamente cualquier cosa del código y de los tests, con la única condición que los tests deben pasar correctamente al entregar la solución.


## Objetivos:

- [X] 1- Refactorizar la clase para respetar principios de la programación orientada a objetos (80%)
- [X] 2- Implementar la forma Rectangulo.
- [ ] 3- Implementar la forma Trapecio.
- [ ] 4- Agregar el idioma Italiano al reporte.
- [X] 5- Migrar/Elaborar los nuevos tests (40% Progreso).

## Objetivos Adicionales Planeados:

4 - Agregar el idioma Italiano al reporte.
- [ ] a -Migrar los idiomas a Resx.

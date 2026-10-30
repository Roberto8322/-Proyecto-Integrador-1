# Analisis de Estructuras de Datos - Sistema de Biblioteca

Para representar los titulos del catalogo y sus ejemplares de forma irregular (algunos libros con 1 copia y otros con hasta 5) se evaluaron tres opciones:

## 1. Arreglo Escalonado (Jagged Array - Título[][])
- Ventaja: Ahorra memoria al no dejar celdas vacias para los titulos con pocos ejemplares.
- Desventaja: Los arreglos son de tamaño fijo. Si se agregan ejemplares despues, hay que redefinir el tamaño del arreglo manualmente.

## 2. List<int[]>
- Ventaja: Permite agregar mas titulos de forma dinamica sin preocuparse por el limite inicial.
- Desventaja: Solo maneja arreglos de numeros. No nos deja guardar metadatos del libro como el ISBN o el contador de prestamos de manera clara.

## 3. List<Título>
- Ventaja: Nos permite usar Programacion Orientada a Objetos. La clase Título puede tener atributos (ISBN, Prestamos) y adentro un arreglo/lista propia para los ejemplares sin desperdiciar espacio.
- Desventaja: Requiere definir bien el modelo de clases desde el inicio.

## Decision
Elegimos la opcion 3 (List<Título>) porque facilita el manejo de las propiedades del libro y permite mantener la estructura limpia sin celdas vacias.

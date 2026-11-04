Reporte tecnico y pruebas  sistema de la biblioteca 





1 Pruebas de escritorio en el registro de prestamo

en las simulaciones de prestamo, el contador de PrestamosHistoricos incrementa en 1 y el valor de CopiasDisponibles decrementa en 1 En caso de que CopiasDisponibles sea igual a 0 la funcion retorna falso y bloquea la transaccion



2 Ordenamiento por inserccion

Se implementa el algoritmo de insercion sobre la lista de libros tomando como criterio la propiedad PrestamosHistoricos de mayor a menor



Funcionamiento

° Se recorre la lista a partir del segundo elemento en indice 1

° Se guarda el elemento actual en una variable temporal

° Se compara hacia la izquierda y se desplazan los elementos menores a una posicion superior

° Se inserta el elemento guardado en la posicion correspondiente



3 Algoritmos de busqueda

° Busqueda secuencial Recorre los elementos comparando si el nombre contiene la subcadena ingresada (insensible a mayusculas/minusculas)

° Busqueda binaria Requiere que la lista este ordenada previamente por ISBN, Compara la clave bucada con el punto medio de la lista, reduciendo el espacio de busqueda a la mitad en cada iteracion


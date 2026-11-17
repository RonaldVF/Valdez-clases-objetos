# POO_Actividad1

# Control de Inventario - TecnoPunto

## Datos del autor
* **Nombre:** Ronald Valdez Francisco
* **Matricula:** 2025-1402

## Descripcion del programa
Este es un programa de consola hecho en C# para llevar el control del inventario de la tienda TecnoPunto. El sistema permite registrar productos de forma segura usando clases, objetos y propiedades. De esta manera se evitan errores comunes como guardar precios negativos, cantidades incorrectas o productos sin nombre.

## Datos de entrada
El usuario debe escribir por teclado los siguientes datos para registrar al menos 3 productos:
* **Codigo:** Identificador del producto.
* **Nombre:** Nombre del producto.
* **Precio:** Costo unitario del producto.
* **Cantidad:** Unidades disponibles en la tienda.

## Datos que procesa
* **Validaciones:** El programa revisa que el nombre no este vacio, que el precio sea mayor a 0 y que la cantidad no sea un numero negativo. Si hay un error muestra un aviso y vuelve a pedir el dato sin cerrar el programa.
* **Calculo:** Multiplica el precio del producto por la cantidad ingresada para obtener el valor total en inventario.

## Datos de salida
El programa muestra en pantalla la ficha completa de cada producto registrado con su codigo, nombre, precio, cantidad y el valor total en existencia.

## Capturas de la ejecucion

### 1. Datos validos
<img width="648" height="932" alt="image" src="https://github.com/user-attachments/assets/711fa2ed-5e43-404a-bbf0-03d338f8a92e" />

### 2. Precio negativo
<img width="509" height="417" alt="image" src="https://github.com/user-attachments/assets/a6330fb4-30d0-4e00-b567-a685b154f3e3" />


### 3. Nombre vacio
<img width="587" height="377" alt="image" src="https://github.com/user-attachments/assets/9fe281af-14f2-486a-8a32-7239f5a95f9b" />


### 4. Cantidad cero
<img width="454" height="484" alt="image" src="https://github.com/user-attachments/assets/7a407899-27ea-4009-af60-8929cb7d2217" />

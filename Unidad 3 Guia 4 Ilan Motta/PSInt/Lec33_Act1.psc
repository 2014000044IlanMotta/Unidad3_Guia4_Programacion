Proceso Lec33_Act1
	Definir  nombres, telefonos Como Cadena
    Dimension nombres[10] 
    Dimension telefonos[10]
    Definir i, posicion Como Entero
	
    Para i <- 1 Hasta 10 Con Paso 1 Hacer
        Escribir "Ingrese el nombre de la persona ", i, ":"
        Leer nombres[i]
        Escribir "Ingrese el telefono de la persona ", i, ":"
        Leer telefonos[i]
    FinPara
	
    Escribir "Datos guardados con exito."
    Escribir "Ingrese la posicion que desea consultar (1-10), o 0 para salir:"
    Leer posicion
	
    Mientras posicion <> 0 Hacer
        Si posicion >= 1 Y posicion <= 10 Entonces
            Escribir "Nombre: ", nombres[posicion]
            Escribir "Telefono: ", telefonos[posicion]
        SiNo
            Escribir "Posicion invalida"
        FinSi
        Escribir "Ingrese otra posicion (1-10), o 0 para salir:"
        Leer posicion
    FinMientras
FinProceso
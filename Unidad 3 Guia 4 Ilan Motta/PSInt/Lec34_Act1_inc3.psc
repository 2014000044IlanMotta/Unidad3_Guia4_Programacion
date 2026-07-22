Proceso Lec34_Act1_inc3
    Definir celsius, resultado Como Real
    Definir opcion Como Caracter
	
    Escribir "Ingrese la temperatura en grados centigrados:"
    Leer celsius
	
    Escribir "Convertir a:"
    Escribir "1. Fahrenheit"
    Escribir "2. Celsius"
    Escribir "3. Kelvin"
    Leer opcion
	
    Segun opcion Hacer
        "1": resultado <- (celsius * 9/5) + 32
			Escribir celsius, " C equivalen a ", resultado, " F"
        "2": resultado <- celsius
			Escribir celsius, " C equivalen a ", resultado, " C"
        "3": resultado <- celsius + 273.15
			Escribir celsius, " C equivalen a ", resultado, " K"
        De Otro Modo:
			Escribir "Opcion invalida"
    FinSegun
FinProceso
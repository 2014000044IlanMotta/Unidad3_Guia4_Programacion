Algoritmo Lec32_Act1
	
    Definir metros, resultado Como Real
    Definir opcion Como Entero
	
    Escribir "Ingrese la cantidad de metros:"
    Leer metros
	
    Escribir "1. Milímetros"
    Escribir "2. Centímetros"
    Escribir "3. Decímetros"
    Escribir "4. Hectómetros"
    Escribir "5. Kilómetros"
    Leer opcion
	
    Segun opcion Hacer
        1:
            resultado = metros * 1000
            Escribir metros," metros equivalen a ",resultado," milímetros"
        2:
            resultado = metros * 100
            Escribir metros," metros equivalen a ",resultado," centímetros"
        3:
            resultado = metros * 10
            Escribir metros," metros equivalen a ",resultado," decímetros"
        4:
            resultado = metros / 100
            Escribir metros," metros equivalen a ",resultado," hectómetros"
        5:
            resultado = metros / 1000
            Escribir metros," metros equivalen a ",resultado," kilómetros"
        De Otro Modo:
            Escribir "Opción incorrecta"
    FinSegun
	
FinAlgoritmo
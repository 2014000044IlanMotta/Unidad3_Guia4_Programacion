Proceso Lec34_Act1_inc1
    Definir opcion Como Entero
    Definir numero, resto Como Entero
    Definir binarioTexto Como Cadena
    Definir binarioNum, posicion Como Entero
    Definir decimalResultado Como Entero
	
    Escribir "1. Convertir decimal a binario"
    Escribir "2. Convertir binario a decimal"
    Leer opcion
	
    Si opcion = 1 Entonces
        Escribir "Ingrese un numero decimal:"
        Leer numero
        binarioTexto <- ""
        Mientras numero > 0 Hacer
            resto <- numero MOD 2
            binarioTexto <- ConvertirATexto(resto) + binarioTexto
            numero <- trunc(numero / 2)
        FinMientras
        Escribir "En binario es: ", binarioTexto
    SiNo
        Escribir "Ingrese un numero binario:"
        Leer binarioNum
        decimalResultado <- 0
        posicion <- 0
        Mientras binarioNum > 0 Hacer
            resto <- binarioNum MOD 10
            decimalResultado <- decimalResultado + resto * (2^posicion)
            binarioNum <- trunc(binarioNum / 10)
            posicion <- posicion + 1
        FinMientras
        Escribir "En decimal es: ", decimalResultado
    FinSi
FinProceso
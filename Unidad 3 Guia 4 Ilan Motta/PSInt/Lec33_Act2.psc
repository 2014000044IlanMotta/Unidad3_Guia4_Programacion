Proceso Lec33_Act2
    Definir frase, invertida Como Cadena
    Definir i, long Como Entero
	
    Escribir "Ingrese una frase:"
    Leer frase
	
    long <- Longitud(frase)
    invertida <- ""
	
    Para i <- long Hasta 1 Con Paso -1 Hacer
        invertida <- invertida + SubCadena(frase, i, i)
    FinPara
	
    Escribir "Frase invertida: ", invertida
FinProceso
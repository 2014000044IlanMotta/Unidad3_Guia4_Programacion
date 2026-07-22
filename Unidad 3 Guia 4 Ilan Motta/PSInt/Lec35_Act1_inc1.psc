Proceso Lec35_Act1_inc1
    Definir cantidad Como Real
    Definir opcion Como Entero
    Definir continuar Como Caracter
    Definir usd, eur, mxn, hnl, crc Como Real
	
    continuar <- "s"
	
    Mientras continuar == "s" Hacer
        Escribir "Ingrese la cantidad en Quetzales (GTQ):"
        Leer cantidad
		
        usd <- cantidad / 7.75
        eur <- cantidad / 8.40
        mxn <- cantidad * 2.35
        hnl <- cantidad * 3.20
        crc <- cantidad * 70.50
		
        Escribir "Equivalente en Quetzales (GTQ): ", cantidad
        Escribir "Equivalente en Dolares (USD): ", usd
        Escribir "Equivalente en Euros (EUR): ", eur
        Escribir "Equivalente en Pesos mexicanos (MXN): ", mxn
        Escribir "Equivalente en Lempiras (HNL): ", hnl
        Escribir "Equivalente en Colones costarricenses (CRC): ", crc
		
        Escribir "Desea convertir otra cantidad? (s/n)"
        Leer continuar
    FinMientras
FinProceso
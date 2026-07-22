Proceso Lec35_Act1_inc2
		Definir precio, pago, cambio Como Real
		Definir centavos Como Real
		Definir billete200, billete100, billete50, billete20 Como Real
		Definir moneda10, moneda5, moneda1 Como Real
		
		Escribir "Ingrese el precio del producto:"
		Leer precio
		Escribir "Ingrese la cantidad con la que pago el cliente:"
		Leer pago
		
		cambio <- pago - precio
		
		Si cambio < 0 Entonces
			Escribir "El pago es insuficiente"
		SiNo
			centavos <- cambio
			billete200 <- centavos / 200
			centavos <- centavos MOD 200
			billete100 <- centavos / 100
			centavos <- centavos MOD 100
			billete50 <- centavos / 50
			centavos <- centavos MOD 50
			billete20 <- centavos / 20
			centavos <- centavos MOD 20
			moneda10 <- centavos / 10
			centavos <- centavos MOD 10
			moneda5 <- centavos / 5
			centavos <- centavos MOD 5
			moneda1 <- centavos / 1
			
			Escribir "El cambio a entregar es: ", cambio
			Escribir "Billetes de 200: ", billete200
			Escribir "Billetes de 100: ", billete100
			Escribir "Billetes de 50: ", billete50
			Escribir "Billetes de 20: ", billete20
			Escribir "Monedas de 10: ", moneda10
			Escribir "Monedas de 5: ", moneda5
			Escribir "Monedas de 1: ", moneda1
		FinSi
FinProceso
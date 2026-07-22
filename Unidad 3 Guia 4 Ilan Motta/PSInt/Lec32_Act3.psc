Proceso Lec32_Act3
    Definir lado1, lado2, lado3 Como Real
	
    Escribir "Ingrese la medida del lado 1:"
    Leer lado1
    Escribir "Ingrese la medida del lado 2:"
    Leer lado2
    Escribir "Ingrese la medida del lado 3:"
    Leer lado3
	
    Si lado1 == lado2 Y lado2 == lado3 Entonces
        Escribir "El triangulo es EQUILATERO"
    SiNo
        Si lado1 == lado2 O lado1 == lado3 O lado2 == lado3 Entonces
            Escribir "El triangulo es ISOSCELES"
        SiNo
            Escribir "El triangulo es ESCALENO"
        FinSi
    FinSi
FinProceso
Proceso Lec34_Act1_inc2
    Definir peso, altura, imc Como Real
	
    Escribir "Ingrese su peso en kg:"
    Leer peso
    Escribir "Ingrese su altura en metros:"
    Leer altura
	
    imc <- peso / (altura * altura)
	
    Escribir "Su IMC es: ", imc
	
    Si imc < 18.5 Entonces
        Escribir "Clasificacion: Bajo peso"
    SiNo
        Si imc < 25 Entonces
            Escribir "Clasificacion: Peso normal"
        SiNo
            Si imc < 30 Entonces
                Escribir "Clasificacion: Sobrepeso"
            SiNo
                Escribir "Clasificacion: Obesidad"
            FinSi
        FinSi
    FinSi
FinProceso
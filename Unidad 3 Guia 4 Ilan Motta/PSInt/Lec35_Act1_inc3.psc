Proceso Lec35_Act1_inc3
    Definir opcionUsuario, opcionPC Como Cadena
    Definir numeroAleatorio Como Entero
	
    Escribir "Elige: piedra, papel o tijera"
    Leer opcionUsuario
	
    numeroAleatorio <- Azar(3)
	
    Segun numeroAleatorio Hacer
        0: opcionPC <- "piedra"
        1: opcionPC <- "papel"
        2: opcionPC <- "tijera"
    FinSegun
	
    Escribir "La computadora eligio: ", opcionPC
	
    Si opcionUsuario = opcionPC Entonces
        Escribir "Empate"
    SiNo
        Si (opcionUsuario = "piedra" Y opcionPC = "tijera") O (opcionUsuario = "papel" Y opcionPC = "piedra") O (opcionUsuario = "tijera" Y opcionPC = "papel") Entonces
            Escribir "Ganaste"
        SiNo
            Escribir "Gano la computadora"
        FinSi
    FinSi
FinProceso
Proceso Lec32_Act2
		Definir mes, dia Como Entero
		Definir signo Como Cadena
		
		Escribir "Ingrese el mes de nacimiento (1-12):"
		Leer mes
		Escribir "Ingrese el dia de nacimiento:"
		Leer dia
		
		Si (mes=3 Y dia>=21) O (mes=4 Y dia<=19) Entonces
			signo <- "Aries"
		SiNo
			Si (mes=4 Y dia>=20) O (mes=5 Y dia<=20) Entonces
				signo <- "Tauro"
			SiNo
				Si (mes=5 Y dia>=21) O (mes=6 Y dia<=20) Entonces
					signo <- "Geminis"
				SiNo
					Si (mes=6 Y dia>=21) O (mes=7 Y dia<=22) Entonces
						signo <- "Cancer"
					SiNo
						Si (mes=7 Y dia>=23) O (mes=8 Y dia<=22) Entonces
							signo <- "Leo"
						SiNo
							Si (mes=8 Y dia>=23) O (mes=9 Y dia<=22) Entonces
								signo <- "Virgo"
							SiNo
								Si (mes=9 Y dia>=23) O (mes=10 Y dia<=22) Entonces
									signo <- "Libra"
								SiNo
									Si (mes=10 Y dia>=23) O (mes=11 Y dia<=21) Entonces
										signo <- "Escorpio"
									SiNo
										Si (mes=11 Y dia>=22) O (mes=12 Y dia<=21) Entonces
											signo <- "Sagitario"
										SiNo
											Si (mes=12 Y dia>=22) O (mes=1 Y dia<=19) Entonces
												signo <- "Capricornio"
											SiNo
												Si (mes=1 Y dia>=20) O (mes=2 Y dia<=18) Entonces
													signo <- "Acuario"
												SiNo
													signo <- "Piscis"
												FinSi
											FinSi
										FinSi
									FinSi
								FinSi
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
		
		Escribir "Tu signo zodiacal es: ", signo
		
		Segun signo Hacer
			"Aries": Escribir "Hoy tendras mucha energia, aprovechala en tus proyectos."
			"Tauro": Escribir "Es un buen dia para poner los pies sobre la tierra."
			"Geminis": Escribir "La comunicacion sera tu mejor herramienta hoy."
			"Cancer": Escribir "Cuida tus emociones y rodeate de tu familia."
			"Leo": Escribir "Brillaras en cualquier lugar donde estes hoy."
			"Virgo": Escribir "Pon atencion a los detalles, te traeran buenos resultados."
			"Libra": Escribir "Busca el equilibrio entre el trabajo y el descanso."
			"Escorpio": Escribir "Tu intuicion estara mas fuerte que nunca."
			"Sagitario": Escribir "Es un buen momento para planear un viaje."
			"Capricornio": Escribir "La disciplina te llevara a cumplir tus metas."
			"Acuario": Escribir "Tus ideas originales sorprenderan a todos."
			"Piscis": Escribir "Confia en tu creatividad para resolver un problema."
		FinSegun
FinProceso
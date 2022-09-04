El código del repositorio original no cumple con los patrones de SRP ni de Expert. En una misma clase, en el repositorio "base" se creaba la cita, se validaba e imprimia. 
Según los patrones que hemos visto hasta el momento esto es algo que está sumamente incorrecto. Debemos crear clases, cuya responsabilidad sea única, y no se encarguen de más de una cosa a la vez. A su vez, estas clases, para cumplir con sus responsabilidades, deben tener la informacíon necesaria (en este ejercicio mis clases presentan un colaborador cada una de ellas) para que puedan hacer lo que nosotros necesitemos. 


Para solucionar los problemas anteriormente mencionados, cree 3 clases. Una clase denominada AppointmentData, la cual es la encargada de crear un objeto cuyos atributos son todos los datos de la cita.

La siguiente clase, es IsValid, la cual recibe como parametro un objeto de la clase AppointmentData. Está encargada de verificar si alguno de los datos ingresados en los datos de la cita no son correctos.

Por último, para imprimir si la cita fue creada con éxito o no, cree la clase PrintService. Esta clase recibe como parametro un objeto de la clase IsValid, donde chequea si hubieron datos que faltaron o no fueron ingresados de manera correcta. En caso de no haber datos incorrectos, nos indicará por la consola que fue creada con éxito. En caso de que no haya sido creada con éxito, nos indicará también por consola, los datos que estan incorrectos y deben ser solucionados para crear la cita con éxito. 
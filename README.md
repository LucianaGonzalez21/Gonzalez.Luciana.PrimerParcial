# Gonzalez.Luciana.PrimerParcial

**Titulo**: Aplicación de Aerolineas

**Sobre mí**: Mi nombre es Luciana Gonzalez y soy estudiante del segundo cuatrimestre de la carrera de programación en la Universidad Tecnológica Nacional.
Este trabajo fue un verdadero desafío para mí, porque en mi corta experiencia programando nunca había tenido que plantear un proyecto desde cero. Al principio no tenía idea hacia donde ir, pero de a poco fui construyendo, y así llegué a realizar esta aplicación. 
Lo que más me llevo de esto es que aprendí a buscar información por mi cuenta a través de internet y no tanto a esperar que alguien me explique. 

**Resumen**: esta aplicación administra los servicios que ofrece una aerolínea: vuelos nacionales e internacionales. Está pensada para que los empleados puedan loguearse y poder visualizar los siguientes datos:

* Una lista de los aviones que posee la aerolínea, con sus características tales como sus matrículas, la cantidad de asientos disponibles o si ofrece wifi o comida.
* Una lista de clientes: aquellas personas que se han registrado pero aún no han realizado una compra en la empresa.
* Una lista de vuelos donde se detallan el origen y destino de cada vuelo, así como el estado de vuelo, su duración y la fecha de partida.
* Una lista de pasajeros: aquellos clientes que adquirieron uno o más vuelos en la empresa.
* Una lista de pasajes donde se ve el nombre del pasajero y hacia dónde viaja.

**Diagrama de clases**


**Justificación de técnica**: implementé una clase estática para el core de la aplicación, la aerolinea, ya que no se instancian objetos de este tipo, la aerolínea es una sola y es el negocio. Esta clase funciona como administradora de las demás: verifica si los clientes ya existen, si al dar de alta un vuelo el avión seleccionado se encuentra en otro, los destinos más elegidos por los clientes, etc. 

La aplicación usa como interfaz gráfica a los formularios de Windows: a través de ellos se pueden visualizar las listas antes mencionadas, vender pasajes y dar de alta a nuevos clientes. Estos formularios toman la información ingresada por el empleado, la valida y a su vez, la clase administradora (Aerolinea) hace sus propias validaciones. Así implementé el encapsulamiento: no es tarea del Windows Form saber  los clientes que están registrados en la empresa o recorrer la lista de usuarios para dejar que el empleado se registre.


Para tener a los objetos del mismo tipo agrupados (usuarios, vuelos, pasajes, etc) hice uso de colecciones genéricas: listas, stack y dictionary. La clase administradora cuenta con listas de pasajeros, clientes, usuarios, etc. También con un diccionario donde la key es el destino y el value puede usarse tanto como para contador de la cantidad de veces que tal lugar se elegió o como acumulador de costos para calcular la facturación de cada destino. Una de las desventajas que presentó esto para mi nivel de conocimientos es no saber ordenar el diccionario por los valores. 

Por otra parte, implementé herencia a través de una clase abstracta Persona, que funciona como la base de una jerarquía de herencia. No se instanciarán objetos del tipo Persona pero sirve como molde para las clases que heredan de ella: Cliente, Pasajero y PasajeroPremium. Por la forma en que establecí las características del Pasajero (turista) me pareció correcto hacer que PasajeroPremium heredara de el: cuenta con los mismos atributos, métodos y los redefine para adaptarlos a los beneficios de un pasajero que viaja en clase premium. En ese punto, apliqué polimorfismo para sobrescribir el método CalcularCosto(). El precio es el del pasaje común más un 15%. 

Para poder llevar a cabo el hardcodeo de los clientes empleé sobrecarga de constructores, y así poder construirlos directamente con su propio id. Además, por medio de la sobrecarga de operadores, pude efectuar comparaciones entre Clientes o Pasajes, para así poder saber si un cliente ya está cargado en el sistema, o si un pasajero está intentando comprar un boleto para un vuelo en el que ya se encuentra registrado.


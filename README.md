# TecAvPro-clase7

Diseñar una clase Cliente para una aplicación bancaria.

Datos miembros protegidos:

long NumeroCuenta		// Número de cuenta.
string Apellido	
string Nombre
string Direccion
string FechaNac	// Fecha nacimiento dd/mm/aaaa
double Saldo		// Saldo de la cuenta.

Funciones miembro públicas:

PonerApellido: Recibe una cadena con el apellido.
ObtenerApellido: Devuelve el apellido.
PonerNombre: Recibe una cadena con el nombre.
ObtenerNombre: Devuelve el nombre.
PonerDireccion: Recibe una cadena con la direccion.
ObtenerDireccion: Devuelve el dirección.
PonerFechaNac: Recibe una cadena con la fecha.
ObtenerFechaNac: Devuelve la fecha.
ObtenerSaldo: Devuelve el saldo.
Depositar: Recibe el monto a depositar, (incrementa el saldo), y devuelve el saldo actualizado.
Retirar: Recibe el monto a retirar. La función debe verificar si hay saldo suficiente, en caso positivo se lo descuenta al saldo y devuelve el saldo actualizado, caso contrario, (el saldo no es suficiente para retirar el monto pretendido), se devuelve –1.
Escribir un programa que instancie un objeto Cliente y ejemplifique alguno de los métodos.

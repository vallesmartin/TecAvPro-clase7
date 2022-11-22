using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clase7
{
    public class Program
    {
        // Instancia cliente que se usa en el programa
        private static Cliente cliente = new Cliente();

        // Definicion de clase Cliente
        public class Cliente
        {
            // Miembros protegidos
            private long NumeroCuenta;	// Número de cuenta.
            private string Apellido;
            private string Nombre;
            private string Direccion;
            private string FechaNac;	// Fecha nacimiento dd/mm/aaaa
            private double Saldo;		// Saldo de la cuenta.

            // Funciones y metodos publicos
            public void PonerApellido(string apellido)
            {
                this.Apellido = apellido;
            }
            public string ObtenerApellido()
            {
                return this.Apellido;
            }
            public void PonerNombre(string nombre)
            {
                this.Nombre = nombre;
            }
            public string ObtenerNombre()
            {
                return this.Nombre;
            }
            public void PonerDireccion(string direccion)
            {
                this.Direccion = direccion;
            }
            public string ObtenerDireccion()
            {
                return this.Direccion;
            }
            public void PonerFechaNac(string fechanac)
            {
                this.FechaNac = fechanac;
            }
            public string ObtenerFechaNac()
            {
                return this.FechaNac;
            }
            public double ObtenerSaldo()
            {
                return this.Saldo;
            }
            public void Depositar(double monto)
            {
                this.Saldo += monto;
            }
            public double Retirar(double monto)
            {
                if (this.Saldo >= monto)
                {
                    this.Saldo -= monto;
                    return this.Saldo;
                }
                else
                {
                    return -1;
                }

            }
        }
        public static void Main(string[] args)
        {
            // Comienza el programa. Crea un cliente con datos por defecto
            Crear_Cliente_Defecto();
            // Luego de crear el cliente, muestra datos en pantalla
            Muestra_Datos_Cliente();
            // Pide una cifra para retirar de la cuenta del cliente
            Retirar_Dinero();
            // Espera tecla para finalizar
            Console.ReadLine();
        }

        private static void Crear_Cliente_Defecto()
        {
            cliente.PonerNombre("Martin");
            cliente.PonerApellido("Valles");
            cliente.PonerDireccion("Balcarce 50");
            cliente.Depositar(50000);
        }
        private static void Muestra_Datos_Cliente()
        {
            Console.WriteLine("Cliente: "+cliente.ObtenerNombre()+' '+cliente.ObtenerApellido());
            Console.WriteLine("Saldo: "+cliente.ObtenerSaldo().ToString());
        }
        private static void Retirar_Dinero()
        {
            // Pide monto, asume si o si numero
            double monto, respuestaRetiro;
            Console.WriteLine();
            Console.WriteLine("Escriba un monto para retirar: ");
            monto = double.Parse(Console.ReadLine());

            // Descuenta del cliente, si -1 entonces no pudo retirar
            respuestaRetiro = cliente.Retirar(monto);
            if (respuestaRetiro >= 0)
            {
                // Pudo retirar, muestra saldo
                Console.WriteLine("Saldo restante: " + respuestaRetiro.ToString());
            } else
            {
                // No pudo retirar, saldo insuficiente
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}

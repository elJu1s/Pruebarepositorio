using System;

namespace Banco
{        

namespace u1_identidad1
    {
        class Cliente
        {
            private string nombre;
            private int monto;

            //Definir propiedades
            public string Nombre
            {
                set
                {
                    nombre = value;
                }
                get
                {
                    return nombre;
                }
            }
            public int Monto
            {
                set
                {
                    monto = value;
                }
                get
                {
                    return monto;
                }
            }

            //métodos
            public void imprimir()
            {
                Console.WriteLine(nombre + " tiene depositado:" + monto);
            }
        }

        class Banco
        {
            string nombre = "Banco Mexicano";
            string sucursal = "Centro";
            Cliente cliente1 = new Cliente();
            Cliente cliente2 = new Cliente();
            Cliente cliente3 = new Cliente();

            public void cargarInformacion()
            {
                cliente1.Nombre = "Juan";
                cliente1.Monto = 0;

                cliente2.Nombre = "Ana";
                cliente2.Monto = 0;

                cliente3.Nombre = "Pedro";
                cliente3.Monto = 0;
            }

            public void hacer_deposito()
            {
                cliente1.Monto = cliente1.Monto + 100;
                cliente2.Monto = cliente2.Monto + 150;
                cliente3.Monto = cliente3.Monto + 300;
            }

            public void retirar()
            {
                cliente1.Monto = cliente1.Monto - 100;
                cliente2.Monto = cliente2.Monto - 100;
                cliente3.Monto = cliente3.Monto - 5;
            }

            public void DepositosTotales()
            {
                int t = cliente1.Monto + cliente2.Monto + cliente3.Monto;
                Console.WriteLine("Banco: " + nombre);
                Console.WriteLine("Sucursal: " + sucursal);
                Console.WriteLine("El total de dinero en el banco es:" + t);
                cliente1.imprimir();
                cliente2.imprimir();
                cliente3.imprimir();
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Banco banco1 = new Banco();
                banco1.cargarInformacion();
                banco1.hacer_deposito();
                banco1.DepositosTotales();
                banco1.retirar();
                banco1.DepositosTotales();
                Console.ReadKey();

            }
        }
    }

}
    


using System;
using System.Collections.Generic;

namespace CustomerServiceQueue
{
    // Clase que representa el sistema de atención de clientes
    public class CustomerService
    {
        private Queue<string> customerQueue;

        public CustomerService()
        {
            customerQueue = new Queue<string>();
        }

        // Método para agregar un cliente a la cola
        public void AddCustomer(string customerName)
        {
            customerQueue.Enqueue(customerName);
            Console.WriteLine($"Cliente '{customerName}' agregado a la cola.");
            PrintQueue();
        }

        // Método para atender al siguiente cliente en la cola
        public void ServeNextCustomer()
        {
            if (customerQueue.Count > 0)
            {
                string nextCustomer = customerQueue.Dequeue();
                Console.WriteLine($"Atendiendo al cliente: {nextCustomer}");
            }
            else
            {
                Console.WriteLine("No hay clientes en la cola.");
            }
            PrintQueue();
        }

        // Método para imprimir el estado actual de la cola
        public void PrintQueue()
        {
            Console.WriteLine("Estado actual de la cola:");
            if (customerQueue.Count == 0)
            {
                Console.WriteLine("La cola está vacía.");
            }
            else
            {
                foreach (var customer in customerQueue)
                {
                    Console.WriteLine($"- {customer}");
                }
            }
            Console.WriteLine();
        }
    }

    // Clase principal para probar el sistema de atención de clientes
    class Program
    {
        static void Main(string[] args)
        {
            CustomerService service = new CustomerService();

            // Agregar clientes a la cola
            service.AddCustomer("Juan");
            service.AddCustomer("Maria");
            service.AddCustomer("Pedro");

            // Atender clientes
            service.ServeNextCustomer();
            service.ServeNextCustomer();

            // Agregar más clientes
            service.AddCustomer("Ana");
            service.AddCustomer("Luis");

            // Atender más clientes
            service.ServeNextCustomer();
            service.ServeNextCustomer();
            service.ServeNextCustomer();
            service.ServeNextCustomer(); // Intentar atender cuando la cola está vacía
        }
    }
}
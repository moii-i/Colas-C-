# Implementación de un Sistema de Atención de Clientes en C#

Este repositorio contiene una implementación sencilla de un sistema de atención de clientes utilizando colas en C#. El sistema permite agregar clientes a una cola y atenderlos en el orden en que llegaron (FIFO).

## Características

- **Agregar clientes**: Se pueden agregar clientes a la cola de espera.
- **Atender clientes**: Se atiende al siguiente cliente en la cola.
- **Imprimir cola**: Se muestra el estado actual de la cola en todo momento.

## Ejemplos de Uso

```csharp
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

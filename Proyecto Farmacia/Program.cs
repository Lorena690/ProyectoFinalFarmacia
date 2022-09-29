// AUTOR: LORENA SÁNCHEZ FERNÁNDEZ//
// CÓDIGO: 1116247763//
using Proyecto_Farmacia;

Farmacia miFarmacia = new Farmacia();

Producto producto1 = new Producto("Acetaminofen" , 10000 , "Genfar" , "Jarabe" , "100mL" , "Acetaminofen 5mL/100mL" , "123456" );
Producto producto2 = new Producto("Ibuprofeno", 15000, "MK", "Jarabe", "100mL", "Ibuprofeno 5mL/100mL", "987654");
Producto producto3 = new Producto("Dipirona", 5000, "Laproff", "Gotas", "20mL", "Dipirona 2mL/20mL", "456789");
Producto producto4 = new Producto("Diclofenaco", 1000, "MK", "Capsula", "5mg", "Diclofenaco 5mg", "159753");
Producto producto5 = new Producto("Buscapina", 1450, "Colmed", "Pastilla", "5mg", "Hioscina n-butil bromuro 5mg", "963258");

miFarmacia.agregarProducto(producto1);
miFarmacia.agregarProducto(producto2);
miFarmacia.agregarProducto(producto3);
miFarmacia.agregarProducto(producto4);
miFarmacia.agregarProducto(producto5);


Console.WriteLine("Bienvenidos a Drogueria Mi Salud");
Console.WriteLine("Ingrese el nombre del cliente");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese el telefono del cliente");
string telefono = Console.ReadLine();
Console.WriteLine("Ingrese la direccion del cliente");
string direccion = Console.ReadLine();
Cliente cliente = new Cliente(nombre, telefono, direccion, miFarmacia);

string opcion = "";

while (opcion != "0")
{
    Console.WriteLine("Seleccione la opcion que desea realizar ");
    Console.WriteLine("1 para consultar un producto");
    Console.WriteLine("2 para comprar un producto");
    Console.WriteLine("3 para devolver un producto");
    Console.WriteLine("0 para terminar");

    opcion = Console.ReadLine();
    string codigoProducto;
    switch (opcion) {
        case "1":
            Console.WriteLine("Ingrese el codigo del producto a consultar");
            codigoProducto = Console.ReadLine().Trim();
            Producto productoConsultado = cliente.consultarPrecio(codigoProducto);
            Console.WriteLine(productoConsultado);
            break;
        case "2":
            Console.WriteLine("Ingrese el codigo del producto a comprar");
            codigoProducto = Console.ReadLine().Trim();
            cliente.comprar(codigoProducto);

            Console.WriteLine("Productos Comprados hasta el momento: ");
            for (int i = 0; i < cliente.getListadoProductos().Count; i++)
            {
                Console.WriteLine(cliente.getListadoProductos()[i]);
            }
            break;
        case "3":
            Console.WriteLine("Ingrese el codigo del producto a devolver");
            codigoProducto = Console.ReadLine().Trim();
            cliente.devolucion(codigoProducto);
            Console.WriteLine("Productos Comprados hasta el momento: ");
            for (int i = 0; i < cliente.getListadoProductos().Count; i++)
            {
                Console.WriteLine(cliente.getListadoProductos()[i]);
            }
            break;
        case "0":
            break;
        default:
            Console.WriteLine("La opcion no es valida");
            break;
    }


}

Console.WriteLine("Gracias por visitarnos cliente: " + cliente.getNombre() );

using System.Collections.Generic;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int,Cliente> Entrada = new Dictionary<int, Cliente>();
        int menu = 0, id = 0;
        int [] entrada = new int(4);
        int [] recaudacion = new int(4);
        string espacio = Environment.NewLine;
        while(menu != 5){
            Console.WriteLine($"Elija una opcion {espacio}1.Nueva inscripción{espacio}2.Obtener estadísticas del evento{espacio}3.Buscar cliente{espacio}4.Cambiar entrada de un cliente{espacio}5. Salir");
            switch(menu){
                case 1:
                NuevaInscripcion(ref Entrada,ref id, ref tipoEntrada, ref recaudacion);
                break;
                case 2:
                EstadisticasEvento(Entrada, entrada, recaudacion);
                break;
                case 3:
                break;
                case 4:
                break;
            }
        }
    }
    static void NuevaInscripcion(ref Dictionary<int,Cliente> entrada,ref int id, ref int [] entrada, ref int [] recaudacion){
        Cliente datos = new Cliente("","","",0,0);
        int tipo = 0;
        double abono = 0;
        string dni = IngresarString("Ingrese el dni");
        string ape = IngresarString("Ingrese el apellido");
        string nom = IngresarString("Ingrese el nombre");
        id++;
        TipoEntrada(tipo,abono, ref entrada, ref recaudacion);
        datos = new Cliente(dni,ape,nom,tipo,abono);
        entrada.Add(id, datos);

    }
    static void EstadisticasEvento(Dictionary<int,Cliente> datos, int[] entrada, int[] recaudacion){
        if(datos.Contains > 0){
            int cantidadP = datos.Count;
            int totalEntradas;
            for(int i = 0; i<entrada.Length; i++){
                totalEntradas+=entrada(i);
            }
        int porcentaje1 = (entrada[1]/totalEntradas)*100;
        int porcentaje2 = (entrada[2]/totalEntradas)*100;
        int porcentaje3 = (entrada[3]/totalEntradas)*100;
        int porcentaje4 = (entrada[4]/totalEntradas)*100;
        int totalrecaudado;
        for(int i = 0; i<entrada.Length; i++){
            totalrecaudado+=recaudacion(i);
        }
        Console.WriteLine($"El total de clientes es de {cantidadP}");
        Console.WriteLine($"El porcentaje total del dia 1 es de {porcentaje1}, el del dia 2 es de {porcentaje2}, el del dia 3 es de {porcentaje3} y el de todos los dias de {porcentaje4}");
        Console.WriteLine($"El total recaudado del dia 1 es de {recaudacion[1]} el del dia 2 es de {recaudacion[2]} el del dia 3 es de {recaudacion[3]} y el de todos los dias de {recaudacion[4]}");
        Console.WriteLine($"El total de recaudacion fue de {totalrecaudado}");
        }else{
            Console.WriteLine("Aun no se anoto nadie");
        }
    }
    static void BuscarCliente(Dictionary<int,Cliente> entrada){
        Cliente cliente;
        int id;
        id = IngresarInt("Ingrese el id del usuario que quiere buscar");
        foreach(int i in entrada.Keys){
            if(id = i){
                cliente = entrada.Values;
            }
        }
        Console.WriteLine($"Dni del cliente {cliente.DNI}");
        Console.WriteLine($"Nombre y apellido del cliente: {cliente.Nombre} {cliente.Apellido}");
        Console.WriteLine($"Tipo de entrada y abono: {cliente.TipoEntrada} con un valor de ${cliente.TotalAbonado}");
        
    }
    static void CambioEntrada(Dictionary<int,Cliente> entrada){
        
    }
    static int IngresarInt(string m){
        int d;
        Console.WriteLine(m);
        return d = int.Parse(Console.ReadLine());
    }
    static string IngresarString(string m){
        string d;
        Console.WriteLine(m);
        return d = Console.ReadLine();
    }
    static void TipoEntrada(int tipo, double abono, ref int [] entrada, ref int[] recaudacion){
        
        string e = Environment.NewLine;
        tipo = IngresarInt($"Elija el tipo de ticket {e}1. Dia 1: $10.000{e}2. Dia 2: $30.000{e}3. Dia 3: $15.000{e}4. Todos los dias: $45.000");
        switch(tipo){
            case 1:
            abono = 10000;
            entrada(tipo)++;
            recaudacion(tipo)+=abono;
            break;
            case 2:
            abono = 30000;
            entrada(tipo)++;
            recaudacion(tipo)+=abono;
            break;
            case 3:
            abono = 15000;
            entrada(tipo)++;
            recaudacion(tipo)+=abono;
            break;
            case 4:
            abono = 45000;
            entrada(tipo)++;
            recaudacion(tipo)+=abono;
            break;
        }
    }
}
using System;
using System.Collections.Generic;

static void Main(string[] args)
{ 

}
// Interfaz para los vehículos que pueden encender, apagar, detener y moverse
public interface IVehiculo
{
    void Encender();
    void Apagar();
    void Detener();
    void Mover();
}

// Clase abstracta para los monoplazas
public abstract class Monoplaza : IVehiculo
{
    private bool encendido = false;
    private bool enMovimiento = false;

    public string Escuderia { get; set; }

    public void Encender()
    {
        if (!encendido)
        {
            encendido = true;
            Console.WriteLine("El monoplaza está encendido.");
        }
        else
        {
            Console.WriteLine("El monoplaza ya está encendido.");
        }
    }

    public void Apagar()
    {
        if (encendido && !enMovimiento)
        {
            encendido = false;
            Console.WriteLine("El monoplaza está apagado.");
        }
        else
        {
            Console.WriteLine("No se puede apagar el monoplaza.");
        }
    }

    public void Detener()
    {
        if (encendido && enMovimiento)
        {
            enMovimiento = false;
            Console.WriteLine("El monoplaza está detenido.");
        }
        else
        {
            Console.WriteLine("No se puede detener el monoplaza.");
        }
    }

    public void Mover()
    {
        if (encendido && !enMovimiento)
        {
            enMovimiento = true;
            Console.WriteLine("El monoplaza está en movimiento.");
        }
        else
        {
            Console.WriteLine("No se puede mover el monoplaza.");
        }
    }

    public abstract string Nombre { get; }
}

// Clase para el monoplaza de McLaren
public class McLaren : Monoplaza
{
    public override string Nombre => "McLaren";
}

// Clase para el monoplaza de Ferrari
public class Ferrari : Monoplaza
{
    public override string Nombre => "Ferrari";
}

// Clase para el monoplaza de Red Bull
public class RedBull : Monoplaza
{
    public override string Nombre => "Red Bull";
}

// Clase para el circuito
public class Circuito
{
    private Monoplaza monoplaza;
    private int numeroVueltas;
    private string nombreCircuito;

    public Circuito(int numeroVueltas, string nombreCircuito)
    {
        this.numeroVueltas = numeroVueltas;
        this.nombreCircuito = nombreCircuito;
    }

    public void AgregarMonoplaza(Monoplaza monoplaza)
    {
        if (this.monoplaza == null)
        {
            this.monoplaza = monoplaza;
        }
    }

    public void SacarMonoplaza()
    {
        if (this.monoplaza != null)
        {
            this.monoplaza = null;
        }
    }

    public void RealizarPrueba()
    {
        if (this.monoplaza != null)
        {
            Console.WriteLine($"Realizando prueba en el circuito {nombreCircuito} con el monoplaza {monoplaza.Nombre}...");
            List<int> tiempos = new List<int>();
            Random random = new Random();

            for (int i = 1; i <= numeroVueltas; i++)
            {
                int tiempo = random.Next(100000, 999999);
            }
        }
    }
}
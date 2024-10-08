interface IPago
{
    void RealizarPago();
}

class PagoTarjeta : IPago
{
    public void RealizarPago()
    {
        System.Console.WriteLine("Pago con tarjeta realizado");
    }
}

class PagoPaypal : IPago
{
    public void RealizarPago()
    {
        System.Console.WriteLine("Pago con Paypal realizado");
    }
}

class Program
{
    static void Main()
    {
        IPago pagoTarjeta = new PagoTarjeta();
        IPago pagoPaypal = new PagoPaypal();

        pagoTarjeta.RealizarPago();
        pagoPaypal.RealizarPago();
    }
}


/*
 * 
 * 3. Crea una interfaz IPago que tenga un método RealizarPago(). Luego, crea dos clases PagoTarjeta y PagoPaypal que implementen esta interfaz. 
 * Cada una debe imprimir un mensaje distinto cuando se realice el pago. Escribe un programa que simule el pago con tarjeta y el pago con Paypal.
 * 
 */
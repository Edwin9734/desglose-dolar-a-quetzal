static void desgloseconmonedas()
{
    float can,dol;
    int c200, c100, c50, c20, c10, c5, c1, d50, d10, d5, d1;
    can = c200 = c100 = c50 = c20 = c10 = c5 = c1 = d50 = d10 = d5 = d1 = 0;
    string linea;

    Console.WriteLine("Bienvenido a Su desglosador incluyendo monedas ");
    Console.WriteLine("Ingrese su cantidad de dolares");
    linea = Console.ReadLine();
    dol = float.Parse(linea);
    can = (float)(dol * 7.70);

    if ((can >= 200))
    {
        c200 = ((int)can / 200);
        can = can - (c200 * 200);
    }
    if ((can >= 100))
    {
        c100 = ((int)can / 100);
        can = can - (c100 * 100);
    }
    if ((can >= 100))
    {
        c100 = ((int)can / 100);
        can = can - (c100 * 100);
    }
    if ((can >= 50))
    {
        c50 = ((int)can / 50);
        can = can - (c50 * 50);
    }
    if ((can >= 20))
    {
        c20 = ((int)can / 20);
        can = can - (c20 * 20);
    }
    if ((can >= 10))
    {
        c10 = ((int)can / 10);
        can = can - (c10 * 10);
    }
    if ((can >= 5))
    {
        c5 = ((int)can / 5);
        can = can - (c5 * 5);
    }
    if ((can >= 1))
    {
        c1 = ((int)can / 1);
        can = can - (c1 * 1);
    }
    if ((can >= 0.5))
    {
        d50 = (int)(can / 0.50);
        can = can - (float)(d50 * 0.50);
    }
    if ((can >= 0.10))
    {
        d10 = (int)(can / 0.10);
        can = can - (float)(d10 * 0.10);
    }
    if ((can >= 0.05))
    {
        d5 = (int)(can / 0.05);
        can = can - (float)(d5 * 0.05);
    }
    if ((can >= 0.01))
    {
        d1 = (int)Math.Round(can / 0.01);
        can = can - (float)(d1 * 0.01);
    }


    Console.WriteLine($"BILLETES DE 200     {c200}");
    Console.WriteLine($"BILLETES DE 100     {c100}");
    Console.WriteLine($"BILLETES DE 50      {c50}");
    Console.WriteLine($"BILLETES DE 20      {c20}");
    Console.WriteLine($"BILLETES DE 10      {c10}");
    Console.WriteLine($"BILLETES DE 5       {c5}");
    Console.WriteLine($"BILLETES DE 1       {c1}");
    Console.WriteLine($"Monedas de 50 cent. {d50}");
    Console.WriteLine($"Monedas de 10 cent. {d10}");
    Console.WriteLine($"Monedas de 5  cent. {d5 }");
    Console.WriteLine($"Monedas de 1  cent. {d1}");
}// fin de desglose con monedas
desgloseconmonedas();


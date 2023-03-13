Random rnd = new Random();
int cislo1;
int cislo2;

//Cyklus na štvorcovú maticu
do
{
   cislo1 = rnd.Next(2,10); //Min. matica musí byť aspoň 2x2
   cislo2 = rnd.Next(2,10); 
}while (cislo1 != cislo2);

int[,] Pole = new int[cislo1,cislo2];
int[] Pole1D = new int[cislo1*cislo2];
int index = 0;

//Vytvorenie hodnôt 2D poľa + zlúčenie do 1D poľa

for (int i = 0; i < cislo1; i++)
{
    for (int c = 0; c < cislo1; c++)
    {
        Pole[i,c] = rnd.Next(10);
        Pole1D[index] = Pole[i, c];
        index++;    
    }
}

//Výpis 2D poľa

for (int i = 0; i < cislo1; i++)
{
    for (int c = 0; c < cislo1; c++)
    {
        Console.Write(Pole[i,c] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

//Triedenie

BubbleSort(Pole1D);

//Výpis 1D poľa

for (int i = 0; i < Pole.Length; i++)
{
    Console.Write(Pole1D[i] + " ");
}
Console.WriteLine("\n");

int[,] SortedArray = new int[cislo1, cislo2];
int PrvokPola = 0;

//Vpísanie zoradených hodnôt do 2D poľa

for (int i = 0; i < cislo1; i++)
{
    for (int c = 0; c < cislo1; c++)
    {
        if(PrvokPola< Math.Pow(cislo1,2))
        {
            SortedArray[i, c] = Pole1D[PrvokPola];
        }
        PrvokPola++;       
    }
}

//Výpis 2D poľa

for (int i = 0; i < cislo1; i++)
{
    for (int c = 0; c < cislo2; c++)
    {
        Console.Write(SortedArray[i,c]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int priemer = 0 , suma = 0;

for (int i = 0; i < cislo1; i++)
{
    for (int c= 0; c < cislo1; c++)
    {
        priemer += SortedArray[i, c];
        if (i == c)
        {
            suma += SortedArray[i, c];
        }
    }   
}

//Výpis funkcii

Console.WriteLine("Najmenšie je : " + Pole1D[0]);
Console.WriteLine("Najväčšie je : " + Pole1D[Pole1D.Length-1]);
Console.WriteLine("Suma je : " + suma);
Console.WriteLine("Súčet pola je : " + priemer);
Console.WriteLine("Aritmetický priemer je : " + Convert.ToDouble(priemer) / (cislo2 * cislo1));


//Sorting metóda

static void BubbleSort(int[]Pole1D)
{
    bool usporiadane = false;
    int cmd = Pole1D.Length-1;
    while (!usporiadane)
    {
        usporiadane = true;
        for (int i = 0; i < cmd; i++)
        {
            if (Pole1D[i] > Pole1D[i + 1])
            {
                int t = Pole1D[i];
                Pole1D[i] = Pole1D[i + 1];
                Pole1D[i + 1] = t;
                usporiadane = false;
            }
        }
        cmd--;
    }
}
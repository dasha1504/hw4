/* Console.WriteLine("Input First Number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input Second Number");
int b = int.Parse(Console.ReadLine());
int result = a;
for(int i=1; i < b; i++)
{
result = result * a;
}
Console.WriteLine(result); */


/* Console.WriteLine("Input number");
int a = int.Parse(Console.ReadLine());
int sum = 0;
int b = 0;
while(a>=1)
{
b = a%10;
a = a/10;
sum=sum + b;
}
Console.WriteLine(sum); */


/* void FillArray(int[] massiv)
{
    int a = massiv.Length;
    int i = 0;
    while(i<a)
    {
        massiv[i] = new Random().Next(0, 100);
        i++;
    }

}
void PrintArray(int[] massiv)
{
   int a= massiv.Length;
   int i = 0;
while(i<a)
{
    Console.Write(massiv[i] + ",");
    i++;
}
} 
int[]massiv = new int[8];
FillArray(massiv);
PrintArray(massiv); */
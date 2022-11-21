//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

Console.WriteLine("Введите число: ");
int x=Convert.ToInt32(Console.ReadLine());
int n=0;

while (x>0);
{
  n++;
  x=x/10;

}

//int array [n]
//int number = x;
//for(int i=n-1; i>=0; i--);
//{
   // array[i] = number %10;
  //  number/=10; 
//}

//if(n>=3)
//{
  //  Console.WriteLine(array[2]);
//}
//else
//{
  //  Console.WriteLine("Третей цифры нет!");
//}

if(n>99)
{
  Console.WriteLine((n/100)%1);
}


//Console.WriteLine();
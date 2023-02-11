//введите некоторое кол-во чисел. укажите сколько из них положительных

Console.Write("укажите кол-во вводимых чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = new int [num];

for (int i = 0; i < array.Length; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    
int numPositive = 0;
for (int i = 0; i < array.Length; i++)
  if (array[i] > 0) numPositive++;

 Console.WriteLine($"positive numbers: {numPositive}");

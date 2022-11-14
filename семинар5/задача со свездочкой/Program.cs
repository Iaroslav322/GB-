//Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
Console.Clear();
 int [] numbers = {1,2,2,3,2};
int temp;  
 

for (int i = 0; i < numbers.Length; i++){
for(int j = 0; j < numbers.Length-1-i; j++){
if (numbers[j] < numbers[j + 1]){

temp = numbers[j];
numbers[j] = numbers[j+1];
numbers[j+1] = temp;
}
}
}

{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + ", ");
        }
    Console.Write("]");
    Console.WriteLine();
}


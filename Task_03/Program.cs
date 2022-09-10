// Найдите сумму произведений пар чисел в одномерном целочисленном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.

// 1, 3, 8, 3, 2 -> 11

// 8, 3, 4, 2 -> 28

int[] array = new int[] {1,2,3,4,5};

void WorkMassiv(int[] array)
{
    int work = 0;
    for(int i = 0; i<array.Length/2;i++)
    {
        work = work + array[i] * array[array.Length - (i+1)];
    }
Console.WriteLine(work);
}
WorkMassiv(array);
int[] qwerty = new int[] {3,5,4,6,5,4,2,7};
WorkMassiv(qwerty);
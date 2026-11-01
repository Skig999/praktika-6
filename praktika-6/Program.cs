//#1
struct IntArray
{
    public int[] arr;
    public Random rnd;

    // Конструктор с одним аргументом - размер массива
    public IntArray(int size)
    {
        arr = new int[size];
        rnd = new Random();     //генератор случайных чисел
        for (int i = 0; i < size; i++)
        {        //Проходит по всем ячейкам массива и кладёт туда случайное число от 1 до 99
            arr[i] = rnd.Next(1, 100);
        }
    }

    //Max ищет наибольший элемент
    public int Max()
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
        }
        return max;
    }

    //Min ищет наименьший элемент
    public int Min()
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min) min = arr[i];
        }
        return min;
    }

    //Average - поиск среднее значение
    public double Average()
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return (double)sum / arr.Length;
    }
}

class Program
{
    static void Main()    //Создаёт структуру размером 5 элементов, выводит массив и результаты расчётов
    {
        IntArray a = new IntArray(5);
        Console.WriteLine("Массив: " + string.Join(", ", a.arr));
        Console.WriteLine("Максимум: " + a.Max());
        Console.WriteLine("Минимум: " + a.Min());
        Console.WriteLine("Среднее: " + a.Average());
    }
}

////#2
//// Вторая структура - с символьным полем
//struct CharBox    //простая структура с одним полем - char
//{
//    public char symbol;
//}

//// Первая структура - с текстовым полем
//struct TextBox
//{
//    public string text;

//    // Метод возвращает экземпляр CharBox
//    public CharBox GetCharAt(int index)    //Принимает номер буквы индекса, счёт начинается с 0
//    {
//        CharBox result;     //Создаёт переменную result типа CharBox
//        result.symbol = text[index];    //Записывает в неё букву из текста по указанному индексу text[index]
//        return result;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        TextBox tb;
//        tb.text = "Привет";   // создает тексбокс и вписываем в него слово

//        CharBox cb = tb.GetCharAt(2); // 'и'
//        Console.WriteLine("Символ: " + cb.symbol);    //в консоли будет выводиться 3-й символ
//    }
//}

////#3
//// Первая структура - одно целочисленное поле
//struct One
//{
//    public int value;
//}

//// Вторая структура - два целочисленных поля
//struct Two
//{
//    public int a;
//    public int b;

//    // Оператор сложения двух One -> Two
//    public static Two operator +(One x, One y)
//    {
//        Two result;
//        result.a = x.value;
//        result.b = y.value;
//        return result;
//    }

//    // Метод "разбивает" Two на массив из двух One
//    public One[] Split()
//    {
//        One[] result = new One[2];
//        result[0].value = a;
//        result[1].value = b;
//        return result;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        One x;
//        x.value = 10;

//        One y;
//        y.value = 25;

//        Two sum = x + y;
//        Console.WriteLine("Two: a = " + sum.a + ", b = " + sum.b);

//        One[] parts = sum.Split();
//        Console.WriteLine("Части: " + parts[0].value + " и " + parts[1].value);
//    }
//}
string[] arr = { "hello", "world", "^^", ":D", "GeekBrains" }; // Исходный массив

int count = 0;
foreach (string s in arr)           // Ищем строки, которые больше 3 символов
{
  if (s.Length <= 3)
  {
    count++;
  }
}
// Создаем новый массив из строк, длина которых меньше или равна 3 символам
string[] newArr = new string[count];
int index = 0;
foreach (string s in arr)
{
  if (s.Length <= 3)
  {
    newArr[index] = s;
    index++;
  }
}

// Выводим новый массив
foreach (string s in newArr)
{
  Console.WriteLine(s);
}

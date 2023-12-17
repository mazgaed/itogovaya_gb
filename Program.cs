string[] arr = { "hello", "world", "^^", ":D", "GeekBrains" }; // Исходный массив

foreach (string s in arr){ // Ищем строки, которые больше 3 символов
if(s.Length > 3){
  System.Console.WriteLine(s); // Выводим элементы массива
}
}

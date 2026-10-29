// // Пример задания 1
// Console.Write("Введите слово: ");
// string word = Console.ReadLine();
// Console.WriteLine($"Длина: {word.Length}");
// Console.WriteLine($"Первый символ: {word[0]}");
// Console.WriteLine($"Последний символ: {word[word.Length - 1]}");

// Задание 1
// Console.Write("Введите строку: ");
// string input = Console.ReadLine();
// int count = 0;
// foreach (char c in input)
// {
//     if (char.ToLower(c) == 'а')
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Буква 'а' встречается раз: {count}");

// Пример 2
// Console.Write("Имя файла: ");
// string fileName = Console.ReadLine();
// if (fileName.EndsWith(".cs")) {
//     Console.WriteLine("Это файл C#");
// } else {
//     Console.WriteLine("Это не файл C#");
// }

// Задание 2
// Console.Write("Имя файла: ");
// string fileName = Console.ReadLine();
// if (fileName.EndsWith(".cs"))
// {
//     Console.WriteLine("Это файл C#");
// }
// else if (fileName.EndsWith(".png") || fileName.EndsWith(".jpg"))
// {
//     Console.WriteLine("Это изображение");
// }
// else
// {
//     Console.WriteLine("неизвестный тип");
// }
// if (fileName.StartsWith("Lab"))
// {
//     Console.WriteLine("Это лабораторная работа");
// }
// if (fileName.Contains("test"))
// {
//     Console.WriteLine("Тестовый файл");
// }

// Пример 3
// Console.Write("Вы согласны? (да/нет): ");
// string answer = Console.ReadLine();
// if (answer.ToLower() == "да") {
//     Console.WriteLine("Отлично!");
// }

// Задание 3
// Console.Write("Введите фразу: ");
// string phrase = Console.ReadLine();
// Console.WriteLine(phrase.ToUpper());
// Console.WriteLine(phrase.Replace(" ", "_"));
// if (phrase.ToLower().Contains("стоп"))
// {
//     Console.WriteLine("Стоп-слово найдено!");
// }

// Пример 4
// string date = "2026-09-29";
// string year = date.Substring(0, 4);
// Console.WriteLine(year);

// // Задание 4

// // вариант 1 
// Console.Write("Введите дату в формате ГГГГ-ММ-ДД (например, 2026-09-29): ");
// string iD = Console.ReadLine();
// string yyyy = iD.Substring(0, 4);
// string mm = iD.Substring(5, 2);
// string dd = iD.Substring(8, 2);
// Console.WriteLine($"Дата в новом формате: {dd}.{mm}.{yyyy}");
// Console.WriteLine();

// // вариант 2
// Console.Write("Введите телефон из 11 цифр (например, 89161234567): ");
// string phone = Console.ReadLine();
// string code = phone.Substring(1, 3);   
// string part1 = phone.Substring(4, 3);  
// string part2 = phone.Substring(7, 2);  
// string part3 = phone.Substring(9, 2);  
// Console.WriteLine($"Телефон в новом формате: +7 ({code}) {part1}-{part2}-{part3}");

// самостоятельные задания

// задание 5
// Console.Write("Введите строку: ");
// string text = Console.ReadLine();
// int t = text.Length;
// int Count1 = 0;
// int Count2 = 0;
// string vowels = "аеёиоуыэюя";
// foreach (char c in text)
// {
//     if (c == ' ')
//     {
//         Count1++;
//     }
//     if (vowels.Contains(char.ToLower(c)))
//     {
//         Count2++;
//     }
// }
// Console.WriteLine($"Количество символов: {t}");
// Console.WriteLine($"Количество пробелов: {Count1}");
// Console.WriteLine($"Количество гласных букв: {Count2}");

// Задание 6
// Console.Write("Введите слово: ");
// string word = Console.ReadLine();
// string reversed = "";
// for (int i = word.Length - 1; i >= 0; i--)
// {
//     reversed += word[i];
// }
// Console.WriteLine($"Слово задом наперёд: {reversed}");
// if (word.ToLower() == reversed.ToLower())
// {
//     Console.WriteLine("Слово является палиндромом");
// }
// else
// {
//     Console.WriteLine("Слово не является палиндромом");
// }

// Итоговая задача
// Console.Write("Введите email: ");
// string email = Console.ReadLine();
// if (email.Length < 5)
// {
//     Console.WriteLine("Адрес некорректен: Длина меньше 5 символов");
//     return; 
// }
// int atCount = 0;
// foreach (char c in email)
// {
//     if (c == '@')
//     {
//         atCount++;
//     }
// }
// if (atCount != 1)
// {
//     Console.WriteLine("Адрес некорректен: Должен быть ровно один символ @");
//     return;
// }
// if (email.StartsWith("@") || email.EndsWith("@"))
// {
//     Console.WriteLine("Адрес некорректен: Адрес не должен начинаться или заканчиваться на @");
//     return;
// }
// if (email.Contains(" "))
// {
//     Console.WriteLine("Адрес некорректен: В адресе не должно быть пробелов");
//     return;
// }
// string emailLower = email.ToLower();
// if (!emailLower.EndsWith(".ru") && !emailLower.EndsWith(".com"))
// {
//     Console.WriteLine("Адрес некорректен: Адрес должен заканчиваться на .ru или .com");
//     return;
// }
// Console.WriteLine("Адрес корректен");
// Console.WriteLine(emailLower);


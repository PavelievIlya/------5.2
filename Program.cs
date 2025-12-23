using System;
using System.Collections.Generic;
using System.Linq;

// Исходный список
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine("Полный список: " + string.Join(", ", numbers));
int n = 3;
var firstElements = numbers.Take(n).ToList();

Console.WriteLine($"Первые {n} элемента: " + string.Join(", ", firstElements));

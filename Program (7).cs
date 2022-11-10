// Выносим в константы размерность матрицы
const int columnsCount = 5;
const int rowsCount = 10;

var matrix = new double[columnsCount, rowsCount];
var random = new Random();

// Проходимся по каждой строке
for (var i = 0; i < columnsCount; i++) {
    // Проходимся по каждому столбцу строки
    for (var j = 0; j < rowsCount; j++) {
        // Заполняем и выводим элемент матрицы
        matrix[i, j] = random.Next(100);
        Console.Write($"{matrix[i, j].ToString().PadLeft(2)} ");
    }
    Console.WriteLine();
}

// Создаем переменную под количество монотонно убывающих столбцов
var count = 0;
// Проходимся по каждому стобцу
for (var i = 1; i < rowsCount; i++) {
    // Создаем переменную под флаг
    var flag = true;
    // Проходимся по строкам стобца, постепенно спускаясь
    for (var j = 0; j < columnsCount; j++) {
        // Если предыдущий элемент столбца был больше текущего, то меняем флаг
        if (matrix[j, i - 1] < matrix[j, i]) flag = false;
    }
    // Если каждый последующий элемент был меньше предыдущего, то есть столбец монотонно убывал, то увеличиваем счетчик
    if (flag) count++;
}

// Ну и выводим этот счетчик
Console.WriteLine($"\nCount: {count}");


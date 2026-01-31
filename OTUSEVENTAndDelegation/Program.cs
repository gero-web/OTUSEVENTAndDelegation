// See https://aka.ms/new-console-template for more information
using OTUSEVENTAndDelegation;
using OTUSEVENTAndDelegation.EnetsArgs;
using OTUSEVENTAndDelegation.Extensions;

List<string> strings =
[
        "1", "2", "3", "4","1", "2", "3",
];



var maxElement = strings.GetMax(x =>
{
    var result = float.TryParse(x, out var value);
    if (result == false)
    {
        throw new ArgumentException($" не удалось преобразовать значение {x}");
    }
    return value;
});

Console.WriteLine(maxElement);

Console.Write("Введите путь папки в кторой надо найти файлы:");
var path = Console.ReadLine();
var fileSearch = new FileFinders();

fileSearch.FileHangler += (sender, fileArgs) =>
            Console.WriteLine($"Найден файл: {fileArgs.FileName}");

fileSearch.SearchFile(path);
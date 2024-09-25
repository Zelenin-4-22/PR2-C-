using ConsoleApp1;

start: 

Labotary2 lb2 = new Labotary2();

string per;

double x;
double y;

Console.WriteLine("Введите первое число");
try { x = Convert.ToDouble(Console.ReadLine());}
catch (Exception ex)
{
    x = 0;
}

Console.WriteLine("Введите операцию или функцию");
per = Convert.ToString(Console.ReadLine());

Console.WriteLine("Введите второе число");
try
{
    y = Convert.ToDouble(Console.ReadLine());
}
catch (Exception ex)
{
    y = 0;
}

switch(per)
{
    case "+":
        lb2.plus(x, y);
        goto start;
    case "-":
        lb2.minus(x, y);
        goto start;
    case "*":
        lb2.umnoshenie(x, y);
        goto start;
    case "/":
        lb2.delenie(x, y);
        goto start;
    case "степень":
        lb2.stepen(x, y);
        goto start;
    case "sqrt":
        lb2.sqrt(x, y);
        goto start;
    case "округление":
        lb2.okryglenie(x, y);
        goto start;
    case "арксинус":
        lb2.arksin(x, y);
        goto start;
    case "площадь прямоугольника":
        lb2.ploshadpr(x, y);
        goto start;
    case "тангенс":
        lb2.tan(x, y);
        goto start;
    case "гиперболический тангенс":
        lb2.tanh(x, y);
        goto start;
    case "периметр прямоугольника":
    default:
        Console.WriteLine("Вы не ввели действие");
        break;
}
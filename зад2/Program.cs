// по заданному номеру четверти покажет диапазон координат точек
 void Qua(int quadrant)
{
    string output = "некорректный ввод данных";
    if (quadrant==1)
    output = $"для четверти {quadrant} x>0 y>0";
    if (quadrant==2)
    output = $"для четверти {quadrant} x<0 y>0";
    if (quadrant==3)
    output = $"для четверти {quadrant} x<0 y<0";
    if (quadrant==4)
    output = $"для четверти {quadrant} x>0 y<0";
    Console.WriteLine(output);
}
Console.WriteLine("Введите номер четверти: ");
int qua = Convert.ToInt32(Console.ReadLine());
Qua(qua);

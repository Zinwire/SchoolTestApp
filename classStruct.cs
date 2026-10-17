

namespace SchoolTestApp;

struct SClass{

}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct ClassId
{
    public byte Grade;         // 1 байт — Номер класса (1, 2... 10, 11)
    public ClassLetter Letter; // 14 байт — Буква класса (А, Б, В, М...)

    // Удобное свойство-обертка для красивого вывода в UI вашего MAUI приложения
    public string DisplayName => $"{Grade}-{Letter}";

    // Задаем базовый тип byte. Теперь каждый элемент занимает ровно 1 байт.
	public enum ClassLetter : byte
	{
    	None = 0,
    	A = 1,
    	B = 2,
    	V = 3,
    	G = 4,
    	M = 5 // Например, "М" — математический класс
	}

}
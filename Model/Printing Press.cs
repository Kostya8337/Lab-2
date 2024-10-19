using System;

// Базовий клас ДрукарськеВидання
abstract class ДрукарськеВидання
{
    public string Назва { get; set; }
    public double Ціна { get; set; }

    public ДрукарськеВидання(string назва, double ціна)
    {
        Назва = назва;
        Ціна = ціна;
    }

    // Два віртуальні методи
    public virtual void ПоказатиДані()
    {
        Console.WriteLine($"Назва: {Назва}, Ціна: {Ціна}");
    }

    public virtual void ОновитиЦіну(double новаЦіна)
    {
        Ціна = новаЦіна;
        Console.WriteLine($"Ціна оновлена до: {Ціна}");
    }
}

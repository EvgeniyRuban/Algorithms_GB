﻿using BenchmarkDotNet.Running;

namespace Algorithms.Lesson_3
{
    class Program
    {
        //Напишите тесты производительности для расчёта дистанции между точками с помощью BenchmarkDotNet.
        //Рекомендуем сгенерировать заранее массив данных, чтобы расчёт шёл с различными значениями,
        //но сам код генерации должен происходить вне участка кода, время которого будет тестироваться.

        //Для каких методов потребуется написать тест:
        //Обычный метод расчёта дистанции со ссылочным типом(PointClass — координаты типа float).
        //Обычный метод расчёта дистанции со значимым типом(PointStruct — координаты типа float).
        //Обычный метод расчёта дистанции со значимым типом(PointStruct — координаты типа double).
        //Метод расчёта дистанции без квадратного корня со значимым типом(PointStruct — координаты типа float).
        //Результаты можно оформить в виде списка или таблицы, в которой наглядно можно будет
        //увидеть время выполнения того или иного метода.

        //public static void Main(string[] args)
        //{
        //    BenchmarkRunner.Run<DistanceSearchBenchmarks>();
        //}
    }
}

﻿/*
                                                        Задача:
                                    Спроектувати об'єктну модель для заданої наочної області.
                У роботі в обов'язковому порядку має бути реалізований ВЕСЬ потрібний в завданні функціонал.

                                                    Наочна область:
                               Новорічний дарунок. Визначити ієрархію цукерок і інших солодощів.
                         Створити декілька об'єктів-цукерок. Зібрати дарунок з визначенням його ваги.
                            Провести сортування цукерок в дарунку на основі одного з параметрів.
                             Знайти цукерку в дарунку, відповідну заданому критерію параметрів

                                                        Критерії:

- Використовувати: класи, спадкоємство, інтерфейси, поліморфізм, інкапсуляція
- Кожен клас, метод і змінна повинні мати вичерпні сенс назву і інформативний склад.
    Необхідно точно продумати, які класи необхідні для вирішення завдання.
- Спадкоємство повинне застосовуватися лише тоді, коли це має сенс.
- Класи мають бути грамотно розкладені по файлах.
- Завдання є якоюсь наочною областю, в якій потрібно виділити необхідну ієрархію класів і
    реалізувати її за допомогою ООП (використовуючи спадкоємство, якщо необхідно або реалізовуючи інтерфейси).
- У кожному класі мають бути поля і методи, які ви порахуєте необхідними.
    Програма повинна створювати об'єкти різних класів виділеної наочної області, об'єднувати їх
        в якийсь набір об'єктів (не використовувати колекції). Як правило, виконати пошук по
            заданих критеріях об'єктів, задовольняючим умовам пошук з отриманого набору об'єктів.
- Як структури для зберігання даних використовувати масиви
- Для реалізації пошуку реалізувати методи розширення
- Код має бути відформатований
- Ієрархія спадкоємства має бути мінімум 4 кроки в глибину не включаючи в розрахунок самий базовий.

 */

namespace Module2_HW2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Starter.Run();

            Console.Write("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}
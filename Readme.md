# Контрольная работа

## **Задание:**

### *Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

## **Описание решения:**

### *Сначала просим пользователя ввести количество элементов с клавиатуры. Для этого используем функцию* **ReadInt**, *которая проверяет, действительно ли введённое пользователем число является числом, и если нет, то возвращает ошибку, пока не будет введено целое число.*

### *Далее вводим с клавиатуры строковый массив с количеством эелементов, указанных пользователем с помощью функций* **EnterArray** *и* **ReadString.** *Вводим целую переменную* **count**, *значение которой находим с помощью метода* **GetCount**. *Этот метод считает, сколько у нас элементов в массиве <= 3. Объявляем новый массив, с количестовом элементов* **count**. *С помощью функции* **GetArray** *заполняем новый массив элементами, которые <=3.*

### *Используем ветвлениe. Если количество нужных нам элементов в массиве > 0, то с помощью функции* **PrintArray** *печатаем новый массив, иначе выводим пустые квадратные скобки, которые означают, что нужных нам элементов в массиве нет.*
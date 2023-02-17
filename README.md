# Task

## Библиотека для расчета площади различных фигур

Библиотека предоставляет метод Calculate(shape, segments), shape опциональный, если не передать ничего, то метод вернёт площадь "дефолтной" фигуры (круг для 1 параметра, прямоугольник для 2, треугольник для 3).

##Доступные фигуры

Фигура | Enum | Параметры
------------- | -------------|-------------
Круг | Circle | radius
Прямоугольник | Rectangle | firstSide, secondSide
Треугольник | Triangle | firstSide, secondSide, thirdSide
Трапеция | Trapezoid | largeBasis, smallBasis, height



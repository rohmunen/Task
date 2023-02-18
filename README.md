# Task

## Библиотека для расчета площади различных фигур

Библиотека предоставляет метод Calculate(shape, segments), shape опциональный, если не передать ничего, то метод вернёт площадь "дефолтной" фигуры (круг для 1 параметра, прямоугольник для 2, треугольник для 3).

##Доступные фигуры

Фигура        |     Enum     | Параметры
------------- | -------------|-------------
Круг          | Circle       | radius
Прямоугольник | Rectangle    | firstSide, secondSide
Треугольник   | Triangle     | firstSide, secondSide, thirdSide
Трапеция      | Trapezoid    | largeBasis, smallBasis, height

## Вопрос 3

**products**
Name | Data type |
------------- | -------------|
product_id | int | 
product_name | VARCHAR(50) |

**productcategory**

Name          | Data type    |
------------- | -------------|
product_id    | int          | 
category_id   | int          |    

**category**
Name          | Data type    |
------------- | -------------|
category_id   | int          | 
category_name | VARCHAR(50)  |

Запрос для указанных выше таблиц:

SELECT distinct products.product_name AS product_name, 
categories.category_name AS category_name 
FROM products LEFT OUTER JOIN productcategory 
ON products.product_id = productcategory.product_id
LEFT OUTER JOIN categories ON productcategory.category_id = categories.category_id;






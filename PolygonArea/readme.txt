Приложение для рассчета площади простого многоугольника.
Простой многоугольник - многоугольник, ребра которого не пересекаются, при этом
он может быть выпуклым или вогнутым.
Площадь такого многоугольника вычисляется по формуле площади Гаусса (ссылка на описание:
https://ru.wikipedia.org/wiki/Формула_площади_Гаусса).
Перед вычислением площади проводятся две проверки: проверка на совпадение координат вершин (
не должны совпадать) и проверка на пересечения ребер.
Пересечение ребер проверяется как пересечение отрезков следующим образом:
находятся 2 векторных произведения между вектором, содержащим один отрезок, и векторами от начала
этого отрезка к концам отрезка, который проверяется на перечение. 
Если отрезки пересекаются, то векторные произведения будут разного знака, и произведение вычисленных 
произведений будет меньше 0. Аналогично вычисляются еще два произведения для этих же отрезков, но поменянных
между собой. Произведение вычисленных произведений также должно быть меньше 0.
При соблюдении обоих условий отрезки пересекаются.
Координаты X и Y вводятся последовательно друг за другом, без повторений.


﻿>   **Примерен изпит по "Основи на програмирането"**

1.Пътуване до море
--------------------------

>   Група туристи решили да си направят лятна екскурзия до морето. Те тръгват от
>   село Чушкопек.

>   Да се напише програма, която пресмята общата сума в левове, която е
>   необходима на туристите за тази екскурзия.

>   Разстоянието до морето е 210 километра, а цялата екскурзия е с
>   продължителност 3 дни.

>   Тяхната кола изразходва средно по 7 литра на всеки 100 километра, а цената
>   на бензина е 1,85 лв. за един литър.

>   За всеки ден от техния престой те харчат пари за храна и сувенири.

>   Общата цена за хотел е Z лв. на ден. Като група, първия ден те получават 10%
>   намаление за престоя, втория ден - 15% намаление, а третия ден - 20%.

>   Вход

>   От конзолата се прочитат 3 реда:

-   Парите за храна за един ден - реално число в интервала (0.00…1500.00]

-   Парите за сувенири за един ден - реално число в интервала (0.00…1500.00]

-   Парите за хотел за един ден - реално число в интервала [100.00…5000.00]

>   Изход

>   На конзолата се отпечатва 1 ред:

"Money needed: {total money}"

>   където {total money} e сумата на общия разход на групата, форматирана до
>   втория знак след десетичната запетая.

2. Космически кораб
----------------------------

> Георги трябва да построи космически кораб, който да събира част от екипажа му.
> За целта, той трябва да го направи така, че да има място за поне трима
> астронавти, но за не повече от 10. Всеки астронавт се нуждае от малка стая,
> която да е с размери: 2 метра ширина, 2 метра дължина и с 40 см по-висока от
> средната височина на астронавтите.

> Напишете програма, която изчислява обема на кораба, колко астронавта ще събере и
> принтира на конзолата дали той е достатъчно голям.

> Вход

> Входът се чете от конзолата и съдържа точно 4 реда:

-   На първия ред е широчината на кораба - реално число в интервала [1.00...
    10.00]

-   На втория ред е дължината на кораба - реално число в интервала [1.00…10.00]

-   На третия ред е височината на кораба - реално число в интервала [1.00…20.00]

-   На четвъртия ред е средната височина на астронавтите - реално число в
    интервала [1.50 … 1.90]

> Изход

> Да се отпечата на конзолата един ред:

-   Ако броят на астронавтите е между 3 и 10:

>   "The spacecraft holds {броя на астронавтите} astronauts."

-   Ако броят на астронавтите е по-малък от 3:

>   "The spacecraft is too small."

-   Ако броят на астронавтите е по-голям от 10:

>   "The spacecraft is too big."


3. Суши
-------------------------------

> Суши е японско ястие, което напоследък набира огромна популярност както в
> Европа, така и в България.

> В таблицата са посочени основните видове суши и ресторантите, които го
> предлагат, както и цената за порция суши. Ако искате да си поръчате за вкъщи се
> доплаща цена за доставка, която е на стойност 20 % от цялата поръчка.

| Видове / Ресторанти | Сашими (sashimi) | Маки (maki) | Урамаки (uramaki) | Темаки (temaki) |
|---------------------|------------------|-------------|-------------------|-----------------|
| Sushi Zone          | 4.99 лв.         | 5.29 лв.    | 5.99 лв.          | 4.29 лв.        |
| Sushi Time          | 5.49 лв.         | 4.69 лв.    | 4.49 лв.          | 5.19 лв.        |
| Sushi Bar           | 5.25 лв.         | 5.55 лв.    | 6.25 лв.          | 4.75 лв.        |
| Asian Pub           | 4.50 лв.         | 4.80 лв.    | 5.50 лв.          | 5.50 лв.        |

> Напишете програма, която изчислява колко ще е цената за поръчката. При въвеждане
> на невалиден ресторант да се отпечатва: {име на ресторанта} is invalid
> restaurant!

> Вход

> Входът се чете от конзолата и съдържа точно 4 реда:

-   Видът суши – текст – една от възможностите: "sashimi", "maki", "uramaki",
    "temaki"

-   Име на ресторанта – текст – една от възможностите: "Sushi Zone", "Sushi
    Time", "Sushi Bar", "Asian Pub"

-   Брой порции – цяло число в интервала [1…100]

-   Поръчка – символ – 'Y' или 'N'

> Изход

> Да се отпечата на конзолата :

-   Total price: {крайна цена} lv.

> където резултатът трябва да бъде закръглен до по-голямото цяло число.


4. Преместване
----------------------

> На Осемнадесетият си рожден ден на Хосе взел решение, че ще се изнесе да живее
> на квартира. Опаковал багажа си в кашони и намерил подходяща обява за апартамент
> под наем. Той започва да пренася своя багаж на части, защото не може да вдигне
> целият наведнъж. Има ограничено свободно пространство в новото си жилище където
> може да разположи вещите така, че мястото да бъде подходящо за живеене.

> Напишете програма, която изчислява свободният обем от жилището на Хосе, който
> остава след като пренесе багажа си.

> Бележка: Един кашон е със точни размери: 1m. x 1m. x 1m.

> Вход

> Потребителят въвежда следните данни на отделни редове:

1.  Широчина на свободното пространство – цяло число в интервала [1...1000];

2.  Дължина на свободното пространство – цяло число в интервала [1...1000];

3.  Височина на свободното пространство – цяло число в интервала [1...1000];

4.  На следващите редове (до получаване на команда "Done") – брой кашони, които
    се пренасят в квартирата – цели числа в интервала [1...10000];

> Програмата трябва да приключи прочитането на данни при команда "Done" или ако
> свободното място свърши.

> Изход

> Да се отпечата на конзолата един от следните редове:

-   Ако стигнете до командата "Done" и има още свободно място:

>   "{брой кашони} Cubic meters left."

-   Ако свободното място свърши преди да е дошла команда "Done":

>   "No more free space! You need {брой недостигащи куб. метри} Cubic meters
>   more."


5. Автобус
------------------------


> Автобус кара по маршрут София - Бургас. При тръгването си в автобуса има
> определен брой пътници. На всяка спирка се качват и слизат определен брой
> пътници. Броят на спирките се въвежда от конзолата. Също така, на всеки нечетен
> брой спирки се качват по двама проверяващи и слизат на четните спирки.

> Напишете програма, която изчислява колко пътника ще има в автобуса когато стигне
> в Бургас.

> Вход

> Входът се чете от конзолата и съдържа:

1.  На първия ред - броят пътници в автобуса при потеглянето му - цяло число в
    интервала [1 ... 100]

2.  На втория ред - броят на спирките - цяло число в интервала [1…50]

3.  На следващите редове (равни на броят на спирките \* 2) - броя на пътниците,
    които слизат и броя на пътниците които се качват - цели числа в интервала
    [0…100]

> Изход

>Да се отпечата на конзолата 1 ред :

> "The final number of passengers is: {брой пътници при пристигането}."


6. Таблица за умножение
-----------------------------------

> Най-малкият син на сем. Иванови все още не знае таблицата за умножение. Веднага
> след коледните празници, той ще има контролно и вие трябва да му помогнете да я
> научи. Вашата задача е да съставите програма, в която се въвежда цяло трицифрено
> число, и се извежда таблицата за умножение. Поради особености на вашата програма
> вземаме цифрите на въведеното число в обратен ред. Максималната стойност на
> множителите е определена от всяка една от 3-те цифри на въведеното число.

> Вход

> Входът е цяло трицифрено число в интервала [111…999].

> Изход

> Да се отпечатат на конзолата няколко на брой реда в следния формат:

> {първата цифра} \* {втората цифра} \* {третата цифра} = {резултатът от
> умножението на трите цифри}

Първата, втората и третата цифра не могат да бъдат отрицателно или равно на 0
число!
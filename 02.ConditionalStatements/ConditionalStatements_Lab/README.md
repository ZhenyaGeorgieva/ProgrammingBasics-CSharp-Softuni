﻿Лаб: Условни конструкции
========================

Задачи за упражнение в клас и за домашно към курса ["Основи на програмирането"
\@ СофтУни](https://softuni.bg/courses/programming-basics).

1.Проверка за отлична оценка
--------------------------

Първата задача от тази тема е да се напише **конзолна програма**, която **чете
оценка** (десетично число), въведена от потребителя, и отпечатва
"**Excellent!"** ако оценката е **5.50** или по-висока.

| **вход** | **изход**  |   | **вход** | **изход**      |   | **вход** | **изход**  |   | **вход** | **изход**      |
|----------|------------|---|----------|----------------|---|----------|------------|---|----------|----------------|
| 6        | Excellent! |   | 5        | *(няма изход)* |   | 5.50     | Excellent! |   | 5.49     | *(няма изход)* |

2.Четно или нечетно
-----------------

Да се напише програма, която чете **цяло число**, въведено от потребителя, и
печата дали е **четно** или **нечетно**. Примери:

| **вход** | **изход** |   | **вход** | **изход** |   | **вход** | **изход** |   | **вход** | **изход** |
|----------|-----------|---|----------|-----------|---|----------|-----------|---|----------|-----------|
| 2        | even      |   | 3        | odd       |   | 25       | odd       |   | 1024     | even      |

3.Намиране на по-голямото число
-----------------------------

Да се напише програма, която чете **две цели числа**, въведени от потребителя, и
отпечатва по-голямото от двете. Примери:

| **вход** | **изход** |
|----------|-----------|
| 5        | 5         |
| 3        |           |

4.Изписване на число до 9 с думи
------------------------------

Да се напише програма, която чете **цяло число в диапазона [0…10]**, въведено от
потребителя, и го **изписва с думи** на английски език. Ако числото е извън
диапазона, изписва "**number too big**". Примери:

| **вход** | **изход** |   |   | **вход** | **изход** |   | **вход** | **изход** |   | **вход** | **изход**      |
|----------|-----------|---|---|----------|-----------|---|----------|-----------|---|----------|----------------|
| 5        | five      |   |   | 1        | one       |   | 9        | nine      |   | 10       | number too big |

Тествайте решението си в **judge системата**:
<https://judge.softuni.bg/Contests/Practice/Index/1012#3>

**Подсказка**: можете да напишете дълга
**if**-**else**-**if**-**else**…**else**, с която да разгледате възможните **11
случая**.

5.Познай паролата
---------------

Да се напише програма, която **чете парола** (един ред с произволен текст),
въведена от потребителя, и проверява дали въведеното **съвпада** с фразата
"**s3cr3t!P\@ssw0rd**". При съвпадение да се изведе "**Welcome**". При
несъвпадение да се изведе "**Wrong password!**". Примери:

| **вход** | **изход**       |   | **вход**         | **изход** |   | **вход**     | **изход**       |
|----------|-----------------|---|------------------|-----------|---|--------------|-----------------|
| qwerty   | Wrong password! |   | s3cr3t!P\@ssw0rd | Welcome   |   | s3cr3t!p\@ss | Wrong password! |

Тествайте решението си в **judge системата**:
<https://judge.softuni.bg/Contests/Practice/Index/1012#4>

**Подсказка**: използвайте **if**-**else** конструкцията.

6.Число от 100 до 200
-------------------

Да се напише програма, която **чете цяло число**, въведено от потребителя, и
проверява дали е **под 100**, **между 100 и 200** или **над 200**. Да се
отпечатат съответно съобщения като в примерите по-долу:

| **вход** | **изход**     |   | **вход** | **изход**           |   | **вход** | **изход**        |
|----------|---------------|---|----------|---------------------|---|----------|------------------|
| 95       | Less than 100 |   | 120      | Between 100 and 200 |   | 210      | Greater than 200 |

Тествайте решението си в **judge системата**:
<https://judge.softuni.bg/Contests/Practice/Index/1012#5>

**Подсказка**: използвайте **if**-**else**-**if**-**else** конструкция за да
проверите всеки от трите случая.

7.Еднакви думи
------------

Да се напише програма, която **чете две думи**, въведени от потребителя, и
проверява дали са еднакви. Да не се прави разлика между главни и малки думи. Да
се изведе "**yes**" или "**no**". Примери:

| **вход** | **изход** |
|----------|-----------|
| Hello    | yes       |
|          |           |
| Hello    |           |

Тествайте решението си в **judge системата**:
<https://judge.softuni.bg/Contests/Practice/Index/1012#6>

**Подсказка**: използвайте **if**-**else** конструкция. Преди сравняване на
думите ги обърнете в долен регистър: **word = word.toLower()**.

8.Лица на фигури
--------------

Да се напише програма, в която потребителят **въвежда вида и размерите на
геометрична** фигура и пресмята лицето й. Фигурите са четири вида: квадрат
(**square**), правоъгълник (**rectangle**), кръг (**circle**) и триъгълник
(**triangle**). На първия ред на входа се чете вида на фигурата (**square**,
**rectangle**, **circle** или **triangle**). Ако фигурата е **квадрат**, на
следващия ред се чете едно число - дължина на страната му. Ако фигурата е
**правоъгълник**, на следващите два реда четат две числа - дължините на страните
му. Ако фигурата е **кръг**, на следващия ред чете едно число - радиусът на
кръга. Ако фигурата е **триъгълник**, на следващите два реда четат две числа -
дължината на страната му и дължината на височината към нея. Резултатът да се
закръгли до **3 цифри след десетичната точка**. Примери:

| **вход** | **изход** |   | **вход**  | **изход** |
|----------|-----------|---|-----------|-----------|
| square   | 25        |   | rectangle | 17.5      |
|          |           |   | 7         |           |
| 5        |           |   | 2.5       |           |

Тествайте решението си в **judge системата**:
<https://judge.softuni.bg/Contests/Practice/Index/1012#7>

**Подсказка**: използвайте серия от **if**-**else**-**if**-**else-**…
конструкции, за да обработите 4-те вида фигури.

9.Еднакви 3 числа
---------------

Да се въведат 3 числа и да се отпечата дали са еднакви (yes / no)

Примери:

| **вход** | **изход** | **вход** | **изход** |
|----------|-----------|----------|-----------|
| 1        | yes       | 11       | no        |
| 1        |           | 8        |           |
| 1        |           | 5        |           |

Тествайте решението си в **judge системата**:
<https://judge.softuni.bg/Contests/Practice/Index/1012#8>

**Примерна изпитна задача**

10.Магазин за детски играчки
-------------------------

*Тествайте решението си*
[тук](https://judge.softuni.bg/Contests/Practice/Index/1012#9)*.*

Петя има магазин за детски играчки. Тя получава голяма поръчка, която трябва да
изпълни. С парите, които ще спечели иска да отиде на екскурзия. Да се напише
програма, която пресмята печалбата от поръчката.

**Цени на играчките:**

-   **Пъзел - 2.60 лв.**

-   **Говореща кукла - 3 лв.**

-   **Плюшено мече - 4.10 лв.**

-   **Миньон - 8.20 лв.**

-   **Камионче - 2 лв.**

Ако поръчаните играчки са **50 или повече** магазинът прави **отстъпка 25% от
общата цена**. От спечелените пари Петя трябва да даде **10% за наема** на
магазина. Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.

### Вход

От конзолата се четат **6 реда**:

1.  **Цена на екскурзията - реално число в интервала [1.00 … 10000.00]**

2.  **Брой пъзели - цяло число в интервала [0… 1000]**

3.  **Брой говорещи кукли - цяло число в интервала [0 … 1000]**

4.  **Брой плюшени мечета - цяло число в интервала [0 … 1000]**

5.  **Брой миньони - цяло число в интервала [0 … 1000]**

6.  **Брой камиончета - цяло число в интервала [0 … 1000]**

### Изход

На конзолата се отпечатва:

-   Ако **парите са достатъчни** се отпечатва:

    -   **"Yes! {оставащите пари} lv left."**

-   Ако **парите НЕ са достатъчни** се отпечатва:

    -   **"Not enough money! {недостигащите пари} lv needed."**

**Резултатът трябва да се форматира до втория знак след десетичната запетая**.

### Примерен вход и изход

| **Вход** | **Изход**            | **Обяснения**                                                                                                                                                                                                                                                                                                                                                                     |
|----------|----------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| 40.8     | Yes! 418.20 lv left. | **Сума**: 20 \* 2.60 + 25 \* 3 + 30 \* 4.10 + 50 \* 8.20 + 10 \* 2 = **680** лв. **Брой на играчките**: 20 + 25 + 30 + 50 + 10 = **135 135 \> 50 =\> 25% отстъпка**; 25% от 680 = **170 лв. отстъпка Крайна цена**: 680 – 170 = **510** лв. **Наем**: 10% от 510 лв. = **51** лв. **Печалба**: 510 – 51 = **459** лв. **459 \> 40.8** =\> 459 – 40.8 = **418.20** лв. **остават** |
| 20       |                      |                                                                                                                                                                                                                                                                                                                                                                                   |
| 25       |                      |                                                                                                                                                                                                                                                                                                                                                                                   |
| 30       |                      |                                                                                                                                                                                                                                                                                                                                                                                   |
| 50       |                      |                                                                                                                                                                                                                                                                                                                                                                                   |
| 10       |                      |                                                                                                                                                                                                                                                                                                                                                                                   |

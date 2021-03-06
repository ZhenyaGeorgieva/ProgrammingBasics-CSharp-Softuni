Изпит по "Основи на програмирането" – 7 и 8 Юли 2018
====================================================

Задача 3. Суши
==============

Суши е японско ястие, което напоследък набира огромна популярност както в
Европа, така и в България.

В таблицата са посочени основните видове суши и ресторантите, които го
предлагат, както и цената за порция суши. Ако искате да си поръчате за вкъщи се
доплаща цена за доставка, която е на стойност 20 % от цялата поръчка.

| **Видове / Ресторанти** | **Сашими**  **(sashimi)** | **Маки (maki)** | **Урамаки (uramaki)** | **Темаки (temaki)** |
|-------------------------|---------------------------|-----------------|-----------------------|---------------------|
| **Sushi Zone**          | 4.99 лв.                  | 5.29 лв.        | 5.99 лв.              | 4.29 лв.            |
| **Sushi Time**          | 5.49 лв.                  | 4.69 лв.        | 4.49 лв.              | 5.19 лв.            |
| **Sushi Bar**           | 5.25 лв.                  | 5.55 лв.        | 6.25 лв.              | 4.75 лв.            |
| **Asian Pub**           | 4.50 лв.                  | 4.80 лв.        | 5.50 лв.              | 5.50 лв.            |

**Напишете програма, която изчислява колко ще е цената за поръчката. При
въвеждане на невалиден ресторант да се отпечатва: {име на ресторанта} is invalid
restaurant!**

Вход
----

Входът се чете от **конзолата** и съдържа **точно 4 реда**:

-   **Видът суши – текст – една от възможностите: "sashimi", "maki", "uramaki",
    "temaki"**

-   **Име на ресторанта – текст – една от възможностите: "Sushi Zone", "Sushi
    Time", "Sushi Bar", "Asian Pub"**

-   **Брой порции – цяло число в интервала [1…100]**

-   **Поръчка – символ – 'Y' или 'N'**

Изход
-----

Да се **отпечата** на конзолата :

-   **Total price: {крайна цена} lv.**

където резултатът трябва да бъде **закръглен до по-голямото цяло число**.

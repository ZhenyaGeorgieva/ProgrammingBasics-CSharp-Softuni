**Изпит по "Основи на програмирането" - 3 и 4 Ноември 2018**
============================================================

Задача 3.Инвестиции за сватба
=============================

Мечтаейки да осигури перфектната сватба на половинката си, Иван решава да
инвестира и отваря ресторант, като част от идеята му е да предлага и абонаментни
програми за доставка до дома. **Месечната такса се определя в зависимост от типа
поръчка и срока**. **Да се напише програма, която изчислява сумата, която трябва
да се плати за определен брой месеци.**

| **срок / тип** | **Small** | **Middle** | **Large** | **ExtraLarge** |
|----------------|-----------|------------|-----------|----------------|
| **1 година**   | 9.98 лв.  | 18.99 лв.  | 25.98 лв. | 35.99 лв.      |
| **2 години**   | 8.58 лв.  | 17.09 лв.  | 23.59 лв. | 31.79 лв.      |

**Условия:**

-   **при добавен десерт, към таксата се прибавя различна сума, в зависимост от
    цената на абонамента**

-   **при сума по-малка или равна на 10.00 лв. 5.50 лв**

-   **при сума по-малка или равна на 30.00 лв. 4.35 лв.**

-   **при сума по-голяма от 30.00 лв. 3.85 лв.**

-   **ако договорът е за две години, общата сума се намалява с 3.75%**

### Вход

От конзолата се четат **4 реда**:

1.  **срок на договор - текст - "one"**, или **"two"**

2.  **тип на договор - текст - "Small", "Middle", "Large"или "ExtraLarge"**

3.  **Добавен десерт - текст - "yes", или "no"**

4.  **брой месеци за плащане - цяло число в интервала [1 … 24]**

### Изход

На конзолата се отпечатва **1 ред**:

-   **Цената, която заплаща клиентът**, **форматирана до втория знак след
    десетичната запетая**, в следния формат: **"{цената} lv."**
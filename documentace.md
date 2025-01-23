## 1. Selection Sort
### Popis fungování
- Algoritmus opakovaně hledá nejmenší prvek v nezpracované části seznamu a přesouvá jej na správnou pozici.
- Iteruje přes seznam a pro každou pozici vybírá nejmenší zbývající hodnotu.

### Vhodnost a omezenost využití
- **Vhodnost:** Jednoduchá implementace, vhodný pro malé seznamy.
- **Omezenost:** Nízká efektivita na velkých datech (časová složitost O(n²)).

---

## 2. Bubble Sort
### Popis fungování
- Opakovaně porovnává sousední prvky a mění jejich pořadí, pokud jsou ve špatném pořadí.
- Po každé iteraci je největší prvek na správném místě.

### Vhodnost a omezenost využití
- **Vhodnost:** Snadná implementace, vhodný pro malé seznamy nebo seznamy téměř seřazené.
- **Omezenost:** Nejhorší časová složitost O(n²), nevhodné pro velké množství dat.

---

## 3. Insertion Sort
### Popis fungování
- Buduje seřazenou část seznamu tím, že se prvky vkládají na správné místo.
- Prochází seznam a "vkládá" aktuální prvek na správnou pozici v již seřazené části.

### Vhodnost a omezenost využití
- **Vhodnost:** Efektivní pro malé seznamy nebo téměř seřazené seznamy (časová složitost O(n) v nejlepším případě).
- **Omezenost:** Nevhodné pro velké seznamy kvůli časové složitosti O(n²).

---

## 4. Heapsort
### Popis fungování
- Vytvoří binární haldu (heap) a opakovaně extrahuje největší prvek.
- Po každém odstranění největšího prvku obnovuje haldu.

### Vhodnost a omezenost využití
- **Vhodnost:** Efektivní časová složitost O(n log n), stabilní výkon.
- **Omezenost:** Vyžaduje další paměť pro haldu, není stabilní.

---

## 5. Merge Sort
### Popis fungování
- Rekurzivně dělí seznam na menší podseznamy, dokud nemá jednotlivé prvky.
- Slévá podseznamy zpět ve správném pořadí.

### Vhodnost a omezenost využití
- **Vhodnost:** Stabilní, časová složitost O(n log n). Vhodné pro velké datové sady.
- **Omezenost:** Vyžaduje další paměť (O(n)), což může být nevýhodou.

---

## 6. Quick Sort
### Popis fungování
- Vybere pivotní prvek a rozdělí seznam na dvě části: menší než pivot a větší než pivot.
- Rekurzivně třídí obě části.

### Vhodnost a omezenost využití
- **Vhodnost:** Velmi rychlý v praxi (O(n log n) v průměru), efektivní pro velké datové sady.
- **Omezenost:** V nejhorším případě časová složitost O(n²), není stabilní.

---

## 7. Radix Sort
### Popis fungování
- Netřídí podle porovnávání, ale na základě číslic nebo znaků. Prochází číslice od nejméně významné po nejvýznamnější.
- Využívá podpůrný algoritmus, např. Counting Sort.

### Vhodnost a omezenost využití
- **Vhodnost:** Vhodný pro čísla s pevnou délkou nebo konkrétní datové struktury (časová složitost O(nk), kde k je počet číslic).
- **Omezenost:** Nelze použít na všechny typy dat, vyžaduje další paměť.

---

## Komparace jednotlivých algoritmů

| Algoritmus       | Časová složitost (průměr) | Časová složitost (nejhorší) | Paměťová složitost | Stabilita |
|-------------------|--------------------------|-----------------------------|--------------------|-----------|
| Selection Sort    | O(n²)                   | O(n²)                      | O(1)               | Ne        |
| Bubble Sort       | O(n²)                   | O(n²)                      | O(1)               | Ano       |
| Insertion Sort    | O(n²)                   | O(n²)                      | O(1)               | Ano       |
| Heapsort          | O(n log n)              | O(n log n)                 | O(1)               | Ne        |
| Merge Sort        | O(n log n)              | O(n log n)                 | O(n)               | Ano       |
| Quick Sort        | O(n log n)              | O(n²)                      | O(log n)           | Ne        |
| Radix Sort        | O(nk)                   | O(nk)                      | O(n + k)           | Ano       |

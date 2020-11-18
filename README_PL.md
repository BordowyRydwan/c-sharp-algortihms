![Algorytmy i struktury danych](top_banner.png)

# Algorytymy w C#

Repozytorium jest rozszerzeniem dla [algorithms-and-data-structures](https://github.com/BordowyRydwan/algorithms-and-data-structures), który zawiera moje rozwiązania z przedmiotu "Algorytmy i struktury danych". Zawiera ono przepisane algorytmy z wykładów tego przedmiotu, ale w sposób, który jest choć trochę bardziej zrozumiały niż treści na tych wykładach przedstawione. Ściągaj, jeśli umiesz, tylko się nie przelicz :smile:.

Link do **README** po angielsku: [TUTAJ](README.md)

##  Lista algorytmów

### Algebra

Nazwa | Złożoność czasowa | Złożoność pamięciowa | Czy są TDD? | Notatki
-----| ----------------| ----------------- | ------ | -----
[Symbol Newtona](/algorithms/algebra/binomial_coefficient) | O(n) | O(1) | Nie |
[Liczby pierwsze mniejsze od N](algorithms/algebra/erathostenes_sieve) | O(n^2) | O(n) | Tak |
[Test, czy liczba jest pierwsza](/algorithms/algebra/erathostenes_sieve) | O(n) | O(1) | Tak |
[Ciąg Fibonacciego](/algorithms/algebra/fibonacci_seq) (dynamiczny) | O(n) | O(n) | Nie |
[Ciąg Fibonacciego](/algorithms/algebra/fibonacci_seq) (reszta) | O(n) | O(1) | Nie |
[Najmniejszy Wspólny Dzielnik (NWD)](/algorithms/algebra/gcd_lcm) | O(n) | O(1) | Tak |
[Najmniejsza Wspólna Wielokrotność (NWW)](/algorithms/algebra/gcd_lcm) | O(n) | O(1) | Tak |
[Szybkie potęgowanie](/algebra/quick_power) | O(n) | O(1) | Tak |
[Wyznaczanie pierwiastka kwadratowego](algorithms/algebra/square_root) (Newton - Rawson) | O(n) | O(1) | Nie |

### Kombinatoryka

Nazwa | Złożoność czasowa | Złożoność pamięciowa | Czy są TDD? | Notatki
-----| ----------------| ----------------- | ------ | -----
[Wydawanie reszty](/algorithms/combinatorics/giving_change) (ilość sposobów) | O(n^2) | O(n) | Nie |
[Wydawanie reszty](/algorithms/combinatorics/giving_change) (minimalna ilość monet) | O(n) | O(n) | Nie |
[Index sum](/algorithms/combinatorics/index_sum) | O(n) | O(1) | Nie | dane muszą być posortowane
[Problem plecakowy](/algorithms/combinatorics/knapsack_problem) (maksymalna wartość) | O(n^2) | O(n^2) | Nie |
[Problem plecakowy](/algorithms/combinatorics/knapsack_problem) (konkretne przedmioty) | O(n^2) | O(n^2) | Nie |
[Przywódca ciągu](/algorithms/combinatorics/master_element) | O(n) | O(1) | Nie | dane muszą być posortowane
[Problem wyboru zajęć](/algorithms/combinatorics/separated_tasks_problem) | O(n^2) | O(n) | Nie | 

### Szukanie

Nazwa | Złożoność czasowa | Złożoność pamięciowa | Czy są TDD? | Notatki
-----| ----------------| ----------------- | ------ | -----
[Wyszukiwanie liniowe](/algorithms/searching/linear_search) | O(n) | O(1) | Nie |
[Wyszukiwanie binarne](/algorithms/searching/binary_search) | O(log(n)) | O(1) | Nie | dane muszą być posortowane
[Wyszukiwanie ternarne (trójkowe)](/algorithms/searching/ternary_search) | O(log(n)) | O(1) | Nie | dane muszą być posortowane

### Sortowanie

Nazwa | Złożoność czasowa | Złożoność pamięciowa | Czy są TDD? | Notatki
-----| ----------------| ----------------- | ------ | -----
[Bąbelkowe](/algorithms/sorting/bubble_sort) | O(n^2) | O(1) | Nie |
[Przez wstawianie](/algorithms/sorting/insertion_sort) | O(n^2) | O(1) | Nie |
[Przez wybieranie](/algorithms/sorting/seleciton_sort) | O(n^2) | O(1) | Nie |
[Przez scalanie](/algorithms/sorting/merge_sort) | O(n * log(n)) | O(n) | Nie |
[Szybkie](/algorithms/sorting/quick_sort) | O(n * log(n)) | O(log(n)) | Nie |
[Przez zliczanie](/algorithms/sorting/counting_sort) | O(n + r) | O(n + r) | Nie |
[Pozycyjne](/algorithms/sorting/radix_sort) | O(n * k) | O(n + k) | Nie |
[Sortowanie kolejki](/algorithms/sorting/queue_sort) | O(n^2) | O(n) | Nie |
[Problem flag holenderskich](/algorithms/sorting/flag_problem) | O(n) | O(1) | Nie |

### Tekstowe

Nazwa | Złożoność czasowa | Złożoność pamięciowa | Czy są TDD? | Notatki
-----| ----------------| ----------------- | ------ | -----
[Najdłuższy wspólny podciąg](/algorithms/text/lcs) | O(n^2) | O(n^2) | Nie | 

## TODO:

- [ ] napisać testy jednostkowe
- [ ] oddzielić mocniej pliki
- [ ] napisać dokumentację każdej funkcji
- [ ] lecieć dalej :smile:
- [ ] uzupełnić sekcję źródeł

## Źródła:

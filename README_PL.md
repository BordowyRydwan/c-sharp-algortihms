![Algorytmy i struktury danych](top_banner.png)

# Algorytymy w C#

Repozytorium jest rozszerzeniem dla [algorithms-and-data-structures](https://github.com/BordowyRydwan/algorithms-and-data-structures). Zawiera ono przepisane algorytmy z wykładów przedmiotu "Algorytmy i struktury danych" w sposób, który jest choć trochę bardziej zrozumiały niż treści na nim przedstawione. Ściągaj, jeśli umiesz, tylko się nie przelicz :smile:.

Link do **README** po angielsku: [TUTAJ](README.md)

##  Lista algorytmów

### Algebra

Nazwa | Złożoność czasowa | Złożoność pamięciowa | Czy są TDD? | Notatki
-----| ----------------| ----------------- | ------ | -----
[Symbol Newtona](/algorithms/algebra/binomial_coefficient) | O(n) | O(1) | No |
[Liczby pierwsze mniejsze od N](algorithms/algebra/erathostenes_sieve) | O(n^2) | O(n) | Yes |
[Test, czy liczba jest pierwsza](/algorithms/algebra/erathostenes_sieve) | O(n) | O(1) | Yes |
[Ciąg Fibonacciego](/algorithms/algebra/fibonacci_seq) (dynamiczny) | O(n) | O(n) | No |
[Ciąg Fibonacciego](/algorithms/algebra/fibonacci_seq) (reszta) | O(n) | O(1) | No |
[Najmniejszy Wspólny Dzielnik (NWD)](/algorithms/algebra/gcd_lcm) | O(n) | O(1) | Yes |
[Najmniejsza Wspólna Wielokrotność (NWW)](/algorithms/algebra/gcd_lcm) | O(n) | O(1) | Yes |
[Szybkie potęgowanie](/algebra/quick_power) | O(n) | O(1) | Yes |
[Wyznaczanie pierwiastka kwadratowego](algorithms/algebra/square_root) (Newton - Rawson) | O(n) | O(1) | No |

### Kombinatoryka

Nazwa | Złożoność czasowa | Złożoność pamięciowa | Czy są TDD? | Notatki
-----| ----------------| ----------------- | ------ | -----
[Wydawanie reszty](/algorithms/combinatorics/giving_change) (ilość sposobów) | O(n^2) | O(n) | No |
[Wydawanie reszty](/algorithms/combinatorics/giving_change) (minimalna ilość monet) | O(n) | O(n) | No |
[Index sum](/algorithms/combinatorics/index_sum) | O(n) | O(1) | No | dane muszą być posortowane
[Problem plecakowy](/algorithms/combinatorics/knapsack_problem) (maksymalna wartość) | O(n^2) | O(n^2) | No |
[Problem plecakowy](/algorithms/combinatorics/knapsack_problem) (konkretne przedmioty) | O(n^2) | O(n^2) | No |
[Przywódca ciągu](/algorithms/combinatorics/master_element) | O(n) | O(1) | No | dane muszą być posortowane
[Problem wyboru zajęć](/algorithms/combinatorics/separated_tasks_problem) | O(n^2) | O(n) | No | 

### Szukanie

Nazwa | Złożoność czasowa | Złożoność pamięciowa | Czy są TDD? | Notatki
-----| ----------------| ----------------- | ------ | -----
[Wyszukiwanie liniowe](/algorithms/searching/linear_search) | O(n) | O(1) | No |
[Wyszukiwanie binarne](/algorithms/searching/binary_search) | O(log(n)) | O(1) | No | dane muszą być posortowane
[Wyszukiwanie ternarne (trójkowe)](/algorithms/searching/ternary_search) | O(log(n)) | O(1) | No | dane muszą być posortowane

### Sortowanie

Nazwa | Złożoność czasowa | Złożoność pamięciowa | Czy są TDD? | Notatki
-----| ----------------| ----------------- | ------ | -----
[Bąbelkowe](/algorithms/sorting/bubble_sort) | O(n^2) | O(1) | No |
[Przez wstawianie](/algorithms/sorting/insertion_sort) | O(n^2) | O(1) | No |
[Przez wybieranie](/algorithms/sorting/seleciton_sort) | O(n^2) | O(1) | No |
[Przez scalanie](/algorithms/sorting/merge_sort) | O(n * log(n)) | O(n) | No |
[Szybkie](/algorithms/sorting/quick_sort) | O(n * log(n)) | O(log(n)) | No |
[Przez zliczanie](/algorithms/sorting/counting_sort) | O(n + r) | O(n + r) | No |
[Pozycyjne](/algorithms/sorting/radix_sort) | O(n * k) | O(n + k) | No |
[Sortowanie kolejki](/algorithms/sorting/queue_sort) | O(n^2) | O(n) | No |
[Problem flag holenderskich](/algorithms/sorting/flag_problem) | O(n) | O(1) | No |

## TODO:

- [ ] napisać testy jednostkowe
- [ ] oddzielić mocniej pliki
- [ ] napisać dkoumentację każdej funkcji
- [ ] lecieć dalej :smile:
- [ ] uzupełnić sekcję źródeł

## Źródła:

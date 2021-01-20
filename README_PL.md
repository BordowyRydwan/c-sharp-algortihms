![Algorytmy i struktury danych](top_banner.png)

# Algorytymy w C#

Repozytorium jest rozszerzeniem dla [algorithms-and-data-structures](https://github.com/BordowyRydwan/algorithms-and-data-structures), który zawiera moje rozwiązania z przedmiotu "Algorytmy i struktury danych". Zawiera ono przepisane algorytmy z wykładów tego przedmiotu, ale w sposób, który jest choć trochę bardziej zrozumiały niż treści na tych wykładach przedstawione. Ściągaj, jeśli umiesz, tylko się nie przelicz :smile:.

Link do **README** po angielsku: [TUTAJ](README.md)

##  Lista algorytmów

### Algebra

Nazwa | Złożoność czasowa | Złożoność pamięciowa  | Notatki
-----| ----------------| -----------------  | -----
[Symbol Newtona](/algorithms/algebra/binomial_coefficient) | O(n) | O(1)  |
[Liczby pierwsze mniejsze od N](algorithms/algebra/erathostenes_sieve) | O(n^2) | O(n)  |
[Test, czy liczba jest pierwsza](/algorithms/algebra/erathostenes_sieve) | O(n) | O(1)  |
[Ciąg Fibonacciego](/algorithms/algebra/fibonacci_seq) (dynamiczny) | O(n) | O(n)  |
[Ciąg Fibonacciego](/algorithms/algebra/fibonacci_seq) (reszta) | O(n) | O(1)  |
[Najmniejszy Wspólny Dzielnik (NWD)](/algorithms/algebra/gcd_lcm) | O(n) | O(1)  |
[Najmniejsza Wspólna Wielokrotność (NWW)](/algorithms/algebra/gcd_lcm) | O(n) | O(1)  |
[Szybkie potęgowanie](/algorithms/algebra/quick_power) | O(n) | O(1)  |
[Wyznaczanie pierwiastka kwadratowego](algorithms/algebra/square_root) (Newton - Rawson) | O(n) | O(1)  |

### Kombinatoryka

Nazwa | Złożoność czasowa | Złożoność pamięciowa  | Notatki
-----| ----------------| -----------------  | -----
[Wydawanie reszty](/algorithms/combinatorics/giving_change) (ilość sposobów) | O(n^2) | O(n)  |
[Wydawanie reszty](/algorithms/combinatorics/giving_change) (minimalna ilość monet) | O(n) | O(n)  |
[Index sum](/algorithms/combinatorics/index_sum) | O(n) | O(1)  | dane muszą być posortowane
[Problem plecakowy](/algorithms/combinatorics/knapsack_problem) (maksymalna wartość) | O(n^2) | O(n^2)  |
[Problem plecakowy](/algorithms/combinatorics/knapsack_problem) (konkretne przedmioty) | O(n^2) | O(n^2)  |
[Przywódca ciągu](/algorithms/combinatorics/master_element) | O(n) | O(1)  | dane muszą być posortowane
[Problem wyboru zajęć](/algorithms/combinatorics/separated_tasks_problem) | O(n^2) | O(n)  | 

### Szukanie

Nazwa | Złożoność czasowa | Złożoność pamięciowa  | Notatki
-----| ----------------| -----------------  | -----
[Wyszukiwanie liniowe](/algorithms/searching/linear_search) | O(n) | O(1)  |
[Wyszukiwanie binarne](/algorithms/searching/binary_search) | O(log(n)) | O(1)  | dane muszą być posortowane
[Wyszukiwanie ternarne (trójkowe)](/algorithms/searching/ternary_search) | O(log(n)) | O(1)  | dane muszą być posortowane

### Sortowanie

Nazwa | Złożoność czasowa | Złożoność pamięciowa  | Notatki
-----| ----------------| -----------------  | -----
[Bąbelkowe](/algorithms/sorting/bubble_sort) | O(n^2) | O(1)  |
[Przez wstawianie](/algorithms/sorting/insertion_sort) | O(n^2) | O(1)  |
[Przez wybieranie](/algorithms/sorting/seleciton_sort) | O(n^2) | O(1)  |
[Przez scalanie](/algorithms/sorting/merge_sort) | O(n * log(n)) | O(n)  |
[Szybkie](/algorithms/sorting/quick_sort) | O(n * log(n)) | O(log(n))  |
[Przez zliczanie](/algorithms/sorting/count_sort) | O(n + r) | O(n + r)  |
[Pozycyjne](/algorithms/sorting/radix_sort) | O(n * k) | O(n + k)  |
[Sortowanie kolejki](/algorithms/sorting/queue_sort) | O(n^2) | O(n)  |
[Problem flag holenderskich](/algorithms/sorting/flag_problem) | O(n) | O(1)  |

### Tekstowe

Nazwa | Złożoność czasowa | Złożoność pamięciowa  | Notatki
-----| ----------------| -----------------  | -----
[Najdłuższy wspólny podciąg](/algorithms/text/lcs) | O(n^2) | O(n^2) | 

## Struktury danych

- [Drzewo binarne](/data_structures/array_binary_tree) (implementacja na tablicy)
- [Drzewo binarne](/data_structures/binary_tree) (implementacja węzłowa)
- [Binarne drzewo poszukiwań (BST)](/data_structures/bst)
- [Find & Union](/data_structures/union_find) 
- [Graf](/data_structures/graph) 
- [Kopiec binarny](/data_structures/heap) 
- [Kolejka](/data_structures/queue) 
- [Lista](/data_structures/list) 
- [Zbiór mnogościowy](/data_structures/set) (List and Hashtable implementations)
- [Stos](/data_structures/stack) 
- [Ogólna struktura drzewa](/data_structures/tree) 


## Źródła:

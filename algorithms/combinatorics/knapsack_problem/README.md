# Knapsack problem (often named "0/1 Knapsack Problem")

Another example of solving problems by dynamic programming. Typical storyline goes like that:

You have a table of items:

Weight | Value
-------|------
2 | 1
1 | 4
3 | 8
7 | 8

Tell which items should you pick into the backpack if you can carry only `n` kilogrammes of items. **You can pick each item only once.**

[This movie](https://www.youtube.com/watch?v=xCbYmUPvc2Q) explains how to solve the problem.

## Methods inside:
Declaration | Type of result | Time complexity | Memory stack size | Notes
------------|----------------|-----------------|-------------------|------
int MaxKnapsackValue(List< Tuple< int, int>> items, int maxWeight) | maximum value | O(m * n) | O(m * n) | 
bool[] KnapsackItems(List< Tuple< int, int>> items, int maxWeight) | maximum value | O(m * n) | O(m * n) | 

## TODO:
- [ ] separate files
- [ ] translate the readme into Polish
- [ ] write unit tests

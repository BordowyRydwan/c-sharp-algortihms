# Index sum

It's a solution for problem stated like this:

You 2 arrays of ints sorted with increasing order - `arr1` and `arr2` and a number `N`.
Write an algorithm which tells us if there exist any indexes `a` and `b` that satisfy the equation: `arr1[a] + arr2[b] = N`.

This problem sometimes appears during interviews :smile:


## Methods inside:
Declaration | Type of result | Time complexity | Memory stack size | Notes
------------|----------------|-----------------|-------------------|------
bool DoesIndexSumExist(int[] arr1, int[] arr2, int checkedNumber) | true if sum like that exists | O(n) | O(1) | O(n*log(n)) if input is not sorted

## TODO:
- [ ] extract the algorithms into separate files.
- [ ] translate the readme into Polish
- [ ] write unit tests

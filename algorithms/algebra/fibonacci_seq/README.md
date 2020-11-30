# Fibonacci sequence

Formula of Fibonacci sequence is given below:
```
Fn = Fn-1 + Fn-2
F2 = 1
F1 = 1
```

## Methods inside:
Declaration | Type of result | Time complexity | Memory stack size | Notes
------------|----------------|-----------------|-------------------|------
long FibonacciTermRecursive(long n) | returns n-th Fibonacci sequence term | O(n) | O(1) | 
long FibonacciTermDynamic(long n) | returns n-th Fibonacci sequence term | O(n) | O(n) |
long FibonacciTermIterative(long n) | returns n-th Fibonacci sequence term | O(n) | O(1) | *de facto* an alias of FactorialIterative


## TODO:
- [ ] extract the algorithms into separate files.
- [ ] translate the readme into Polish
- [ ] write unit tests

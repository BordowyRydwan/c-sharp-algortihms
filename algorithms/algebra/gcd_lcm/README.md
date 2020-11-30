# Euclidean formula algorithms

Shortcuts:
- GCD - Greatest Common Divisor - it's counted using the identity: `GCD(a, b) = GCD(a, b % a)` - assuming `b > a`
- LCM - Least Common Multiplier - simply: `max(a, b) * GCD(a, b)`

## Methods inside:
Declaration | Type of result | Time complexity | Memory stack size | Notes
------------|----------------|-----------------|-------------------|------
int GCDRecursive(int a, int b) | returns GCD(a, b) | O(n) | O(1) | 
int GCDIterative(int a, int b) | returns GCD(a, b) | O(n) | O(1) |
int GCD(int a, int b) | returns GCD(a, b) | O(n) | O(1) | *de facto* an alias of GCDIterative
int LCM(int a, int b) | returns GCD(a, b) | O(n) | O(1) | uses GCD(a, b)


## TODO:
- [ ] extract the algorithms into separate files.
- [ ] translate the readme into Polish

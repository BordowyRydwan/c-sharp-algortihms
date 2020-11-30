# Index sum

It's a solution for problem stated like this:

Definition of relation is a pair (time_start, time_end). Two relations are separated on the schedule if for two relations R1(a_start, a_end) and R2(b_start, b_end) the expression "b_start >= a_end && a_start >= b_end" is true.

Your task is to make a schedule with as many relations as possible from the given set of relations.

## Methods inside:
Declaration | Type of result | Time complexity | Memory stack size | Notes
------------|----------------|-----------------|-------------------|------
Schedule.ClearNotSeparateActivities() | clearing the non-separated tasks | O(n^2) | O(n) | Schedule object is initialized by List< Range> 

## TODO:
- [ ] translate the readme into Polish
- [ ] write unit tests


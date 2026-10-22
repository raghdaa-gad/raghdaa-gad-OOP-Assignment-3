 ## task 2.1  IReadOnlyDictionary & SortedDictionary

1. What is each one?

-IReadOnlyDictionary<TKey, TValue> is an interface that provides read-only acess to key-value pairs

-SortedDictionary<TKey, TValue> is a class that stores key-value pairs with keys sortrd automatically

2. How is IReadOnlyDictionary different from Dictionary, and why would a public method return it?

-Dictionary<TKey, TValue> is a class that allows adding ,removing and update entries 
but IReadOnlyDictionary<TKey, TValue> provides read operations without exposing these modification methods

A public method may return IReadOnlyDictionary to limit the operations available to callers


3. How is SortedDictionary different from Dictionary in ordering and lookup speed?

-Dictionary<TKey, TValue> uses a hash table and provides average O(1) lookup ,does nit sorted key order

-SortedDictionary<TKey, TValue> keeps keys sorted  and provides O(log n) lookup using a balanced search tree

4. When would you choose SortedDictionary?

I would choose SortedDictionary when i need to keeps keys sorted while adding ,removing and looking up entries
If i mainly need fast lookup and do not need sorted key i would choose  Dictionary


----
## Task 2.2 — Pick the Collection


S1 - Dictionary

Use Dictionary because it provides fast average lookup by national ID

S2 - HashSet

Use HashSet because it prevents duplicate tags

S3 - List

Use List because it preserves the order in which grades were entered and allows duplicate grades

S4 - IReadOnlyDictionary

Use IReadOnlyDictionary because callers can read course prices without having add or update methods through the returned interface

S5 - SortedDictionary

Use SortedDictionary because it keeps sessions sorted by their start-time keys

S6 - IEnumerable

Use IEnumerable because it allows the caller to iterate over results and stop early without requiring all results to be created at once
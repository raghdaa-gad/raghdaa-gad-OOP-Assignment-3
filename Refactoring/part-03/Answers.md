# Part 03 — answers

---

## BlockedUsers
 
- Time complexity before: O(n * m)because List.Contains() searches linearly for each request.
- Time (ms) before: 129 ms
- What did you change? Replaced the repeated list searches with a HashSet<> for faster lookups.
- Time complexity after: O(n + m) on average.
- Time (ms) after: 6 ms

The found count remained 5000 The execution time decreased from 129 ms to 6 ms

---

## Students

- What was the problem? GetAllStudents() created one million students and stored them in a list, even though the program printed only the first three.
- What did you change? Changed the method to return IEnumerable<> and use yield return , so students are created only when requested. The program stops after the first three students.
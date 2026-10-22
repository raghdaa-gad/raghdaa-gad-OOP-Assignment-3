## What is the same in both stores? What is different?

- Both classes have the same structure and methods: Add, GetById, GetAll and Remove

- The main difference is the type of data they store. StudentStore stores Student objects in a List<Student>, while CourseStore stores Course  objects in a List<Course> Their method implementations are almost identical, except for the object type and the list name


### Step 3 — Why doesn't GetById compile in Store<T>?

- The compiler error occurs because T can represent any type, so the compiler cannot assume that every type has an Id property and T might be a non-nullable value type, so the compiler cannot assume that null can be returned


### Step 7 — Why must Store<string> fail to compile?

- Store<T> has the constraint where T : class, IHasId The string type is a reference type, but it does not implement IHasId Therefore Store<string> violates the generic constraint and fails to compile

Store<Student> studentStore = new();

studentStore.Add(new Student { Id = 1, Name = "Ahmed" });
studentStore.Add(new Student { Id = 2, Name = "Mona" });
studentStore.Add(new Student { Id = 3, Name = "Omar" });
studentStore.Add(new Student { Id = 4, Name = "Sara" });
studentStore.Add(new Student { Id = 5, Name = "Ali" });

Store<Course> courseStore = new();

courseStore.Add(new Course { Id = 101, Title = "C#", Price = 1500m });
courseStore.Add(new Course { Id = 102, Title = "SQL", Price = 1200m });
courseStore.Add(new Course { Id = 103, Title = "OOP", Price = 1800m });

// Get one student and one course
Console.WriteLine($"Student: {studentStore.GetById(2)?.Name}");
Console.WriteLine($"Course: {courseStore.GetById(102)?.Title}");

// Test duplicate student ID
try
{
    studentStore.Add(new Student { Id = 2, Name = "Another Student" });
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Duplicate ID: {ex.Message}");
}

// Print page 2 with 2 students per page
Console.WriteLine("Page 2:");
foreach (Student student in studentStore.GetAll().Page(2, 2))
{
    Console.WriteLine(student.Name);
}

// Find a course in a regular List<Course>
List<Course> courses =
[
    new Course { Id = 201, Title = "Algorithms", Price = 2000m },
    new Course { Id = 202, Title = "Databases", Price = 1700m },
    new Course { Id = 203, Title = "Networks", Price = 1600m }
];

Course? foundCourse = courses.FindById(202);
Console.WriteLine($"Found course: {foundCourse?.Title}");

// This must NOT compile:
// Store<string> stringStore = new();

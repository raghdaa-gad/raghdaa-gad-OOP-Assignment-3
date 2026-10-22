# Part 02 — answers

---

## Reports

- What was the problem?

The three exporters had duplicated code for loading, validating, and saving reports.

- What did you change?

Created an abstract ReportExporter class to handle the shared steps, while each exporter implements its own Format() method.

- Why did you choose that approach?

The abstract class lets us write the shared workflow once and keep the code organized using the Template Method pattern.
---

## Enrollment

- What problem does the Facade solve here?

The Program.cs was creating and calling four services directly, making the enrollment process harder to manage.

- What did you change?

Created an EnrollmentFacade that handles the enrollment steps in the correct order. The Program.cs now calls only one method, Enroll().

- What does the caller no longer need to know?

The caller no longer needs to know about the four services or the order of the enrollment steps.
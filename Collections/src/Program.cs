
Console.WriteLine("=== Egyptian Phone Validation ===");

Console.WriteLine($"Valid phone: {"01012345678".IsValidEgyptianPhone()}");
Console.WriteLine($"Valid international phone: {"+201012345678".IsValidEgyptianPhone()}");
Console.WriteLine($"Invalid prefix: {"01612345678".IsValidEgyptianPhone()}");
Console.WriteLine($"Invalid length: {"010123".IsValidEgyptianPhone()}");
Console.WriteLine($"Empty phone: {"".IsValidEgyptianPhone()}");

Console.WriteLine();

Console.WriteLine("=== Egyptian National ID Validation ===");

Console.WriteLine($"Valid ID starting with 2: {"29912345678901".IsValidEgyptianNationalId()}");
Console.WriteLine($"Valid ID starting with 3: {"39912345678901".IsValidEgyptianNationalId()}");
Console.WriteLine($"Invalid first digit: {"19912345678901".IsValidEgyptianNationalId()}");
Console.WriteLine($"Invalid length: {"29912345".IsValidEgyptianNationalId()}");
Console.WriteLine($"Empty ID: {"".IsValidEgyptianNationalId()}");

/*=== Egyptian Phone Validation ===
Valid phone: True
Valid international phone: True
Invalid prefix: False
Invalid length: False
Empty phone: False

=== Egyptian National ID Validation ===
Valid ID starting with 2: True
Valid ID starting with 3: True
Invalid first digit: False
Invalid length: False
Empty ID: False*/
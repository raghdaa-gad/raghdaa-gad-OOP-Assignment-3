
using System.Text.RegularExpressions;

public static class StringValidationExtensions
{
    public static bool IsValidEgyptianPhone(this string phone)
    {
        return Regex.IsMatch(
            phone ?? "",
            @"\A(?:01[0125][0-9]{8}|\+201[0125][0-9]{8})\z"
        );
    }

    public static bool IsValidEgyptianNationalId(this string nationalId)
    {
        return Regex.IsMatch(
            nationalId ?? "",
            @"\A[23][0-9]{13}\z"
        );
    }
}

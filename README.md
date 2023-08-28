# PhoneNumberLib

That library makes it easier to work with phone numbers.
.NET Framework 4.8

### Usage example
```C#
    var input = Console.ReadLine(); // +7(900)123-45-67
    var number = new PhoneNumber(input);
    Console.WriteLine(number.cnumber); // +79001234567
```

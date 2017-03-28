# FizzBuzz-C#
#### Technologies: C#, NUnit

* [Setting up the application](#setup)
* [NUnit Tests](#tests)
* [C# Code](#code)

## The Challenge ##
The challenge was to make a simple “FizzBuzz” program that accepted one integer value into a function called fizzBuzz. The function checks for the following conditions: if the integer is divisible by 3 it returns ‘Fizz’, if the integer is divisible by 5 it returns ‘Buzz’, if the integer is divisible by 3 and 5 it returns ‘FizzBuzz’ and if none of the conditions are met it returns the integer. Example below
```shell
1 --> 1
2 --> 2
3 --> Fizz
4 --> 4
5 --> Buzz
6 --> Fizz
7 --> 7
8 --> 8
9 --> Fizz
10 --> Buzz
11 --> 11
12 --> Fizz
13 --> 13
14 --> 14
15 --> FizzBuzz
16 --> 16
17 --> 17
18 --> Fizz
19 --> 19
20 --> Buzz
```

## <a name="setup">Setting up the applicaion</a>
```
$ git clone https://github.com/adrianeyre/fizzbuzz-CSharp
$ cd fizzbuzz-CSharp
```

## <a name="tests">NUnit Tests</a> ##

```csharp
namespace Work
{
    [TestFixture]
    class FizzBuzzTest
    {
        [TestCase]
        public void FizzBuzz()
        {
            Kata test = new Kata();
            Assert.AreEqual("fizz", test.FizzBuzz(3));
            Assert.AreEqual("buzz", test.FizzBuzz(5));
            Assert.AreEqual("fizzbuzz", test.FizzBuzz(15));
            Assert.AreEqual("1", test.FizzBuzz(1));
            Assert.AreEqual("2", test.FizzBuzz(2));
        }
    }
}
```

## <a name="code">C# Code</a> ##
```csharp
namespace Work
{
    public class Kata
    {
        public string FizzBuzz(int num)
        {
            string result = "";
            if (num % 3 == 0) result += "fizz";
            if (num % 5 == 0) result += "buzz";
            if (result == "") return num.ToString(); else return result;
        }
    }
}
```

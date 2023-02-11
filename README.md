# FunctionalCSharp

FunctionalCSharp is a library that makes it easier to write functional-oriented code in C#. It provides functional programming constructs such as partial application, pipe operator, and functional composition. So, give it a try and take your C# coding to the next level!

## Working with FunctionalCSharp: An Overview
### Fp

The _Fp_ static class contains most of functional programming constructs of the library. Most of the methods are the extension methods of generic types or delegates.

#### Into

The _Into_ extension method can be used to implement a functional-style pipeline, similar to the F# pipe operator. The method takes in an input value and returns an output value, allowing you to chain multiple method calls together in a fluent, readable manner.

Here's an example of how you might use the "Into" method to implement a simple calculation:

```csharp
int result = 5.Into(x => x + 2)
              .Into(x => x * 3)
              .Into(x => x - 1);
```
The value 5 is passed through a pipeline of delegates (add 2, multiply by 3, subtract 1) to get the final result of 20.

#### Into1

The _Into1_ extension method is similar to the _Into_ method, with the main difference being how the input value is passed to the first argument of the delegate.

```csharp
int result = 5.Into1((x, y) => x + y, 2)
              .Into1((x, y) => x * y, 3)
              .Into1((x, y) => x - y, 1);
```

The value 5 is passed through a pipeline of delegates but as the first _x_ argument (add 2, multiply by 3, subtract 1) to get the final result of 20.

#### Compose

The _Compose_ extension method provides functionality for functional composition. The method allows you to combine multiple delegates into a single delegate, in a way that the output of one delegate becomes the input of the next delegate.

Here's an example of how you might use the "Compose" method to implement a simple calculation:

```csharp
Func<int, int> add2 = x => x + 2;
Func<int, int> multiplyBy3 = x => x * 3;
Func<int, int> subtract1 = x => x - 1;

var composed = add2.Compose(multiplyBy3).Compose(subtract1);

int result = composed(5);
```

In this example, the add2, multiplyBy3, and subtract1 delegates are combined into a single delegate using the Compose method. The composed delegate takes an input of 5, adds 2 to it, multiplies the result by 3, and finally subtracts 1 to get a final result of 20.

#### ComposeBack

The _ComposeBack_ extension method is similar to the _Compose_ method, with the main difference being that delegates are composed backwards.

```csharp
Func<int, int> add2 = x => x + 2;
Func<int, int> multiplyBy3 = x => x * 3;
Func<int, int> subtract1 = x => x - 1;

var composedBack = subtract1.ComposeBack(multiplyBy3).ComposeBack(add2);

int result = composedBack(5);
```

#### Partly

The _Partly_ extension method provides functionality for partial application.

```csharp
Func<int, int, int> add = (x, y) => x + y;

var partly = add.Partly(2);

Func<int, int> addTwo = partly;

int result = addTwo(3);
```

In this example, the add delegate takes two arguments and returns their sum. By using the Partly method and passing in the value 2, we create a new delegate addTwo that takes a single argument and adds 2 to it. When we call addTwo with an argument of 3, the result is 5.

#### Unit

The _Unit_ extension method for the _Fp_ class is similar to the _Unit.Create_ method, but it immediately invokes the provided delegate or expression when called. [See Unit.Create method](#create)

#### If

The _If_ method is an extension method that allows you to create expression-like if statements in a functional style.

```csharp
int input = 2;
int result = If(input > 3, 3)
                .Elif(input == 3, 2)
                .Else(1).Evaluate();

Console.WriteLine(result); //prints 1
```

When you omit the _Evaluate_ method call, the result of the If/Elif/Else method will be an object that represents the expression-like if statement. This object can be stored and executed later. 

### Unit

The _Unit_ class is a type that is used to represent an expression that has no value.

```csharp
Func<int, Unit> print = x => {
    Console.WriteLine(x);
    return Unit.Value;
};

int input = 5;
print(input);
```

In this example, the print delegate takes an int argument and writes it to the console. The return type of the delegate is Unit, indicating that the delegate doesn't return a result. The delegate is used to perform a side effect, in this case printing to the console, and the return value of Unit.Value is ignored.

#### Create

The _Create_ static method for the _Unit_ class is used to create a delegate that wraps a provided delegate or expression, and returns Unit.Value. This method is used to transform expressions and statements that don't return a result into expressions that return a Unit value, allowing them to be used in a functional programming context.

```csharp
Action<int> print = x => Console.WriteLine(x);
Func<int, Unit> printUnit = Unit.Create(print);

int input = 5;
printUnit(input);
```

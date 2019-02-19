# Phema.Random
C# Random wrapper for Microsoft DI

## Usage
```csharp
// register
services.AddPhemaRandom(); // .AddPhemaCryptoRandom()

// resolve
var random = provider.GetRequiredService<IRandom>();

// generate
var number = random.Next(); // .Next(10) .Next(10, 20) .NextBytes(100)
```

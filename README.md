# Phema.Random

C# Random wrapper for `Microsoft.Extensions.DependencyInjection`

## Usage

```csharp
// Add
services.AddRandom(); // .AddCryptoRandom()

// Get
var random = provider.GetRequiredService<IRandom>();

// Use
var number = random.Next(); // .Next(10) .Next(10, 20) .NextBytes(100)
```

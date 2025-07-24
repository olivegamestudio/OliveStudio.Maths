# OliveStudio.Maths

A C# mathematics library providing essential functions for game development and graphics programming.

## Installation

```bash
# Package manager
Install-Package OliveStudio.Maths

# .NET CLI
dotnet add package OliveStudio.Maths
```

## Core Functions

### Basic Math
```csharp
// Linear interpolation
float result = Maths.Lerp(0f, 100f, 0.5f); // 50f
double result = Maths.Lerp(0.0, 100.0, 0.5); // 50.0

// Distance between points
float distance = Maths.GetDistance(0f, 0f, 3f, 4f); // 5f

// Normalize vector
var (x, y) = Maths.Normalize(3f, 4f); // (0.6f, 0.8f)
```

### Angles and Vectors
```csharp
// Angle between points (in radians)
float angle = Maths.GetAngleBetweenPointsInRadians(0f, 0f, 1f, 1f);

// Convert angle to direction vector
var (x, y) = Maths.RadiansToVector(angle);

// Convert between degrees and radians
float radians = Maths.AsRadians(90f); // π/2
float degrees = Maths.AsDegrees(Math.PI); // 180f
```

## Easing Functions

```csharp
// Built-in easing functions
float t = 0.5f;
float linear = EasingFunctions.Linear(t);
float easeIn = EasingFunctions.EaseInQuad(t);
float easeOut = EasingFunctions.EaseOutQuad(t);
float easeInOut = EasingFunctions.EaseInOutQuad(t);

// Cubic, Quartic, and Quintic variants available
float cubic = EasingFunctions.EaseInCubic(t);
float quart = EasingFunctions.EaseOutQuart(t);
float quint = EasingFunctions.EaseInOutQuint(t);
```

## Advanced Interpolation

```csharp
// Basic interpolation
float lerp = Interpolate.Lerp(0f, 100f, 0.5f);

// Easing interpolation with custom function
EasingFunction easing = EasingFunctions.EaseInQuad;
float eased = Interpolate.EasingInterpolate(0f, 100f, 0.5f, easing);
```

## Random Number Generation

```csharp
// Standard randomizer
IRandomiser random = new Randomiser();
int value = random.GetRandom(1, 10); // Random between 1-10
int percent = random.GetRandom(); // Random 0-100
int asyncValue = await random.GetRandomAsync(); // Async random 0-100

// Stub randomizer for testing
IRandomiser stub = new StubRandomiser(42);
int fixed = stub.GetRandom(1, 10); // Always returns 42
```

## Usage Examples

### Animation System
```csharp
public void AnimatePosition(float progress)
{
    // Smooth eased animation
    float easedProgress = EasingFunctions.EaseInOutQuad(progress);
    float x = Interpolate.EasingInterpolate(startX, endX, easedProgress, EasingFunctions.EaseOutCubic);
    float y = Maths.Lerp(startY, endY, progress);
    
    SetPosition(x, y);
}
```

### Movement Controller
```csharp
public void MoveToTarget(Vector2 current, Vector2 target, float speed)
{
    float angle = Maths.GetAngleBetweenPointsInRadians(current.X, current.Y, target.X, target.Y);
    var direction = Maths.RadiansToVector(angle);
    
    var newPosition = new Vector2(
        current.X + direction.x * speed,
        current.Y + direction.y * speed);
}
```

### Procedural Generation
```csharp
public void GenerateLevel(IRandomiser random)
{
    int roomCount = random.GetRandom(5, 15);
    for (int i = 0; i < roomCount; i++)
    {
        int width = random.GetRandom(10, 50);
        int height = random.GetRandom(10, 50);
        CreateRoom(width, height);
    }
}
```

## Available Easing Functions

- **Linear**: `Linear(t)`
- **Quadratic**: `EaseInQuad`, `EaseOutQuad`, `EaseInOutQuad`
- **Cubic**: `EaseInCubic`, `EaseOutCubic`, `EaseInOutCubic`
- **Quartic**: `EaseInQuart`, `EaseOutQuart`, `EaseInOutQuart`
- **Quintic**: `EaseInQuint`, `EaseOutQuint`, `EaseInOutQuint`

## Key Interfaces

### EasingFunction Delegate
```csharp
public delegate float EasingFunction(float input);
```

### IRandomiser Interface
```csharp
public interface IRandomiser
{
    int GetRandom(int minValue, int maxValue);
    int GetRandom(); // Returns 0-100
    Task<int> GetRandomAsync(); // Async version
}
```

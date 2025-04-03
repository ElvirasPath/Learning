# Task Vehicle System

## Task Description

In this task, we will create a vehicle system where different types of transport inherit properties from a common parent class.

### Requirements

1. **Create a Base Class (Vehicle):**

   - Represents a general vehicle.
   - Contains:
     - The brand of the vehicle.
     - The current speed.
     - A method to move the vehicle.

2. **Create Two Child Classes:**

   - These classes inherit from the base class.
   - They implement their own methods in addition to the inherited ones.
   - Override the `move` method using `virtual` and `override`.

3. **Create an Interface:**

   - Used by both child classes.
   - Example functionality: charging a battery or filling air in tires.

4. **Overload a Method (SpeedUp):**
   - The method should behave differently based on the type of vehicle using it.

### Extra Challenge

- Create a new class `Boat`, which does not inherit from the main class.
- What properties does it need?
- Can it move without inheriting from the base class?
- Try the same with a `Train` or similar object.

## Pseudocode

```csharp
// Parent class
class Vehicle {
    string brand;
    int speed;

    virtual void move() {
        // Default movement logic
    }
}

// Child class 1
class Car : Vehicle {
    override void move() {
        // Custom movement for Car
    }
}

// Child class 2
class Bike : Vehicle {
    override void move() {
        // Custom movement for Bike
    }
}

// Interface
interface IVehicleService {
    void ChargeBattery();
    void FillTires();
}

// Overloaded method
void SpeedUp(int amount);
void SpeedUp(double factor);

// Boat class without inheritance
class Boat {
    string type;
    int speed;

    void move() {
        // Boat specific movement
    }
}
```

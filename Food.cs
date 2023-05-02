// namespace - conceptually similar to a module in JS
namespace FoodStuff
{

    // Enumeration
    // list of possible types of values
    // may be useful to think of this as a dropdown list.
    public enum FoodType
    {
        Pizza,
        Tacos,
        Sushi,
        Hotdish,
    }

    // note public - accessible outside of this file.
    // accessorLevel class ClassName
    public class Food

    {
        // accessorLevel dataType name = 
        public FoodType kind = FoodType.Tacos;
        public float remaining = 100f; // percent left
        protected float temperature = 45f;

        // constructor:
        // special thing attached to any new class. Named same as the class.
        // public Food(FoodType type)
        // {
        //     this.kind = type;
        // }
        // Food can do things.

        // method (function) belonging to this class. 
        // of course, it is public, so it can be called elsewhere
        // void is the return type.
        // AccessorLevel return-type Name
        public void Cook()
        {
            temperature += 10f;
        }

        public float GetTemp()
        {
            return temperature;
        }

    }

    public class Pizza : Food
    {
        // pizza class has everything Food class has, plus the below.
        public Pizza()
        {
            this.kind = FoodType.Pizza;
        }

        // overriding current function
        // example of polymorphism

        public new void Cook()
        {
            temperature += 50f;
        }
    }
}
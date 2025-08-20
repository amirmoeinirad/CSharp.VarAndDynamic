
// Amir Moeini Rad
// August 20, 2025
// Help from Grok

// Main Concept: 'var' and 'dynamic' keywords


namespace VarAndDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("'var' and 'dynamic' keywords in C#.NET.");
            Console.WriteLine("---------------------------------------\n");


            // (1) Using 'var'
            // Statically and implicitly typed as int at compile-time.
            var number = 42;
            Console.WriteLine($"var example: {number} (Type: {number.GetType()})\n");
            // This would cause a compile-time error because the type is fixed.
            // number = "text";


            // (2) Using 'dynamic'
            // Type dynamically resolved at runtime.
            dynamic value = 42;
            Console.WriteLine($"dynamic example: {value} (Type: {value.GetType()})");
            // No error, type changes at runtime.
            value = "Now a string";
            Console.WriteLine($"dynamic example: {value} (Type: {value.GetType()})");


            Console.WriteLine("\nDone.");
        }
    }
}
    

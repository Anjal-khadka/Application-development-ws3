using System;

class NullOperations
{
    public void PerformNullChecks()
    {
        // Step 1: Declare username and assign null
        string username = null;

        // Step 2: Use Ternary Operator to check null
        Console.WriteLine(username == null ? "Username is not available" : username);

        // Step 3: Null-Coalescing Operator (??)
        // If username is null, print fallback text
        Console.WriteLine(username ?? "Username is not available (Using ??)");

        // Step 4: Null-Coalescing Assignment Operator (??=)
        // Assign value only if username is null
        username ??= "Anjal";

        // Step 5: Print updated username
        Console.WriteLine("Updated Username: " + username);
    }
}
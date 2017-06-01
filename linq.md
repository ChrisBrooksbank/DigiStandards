# Linq

Ensure any LINQ querys can be resolved to SQL querys and dont need ( expensive ) in memory processing.

To check this can run SQL profiler. ( preferred )

Or can try using code such as.

```c#
using (MyDatabaseEntities context = new MyDatabaseEntities())
{
    context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
    // query the database using EF here.
}
```
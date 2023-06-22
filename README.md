# Demo.EntityFramework.ComplexQuery.FromSql
Use case FromSqlRaw

## What is FromSqlRow?

FromSqlRow is a entity framework method that allows a direct query execution, and convert into an object, like an ORM (Dapper).
  
## Use case

A scenario that we can use this method is with mysql, a strength of entity framework is your ability with dynamic queries, but with mysql data base isn't supported the concept of schemas, difficult to use.
So, in a case that we need to implement a query with multiple schemas is necessary an alternative solution, and FromSqlRow can be used.

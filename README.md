# What's new in C# 7.0

### _out_ variables
You can declare out values inline as arguments to the method where they are used.
### Tuples
You can create lightweight, unnamed types that contain multiple public fields. Compilers and IDE tools understand the semantics of these types.
### Discards
Discards are temporary, write-only variables used in assignments when you don't care about the value assigned. They are particularly useful when deconstructing tuples and user-defined types, as well as when calling methods with out parameters.
### Pattern matching
You can create branching logic based on arbitrary types and values of the members of those types.
### _ref_ locals and returns
Method arguments and local variables can be references to other storage.
### Local functions
You can nest functions inside other functions to limit their scope and visibility.
### More expression-bodied members
The list of members that can be authored using expressions has grown.
### _throw_ expressions
You can throw exceptions in code constructs that previously were not allowed because throw was a statement.
### Generalized async return types
Methods declared with the async modifier can return other types in addition to Task and Task<T>.
### Numeric literal syntax improvements
New tokens improve readability for numeric constants.

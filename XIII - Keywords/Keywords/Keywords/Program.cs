using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keywords
{
    class Program
    {
        // C SHARP KEYWORDS

        // Keywords are predefined, reserved identifiers that have special meanings to the compiler.
        // They cannot be used as identifiers in your program unless they include @ as a prefix.
        // For example, @if is a valid identifier, but if is not because if is a keyword.

        // The first table in this topic lists keywords that are reserved identifiers in any part of a C# program. 
        // The second table in this topic lists the contextual keywords in C#. Contextual keywords have special meaning only 
        // in a limited program context and can be used as identifiers outside that context. Generally, as new keywords are 
        // added to the C# language, they are added as contextual keywords in order to avoid breaking programs written in 
        // earlier versions.

        // { abstaract } //

        // The abstract modifier indicates that the thing being modified has a missing or incomplete implementation.The abstract
        // modifier can be used with classes, methods, properties, indexers, and events.Use the abstract modifier in a class 
        // declaration to indicate that a class is intended only to be a base class of other classes.Members marked as abstract, 
        // or included in an abstract class, must be implemented by classes that derive from the abstract class.

        // { as } //

        // You can use the as operator to perform certain types of conversions between compatible reference types or nullable types.

        // { base } //

        // The base keyword is used to access members of the base class from within a derived class:
        // Call a method on the base class that has been overridden by another method.
        // Specify which base-class constructor should be called when creating instances of the derived class.    
        // A base class access is permitted only in a constructor, an instance method, or an instance property accessor.
        // It is an error to use the base keyword from within a static method.
        // The base class that is accessed is the base class specified in the class declaration. For example, if you specify class
        // ClassB : ClassA, the members of ClassA are accessed from ClassB, regardless of the base class of ClassA.

        // { bool } //

        // The bool keyword is an alias of System.Boolean. It is used to declare variables to store the Boolean values, true and false.

        // { break } //

        // The break statement terminates the closest enclosing loop or switch statement in which it appears. Control is passed to the
        // statement that follows the terminated statement, if any.

        // { byte } //

        // byte denotes an integral type that stores values as indicated in the following table.

        // { case } //

        // switch is a selection statement that chooses a single switch section to execute from a list of candidates based on a pattern 
        // match with the match expression.

        // { catch } //

        // The try-catch statement consists of a try block followed by one or more catch clauses, which specify handlers for different 
        // exceptions.

        // { char } //

        // The char keyword is used to declare an instance of the System.Char structure that the .NET Framework uses to represent a 
        // Unicode character. The value of a Char object is a 16-bit numeric (ordinal) value.  Unicode characters are used to represent
        // most of the written languages throughout the world.

        // { checked } //

        // The checked keyword is used to explicitly enable overflow checking for integral-type arithmetic operations and conversions.
        // By default, an expression that contains only constant values causes a compiler error if the expression produces a value that
        // is outside the range of the destination type.  If the expression contains one or more non-constant values, the compiler does
        // not detect the overflow.

        // { class } //

        // Classes are declared using the keyword class.

        // { const } //

        // You use the const keyword to declare a constant field or a constant local.Constant fields and locals aren't variables and may
        // not be modified. Constants can be numbers, Boolean values, strings, or a null reference. Don’t create a constant to represent 
        // information that you expect to change at any time. For example, don’t use a constant field to store the price of a service,
        // a product version number, or the brand name of a company. These values can change over time, and because compilers propagate
        // constants, other code compiled with your libraries will have to be recompiled to see the changes.

        // { continue } //

        // The continue statement passes control to the next iteration of the enclosing while, do, for, or foreach statement in which 
        // it appears.

        // { decimal } //

        // The decimal keyword indicates a 128-bit data type. Compared to other floating-point types, the decimal type has more 
        //precision and a smaller range, which makes it appropriate for financial and monetary calculations.

        // { defuault } //

        // The default keyword can be used in the switch statement or in a default value expression: The switch statement: Specifies 
        // the default label.  Default value expressions: Produces the default value of a type.

        // { delegate } //

        // A delegate is a reference type that can be used to encapsulate a named or an anonymous method. Delegates are similar to 
        // function pointers in C++; however, delegates are type-safe and secure. For applications of delegates, see Delegates and
        // Generic Delegates.

        // { do } //

        // The do statement executes a statement or a block of statements while a specified boolean expression evaluates to true. 
        // Because that expression is evaluated after each execution of the loop, a do-while loop executes one or more times.This
        // differs from the while loop, which executes zero or more times.  At any point within the do statement block, you can break
        // out of the loop by using the break statement.  You can step directly to the evaluation of the while expression by using 
        // the continue statement.If the expression evaluates to true, execution continues at the first statement in the loop.Otherwise,
        // execution continues at the first statement after the loop.  You also can exit a do-while loop by the goto, return, or throw
        // statements.

        // { double } //

        // The double keyword signifies a simple type that stores 64-bit floating-point values. The following table shows the precision 
        // and approximate range for the double type.

        // { else } //

        // An if statement identifies which statement to run based on the value of a Boolean expression.In the following example, the 
        // Boolean variable result is set to true and then checked in the if statement.The output is The variable is set to true.

        // { enum } //

        // The enum keyword is used to declare an enumeration, a distinct type that consists of a set of named constants called the 
        // enumerator list.  Usually it is best to define an enum directly within a namespace so that all classes in the namespace can
        // access it with equal convenience.  However, an enum can also be nested within a class or struct.  By default, the first 
        // enumerator has the value 0, and the value of each successive enumerator is increased by 1. For example, in the following 
        // enumeration, Sat is 0, Sun is 1, Mon is 2, and so forth.

        // { event } //

        // The event keyword is used to declare an event in a publisher class.

        // { explicit } //

        // The explicit keyword declares a user-defined type conversion operator that must be invoked with a cast. 

        // { extern } //

        // The extern modifier is used to declare a method that is implemented externally.A common use of the extern modifier is with 
        // the DllImport attribute when you are using Interop services to call into unmanaged code.In this case, the method must also be 
        // declared as static.

        // { false } //

        // Used as an overloaded operator or as a literal: false Operator, false Literal

        // { finally } //

        // By using a finally block, you can clean up any resources that are allocated in a try block, and you can run code even if an 
        // exception occurs in the try block.  Typically, the statements of a finally block run when control leaves a try statement.The 
        // transfer of control can occur as a result of normal execution, of execution of a break, continue, goto, or return statement,
        // or of propagation of an exception out of the try statement.  Within a handled exception, the associated finally block is 
        // guaranteed to be run.However, if the exception is unhandled, execution of the finally block is dependent on how the exception 
        // unwind operation is triggered.That, in turn, is dependent on how your computer is set up.  Usually, when an unhandled 
        // exception ends an application, whether or not the finally block is run is not important. However, if you have statements in a 
        // finally block that must be run even in that situation, one solution is to add a catch block to the try-finally statement.
        // Alternatively, you can catch the exception that might be thrown in the try block of a try-finally statement higher up the 
        // call stack. That is, you can catch the exception in the method that calls the method that contains the try-finally statement,
        // or in the method that calls that method, or in any method in the call stack.If the exception is not caught, execution of the
        // finally block depends on whether the operating system chooses to trigger an exception unwind operation.

        // { fixed } //

        // The fixed statement prevents the garbage collector from relocating a movable variable.The fixed statement is only permitted in
        // an unsafe context. fixed can also be used to create fixed size buffers.  The fixed statement sets a pointer to a managed 
        // variable and "pins" that variable during the execution of the statement.  Pointers to movable managed variables are useful
        // only in a fixed context.  Without a fixed context, garbage collection could relocate the variables unpredictably.  The C#
        // compiler only lets you assign a pointer to a managed variable in a fixed statement.

        // { float } //

        // The float keyword signifies a simple type that stores 32-bit floating-point values. 

        // { for } //

        // The for statement executes a statement or a block of statements while a specified boolean expression evaluates to true.  
        // At any point within the for statement block, you can break out of the loop by using the break statement, or step to the
        // next iteration in the loop by using the continue statement.You also can exit a for loop by the goto, return, or throw 
        // statements.

        // { foreach } //

        // The foreach statement executes a statement or a block of statements for each element in an instance of the type that implements
        // the System.Collections.IEnumerable or System.Collections.Generic.IEnumerable<T> interface. The foreach statement is not limited 
        // to those types and can be applied to an instance of any type that satisfies the following conditions: has the public 
        // parameterless GetEnumerator method whose return type is either class, struct, or interface type, the return type of the 
        // GetEnumerator method has the public Current property and the public parameterless MoveNext method whose return type is Boolean.
        // At any point within the foreach statement block, you can break out of the loop by using the break statement, or step to the next
        // iteration in the loop by using the continue statement.  You also can exit a foreach loop by the goto, return, or throw statements.

        // { goto } //

        // The goto statement transfers the program control directly to a labeled statement.  A common use of goto is to transfer control to a 
        // specific switch-case label or the default label in a switch statement.The goto statement is also useful to get out of deeply nested 
        // loops.

        // { if } //

        // An if statement identifies which statement to run based on the value of a Boolean expression.

        // { implicit } //

        // The implicit keyword is used to declare an implicit user-defined type conversion operator. Use it to enable implicit conversions between
        // a user-defined type and another type, if the conversion is guaranteed not to cause a loss of data.

        // { in } //

        // The in keyword is used in four contexts: generic type parameters in generic interfaces and delegates.  As a parameter modifier, which 
        // lets you pass an argument to a method by reference rather than by value. foreach statements. join clauses in LINQ query expressions.

        // { int } //

        // int denotes an integral type that stores values according to the size and range.

        // { interface } //

        // An interface contains only the signatures of methods, properties, events or indexers.A class or struct that implements the interface 
        // must implement the members of the interface that are specified in the interface definition. In the following example, class 
        // ImplementationClass must implement a method named SampleMethod that has no parameters and returns void.

        // { internal } //

        // The internal keyword is an access modifier for types and type members.

        // { is } //

        // Checks if an object is compatible with a given type, or (starting with C# 7.0) tests an expression against a pattern.  The is keyword 
        // evaluates type compatibility at runtime. It determines whether an object instance or the result of an expression can be converted to a 
        // specified type. 

        // { lock } //

        // The lock keyword marks a statement block as a critical section by obtaining the mutual-exclusion lock for a given object, executing a 
        // statement, and then releasing the lock.

        // { long } //

        // long denotes an integral type that stores values according to the size and range.

        // { namespace } //

        // The namespace keyword is used to declare a scope that contains a set of related objects. You can use a namespace to organize code 
        // elements and to create globally unique types.

        // { new } //

        // In C#, the new keyword can be used as an operator, a modifier, or a constraint.  new Operator Used to create objects and invoke 
        //constructors.  new Modifier Used to hide an inherited member from a base class member.  new Constraint Used to restrict types that 
        // might be used as arguments for a type parameter in a generic declaration.

        // { null } //

        // The null keyword is a literal that represents a null reference, one that does not refer to any object. null is the default value 
        // of reference-type variables.  Ordinary value types cannot be null. However, C# 2.0 introduced nullable value types.

        // { object } //

        // The object type is an alias for Object in the.NET Framework.In the unified type system of C#, all types, predefined and user-defined,
        // reference types and value types, inherit directly or indirectly from Object. You can assign values of any type to variables of type 
        // object.  When a variable of a value type is converted to object, it is said to be boxed. When a variable of type object is converted
        // to a value type, it is said to be unboxed.

        // { operator } //

        // Use the operator keyword to overload a built-in operator or to provide a user-defined conversion in a class or struct declaration.

        // { out } //

        // You can use the out keyword in two contexts: As a parameter modifier, which lets you pass an argument to a method by reference rather
        // than by value.  In generic type parameter declarations for interfaces and delegates, which specifies that a type parameter is covariant.

        // { override } //

        // The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer,
        // or event.

        // { params } //

        // By using the params keyword, you can specify a method parameter that takes a variable number of arguments.  You can send a comma-separated
        // list of arguments of the type specified in the parameter declaration or an array of arguments of the specified type.You also can send no 
        // arguments.If you send no arguments, the length of the params list is zero.  No additional parameters are permitted after the params keyword
        // in a method declaration, and only one params keyword is permitted in a method declaration.  The declared type of the params parameter must 
        // be a single-dimensional array, as the following example shows. Otherwise, a 
        // compiler error CS0225 occurs.

        // { private } //

        // The private keyword is a member access modifier.  This page covers private access.The private keyword is also part of the private protected
        // access modifier.  Private access is the least permissive access level.Private members are accessible only within the body of the class or 
        // the struct in which they are declared

        // { protected } //

        // The protected keyword is a member access modifier.  This page covers protected access.The protected keyword is also part of the protected 
        // internal and private protected access modifiers.  A protected member is accessible within its class and by derived class instances.

        // { public } //

        // The public keyword is an access modifier for types and type members. Public access is the most permissive access level. There are no 
        // restrictions on accessing public members.

        // { readonly } //

        // The readonly keyword is a modifier that can be used in three contexts:  In a field declaration, readonly indicates that assignment to the
        // field can only occur as part of the declaration or in a constructor in the same class.  In a readonly struct definition, readonly indicates
        // that the struct is immutable.  In a ref readonly method return, the readonly modifier indicates that method returns a reference and writes 
        // are not allowed to that reference.  The final two contexts were added in C# 7.2.

        // { ref } //

        // The ref keyword indicates a value that is passed by reference.It is used in four different contexts: In a method signature and in a method 
        // call, to pass an argument to a method by reference.See Passing an argument by reference for more information.  In a method signature, to 
        // return a value to the caller by reference.See Reference return values for more information.  In a member body, to indicate that a reference
        // return value is stored locally as a reference that the caller intends to modify or, in general, a local variable accesses another value by 
        // reference. See Ref locals for more information.  In a struct declaration to declare a ref struct or a ref readonly struct.

        // { return } //

        // The return statement terminates execution of the method in which it appears and returns control to the calling method.It can also return an
        // optional value.  If the method is a void type, the return statement can be omitted.  If the return statement is inside a try block, the 
        // finally block, if one exists, will be executed before control returns to the calling method.

        // { sbyte } //

        // sbyte denotes an integral type that stores values according to the size and range.

        // { sealed } //

        // When applied to a class, the sealed modifier prevents other classes from inheriting from it. You can also use the sealed modifier on a method
        // or property that overrides a virtual method or property in a base class. This enables you to allow classes to derive from your class and 
        // prevent them from overriding specific virtual methods or properties.

        // { short } //

        // short denotes an integral data type that stores values according to the size and range.

        // { sizeof } //

        // Used to obtain the size in bytes for an unmanaged type.Unmanaged types include the built-in types that are listed in the table that follows, 
        // and also the following: Enum types Pointer types User-defined structs that do not contain any fields or properties that are reference types.

        // { stackalloc } //

        // The stackalloc keyword is used in an unsafe code context to allocate a block of memory on the stack.

        // { static } //

        // Use the static modifier to declare a static member, which belongs to the type itself rather than to a specific object. The static modifier 
        // can be used with classes, fields, methods, properties, operators, events, and constructors, but it cannot be used with indexers, finalizers,
        // or types other than classes.

        // { string } //

        // The string type represents a sequence of zero or more Unicode characters. string is an alias for String in .NET.  Although string is a 
        // reference type, the equality operators (== and !=) are defined to compare the values of string objects, not references.This makes testing
        // for string equality more intuitive.

        // { struct } //

        // A struct type is a value type that is typically used to encapsulate small groups of related variables, such as the coordinates of a rectangle
        // or the characteristics of an item in an inventory.

        // { switch } //

        // switch is a selection statement that chooses a single switch section to execute from a list of candidates based on a pattern match with the 
        // match expression.

        // { this } //

        // The this keyword refers to the current instance of the class and is also used as a modifier of the first parameter of an extension method.

        // { throw } //

        // Signals the occurrence of an exception during program execution.

        // { true } //

        // Used as an overloaded operator or as a literal: true Operator and true Literal

        // { try } //

        // The try-catch statement consists of a try block followed by one or more catch clauses, which specify handlers for different exceptions.  
        // When an exception is thrown, the common language runtime (CLR) looks for the catch statement that handles this exception. If the currently
        // executing method does not contain such a catch block, the CLR looks at the method that called the current method, and so on up the call 
        // stack. If no catch block is found, then the CLR displays an unhandled exception message to the user and stops execution of the program.  
        // The try block contains the guarded code that may cause the exception.The block is executed until an exception is thrown or it is completed
        // successfully. 

        // { typeof } //

        // Used to obtain the System.Type object for a type.  To obtain the run-time type of an expression, you can use the .NET Framework method #
        // GetType.

        // { uint } //

        // The uint keyword signifies an integral type that stores values according to the size and range.

        // { ulong } //

        // The ulong keyword denotes an integral type that stores values according to the size and range.

        // { unchecked } //

        // The unchecked keyword is used to suppress overflow-checking for integral-type arithmetic operations and conversions.  In an unchecked 
        // context, if an expression produces a value that is outside the range of the destination type, the overflow is not flagged.

        // { unsafe } //

        // The unsafe keyword denotes an unsafe context, which is required for any operation involving pointers.For more information, see Unsafe Code
        // and Pointers.  You can use the unsafe modifier in the declaration of a type or a member.The entire textual extent of the type or member is
        // therefore considered an unsafe context.

        // { ushort } //

        // The ushort keyword indicates an integral data type that stores values according to the size and range.

        // { using } //

        // The using keyword has two major uses: As a directive, when it is used to create an alias for a namespace or to import types defined in other
        // namespaces.See using Directive.  As a statement, when it defines a scope at the end of which an object will be disposed.See using Statement.
        // In addition, the using static directive lets you define a type whose static members you can access without specifying a type name.

        // { using static } //

        // The using static directive designates a type whose static members and nested types you can access without specifying a type name.  where 
        // fully-qualified-type-name is the name of the type whose static members and nested types can be referenced without specifying a type name.
        // If you do not provide a fully qualified type name (the full namespace name along with the type name), C# generates compiler error CS0246:
        // "The type or namespace name 'type/namespace' could not be found (are you missing a using directive or an assembly reference?)".  The using
        // static directive applies to any type that has static members(or nested types), even if it also has instance members.However, instance members
        // can only be invoked through the type instance.The using static directive was introduced in C# 6.

        // { virtual } //

        // The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class.
        // The implementation of a virtual member can be changed by an overriding member in a derived class. 

        // { void } //

        // When used as the return type for a method, void specifies that the method doesn't return a value.  void isn't allowed in the parameter list of#
        // a method.  void is also used in an unsafe context to declare a pointer to an unknown type.  void is an alias for the .NET Framework System.Void
        // type.

        // { volitile } //

        // The volatile keyword indicates that a field might be modified by multiple threads that are executing at the same time.Fields that are declared
        // volatile are not subject to compiler optimizations that assume access by a single thread.These restrictions ensure that all threads will observe
        // volatile writes performed by anyother thread in the order in which they were performed.There is no guarantee of a single total ordering of 
        // volatile writes as seen from all threads of execution.The volatile modifier is usually used for a field that is accessed by multiple threads
        // without using the lock statement to serialize access.  The volatile keyword can be applied to fields of these types: Reference types.  
        // Pointer types (in an unsafe context). Note that although the pointer itself can be volatile, the object that it points to cannot.  In other
        // words, you cannot declare a "pointer to volatile.".  Types such as sbyte, byte, short, ushort, int, uint, char, float, and bool.An enum type
        // with one of the following base types: byte, sbyte, short, ushort, int, or uint.  Generic type parameters known to be reference types.  
        // IntPtr and UIntPtr.  The volatile keyword can onlybe applied to fields of a class or struct. Local variables cannot be declared volatile.

        // { while } //

        // The while statement executes a statement or a block of statements while a specified boolean expression evaluates to true. Because that expression
        // is evaluated before each execution of the loop, a while loop executes zero or more times.This differs from the do loop, which executes one or more
        // times.  At any point within the while statement block, you can break out of the loop by using the break statement.  You can step directly to the 
        // evaluation of the while expression by using the continuestatement.If the expression evaluates to true, execution continues at the first statement
        // in the loop.Otherwise, execution continues at the first statement after the loop.  You also can exit a while loop by the goto, return, or throw 
        // statements.

        // CONTEXTUAL KEYWORDS

        // { add } //

        // The add contextual keyword is used to define a custom event accessor that is invoked when client code subscribes to your event. If you supply a
        // custom add accessor, you must also supply a remove accessor.

        // { alias } //

        // You might have to reference two versions of assemblies that have the same fully-qualified type names. For example, you might have to use two or 
        // more versions of an assembly in the same application. By using an external assembly alias, the namespaces from each assembly can be wrapped inside
        // root-level namespaces named by the alias, which enables them to be used in the same file.

        // { ascending } //

        // The ascending contextual keyword is used in the orderby clause in query expressions to specify that the sort order is from smallest to largest.
        // Because ascending is the default sort order, you do not have to specify it.

        // { async } //

        // Use the async modifier to specify that a method, lambda expression, or anonymous method is asynchronous.If you use this modifier on a method or
        // expression, it's referred to as an async method.

        // { await } //

        // The await operator is applied to a task in an asynchronous method to insert a suspension point in the execution of the method until the awaited
        // task completes.The task represents ongoing work.  await can only be used in an asynchronous method modified by the async keyword. Such a method,
        // defined by using the async modifier and usually containing one or more await expressions, is referred to as an async method.

        // { descending } //

        // The descending contextual keyword is used in the orderby clause in query expressions to specify that the sort order is from largest to smallest.

        // { dynamic } //

        // The dynamic type enables the operations in which it occurs to bypass compile-time type checking.Instead, these operations are resolved at run 
        // time.The dynamic type simplifies access to COM APIs such as the Office Automation APIs, and also to dynamic APIs such as IronPython libraries,
        // and to the HTML Document Object Model(DOM).  Type dynamic behaves like type object in most circumstances.However, operations that contain
        // expressions of type dynamic are not resolved or type checked by the compiler.  The compiler packages together information about the operation,
        // and that information is later used to evaluate the operation at run time.As part of the process, variables of type dynamic are compiled into 
        // variables of type object. Therefore, type dynamic exists only at compile time, not at run time.

        // { from } //

        // A query expression must begin with a from clause.Additionally, a query expression can contain sub-queries, which also begin with a from clause.
        // The from clause specifies the following:  The data source on which the query or sub-query will be run.  A local range variable that represents
        // each element in the source sequence. Both the range variable and the data source are strongly typed.The data source referenced in the from clause
        // must have a type of IEnumerable, IEnumerable<T>, or a derived type such as IQueryable<T>.

        // { get } //

        // The get keyword defines an accessor method in a property or indexer that returns the property value or the indexer element.For more information,
        // see Properties, Auto-Implemented Properties and Indexers.

        // { global } //

        // The global contextual keyword, when it comes before the :: operator, refers to the global namespace, which is the default namespace for any C# 
        // program and is otherwise unnamed. 

        // { group } //

        // The group clause returns a sequence of IGrouping<TKey, TElement> objects that contain zero or more items that match the key value for the group.
        // For example, you can group a sequence of strings according to the first letter in each string. In this case, the first letter is the key and has
        // a type char, and is stored in the Key property of each IGrouping<TKey, TElement> object. The compiler infers the type of the key.  You can end a
        // query expression with a group clause,

        // { into } //

        // The into contextual keyword can be used to create a temporary identifier to store the results of a group, join or select clause into a new 
        // identifier.This identifier can itself be a generator for additional query commands.When used in a group or select clause, the use of the new
        // identifier is sometimes referred to as a continuation.

        // { join } //

        // The join clause is useful for associating elements from different source sequences that have no direct relationship in the object model.The 
        // only requirement is that the elements in each source share some value that can be compared for equality.For example, a food distributor might
        // have a list of suppliers of a certain product, and a list of buyers.A join clause can be used, for example, to create a list of the suppliers
        // and buyers of that product who are all in the same specified region.  A join clause takes two source sequences as input.The elements in each 
        // sequence must either be or contain a property that can be compared to a corresponding property in the other sequence.The join clause compares
        // the specified keys for equality by using the special equals keyword.  All joins performed by the join clause are equijoins.The shape of the 
        // output of a join clause depends on the specific type of join you are performing.  The following are three most common join types: Inner join,
        // Group join and Left outer join.

        // { let } //

        // In a query expression, it is sometimes useful to store the result of a sub-expression in order to use it in subsequent clauses.You can do this
        // with the let keyword, which creates a new range variable and initializes it with the result of the expression you supply.Once initialized with
        // a value, the range variable cannot be used to store another value.However, if the range variable holds a queryable type, it can be queried.

        // { nameof } //

        // Used to obtain the simple(unqualified) string name of a variable, type, or member.  When reporting errors in code, hooking up 
        // model-view-controller (MVC) links, firing property changed events, etc., you often want to capture the string name of a method.  Using nameof
        // helps keep your code valid when renaming definitions. Before, you had to use string literals to refer to definitions, which is brittle when
        // renaming code elements because tools do not know to check these string literals.

        // { orderby } //

        // In a query expression, the orderby clause causes the returned sequence or subsequence(group) to be sorted in either ascending or descending
        // order.  Multiple keys can be specified in order to perform one or more secondary sort operations.The sorting is performed by the default 
        // comparer for the type of the element.The default sort order is ascending.You can also specify a custom comparer.However, it is only available
        // by using method-based syntax.

        // { partial (type) } //

        // Partial type definitions allow for the definition of a class, struct, or interface to be split into multiple files.

        // { parial (method) } //

        // A partial method has its signature defined in one part of a partial type, and its implementation defined in another part of the type. Partial
        // methods enable class designers to provide method hooks, similar to event handlers, that developers may decide to implement or not. If the 
        // developer does not supply an implementation, the compiler removes the signature at compile time. The following conditions apply to partial
        // methods: Signatures in both parts of the partial type must match.  The method must return void.  No access modifiers are allowed.Partial methods
        // are implicitly private.

        // { remove } //

        // The remove contextual keyword is used to define a custom event accessor that is invoked when client code unsubscribes from your event. If
        // you supply a custom remove accessor, you must also supply an add accessor.

        // { select } //

        // In a query expression, the select clause specifies the type of values that will be produced when the query is executed. The result is 
        // based on the evaluation of all the previous clauses and on any expressions in the select clause itself. A query expression must terminate
        // with either a select clause or a group clause.

        // { set } //

        // The set keyword defines an accessor method in a property or indexer that assigns a value to the property or the indexer element. For more
        // information and examples, see Properties, Auto-Implemented Properties, and Indexers.

        // { value } //

        // The contextual keyword value is used in the set accessor in ordinary property declarations. It is similar to an input parameter on a method.
        // The word value references the value that client code is attempting to assign to the property. In the following example, MyDerivedClass has a
        // property called Name that uses the value parameter to assign a new string to the backing field name. From the point of view of client code,
        // the operation is written as a simple assignment.

        // { var } //

        // Beginning in Visual C# 3.0, variables that are declared at method scope can have an implicit "type" var. An implicitly typed local variable
        // is strongly typed just as if you had declared the type yourself, but the compiler determines the type. 

        // { when (filter condition) } //

        // You can use the when contextual keyword to specify a filter condition in two contexts: In the catch statement of a try/catch or 
        // try/catch/finally block.In the case label of a switch statement.

        // { where (generic type constraint) } //

        // The where clause in a generic definition specifies constraints on the types that are used as arguments for type parameters in a generic
        // type, method, delegate, or local function. Constraints can specify interfaces, base classes, or require a generic type to be a reference,
        // value or unmanaged type. They declare capabilities that the type argument must possess.

        // { where (query clause) } //

        // The where clause is used in a query expression to specify which elements from the data source will be returned in the query expression. 
        // It applies a Boolean condition (predicate) to each source element (referenced by the range variable) and returns those for which the 
        // specified condition is true.  A single query expression may contain multiple where clauses and a single clause may contain multiple 
        // predicate subexpressions.

        // { yield } //

        // When you use the yield keyword in a statement, you indicate that the method, operator, or get accessor in which it appears is an iterator.
        // Using yield to define an iterator removes the need for an explicit extra class (the class that holds the state for an enumeration, see 
        // IEnumerator<T> for an example) when you implement the IEnumerable and IEnumerator pattern for a custom collection type.

    }
}

# Overview

The Interpreter Design Pattern is a behavioral design pattern that is used to interpret and evaluate a grammar language or expression. 
It provides a mechanism to evaluate sentences in a language by representing their grammar as a set of classes. 
Each class corresponds to a specific rule or part of the language’s grammar, and these classes can be organized hierarchically to handle more complex expressions.

In my assignment-1, the interpreter design pattern is demonstrated through the implementation of a simple calculator capable of performing four basic mathematical operations:
Addition, Subtraction, Multiplication, Division.

# Design

**Components of the Interpreter Design Pattern Implemented:**
1) Expression Interface
2) Terminal Expressions: NumberExpression
3) Non-Terminal Expressions: AddExpression, SubtractExpression, MultiplyExpression, DivideExpression

The Expression Interface provides a common method Interpret() that all concrete expression classes implement.
NumberExpression is used for representing numbers.
AddExpression, SubtractExpression, MultiplyExpression, and DivideExpression represent operations that manipulate instances of Expression to compute results.



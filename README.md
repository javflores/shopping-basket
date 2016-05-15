# Shopping Basket

Customer basket that allows a customer to add products and provides a total cost of the basket including applicable discounts.

### Available products:

| Product | Cost  |
| --------|------:|
| Butter  | £0.80 |
| Milk    | £1.15 |
| Bread   | £1.00 |


### Offers:

- Buy 2 Butter and get a Bread at 50% off

- Buy 3 Milk and get the 4th milk for free

### Scenarios:

```
Given the basket has 1 bread, 1 butter and 1 milk 
When I total the basket 
Then the total should be £2.95

Given the basket has 2 butter and 2 bread 
When I total the basket 
Then the total should be £3.10

Given the basket has 4 milk 
When I total the basket 
Then the total should be £3.45

Given the basket has 2 butter, 1 bread and 8 milk 
When I total the basket 
Then the total should be £9.00

## Object Calisthenics 

I have followed [Object Calisthenics](http://javflores.github.io/object-calisthenics/) to solve this problem. 
Object Calisthenics are programming exercises, formalized as a set of 9 rules invented by Jeff Bay in his book The ThoughWorks Anthology. 
These rules focus on maintainability, readability, testability, and comprehensibility of your code. These are the rules:

1. Only One Level Of Indentation Per Method
2. Don’t Use The ELSE Keyword
3. Wrap All Primitives And Strings
4. First Class Collections
5. One Dot Per Line
6. Don’t Abbreviate
7. Keep All Entities Small
8. No Classes With More Than Two Instance Variables
9. No Getters/Setters/Properties

Enforcing these rules has led to interesting design concepts.

## Technology

- In order to use the value of double-loop TDD, I have created Acceptance tests that run the provided scenarios. I have used Specflow.

- I have created a Console application so that I can test the hypothesis and run the logic in the context of a real system.

- I have used the latest version of C# and VS2015. For UnitTesting in this case I have used XUnit and NSubstitute for mocking as I wanted simplicity to solve this programming problem.

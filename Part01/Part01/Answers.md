# Why Are 20-Parameter Constructors a Problem?

A constructor with around 20 parameters is difficult to use because it is hard to remember the correct order of all the values.

When creating an object, it may also be unclear what each value represents, especially when many parameters have the same type such as `string` or `decimal`.

This makes the code harder to read and increases the chance of passing values in the wrong order.

It is also inconvenient to provide around 20 values every time an object is created, especially when some of them may be optional.

Adding another property later would also make the constructor even longer and harder to maintain.

## Is this purely a "constructor is too long" problem, or is there a deeper design issue with putting ~20 loosely related properties on a single class in the first place?

The problem is not only that the constructor is too long.

The class also contains many loosely related pieces of data, such as customer information, billing address, shipping address, and order/payment information.

Some of these values are required when creating the object, while others may be optional.

Putting all of them into one large constructor makes the class harder to understand, use, and maintain.

# Why Is the Composed Builder Better?

The composed builder is better because:

- **Single Responsibility:** Each builder is responsible for its own data.
- **Reuse:** `AddressBuilder` can be reused for both billing and shipping addresses.
- **Independent Validation:** Each builder can handle its own validation separately if needed.
- **Readability:** The code becomes easier to read and understand.
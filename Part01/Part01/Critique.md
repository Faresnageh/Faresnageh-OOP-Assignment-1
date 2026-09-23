# Critique of the Procedural C++ Order System

## Global Mutable Data

The program stores customers, products, orders, and counters in global variables

Many functions can read or change the same data

This makes the program harder to control and harder to maintain


## No Real Objects

The program does not use classes for Customer, Product, Order, or OrderLine

The data and the functions are separated

For example, customer data is stored in many arrays while functions like `addCustomer`, `printCustomers`, and `findCustomerIndexById` are separate

Using classes would keep the data and its behavior together


## Parallel Arrays

Customer data is stored in separate arrays like `customerIds`, `customerNames`, `customerEmails`, `customerCities`, and `customerIsVip`

All of these arrays depend on the same index

If the indexes become incorrect, the data can become mixed or inconsistent


## Fixed Size Arrays

The program uses fixed size arrays for customers, products, orders, and order lines

This makes the storage less flexible and harder to change later


## Orders Depend on Array Indexes

An order does not store a real Customer object or Product object

It stores indexes like `orderCustomerIndexes` and `lineProductIndexes`

This makes the relationship between the data harder to understand and easier to break


## Business Logic Is Mixed With Console Output

Some functions do the main work and also print messages using `cout`

For example, `addCustomer` checks the data and also prints error messages

This mixes the business logic with the user interface


## Some Validation Is Missing

Some important values are not fully validated

Customer name can be empty

Customer email is not checked

Customer city can be empty

Product price can be zero or negative

Product stock can be negative


## Old Order Total Can Change

The program calculates the order total using the current product price

The order does not save the product price at the time of the order

If the product price changes later, an old order total can also change

This can make old order data incorrect
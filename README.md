# FizzBuzz

## Business Requirement

  You are a PE teacher.Five minutes before your class is dismissed, you decides to play a game with all students at your class. The rule is as below: 


1. Let all the students stand in one line and everyone counts off in order.
2. During counting off, if the number is the multiples of the first special number, number three (3), then the student should say Fizz; if the number is the multiples of the second special number, number five (5), say Buzz; if the multiples of the third special number, number seven (7), say Whizz. 
3. During counting off, if the number is the multiples of two special numbers, eg. the first and second numbers, then a student should say FizzBuzz instead of this number, so on and so forth. If the number is the multiples of three special numbers, say FizzBuzzWhizz.
  
Now you need to design a program to simulate this game. The output should be output fragments: 

```
1
2
Fizz
4
Buzz
Fizz
Whizz
8
Fizz
Buzz
11
Fizz 
13
Whizz
FizzBuzz
16
17
Fizz
19
Buzz 
… 
FizzBuzz
```

You only need to realize the fizzBuzz functions inside by means of TDD.

## Instructions

- Fork this project into your own repository;
- Clone it to your local computer;
- Fork the codes of the technology stack in your repository;
- Submit your homework on github and send the github url back to the system

## Notes on existing codes

Existing codes will help explain how to use tests. You will find two tests under HelloWorldTest. The first shows how to conduct integration tests and use Assert. 
The second shows how to do mock.

## Tasking
1. should return 4 when counts off given number not multiples with 3, 5, 7
2. should return Fizz when counts off given 3
3. should return Buzz when counts off given 5
4. should return Whizz when counts off given 7
5. should return FizzBuzz when counts off given 15
6. should return FizzWhizz when counts off given 21
7. should return BuzzWhizz when counts off given 35
8. should return FizzBuzzWhizz when counts off given 105

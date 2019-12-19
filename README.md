# Ping-Pong

#### _C#, .NET: Ping-Pong, 12/16/2019_

## Description
Ping-pong is a classic programming exercise that utilizes branching and looping.

## Application should have:

A user enters a number and the application returns all numbers from 1 to the user input with the following changes:
- All numbers divisible by 3 are replaced by "ping".
- All numbers divisible by 5 are replaced by "pong"
- All numbers divisible by both 3 and 5 are replaced by "ping-pong".

## Unit Testing
| Spec  | input | Expected Output |
| :------------- | :------------- | :------------- |
| User input a number | 15 | 1, 2, ping, 4, pong, ping, 7, 8, ping, pong, 11, ping, 13, 14, ping-pong |
| User input a negative number | -10 | Invalid Input |
| User input zero | 0 | Invalid Input |
| User input a number with decimal points| 1.5 | Invalid Input |
| User input a word | Hello | Invalid Input |



## Setup/Installation Requirements

1. Clone this repo:
```
$ git clone https://github.com/misakimichy/Ping-pong-Csharp.Solution.git
```

2. Go into the repo and run this application:
```
$ dotnet run
```


## Known Bugs
* No known bugs at this time.

## Support and contact details
 misaki.koonce@gmail.com

## Technologies Used
_Git, GitHub, C# and MS Test

## License
Copyright © 2019 under the MIT License

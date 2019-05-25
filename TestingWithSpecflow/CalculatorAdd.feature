Feature: CalculatorAdd
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Add two numbers
	Given I have entered <n1> into the calculator
	And I have also entered <n2> into the calculator
	When I press add
	Then the result should be <n3> on the screen

Examples: 
| n1 | n2 | n3 |
| 1  | 2  | 3  |
| 2  | 2  | 4  |

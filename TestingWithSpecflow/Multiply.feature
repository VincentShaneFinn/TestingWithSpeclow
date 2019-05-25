Feature: Multiply

A short summary of the feature

@mytag
Scenario: Multiply two numbers
	Given I have entered 2 into the calculator
	And I have also entered 2 into the calculator
	When I press Multiply
	Then the result should be 4 on the screen

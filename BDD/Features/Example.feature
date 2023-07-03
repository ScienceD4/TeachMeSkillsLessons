Feature: Example

A short summary of the feature

@tag1
Scenario: Add number
	Given the first number is <one>
	And the second number is <two>
	When the two numbers are added
	Then the result should be <res>

Examples:
	| one | two | res |
	| 50  | 70  | 120 |
	| 50  | 60  | 110 |
	| 50  | 30  | 80  |

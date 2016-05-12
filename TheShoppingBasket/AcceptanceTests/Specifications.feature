Feature: The Shopping basket specifications

Scenario: Total of basket with individual products
	Given the basket has "1" "bread"
	And the basket has "1" "butter"
	And the basket has "1" "milk"
	When I total the basket
	Then the total should be £2.95

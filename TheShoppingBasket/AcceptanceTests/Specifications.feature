Feature: Total of basket

Scenario: Shopping individual products
	Given the basket has "1" "bread"
	And the basket has "1" "butter"
	And the basket has "1" "milk"
	When I total the basket
	Then the total should be £2.95

Scenario: Shopping quantity of same product to enjoy free product offer
	Given the basket has "4" "milk"
	When I total the basket
	Then the total should be £3.45

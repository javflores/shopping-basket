Feature: Total of basket

Scenario: Shopping individual products
	Given the basket has "1" "bread"
	And the basket has "1" "butter"
	And the basket has "1" "milk"
	When I total the basket
	Then the total should be £2.95

Scenario: Buy 3 milk and get the 4th milk for free
	Given the basket has "4" "milk"
	When I total the basket
	Then the total should be £3.45

Scenario: Shopping quantity of same product to enjoy free product offer
	Given the basket has "2" "butter"
	And the basket has "2" "bread"
	When I total the basket
	Then the total should be £3.10

Scenario: Shopping quantity a number of products including several offers
	Given the basket has "2" "butter"
	And the basket has "1" "bread"
	And the basket has "8" "milk"
	When I total the basket
	Then the total should be £9.00

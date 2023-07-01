Feature: Booking

A short summary of the feature

@tag1
Scenario: Search Hotel on Booking
	Given hotel name is Royal Lancaster London
	When search hotel
	Then hotel score is 9.1
	And close browser

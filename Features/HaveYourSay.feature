Feature: HaveYourSay
	In order to ensure that Have Your Say input box is in working state
	As test engineer
	I want to validate different input combinations

Background:
	Given I have opened the bbc.com/news web page

Scenario Outline: Message box validation and screenshots
	When I click on More
	And I click on HaveYourSay
	And I click on question link
	When have your say page is opened
	And Message input box is filled with the '<Input Data>'
	And I filled other input fields
	And checked that I signed up for daily news
	Then the length of the message input box should equals '<Values>'
	And '<Screenshot>' is taken

	Examples:
		| Input Data    | Values | Screenshot             |
		| Valid Input   | 140    | ValidInputScreenshot   |
		| Invalid Input | 141    | InvalidInputScreenshot |
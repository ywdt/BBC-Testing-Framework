Feature: HaveYourSay
	In order to ensure that Have Your Say input box is in working state
	As a test engineer
	I want to validate different input combinations

Background:
	Given I have opened the bbc.com/news web page

Scenario Outline: Message box validation and screenshots
	When I click on More
	And I click on HaveYourSay
	And I click on question link
	When Have Your Say page is opened
	And Message input box is filled with the '<Input Data>'
	And I filled other input fields
	And checked that I signed up for daily news
	Then the length of the message input box should equals '<Values>'
	And '<Screenshot>' is taken

	Examples:
		| Input Data    | Values | Screenshot             |
		| Valid Input   | 140    | ValidInputScreenshot   |
		| Invalid Input | 141    | InvalidInputScreenshot |

Scenario Outline: Error messages validation
	When I click on More
	And I click on HaveYourSay
	And I click on question link
	When Have Your Say page is opened
	When I leave given '<Empty Input Field>'
	And fill the other input fields
	And click Submit button
	Then '<Error Message>' is shown

	Examples:
		| Empty Input Field | Error Message                |
		| Name              | Name can't be blank          |
		| Email             | Email address can't be blank |
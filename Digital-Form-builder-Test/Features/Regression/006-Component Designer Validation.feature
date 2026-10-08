Feature: 006-Digital Component form validation 
Background:
	Given Navigate to Home page
@SQLRegressionExecution
Scenario Outline: 001_Create Detailed component 
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Detail' component
	Then Verify component label 'An expandable title that lets users reveal more detailed information only if they need it'
	Then Click on on the 'Detail' Component
	Then Enter Title 'Detail component' and content 'content'
	Then Click on save button
	Then Click on preview button
	Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then verify 'content' in Detail component
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
Examples:
	| FormName        |
	| automationtest1 |


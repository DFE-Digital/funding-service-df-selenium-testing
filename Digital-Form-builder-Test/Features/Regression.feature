#Feature: Digital form regressiontee
#Background:
#	Given Navigate to Home page
#
# #dotnet test --filter Category=Regression1 ;livingdoc test-assembly "C:\Users\MIRFAN1\OneDrive - Department for Education\Desktop\dfe\Automation\C#\df\digital-form-builder-test-take-two\Digital-Form-builder-Test\bin\Debug\netcoreapp3.1\Digital-Form-builder-Test.dll" -t "C:\Users\MIRFAN1\OneDrive - Department for Education\Desktop\dfe\Automation\C#\df\digital-form-builder-test-take-two\Digital-Form-builder-Test\bin\Debug\netcoreapp3.1\TestExecution.json"
#@Regression @SQLRegression
#Scenario: 001_Verify that user should be able navigate to dashboard1
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then verify Digital Form Builder title
#	Then Verify 'My forms' and 'Colleagues' Form
#	             
#
#@Regression @DevRegression 
#Scenario: 002_Verify that user should be able Create New Form1
##	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then verify Digital Form Builder title
#	Then Click on create new form
#	Then Enter the form name 'automationtest1'
#	Then Click on Next button
#	Then Verify label 'First page'
#	Then Verify label 'Second page'
#	Then Verify label 'Summary'
#	Then go to Dashboard
#	Then Verify form name 'automationtest1'
#
#
#@Regression @DevRegression
#Scenario Outline: 003_Verify that user should be able to change form status of existing form1
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then verify Digital Form Builder title
#	Then User Select the form "<FormName>"
#	Then User click on 'Form status'
#	Then user change status to "<FormStatus>"
#	Then Verify the status "<FormStatus>"
#Examples:
#	| FormName        | FormStatus     |
#	| automationtest1 | UAT            |
#	| automationtest1 | Published      |
#	| automationtest1 | Closed         |
#	| automationtest1 | In development |
#
#		
#@Regression @DevRegression
#Scenario Outline: 007_Verify that user should be able to delete the existing form
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then verify Digital Form Builder title
#	Then Click on create new form
#	Then Enter the form name 'automationtest5'
#	Then Click on Next button
#	Then go to Dashboard
#	Then User Select the form "<FormName>"
#	Then Delete the form
#	Then Verify 'No forms found' in results
#Examples:
#	| FormName        |
#	| automationtest5 |
#
#
#@Regression @DevRegression
#Scenario Outline: 008_Verify that all the button should remain disable until user select any form for my forms
#	Given User is on Dashboard Page
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then verify Digital Form Builder title
#	Then Verify button disabled in dashboard
#
#
#@Regression @DevRegression
#Scenario Outline: 009_Verify that all the button should become enable once user select a form for my forms
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then verify Digital Form Builder title
#	Then User Select the form "<FormName>"
#	Then Verify button enabled in dashboard
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 010_Verify that all the button should remain disable until user select any form for my  Colleagues forms
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then verify Digital Form Builder title
#	Then User Select the form "<FormName>"
#	Then Scrolldown to Collegues form status
#	Then Verify button disabled in dashboard
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 011_Verify that all the button should become enable once user select a form for Colleagues forms
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then verify Digital Form Builder title
#	Then User Select the form "<FormName>"
#	Then Scrolldown to Collegues form status
#	Then Select any form in collegues form in tab
#	Then Verify button enabled in dashboard
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#		
# @DevRegression @Regression5555
#Scenario Outline: 012_Verify that if user try to access any close status application then user should be able to see static design error page
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then verify Digital Form Builder title
#	Then User Select the form "<FormName>"
#	Then User click on 'Form status'
#	Then user change status to "<FormStatus>"
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on preview button
#	Then Verify 'Applications have now closed' in page
#	Then Verify 'Contact us if you need more information.' text
#	Then Verify 'Sign up to the ESFA newsletter for further updates.' text
#	Then close the runner window
#Examples:
#	| FormName        | FormStatus |
#	| automationtest1 | Closed     |
#
#
#@Regression @DevRegression
#Scenario Outline: 013_Verify that if form status is "In-Development" or "UAT" and access type is Public, user click on preview button than user should be taken to UAT environment runner URL
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then verify Digital Form Builder title
#	Then User Select the form "<FormName>"
#	Then User click on 'Form status'
#	Then user change status to "<FormStatus>"
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on preview button
#	Then Verify UAT environment runner URL
#	Then close the runner window
#Examples:
#	| FormName        | FormStatus     |
#	| automationtest1 | In development |
#	| automationtest1 | UAT            |
#
#
#@devRegression @DevRegression
#Scenario Outline: 015_Verify that if form status is "Closed" or "Published" and access type is Public, user click on preview button than user should be taken to production environment runner URL
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then verify Digital Form Builder title
#	Then User Select the form "<FormName>"
#	Then User click on 'Form status'
#	Then user change status to "<FormStatus>"
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on preview button
#	Then Verify prod environment runner URL
#	Then close the runner window
#Examples:
#	| FormName        | FormStatus |
#	| automationtest1 | Closed     |
#	#| automationtest1 | Published  |
#
#
#@Regression @DevRegression
#Scenario Outline: 017_Verify that user should be able to see  Submit the form
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on preview button
#	##Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Verify 'Second page' in page
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	#Then Verify User able to save the PDF in "<FormName>"
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	# Then Verify 'What happens next'
#	Then close the runner window
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario: 018_Verify that a form should be get duplicated with provided new name once user clicks on duplicate button present on pop up
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then verify Digital Form Builder title
#	Then User Select the form "<FormName>"
#	Then User click on 'Duplicate form'
#	Then Enter 'automationtest5' to duplicate form
#	Then Click on duplicate form
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 019_Verify Detail component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	#Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Detail' component
#	Then Verify component label 'An expandable title that lets users reveal more detailed information only if they need it'
#	Then Click on on the 'Detail' Component
#	Then Enter Title 'Detail component ' and content 'content<h1> heading</h1><p>paragraph</p>'
#	Then Click on save button
#	Then Click on preview button
#	##Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then verify 'content<h1> heading</h1><p>paragraph</p>' in Detail component
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 020_Verify HTML component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'HTML' component
#	Then Verify component label 'A block of text that you can apply basic HTML to, such as text formatting and hyperlinks'
#	Then Click on on the 'HTML' Component
#	Then Enter content in HTML content '<p>HTML content values.</p>'
#	Then Click on save button
#	Then Click on preview button
#	##Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Verify 'HTML content values.' in html
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 021_Verify Inset text component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Inset text' component
#	Then Verify component label 'A block of text that differentiates it from surrounding content, for example for quotes'
#	Then Click on on the 'Inset text' Component
#	Then Enter content in HTML content '<p>This is inset text content</p>'
#	Then Click on save button
#	Then Click on preview button
#	##Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Verify 'This is inset text content' in html
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 022_Verify List component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Enter Add New List "<ListTitle>" and "<ListValue>"
#	Then Click on create component
#	#Then Verify 'List' component 
#	Then Verify component label 'A series of bullet points'
#	Then Click on on the 'List' Component
#	Then Enter Title 'List2'
#	Then Select the "<ListTitle>"
#	Then Click on preview button
#	##Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	##Then Verify the List values "<ListValue>"
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        | ListTitle | ListValue   |
#	| automationtest1 | List2     | item1,item2 |
#
#
#@Regression @DevRegression
#Scenario Outline: 023_Verify Paragraph component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Paragraph' component
#	Then Verify component label 'A block of text'
#	Then Click on on the 'Paragraph' Component
#	Then Enter content in HTML content '<p>Paragraph component</p>'
#	Then Click on save button
#	Then Click on preview button
#	##Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Verify 'Paragraph component' in html
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 024_Verify Autocomplete component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Autocomplete' component
#	Then Verify component label 'Sets a list of values to suggest to users as they complete this field'
#	Then Click on on the 'Autocomplete' Component
#	Then Enter Title 'Title_Component'
#	Then Select the 'List2' in dropdown
#	Then Click on save button
#	Then Click on preview button
#	##Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Enter 'item1' in autocomplete
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button in the summary
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#	
#@DevRegression
#Scenario Outline: 025_Verify date component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Date' component
#	Then Verify component label 'A calendar for users to specify a date'
#	Then Click on on the 'Date' Component
#	Then Enter Title 'Title_Component'
#	Then Click on save button
#	Then Click on preview button
#	##Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Enter '14011983' in date
#	#Then Click on 'Continue' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Verify 'Summary' in page
#	Then Click on 'Submit' button in the summary
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 026_Verify file download component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'File download' component
#	Then Verify component label 'Allow users to download files available for them'
#	Then Click on on the 'File download' Component
#	Then Enter Title 'Title_Component'
#	Then User click on button 'Import a new document'
#	Then Enter Title 'TestDocument' in import document
#	Then import the document 'Data.xlsx'
#	Then select 'TestDocument' document
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Verify the 'Data.xlsx' file
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 027_Verify Date parts component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Date parts' component
#	Then Verify component label 'Allows users to manually enter a Day, Month and Year'
#	Then Click on on the 'Date parts' Component
#	Then Enter Title 'date part'
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Enter Date value in "<Datevalue>"
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#	
#Examples:
#	| FormName        | Datevalue  |
#	| automationtest1 | 12-12-2022 |
#
#
#@Regression @DevRegression
#Scenario Outline: 028_Verify Date time parts component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Date time parts' component
#	Then Verify component label 'Allows users to manually enter a Day, Month, Year, Hour and Minute'
#	Then Click on on the 'Date time parts' Component
#	Then Enter Title 'Date time parts'
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Enter Date value in "<Datevalue>"
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	# Then Verify 'What happens next'
#	Then close the runner window
#	Then clean the component
#	
#Examples:
#	| FormName        | Datevalue        |
#	| automationtest1 | 12-12-2022-12-30 |
#
#
#@Regression @DevRegression
#Scenario Outline: 029_Verify Email address component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Email address' component
#	Then Verify component label 'A text box that users can enter an email address into'
#	Then Click on on the 'Email address' Component
#	Then Enter Title 'Email address'
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	#Then Verify 'Email address' in label
#	Then Enter email "<email>"
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify component name 'Email address' and value 'test@gmail.com'
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#	
#Examples:
#	| FormName        | email          |
#	| automationtest1 | test@gmail.com |
#
#
#@Regression @DevRegression
#Scenario Outline: 030_Verify Month year parts component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Month year parts' component
#	Then Verify component label 'Allows users to manually enter a Month and Year'
#	Then Click on on the 'Month year parts' Component
#	Then Enter Title 'Month year parts'
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Enter Date value in "<Datevalue>"
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#	
#Examples:
#	| FormName        | Datevalue |
#	| automationtest1 | 12-2022   |
#
#
#
#@Regression @DevRegression
#Scenario Outline: 031_Verify Multiline text component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Multiline text' component
#	Then Click on on the 'Multiline text' Component
#	Then Enter Title 'Multiline text'
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Verify 'Multiline text' in label
#	Then Enter multiline text value 'Multiline text value'
#	Then Click on 'Continue' Button
#	Then Verify component name 'Multiline text' and value 'Multiline text value'
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 032_Verify Telephone number component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Telephone number' component
#	Then Verify component label 'Sets a list of values to suggest to users as they complete this field'
#	Then Click on on the 'Telephone number' Component
#	Then Enter Title 'Telephone number'
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button in first page
#	Then Verify 'Telephone number' in label
#	Then Enter telephone number '7777121219'
#	#Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify component name 'Telephone number' and value '7777121219'
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 029_Verify Text component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Text' component
#	Then Verify component label 'A text box that users can enter letters, numbers and symbols into'
#	Then Click on on the 'Text' Component
#	Then Enter Title 'Text Component'
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Verify 'Text Component' in label
#	Then Enter text value 'Text value'
#	#Then Verify 'TextContent' in html
#	#Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify component name 'Text Component' and value 'Text value'
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#@Regression @DevRegression
#Scenario Outline: 034_Verify Time component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Time' component
#	Then Verify component label 'A clock for users to specify a time'
#	Then Click on on the 'Time' Component
#	Then Enter Title 'Time Component'
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Verify 'Time Component' in label
#	Then Enter time value '1212'
#	#Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify component name 'Time Component' and value '12:12'
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#@Regression @DevRegression
#Scenario Outline: 035_Verify Website component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Website' component
#	Then Verify component label 'A text box that users can enter a website into'
#	Then Click on on the 'Website' Component
#	Then Enter Title 'Website Component'
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Verify 'Website Component' in label
#	Then Enter Website value 'https://www.google.com/'
#	#Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify component name 'Website Component' and value 'https://www.google.com/'
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#@Regression @DevRegression
#Scenario Outline: 036_Verify UK address component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'UK address' component
#	Then Verify component label 'Allows users to enter their street address, town or city and postcode'
#	Then Click on on the 'UK address' Component
#	Then Enter Title 'address Component'
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Verify 'address Component' in label
#	Then Enter UK Address 'foxhall road,forrest fields,coventry,cv11lt'
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Verify component name 'address Component' and value 'foxhall road, forrest fields, coventry, cv11lt'
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 037_Verify File upload component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'File upload' component
#	Then Verify component label 'Allows users to upload files from the device they are using'
#	Then Click on on the 'File upload' Component
#	Then Enter Title 'Title_Component'
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Upload the file 'Data.xlsx'
#	Then Wait for file to upload
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#
#@Regression @DevRegression
#Scenario Outline: 038_Verify CheckBox component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Checkboxes' component
#	Then Click on on the 'Checkboxes' Component
#	Then Enter Title 'CheckBox_Component'
#	Then Select the 'List2' in dropdown
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Select 'item1' in checkbox
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button in the summary
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#
#
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 039_Verify Radiobox component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Radios' component
#	Then Click on on the 'Radios' Component
#	Then Enter Title 'Radios_Component'
#	Then Select the 'List2' in dropdown
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Select 'item1' in checkbox
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button in the summary
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 040_Verify selectbox component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Select' component
#	Then Click on on the 'Select' Component
#	Then Enter Title 'Select_Component'
#	Then Select the 'List2' in dropdown
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Select 'item1' in selectbox
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button in the summary
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#	
#@Regression @DevRegression
#Scenario Outline: 041_Verify YesNo component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Select' component
#	Then Click on on the 'Select' Component
#	Then Enter Title 'Select_Component'
#	Then Select the 'List2' in dropdown
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Select 'item1' in selectbox
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button in the summary
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#	Then clean the component
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#
##@Regression1 @DevRegression
##Scenario Outline: 042_Verify table component
##	Given User is on Dashboard Page
##	Then verify Digital Form Builder title
##	Then Verify Start Now link
##	Then click on Start Now link
##	Then User Select the form "<FormName>"
##	Then User click on 'Edit form' in my form
##	Then Click on Import Data set
##	Then upload the 'Datasetexamples' for import dataset
##	Then Click on Design Data set
##	Then Click on Design Data set link
##	Then Design Data Set from 2 to 2 in data table "<FormName>"
##	Then Click on save button
##Examples:
##	| FormName        |
##	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 043-DFE Signin
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User Click on switch access and change to dfesignin
#	Then User Select the form "<FormName>"
#	Then Click on test link in dashboard in "<FormName>"
#	Then Enter "<DFEUserName>" and "<Password>" and select the "<DFESignin>" in "<Org>"
#	Then verify Organization  "<Org>" and "<FormName>" in your detail page
#	#Then Verify 'First page' in page
#	Then Click on Save and continue
#	Then Verify 'Second page' in page
#	Then Click on Save and continue
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then Click on Signout Button
#	Then close the runner window
#Examples:
#	| FormName        | DFEUserName | Password | DFESignin | Org      |
#	| automationtest1 | DFEUserName | Password | UKPRN     | 10078001 |
#
#
#@Regression @DevRegression
#Scenario Outline: 044-switch access to public
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User Click on switch access and change to public
#	Then User Select the form "<FormName>"
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@Regression @DevRegression
#Scenario Outline: 045_Verify Number component
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Number' component
#	Then Verify component label 'A text box that users can only enter numbers into'
#	Then Click on on the 'Number' Component
#	Then Enter Title 'Number Component'
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Verify Edited component name 'Number Component' in page
#	Then Enter the number value "123456"
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	# Then Verify 'What happens next'
#	Then close the runner window
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#@dev1Regression @DevRegression
#Scenario Outline: 046 Regression pack -UKPRN-optional fields  -Prod Region
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then Click on test link in dashboard in "<FormName>"
#	Then Enter "<DFEUserName>" and "<Password>" and select the "<DFESignin>" in "<Org>"
#	Then verify Organization  "<Org>" and "<FormName>" in your detail page
#	#Then Verify 'First page' in page
#	Then Click on Save and continue
#	Then Select 'Optional Fields' in 'Select component1' with helptext 'Help text (optional)' in "<Org>"
#	Then Click on Save and continue
#	Then Check all component in 'OptionalFields' page "<Org>"
#	Then Click on Save and continue
#	Then Verify Summary page with optinal fields
#		| ComponentName              | ComponentValue  |
#		| Select component1          | Optional Fields |
#		| Autocomplete component     | Not supplied    |
#	#	| Email address component    | Not supplied    |
#		| File upload component      | Not supplied    |
#		| Multiline text component   | Not supplied    |
#		| Number component           | Not supplied    |
#		| Telephone number component | Not supplied    |
#		| Text component             | Not supplied    |
#		| UK address component       | Not supplied    |
#		| Website component          | Not supplied    |
#		| Radios component           | Not supplied    |
#		| YesNo component            | Not supplied    |
#		| Checkboxes component       | Not supplied    |
#		#| Data Import component      | Not supplied    |
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then Click on Signout Button
#	Then close the runner window
#Examples:
#	| FormName             | DFEUserName | Password | DFESignin | Org      |
#	| regressionpack_ukprn | DFEUserName | Password | UKPRN     | 10078001 |
#
#
#@Regressionrework @DevRegression
#Scenario Outline: 047 Regression pack -UKPRN-optional fields  -UAT Region
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then Click on test link in dashboard in "<FormName>"
#	Then Enter "<DFEUserName>" and "<Password>" and select the "<DFESignin>" in "<Org>"
#	Then verify Organization  "<Org>" and "<FormName>" in your detail page
#	#Then Verify 'First page' in page
#	Then Click on Save and continue
#	Then Select 'Optional Fields' in 'Select component1' with helptext 'Help text (optional)' in "<Org>"
#	Then Click on Save and continue
#	Then Check all component in 'OptionalFields' page "<Org>"
#	Then Click on Save and continue
#	Then Verify Summary page with optinal fields
#		| ComponentName              | ComponentValue  |
#		| Select component1          | Optional Fields |
#		| Autocomplete component     | Not supplied    |
#	#	| Email address component    | Not supplied    |
#		| File upload component      | Not supplied    |
#		| Multiline text component   | Not supplied    |
#		| Number component           | Not supplied    |
#		| Telephone number component | Not supplied    |
#		| Text component             | Not supplied    |
#		| UK address component       | Not supplied    |
#		| Website component          | Not supplied    |
#	#	| Radios component           | Optional Fields    |
#		| YesNo component            | Yes             |
#		| Checkboxes component       | Not supplied    |
#	#	| Data Import component      | Not supplied    |
#
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then Click on Signout Button
#	Then close the runner window
#Examples:
#	| FormName             | DFEUserName | Password | DFESignin | Org      |
#	| regressionpack_ukprn | DFEUserName | Password | UKPRN     | 10004733 |
#
#
#@Regression @DevRegression
#Scenario Outline: 048 Check footers link -Information guide
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then Check Footer link 'Information guide' section
#
#
#@Regression @DevRegressiontesting
#Scenario Outline: 049 Check footers link -Support shortcuts
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then Check Footer link 'Support shortcuts' section
#
#
#@Regression @DevRegression
#Scenario Outline: 050 Check footers link -CopyRight
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then Check Footer link 'Copy Right' section
#
#		
#@Regressionrework
#Scenario Outline: 052 -Verify submission id for each submission in UAT region(Development,UAT)
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then Click on test link in dashboard in "<FormName>"
#	Then Enter "<DFEUserName>" and "<Password>" and select the "<DFESignin>" in "<Org>"
#	Then verify Organization  "<Org>" and "<FormName>" in your detail page
#	#Then Verify 'First page' in page
#	Then Click on Save and continue
#	Then Enter the number value "123456"
#	Then Click on Save and continue
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify User able to save the PDF in "<FormName>"
#	Then Verify submissionid in cosmdb in org "<Org>" in UAT
#	Then Verify 'Submission complete' in page
#	Then Click on Signout Button
#	Then close the runner window
#Examples:
#	| FormName                 | DFEUserName | Password | DFESignin | Org      |
#	| RegressionSubmissionform | DFEUserName | Password | UKPRN     | 10078001 |
#
#
#@Regressiondev
#Scenario Outline: 053 -Verify submission id for each submission in (published status)
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then Click on prod link in dashboard in "<FormName>"
#	Then Enter "<DFEUserName>" and "<Password>" and select the "<DFESignin>" in "<Org>"
#	Then verify Organization  "<Org>" and "<FormName>" in your detail page
#	#Then Verify 'First page' in page
#	Then Click on Save and continue
#	Then Enter the number value "123456"
#	Then Click on Save and continue
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Verify submissionid in cosmdb in org "<Org>" in Prod
#	Then Verify 'Submission complete' in page
#	Then Click on Signout Button
#	Then close the runner window
#Examples:
#	| FormName                 | DFEUserName | Password | DFESignin | Org      |
#	| RegressionSubmissionform | DFEUserName | Password | UKPRN     | 10078001 |
#
#
#@DevRegression @Regression
#Scenario Outline: 054-Verify Add condition value
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on Condition button and verify Add or edit condition
#	Then Add condition value "<DisplayName>","<Componentname>","<condition>","<value>"
#Examples:
#	| FormName        | DisplayName | Componentname    | condition | value |
#	| automationtest1 | Condition   | Number Component | is        | 12    |
#
#
#@Sprint2_6 @demo @Regression @DevRegression
#Scenario Outline: 055-Verify Add condition value(123950)
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on Condition button and verify Add or edit condition
#	Then verify "<DisplayName>" in condition
#Examples:
#	| FormName        | DisplayName |
#	| automationtest1 | Condition   |
#
#
#   #Story :123950
#@Sprint2_6 @demo @Regression @DevRegression
#Scenario Outline: 056-Delete condition(123950)
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on Condition button and verify Add or edit condition
#	Then Delete "<DisplayName>" in condition
#Examples:
#	| FormName        | DisplayName |
#	| automationtest1 | Condition   |
#
####	"is at least": (">="),
#
##
##"is at most": ("<="),
##
##"is less than": ("<"),
##
##"is more than": (">"),
##
##"is": "=="
##
##"is not": "!="
#
#@Regression @demo @DevRegression
#Scenario Outline: 057_Result condition Worflow
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then Click on test link in dashboard in "<FormName>"
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Enter the number value "<Value>"
#	Then Click on 'Continue' Button
#	Then Verify "<ConditionPageName>" in page
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	# Then Verify 'What happens next'
#	Then close the runner window
#Examples:
#	| FormName                             | Value | ConditionPageName |
#	| Regression_ResultComponent_Condition | 119   | is at least_120   |
#	| Regression_ResultComponent_Condition | 94    | is at most_95     |
#	| Regression_ResultComponent_Condition | 96    | is less than_99   |
#	| Regression_ResultComponent_Condition | 110   | is more than_110  |
#	| Regression_ResultComponent_Condition | 107   | is_108            |
#	| Regression_ResultComponent_Condition | 106   | is not_98         |
#
#
#@DevRegressionrework @Regressionrework
#Scenario Outline: 063 Regression pack
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then Click on test link in dashboard in "<FormName>"
#	Then Enter "<DFEUserName>" and "<Password>" and select the "<DFESignin>" in "<Org>"
#	Then verify Organization  "<Org>" and "<FormName>" in your detail page
#	##Then Verify 'First page' in page
#	Then Click on Save and continue
#	Then Select 'Mandatory Fields' in 'Select component1' with helptext 'Help text (optional)' in "<Org>"
#	Then Click on Save and continue
#	#Then Enter "<AutoComplete>" in autocomplete
#	Then Enter all the fields in page "<Emailaddress>" ,"<Multilinetext>","<Number>","<Telephonenumber>","<Text>","<UKaddress>","<Website>"
#	Then Click on Save and continue
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Click on 'Submit' button
#	Then verify saved data in cosmodb "<AutoComplete>","<DataImport>","<Emailaddress>" ,"<Multilinetext>","<Number>","<Telephonenumber>","<Text>","<UKaddress>","<Website>","<Radio>","<Select>","<Checkbox>","<YesNo>","<Calculation>"
#	Then Verify 'Submission complete' in page
#	Then Click on Signout Button
#	Then close the runner window
#Examples:
#	| FormName             | DFEUserName | Password | DFESignin | Org      | AutoComplete     | DataImport                      | Emailaddress   | Multilinetext | Number | Telephonenumber | Text | UKaddress                                   | Website                                                                         | Radio            | Select           | Checkbox         | YesNo | Calculation |
#	| regressionpack_ukprn | DFEUserName | Password | UKPRN     | 10078001 | Mandatory Fields | Dataset_examples-UKPRN_prod.csv | Test@gamil.com | Multiline     | 123    | 123             | text | foxhall road,forrest fields,coventry,cv11lt | https://uat.test.digital-forms.education.gov.uk/vm0imSekXE/mandatory-fields_10/ | Mandatory Fields | Mandatory Fields | Mandatory Fields | True  | 76777       |
#
#
#@DevRegression @Regression
#Scenario Outline: 064_Verify Import List
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on Import Data set "<DataSetName>"
#	Then Upload backup file 'ListItems'
#	Then Click on close button
#	Then Enter Add New List "<ListTitle>"
#	Then Select DataSet "<DataSetName>"
#	Then Verify List Title "<ListTitle>","<NoOfItem>","<Datasetavailable>","<Linksavailable>"
#Examples:
#	| FormName        | ListTitle | DataSetName | NoOfItem | Datasetavailable | Linksavailable |
#	| automationtest1 | List3     | DataList    | 12       | Yes              | Yes            |
#
#	
#@DevRegression @Regression
#Scenario Outline: 065_Verify edit List item
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on List
#	Then Edit the List "<ListTitle>"
#	Then Click on edit icon
#	Then edit the values "<Item>"
#	Then Update the values "<itemtext>","<Helptext>","<Value>","<Enterlink>"
#	Then edit the values "<Item>"
#	Then Verify the values "<itemtext>","<Helptext>","<Value>","<Enterlink>"
# Examples:
#	| FormName        | ListTitle | Item  | itemtext     | Helptext        | Value        | Enterlink             |
#	| automationtest1 | List3     | Item1 | UpdatedItem1 | UpdatedHelptext | Updatedvalue | https://www.bing.com/ |
#
#
#@DevRegression @Regression
#Scenario Outline: 066_Verify remove List item
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on List
#	Then Edit the List "<ListTitle>"
#	Then Click on edit icon
#	Then Remove the item "<Item>"
#	Then Verify List Title "<ListTitle>","<NoOfItem>","<Datasetavailable>","<Linksavailable>"
#Examples:
#	| FormName        | ListTitle | Item   | NoOfItem | Datasetavailable | Linksavailable |
#	| automationtest1 | List3     | Item12 | 11       | Yes              | Yes            |
#
#
#@DevRegression @Regression
#Scenario Outline: 067_Verify remove List
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on List
#	Then Edit the List "<ListTitle>"
#	Then Click on delete icon
#	Then Verify The value in list "<ListTitle>"
#Examples:
#	| FormName        | ListTitle |
#	| automationtest1 | List3     |
#
#
#@DevRegression @nodejsRegression
#Scenario Outline: TTo verify node js
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then Then Verify dashboard every "<Min>" min
#Examples:
#	| FormName        | Min |
#	| automationtest1 | 30  |
#
#	
#@Regression7777 @DevRegression
#Scenario Outline: 068_Verify Number component with prefix and suffix
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Verify 'Number' component
#	Then Verify component label 'A text box that users can only enter numbers into'
#	Then Click on on the 'Number' Component
#	Then Enter Title 'Number Component'
#	Then User Select "<Prefix>","<Suffix>","<Addprefix>","<prefixcurrency>","<Entercustomprefix>","<Addsuffix_value>","<Min>","<Max>","<Precison>"
#	Then Click on save button
#	Then Click on preview button
#	#Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Verify Edited component name 'Number Component' in page
#	Then Enter the number value "<Value>"
#	Then Click on 'Continue' Button
#	Then Verify 'Submit' Button
#	Then Verify 'Save summary as PDF' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#Examples:
#	| FormName        | Prefix | Suffix | Addprefix | prefixcurrency | Entercustomprefix | Addsuffix_value | Min | Max | Precison | Value |
#	| automationtest1 | Yes    |        | Yes       | pounds         |                   |                 | 2   | 255 | 2        |  223     |
##	| automationtest1 | Yes    |        | Yes       | Euros          |                   | Hour            |     |     |          |       |
#	#| automationtest1 | Yes    |        | Yes       |                | per month         | Hour            |     |     |          |       |
#	#| automationtest1 |        |        |           |                |                   | Hour            |     |     |          |       |
#
#
#@Regression777722 @DevRegression
#Scenario Outline: 73 dfe Verify multiple submission
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then Click on test link in dashboard in "<FormName>"
#	Then Click on 'Continue' Button
#	Then Enter email "<email>"
#	Then Enter text value '<Textvalue>'
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then Verify Cosmodb values '<email>' and '<Textvalue>'
#	#Then Write the submission id in notepad
#Examples:
#	| FormName              | Textvalue     | email                          |
#	| emailNotificationtest | Test_email002 | mohamed.irfan@education.gov.uk |
#
#
#@Regression777722 @DevRegression
#Scenario Outline: 79 Verify multiple submission on NTP form
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then Click on test link in dashboard in "<FormName>"
#	Then Enter "<DFEUserName>" and "<Password>" and select the "<DFESignin>" in "<Org>"
#	Then verify Organization  "<Org>" and "<FormName>" in your detail page
#	Then Click on Save and continue
#	Then Enter the values in NTP form
#	Then Click on Save and continue
#Examples:
#	| FormName | Textvalue     | email                          | DFEUserName | Password | DFESignin | Org      |
#	| NTP form | Test_email002 | mohamed.irfan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078001 |
#
#
#@Regression777722 @DevRegression
#Scenario Outline: 73 Verify multiple submission
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then Click on test link in dashboard in "<FormName>"
#	Then Enter "<DFEUserName>" and "<Password>" and select the "<DFESignin>" in "<Org>"
#	Then verify Organization  "<Org>" and "<FormName>" in your detail page
#	Then Click on Save and continue
#	Then Click on 'subform' link
#	Then Click on Save and continue
#	Then Enter email "<email>"
#	Then Enter text value '<Textvalue>'
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then Verify Cosmodb values '<email>' and '<Textvalue>'
#	Then Click on Signout Button
#
#	#Then Write the submission id in notepad
#Examples:
#	| FormName   | Textvalue     | email                          | DFEUserName | Password | DFESignin | Org                    |
#	| MasterForm | Test_email001 | mohamed.irfan@education.gov.uk | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email002 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email003 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email004 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email005 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#	#| MasterForm | Test_email006 | marneni.saseelya@education.gov.uk        | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email007 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email008 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email009 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email010 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#	#| MasterForm | Test_email011 | marneni.saseelya@education.gov.uk        | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email012 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email013 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email014 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email015 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#	#| MasterForm | Test_email016 | marneni.saseelya@education.gov.uk        | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email017 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email018 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email019 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email020 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#	#| MasterForm | Test_email021 | marneni.saseelya@education.gov.uk        | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email022 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email023 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email024 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email025 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#	#| MasterForm | Test_email026 | marneni.saseelya@education.gov.uk        | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email027 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email028 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email029 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email030 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#	#| MasterForm | Test_email031 | marneni.saseelya@education.gov.uk        | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email032 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email033 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email034 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email035 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#	#| MasterForm | Test_email036 | marneni.saseelya@education.gov.uk        | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email037 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email038 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email039 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email040 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#	#| MasterForm | Test_email041 | marneni.saseelya@education.gov.uk        | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email042 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email043 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email044 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email045 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#	#| MasterForm | Test_email046 | marneni.saseelya@education.gov.uk        | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email047 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email048 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email049 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email050 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#	#| MasterForm | Test_email051 | marneni.saseelya@education.gov.uk        | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email052 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email053 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email054 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email055 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#	#| MasterForm | Test_email056 | marneni.saseelya@education.gov.uk        | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email057 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email058 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email059 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email060 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#	#| MasterForm | Test_email061 | marneni.saseelya@education.gov.uk        | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email062 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email063 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email064 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email065 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#	#| MasterForm | Test_email066 | marneni.saseelya@education.gov.uk        | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email067 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email068 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email069 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email070 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#	#| MasterForm | Test_email071 | marneni.saseelya@education.gov.uk        | DFEUserName | Password | UKPRN     | Adur Billing Authority |
#	#| MasterForm | Test_email072 | mohamed.irfan@education.gov.uk           | DFEUserName | Password | UKPRN     | 10078001               |
#	#| MasterForm | Test_email073 | sathyamanoj.vakacharla@education.gov.uk  | DFEUserName | Password | UKPRN     | 10078002               |
#	#| MasterForm | Test_email074 | barathkumar.karthikeyan@education.gov.uk | DFEUserName | Password | UKPRN     | 10078003               |
#	#| MasterForm | Test_email075 | lavanya.ganesula@education.gov.uk        | DFEUserName | Password | UKPRN     | 10004733               |
#
#
#	@Regression @DevRegression
#Scenario Outline: 074_Validate File upload component with file size more than 10MB
#	Given User is on Dashboard Page
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	Then Click on on the 'File upload' Component
#	Then Enter Title 'Title_Component'
#	Then Click on save button
#	Then Click on preview button
#	Then Click on 'Continue' Button
#	Then Upload the file 'Morethan10MB.docx'
#	Then Verify the file size error message
#	Then close the runner window
#Examples:
#	| FormName        |
#	| automationtest1 |
#
#
#	@Regression777722 @DevRegression@test123
#Scenario Outline: 73 connect sql
#	Given User is on Dashboard Page
#	Then verify Digital Form Builder title
#	Then connect to sql 
#
#
#
#	
#	@Regression777722 @DevRegression
#Scenario: delete form 
#	Then User Select the form "<FormName>"
#
#Examples:
#	| FormName        |
#	| automationtest1 |
#

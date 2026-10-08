Feature: 003-Digital form- Form component
Background:
	Given Navigate to Home page
@SQLRegressionExecution
Scenario Outline: 001_Verify Detail component
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
	Then Enter Title 'Detail component ' and content 'content<h1> heading</h1><p>paragraph</p>'
	Then Click on save button
	Then Click on preview button
	Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then verify 'content<h1> heading</h1><p>paragraph</p>' in Detail component
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution
Scenario Outline: 002_Verify HTML component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'HTML' component
	Then Verify component label 'A block of text that you can apply basic HTML to, such as text formatting and hyperlinks'
	Then Click on on the 'HTML' Component
	Then Enter content in HTML content '<p>HTML content values.</p>'
	Then Click on save button
	Then Click on preview button
	Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Verify 'HTML content values.' in html
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution
Scenario Outline: 003_Verify Inset text component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Inset text' component
	Then Verify component label 'A block of text that differentiates it from surrounding content, for example for quotes'
	Then Click on on the 'Inset text' Component
	Then Enter content in HTML content '<p>This is inset text content</p>'
	Then Click on save button
	Then Click on preview button
	Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Verify 'This is inset text content' in html
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution
Scenario Outline: 004_Verify List component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Enter Add New List "<ListTitle>" and "<ListValue>"
	Then Click on create component
	#Then Verify 'List' component 
	Then Verify component label 'A series of bullet points'
	Then Click on on the 'List' Component
	Then Enter Title 'List2'
	Then Select the "<ListTitle>"
	Then Click on preview button
	##Then Verify 'First page' in page
	Then Click on 'Continue' Button
	##Then Verify the List values "<ListValue>"
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        | ListTitle | ListValue   |
	| automationtest1 | List2     | item1,item2 |


@SQLRegressionExecution
Scenario Outline: 005_Verify Paragraph component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Paragraph' component
	Then Verify component label 'A block of text'
	Then Click on on the 'Paragraph' Component
	Then Enter content in HTML content '<p>Paragraph component</p>'
	Then Click on save button
	Then Click on preview button
	##Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Verify 'Paragraph component' in html
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution
Scenario Outline: 006_Verify Autocomplete component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Autocomplete' component
	Then Verify component label 'Sets a list of values to suggest to users as they complete this field'
	Then Click on on the 'Autocomplete' Component
	Then Enter Title 'Title_Component'
	Then Select the 'List2' in dropdown
	Then Click on save button
	Then Click on preview button
	##Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Enter 'item1' in autocomplete
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button in the summary
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |

	
@SQLRegressionExecution
Scenario Outline: 007_Verify date component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Date' component
	Then Verify component label 'A calendar for users to specify a date'
	Then Click on on the 'Date' Component
	Then Enter Title 'Title_Component'
	Then Click on save button
	Then Click on preview button
	##Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Enter '14011983' in date
	#Then Click on 'Continue' Button
	Then Verify 'Save summary as PDF' Button
	Then Verify 'Summary' in page
	Then Click on 'Submit' button in the summary
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution
Scenario Outline: 008_Verify file download component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'File download' component
	Then Verify component label 'Allow users to download files available for them'
	Then Click on on the 'File download' Component
	Then Enter Title 'Title_Component'
	Then User click on button 'Import a new document'
	Then Enter Title 'TestDocument' in import document
	Then Upload the file 'Data.xlsx'
	Then select 'TestDocument' document
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Verify the 'Data.xlsx' file
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution
Scenario Outline: 009_Verify Date parts component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Date parts' component
	Then Verify component label 'Allows users to manually enter a Day, Month and Year'
	Then Click on on the 'Date parts' Component
	Then Enter Title 'date part'
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Enter Date value in "<Datevalue>"
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
	
Examples:
	| FormName        | Datevalue  |
	| automationtest1 | 12-12-2022 |


@SQLRegressionExecution
Scenario Outline: 010_Verify Date time parts component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Date time parts' component
	Then Verify component label 'Allows users to manually enter a Day, Month, Year, Hour and Minute'
	Then Click on on the 'Date time parts' Component
	Then Enter Title 'Date time parts'
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Enter Date value in "<Datevalue>"
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	# Then Verify 'What happens next'
	Then close the runner window
	Then clean the component
	
Examples:
	| FormName        | Datevalue        |
	| automationtest1 | 12-12-2022-12-30 |


@SQLRegressionExecution
Scenario Outline: 011_Verify Email address component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Email address' component
	Then Verify component label 'A text box that users can enter an email address into'
	Then Click on on the 'Email address' Component
	Then Enter Title 'Email address'
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	#Then Verify 'Email address' in label
	Then Enter email "<email>"
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify component name 'Email address' and value 'test@gmail.com'
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
	
Examples:
	| FormName        | email          |
	| automationtest1 | test@gmail.com |


@SQLRegressionExecution
Scenario Outline: 012_Verify Month year parts component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Month year parts' component
	Then Verify component label 'Allows users to manually enter a Month and Year'
	Then Click on on the 'Month year parts' Component
	Then Enter Title 'Month year parts'
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Enter Date value in "<Datevalue>"
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
	
Examples:
	| FormName        | Datevalue |
	| automationtest1 | 12-2022   |



@SQLRegressionExecution
Scenario Outline: 013_Verify Multiline text component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Multiline text' component
	Then Click on on the 'Multiline text' Component
	Then Enter Title 'Multiline text'
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Verify 'Multiline text' in label
	Then Enter multiline text value 'Multiline text value'
	Then Click on 'Continue' Button
	Then Verify component name 'Multiline text' and value 'Multiline text value'
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution
Scenario Outline: 014_Verify Telephone number component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Telephone number' component
	Then Verify component label 'Sets a list of values to suggest to users as they complete this field'
	Then Click on on the 'Telephone number' Component
	Then Enter Title 'Telephone number'
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button in first page
	Then Verify 'Telephone number' in label
	Then Enter telephone number '7777121219'
	#Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify component name 'Telephone number' and value '7777121219'
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution
Scenario Outline: 015_Verify Text component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Text' component
	Then Verify component label 'A text box that users can enter letters, numbers and symbols into'
	Then Click on on the 'Text' Component
	Then Enter Title 'Text Component'
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Verify 'Text Component' in label
	Then Enter text value 'Text value'
	#Then Verify 'TextContent' in html
	#Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify component name 'Text Component' and value 'Text value'
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component

Examples:
	| FormName        |
	| automationtest1 |

@SQLRegressionExecution
Scenario Outline: 016_Verify Time component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Time' component
	Then Verify component label 'A clock for users to specify a time'
	Then Click on on the 'Time' Component
	Then Enter Title 'Time Component'
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Verify 'Time Component' in label
	Then Enter time value '1212'
	#Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify component name 'Time Component' and value '12:12'
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |

@SQLRegressionExecution
Scenario Outline: 017_Verify Website component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Website' component
	Then Verify component label 'A text box that users can enter a website into'
	Then Click on on the 'Website' Component
	Then Enter Title 'Website Component'
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Verify 'Website Component' in label
	Then Enter Website value 'https://www.google.com/'
	#Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify component name 'Website Component' and value 'https://www.google.com/'
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |

@SQLRegressionExecution
Scenario Outline: 018_Verify UK address component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'UK address' component
	Then Verify component label 'Allows users to enter their street address, town or city and postcode'
	Then Click on on the 'UK address' Component
	Then Enter Title 'address Component'
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Verify 'address Component' in label
	Then Enter UK Address 'foxhall road,forrest fields,coventry,cv11lt'
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Verify component name 'address Component' and value 'foxhall road, forrest fields, coventry, cv11lt'
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution
Scenario Outline: 019_Verify File upload component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'File upload' component
	Then Verify component label 'Allows users to upload files from the device they are using'
	Then Click on on the 'File upload' Component
	Then Enter Title 'Title_Component'
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Upload the file 'Data.xlsx' the Fileupload component
	Then Wait for file to upload
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |



@SQLRegressionExecution
Scenario Outline: 020_Verify CheckBox component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Checkboxes' component
	Then Click on on the 'Checkboxes' Component
	Then Enter Title 'CheckBox_Component'
	Then Select the 'List2' in dropdown
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Select 'item1' in checkbox
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button in the summary
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component


Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution
Scenario Outline: 021_Verify Radiobox component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Radios' component
	Then Click on on the 'Radios' Component
	Then Enter Title 'Radios_Component'
	Then Select the 'List2' in dropdown
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Select 'item1' in checkbox
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button in the summary
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution
Scenario Outline: 022_Verify selectbox component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Select' component
	Then Click on on the 'Select' Component
	Then Enter Title 'Select_Component'
	Then Select the 'List2' in dropdown
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Select 'item1' in selectbox
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button in the summary
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |

	
@SQLRegressionExecution
Scenario Outline: 023_Verify YesNo component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'YesNo' component
	Then Click on on the 'YesNo' Component
	Then Enter Title 'YesNo_Component'
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Select 'Yes' in yes no buttons
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button in the summary
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        |
	| automationtest1 |


	
@SQLRegressionExecution
Scenario Outline: 024-Data Import Component
	Given User is on Dashboard Page
	#Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Data Import' component
	Then Verify component label 'Allows user to upload datasets from their local machine and store it on the database'
	Then Click on on the 'Data Import' Component
	Then Enter Title 'Data Import Title Component'
	Then User click on button 'Import a new document'
	Then Enter Title 'DataDocument' in import document
	Then Upload the file 'Dataset examplesUKPRN test.csv'
	Then select 'DataDocument' document in Data import
	Then User Select ColumnName and ColumnType
		| Name                        | Type      | Maxdays_Past | Maxdays_Future | Maxlength | Min | Max      | Precision |
		| UKPRN                       | Number    |              |                |           | 1   | 99999999 |           |
		| Institution_Name_Legal_Name | Text      |              |                | 50        |     |          |           |
		| UK_Address                  | UKAddress |              |                |           |     |          |           |
		| DateField                   | Date      | 2585         | 2595           |           |     |          |           |
	Then Make component is optional
	Then Click on save button
	Then Click on preview button
	Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Upload backup file 'Dataset examplesUKPRN test.csv'
	Then Validate the file and messages
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component

Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution
Scenario Outline: 025_Verify table component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on Import Data set
	Then upload the 'Datasetexamples.csv' for import dataset
	Then Click on Design Data set
	Then Click on Design Data set link
	Then Design Data Set from 2 to 2 in data table "<FormName>"
	Then Click on save button
	Then close the button
	Then Click on create component
	Then Click on on the 'Table' Component
	Then Enter Title 'table Component'
	Then select the dataset
	Then Click on save button
	Then Click on preview button
	Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
Examples:
	| FormName        |
	| automationtest1 |

@SQLRegressionExecution
Scenario Outline: 026_Verify tab component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	#Then Click on Import Data set
	#Then upload the 'Datasetexamples.csv' for import dataset
	#Then Click on Design Data set
	#Then Click on Design Data set link
	#Then Design Data Set from 2 to 2 in data table "<FormName>"
	#Then Click on save button
	#Then close the button
	Then Click on create component
	Then Click on on the 'Tabs' Component
	Then Enter Title 'Tabs Component'
	And User Select number of sections as "<Number>" for that component
	And User clicks on Generate structure button
	And User clicks on each block and enters data
	Then Click on save button
	Then Click on preview button
	Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
Examples:
	| FormName        | Number |
	| automationtest1 | 2      |


@SQLRegressionExecution
Scenario Outline: 027-Verify Add condition value
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on Condition button and verify Add or edit condition
	Then Add condition value "<DisplayName>","<Componentname>","<condition>","<value>"
Examples:
	| FormName        | DisplayName | Componentname  | condition | value |
	| automationtest1 | Condition   | Tabs Component | is        | 12    |


@SQLRegressionExecution
Scenario Outline: 028-Verify Add condition value(123950)
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on Condition button and verify Add or edit condition
	Then verify "<DisplayName>" in condition
Examples:
	| FormName        | DisplayName |
	| automationtest1 | Condition   |


   #Story :123950
@SQLRegressionExecution
Scenario Outline: 029-Delete condition
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on Condition button and verify Add or edit condition
	Then Delete "<DisplayName>" in condition
Examples:
	| FormName        | DisplayName |
	| automationtest1 | Condition   |


@SQLRegressiontrailrun
Scenario Outline: 030_Verify DSI data access component
	Given User is on Dashboard Page
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Click on on the 'DSI data access' Component
	Then Enter the Title "<title>"
	Then Click on save button
	Then Click on preview button
	Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then verify "<title>" in summary page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
Examples:
	| FormName        | title |
	| automationtest1 | UKPRN |

	@SQLRegressiontrailrun
Scenario Outline: 031-Verify condition with import dataset file
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form
	Then Enter the form name
	Then Click on Next button
	Then Click on create component
	Then Click on on the 'DSI data access' Component
	Then Enter the Title "<title>"
	Then Click on save button
	Then Click on Import Data set
	Then upload the 'conditionImport.csv' for import dataset
	Then Click on Condition button and verify Add or edit condition
	Then Add condition wiht import dataset "<DisplayName>","<Componentname>","<condition>","<value>"
	Then Click on close button
	Then Click on create new form link
	#Then User Select the newly created form from the dashboard
	#Then Delete the form
Examples:
	| title | DataSetName   | DisplayName              | Componentname | condition | value   |
	| UKPRN | ConditionList | Importing Condition List | UKPRN         | is        | dataset |


	 
@SQLRegressiontrailrun
Scenario Outline: 032-Add condition and page
	Given User is on Dashboard Page
	Then click on Start Now link
	Then User Select the newly created form from the dashboard
	Then User Click on switch access and change to dfesignin
	Then User Select the newly created form from the dashboard
	Then User click on 'Edit form' in my form
	Then Add a page name
		| PageName     | ConditionName            | Page         | PageType |
		| /second-page |                          | No Condition |          |
		| /second-page |  | Condition    |          |
	Then Remove the page 'summary'
	Then Add a page name
		| PageName | ConditionName | Page    | PageType     |
		|          |               | Summary | Summary Page |
	Then add link from 'No Condition' to 'Summary'
	Then add link from 'Condition' to 'Summary'

@SQLRegressiontrailrun
Scenario Outline: 033-Add condition and page1
	Given User is on Dashboard Page
	Then click on Start Now link
	Then User Select the newly created form from the dashboard
	Then Click on test link in dashboard in Latest form
	Then Enter "<DFEUserName>" and "<Password>" and select the "<DFESignin>" in "<Org>"
	Then verify Organization  "<Org>" and "<FormName>" in your detail page
	Then Click on Save and continue
	Then Click on Save and continue
	Then Verify "<ConditionPageName>" in page
	Then Click on Save and continue
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then Click on Signout Button
	Then close the runner window
Examples:
	| DFEUserName                    | Password | DFESignin | Org      | ConditionPageName |
	| mohamed.irfan@education.gov.uk | Password | UKPRN     | 10004733 | No Condition      |
	| mohamed.irfan@education.gov.uk | Password | UKPRN     | 10078002 | Condition         |


@DevRegression @Regression
Scenario Outline: 034_Verify Import List
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on Import Data set "<DataSetName>"
	Then upload the 'ListItems.csv' for import dataset
	Then Enter Add New List "<ListTitle>"
	Then Select DataSet "<DataSetName>"
	Then Verify List Title "<ListTitle>","<NoOfItem>","<Datasetavailable>","<Linksavailable>"
Examples:
	| FormName        | ListTitle | DataSetName | NoOfItem | Datasetavailable | Linksavailable |
	| automationtest1 | List3     | dataset    | 12       | Yes              | Yes            |

	
@DevRegression @Regression
Scenario Outline: 035_Verify edit List item
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on List
	Then Edit the List "<ListTitle>"
	Then Click on edit icon
	Then edit the values "<Item>"
	Then Update the values "<itemtext>","<Helptext>","<Value>","<Enterlink>"
	Then edit the values "<Item>"
	Then Verify the values "<itemtext>","<Helptext>","<Value>","<Enterlink>"
Examples:
	| FormName        | ListTitle | Item  | itemtext     | Helptext        | Value        | Enterlink             |
	| automationtest1 | List3     | Item1 | UpdatedItem1 | UpdatedHelptext | Updatedvalue | https://www.bing.com/ |


@DevRegression @Regression
Scenario Outline: 034_Verify remove List item
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on List
	Then Edit the List "<ListTitle>"
	Then Click on edit icon
	Then Remove the item "<Item>"
	Then Verify List Title "<ListTitle>","<NoOfItem>","<Datasetavailable>","<Linksavailable>"
Examples:
	| FormName        | ListTitle | Item   | NoOfItem | Datasetavailable | Linksavailable |
	| automationtest1 | List3     | Item12 | 11       | Yes              | Yes            |


@DevRegression @Regression
Scenario Outline: 035_Verify remove List
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on List
	Then Edit the List "<ListTitle>"
	Then Click on delete icon
	Then Verify The value in list "<ListTitle>"
Examples:
	| FormName        | ListTitle |
	| automationtest1 | List3     |



@Regression7777 @SQLRegressionExecutiontesting
Scenario Outline: 068_Verify Number component with prefix and suffix
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Verify 'Number' component
	Then Verify component label 'A text box that users can only enter numbers into'
	Then Click on on the 'Number' Component
	Then Enter Title 'Number Component'
	Then User Select "<Prefix>","<Suffix>","<Addprefix>","<prefixcurrency>","<Entercustomprefix>","<Addsuffix_value>","<Min>","<Max>","<Precison>"
	Then Click on save button
	Then Click on preview button
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Verify Edited component name 'Number Component' in page
	Then Enter the number value "<Value>"
	Then Click on 'Continue' Button
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
Examples:
	| FormName        | Prefix | Suffix | Addprefix | prefixcurrency | Entercustomprefix | Addsuffix_value | Min | Max | Precison | Value |
	| automationtest1 | Yes    |        | Yes       | pounds         |                   |                 | 2   | 255 | 2        | 223   |
#	| automationtest1 | Yes    |        | Yes       | Euros          |                   | Hour            |     |     |          |       |
	#| automationtest1 | Yes    |        | Yes       |                | per month         | Hour            |     |     |          |       |
	#| automationtest1 |        |        |           |                |                   | Hour            |     |     |          |       |


@DevRegression @Regression
Scenario Outline: 036_Verify summary behaviour options in a form
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form
	Then Enter the form name
	Then Click on Next button
	And user click on Summary Behaviour button and provide "<Declaration>" and "<CustomiseSummaryMessage>" details
	Then Click on preview button
	Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Click on 'Continue' Button
	Then Verify "<Declaration>" and "<CustomiseSummaryMessage>" in page
Examples:
	| Declaration        | CustomiseSummaryMessage |
	| I declare that this form is submitted with correct values | This form will be closed in January 2025     |

@DevRegression @Regression
Scenario Outline: 037_Verify the page edit functionality in form designer
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form
	Then Enter the form name
	Then Click on Next button
	And user click on edit page of second page
	And user change the page title "<NewFormName>"
	Then Click on preview button
	Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then verify page title in second page as "<NewFormName>"
Examples:
	| NewFormName |
	|Second page edited|

@DevRegression @Regression
Scenario: 038_Verify the duplciate and delete page functionality in form designer
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form
	Then Enter the form name
	Then Click on Next button
	And user click on edit page of second page
	And user click on duplciate page button
	Then validate the newly created page in form designer
	And user clicks on edit page link of newly created page and deletes the page
	Then the user validates if page is deleted
	

	@Regression7777 @SQLRegressionExecutiontesting
Scenario Outline: 069 result component 
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Click on on the 'Number' Component
	Then Enter Title 'A'
	Then User Select "<Prefix>","<Suffix>","<Addprefix>","<prefixcurrency>","<Entercustomprefix>","<Addsuffix_value>","<Min>","<Max>","<Precison>"
	Then Click on save button
	Then Click on add new component
	Then Click on on the 'Number' Component
	Then Click on save button
	Then Enter Title 'B'
	Then User Select "<Prefix>","<Suffix>","<Addprefix>","<prefixcurrency>","<Entercustomprefix>","<Addsuffix_value>","<Min>","<Max>","<Precison>"
	Then Click on save button
	Then Click on add new component
	Then Click on on the 'Result' Component
	Then Add New calculation with page 'Second page' with variable 'A' and 'B' using '+'
	Then Enter calculation name 'calc1','Title','Help text'
	Then Click on save calculation
	Then Click on preview button
	Then Click on 'Continue' Button
	Then Enter the number value '100' and '100' and verify '200'
	Then Click on 'Continue' Button
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
	Then clean the component
	Then remove the calculation component


Examples:
	| FormName        | Prefix | Suffix | Addprefix | prefixcurrency | Entercustomprefix | Addsuffix_value | Min | Max | Precison | Value |
	| automationtest1 | Yes    |        | Yes       | pounds         |                   |                 | 2   | 255 | 2        | 223   |


		@Regression7777 @SQLRegressionExecutiontesting
Scenario Outline: 070 result component hide
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on create component
	Then Click on on the 'Number' Component
	Then Enter Title 'A'
	Then User Select "<Prefix>","<Suffix>","<Addprefix>","<prefixcurrency>","<Entercustomprefix>","<Addsuffix_value>","<Min>","<Max>","<Precison>"
	Then Click on save button
	Then Click on add new component
	Then Click on on the 'Number' Component
	Then Click on save button
	Then Enter Title 'B'
	Then User Select "<Prefix>","<Suffix>","<Addprefix>","<prefixcurrency>","<Entercustomprefix>","<Addsuffix_value>","<Min>","<Max>","<Precison>"
	Then Click on save button
	Then Click on add new component
	Then Click on on the 'Result' Component
	Then Add New calculation with page 'Second page' with variable 'A' and 'B' using '+'
	Then Enter calculation name 'calc1','Title','Help text'
	Then Hide the result component 
	Then Click on save calculation
	Then Click on preview button
	Then Click on 'Continue' Button
	Then Enter the number value '100' and '100' and verify '200' in Hideresult
	Then Click on 'Continue' Button
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
	Then clean the component
	Then clean the component
	Then remove the calculation component

Examples:
	| FormName        | Prefix | Suffix | Addprefix | prefixcurrency | Entercustomprefix | Addsuffix_value | Min | Max | Precison | Value |
	| automationtest1 | Yes    |        | Yes       | pounds         |                   |                 | 2   | 255 | 2        | 223   |



		@Regression7777 @SQLRegressionExecutiontesting
Scenario Outline: 071 result component hide
	Given User is on Dashboard Page
	Then remove the calculation component teejjj
	Then remove the calculation component teejjjrterter

	@Regression7777 @SQLRegressionExecutiontesting
Scenario Outline: 072 result component hide11
	Given User is on Dashboard Page
	Then remove the calculation component teejjjrterter



		@SQLRegressionExecutiontesting
Scenario Outline: 072 --create a form with section
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on add section
	Then Check the design in Add section 
Examples:
	| FormName        | 
	| automationtest1 | 


@SQLRegressionExecutiontesting
Scenario Outline: 073 --create a form with  new section
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on add section
	Then Add section with Name "<Title>"
	Then Verify the  Name "<Title>"
	Examples:
	| FormName        | Title| 
	| automationtest1 |  SectionName    | 


@SQLRegressionExecutiontesting
Scenario Outline: 074 --Edit section
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on add section
	Then Edit section with Name "<Title>" with "<NewTitle>"
	Then Verify the  Name "<NewTitle>"

	Examples:
	| FormName        | Title       |NewTitle|
	| automationtest1 | SectionName |   SectionNameupdated      |



	
@SQLRegressionExecutiontesting
Scenario Outline: 075 --Delete section
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on add section
	Then Delete the section "<NewTitle>"
	Examples:
	| FormName        | NewTitle|
	| automationtest1 |   SectionNameupdated      |
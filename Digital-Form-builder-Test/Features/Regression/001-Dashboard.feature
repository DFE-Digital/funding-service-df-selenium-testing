Feature: 001-Digital form -Dashboard
Background:
	Given Navigate to Home page

 #dotnet test --filter Category=SQLRegressionExecution ;livingdoc test-assembly "C:\Users\MIRFAN1\OneDrive - Department for Education\Desktop\dfe\Automation\C#\df\digital-form-builder-test-take-two\Digital-Form-builder-Test\bin\Debug\netcoreapp3.1\Digital-Form-builder-Test.dll" -t "C:\Users\MIRFAN1\OneDrive - Department for Education\Desktop\dfe\Automation\C#\df\digital-form-builder-test-take-two\Digital-Form-builder-Test\bin\Debug\netcoreapp3.1\TestExecution.json"
 #dotnet test --filter Category=Pipelinetest ;livingdoc test-assembly "..\digital-form-builder-test-take-two\Digital-Form-builder-Test\bin\Debug\netcoreapp3.1\Digital-Form-builder-Test.dll" -t "..\digital-form-builder-test-take-two\Digital-Form-builder-Test\bin\Debug\netcoreapp3.1\TestExecution.json"^C
@SQLRegressionExecution1 @DesignerExecution
Scenario: 001_Verify that user should be able navigate to dashboard
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then Verify 'My forms' and 'Colleagues' Form
	             
@SQLRegressionExecution @DesignerExecution
Scenario: 002_Verify that user should be able Create New Form
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then Click on create new form
	Then Enter the form name 'automationtest1'
	Then Click on Next button
	Then Verify label 'First page'
	Then Verify label 'Second page'
	Then Verify label 'Summary'

@SQLRegressionExecution @DesignerExecution
Scenario Outline: 003_Verify that user should be able to change form status of existing form
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then User Select the form "<FormName>"
	Then User click on 'Form status'
	Then user change status to "<FormStatus>"
	Then Verify the status "<FormStatus>"
Examples:
	| FormName        | FormStatus     |
	| automationtest1 | UAT            |
	| automationtest1 | Published      |
	| automationtest1 | Closed         |
	| automationtest1 | In development |

@SQLRegressionExecution @DesignerExecution
Scenario Outline: 007_Verify that user should be able to delete the existing form
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then Click on create new form
	Then Enter the form name 'automationtest6'
	Then Click on Next button
	Then go to Dashboard
	Then User Select the form "<FormName>"
	Then Delete the form
	Then User Search the form "<FormName>"
	Then Verify 'No items found' in results
Examples:
	| FormName        |
	| automationtest6 |

@SQLRegressionExecution @DesignerExecution
Scenario Outline: 008_Verify that all the button should remain disable until user select any form for my forms
	Given User is on Dashboard Page
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then Verify button disabled in dashboard

@SQLRegressionExecution @DesignerExecution
Scenario Outline: 009_Verify that all the button should become enable once user select a form for my forms
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then User Select the form "<FormName>"
	Then Verify button enabled in dashboard
Examples:
	| FormName        |
	| automationtest1 |

@SQLRegressionExecution @DesignerExecution
Scenario Outline: 010_Verify that all the button should remain disable until user select any form for my  Colleagues forms
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then User Select the form "<FormName>"
	Then Scrolldown to Collegues form status
	Then Verify button disabled in dashboard
Examples:
	| FormName |
	| Test     |


@SQLRegressionExecution @DesignerExecution
Scenario Outline: 011_Verify that all the button should become enable once user select a form for Colleagues forms
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then User Select the form "<FormName>"
	Then Scrolldown to Collegues form status
	Then Select any form in collegues form in tab
	Then Verify button enabled in dashboard
Examples:
	| FormName |
	| Test     |

@SQLRegressionExecution @DesignerExecution
Scenario Outline: 012_Verify that if user try to access any close status application then user should be able to see static design error page
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then User Select the form "<FormName>"
	Then User click on 'Form status'
	Then user change status to "<FormStatus>"
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on preview button
	Then Verify 'Applications have now closed' in page
	Then Verify 'Contact us if you need more information.' text
	Then Verify 'Sign up to the DfE newsletter for further updates.' text
	Then close the runner window
Examples:
	| FormName        | FormStatus |
	| automationtest1 | Closed     |



@SQLRegressionExecution @DesignerExecution
Scenario Outline: 013_Verify that if form status is "In-Development" or "UAT" and access type is Public, user click on preview button than user should be taken to UAT environment runner URL
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then User Select the form "<FormName>"
	Then User click on 'Form status'
	Then user change status to "<FormStatus>"
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on preview button
	Then Verify UAT environment runner URL
	Then close the runner window
Examples:
	| FormName        | FormStatus |
	#| automationtest1 | In development |
	| automationtest1 | UAT        |


@SQLRegressionExecution @DesignerExecution
Scenario Outline: 015_Verify that if form status is "Closed" or "Published" and access type is Public, user click on preview button than user should be taken to production environment runner URL
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then User Select the form "<FormName>"
	Then User click on 'Form status'
	Then user change status to "<FormStatus>"
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on preview button
	Then Verify prod environment runner URL
	Then close the runner window
Examples:
	| FormName        | FormStatus |
#	| automationtest1 | Closed     |
	| automationtest1 | Published  |


@SQLRegressionExecution @DesignerExecution
Scenario: 017_Verify that a form should be get duplicated with provided new name once user clicks on duplicate button present on pop up
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then User Select the form "<FormName>"
	Then User click on 'Duplicate form'
	Then Enter to duplicate form
	Then Click on duplicate form
Examples:
	| FormName        |
	| automationtest1 |

	
@SQLRegressionExecution6666 @DesignerExecution7777
Scenario Outline: 018_Verify that user is able to import form json from dashboard page
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	And user clicks on import saved form link
	Then verify that system gives import json modal window
	Then Import the json "<JsonFile>" with "<Name>"
#	And user enters unique form title and upload form json file "<JsonFile>"
	And user clicks on import .json button
	#Then verify that a form is created
Examples:
	| JsonFile        |Name|
	| n5msi0dc9a.json | testform110424    |

@SQLRegressiontrailrunneedchangesrework @SQLRegressionExecution666
Scenario Outline: 019_Verify that user is able to import form json from form designer page
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form button
		| FormName          |
		| TestForm          |
	Then User selects the form and click on edit button
	And the user uploads form json file "<JsonFile>"
	Then verify that imported form with form name "<FormName>" is displayed in dashboard
Examples:
	| JsonFile        | FormName           |
	| n5msi0dc9a.json | testform110424 MS1 |

@SQLRegressionExecution
Scenario Outline: 019_Verify that user should be able Create Parent child relationship between forms
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form button
		| FormName            |
		| ParentForm          |
		| ChildForm           |
		| DependentForm_One   |
		| DependentForm_Two   |
		| DependentForm_Three |
	Then Verify all forms in dashboard
	And user change page type of Parent form as "Parent Child page"
	And user create parent child relationship between the created forms
	Then Verify the grouped parent child forms in dashboard
	And user change switch access type to DFESignIn with "<FileName>" for all the forms in parent group
Examples:
	| FileName    |
	| ukprn 1.csv |

@SQLRegressionExecution
Scenario Outline: 020_Verify that user should be able change status of Parent child forms
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form button
		| FormName            |
		| ParentForm          |
		| ChildForm           |
		| DependentForm_One   |
		| DependentForm_Two   |
		| DependentForm_Three |
	Then Verify all forms in dashboard
	And user change page type of Parent form as "Parent Child page"
	And user create parent child relationship between the created forms
	Then Verify the grouped parent child forms in dashboard
	And user change switch access type to DFESignIn with "<FileName>" for all the forms in parent group
	And user change status of parent and child forms to "<Status>"
Examples:
	| FileName    | Status    |
	| ukprn 1.csv | Published |

@SQLRegressionExecution
Scenario Outline: 021_Verify that user should be able delete Parent child forms
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form button
		| FormName            |
		| ParentForm          |
		| ChildForm           |
		| DependentForm_One   |
		| DependentForm_Two   |
		| DependentForm_Three |
	Then Verify all forms in dashboard
	And user change page type of Parent form as "Parent Child page"
	And user create parent child relationship between the created forms
	Then Verify the grouped parent child forms in dashboard
	And user change switch access type to DFESignIn with "<FileName>" for all the forms in parent group
	And user change status of parent and child forms to "<Status>"
	And user deletes parent child forms from dashboard
Examples:
	| FileName    | Status |
	| ukprn 1.csv | UAT    |


@SQLRegressionExecution
Scenario Outline: 022_Verify that user should be able add conditions in Parent child relationship
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form button
		| FormName            |
		| ParentForm          |
		| ChildForm           |
		| DependentForm_One   |
		| DependentForm_Two   |
		| DependentForm_Three |
	And user should add a DSI component "UKPRN" and  condition in parent form with "<UKPRN>" and change page type of Parent form as "Parent Child page"
	And user create parent child relationship between the created forms with condition
	Then Verify the grouped parent child forms in dashboard
	And user change switch access type to DFESignIn with "<FileName>" for all the forms in parent group
	And user deletes parent child forms from dashboard
Examples:
	| FileName    | UKPRN     |
	| ukprn 1.csv | 100078001 |

@SQLRegressionExecution
Scenario: 023_Verify that user should be able duplicate Parent child forms
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form button
		| FormName            |
		| ParentForm          |
		| ChildForm           |
		| DependentForm_One   |
		| DependentForm_Two   |
		| DependentForm_Three |
	And user change page type of Parent form as "Parent Child page"
	And user create parent child relationship between the created forms
	And user duplicates the parent child forms with new form names
	And user deletes duplicate parent child forms from dashboard
	And user deletes parent child forms from dashboard

@SQLRegressionExecution
Scenario: 024_Verify form status-DFE Signin
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then User Select the form "<FormName>"
	Then User Click on switch access and change to dfesignin
	Then Verify the form status 'DFE SignIn'

Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution @DesignerExecution
Scenario Outline: 025-switch access to public
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User Click on switch access and change to public
	Then Verify the form status 'Public'

Examples:
	| FormName        |
	| automationtest1 |

@SQLRegressionExecution
Scenario Outline: 026_Verify that user should be able Create Parent child relationship between forms and check runner
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form button
		| FormName            |
		| ParentForm          |
		| ChildForm           |
		| DependentForm_One   |
		| DependentForm_Two   |
		| DependentForm_Three |
	And user change page type of Parent form as "Parent Child page"
	And user create parent child relationship between the created forms
	And user change switch access type to DFESignIn with "<FileName>" for all the forms in parent group
	And user validates runner of the parent child form
Examples:
	| FileName             |
	| ukprn_latest0924.csv |


@DevRegression @Regression
Scenario: 026_Verify the error message of Parent child group if API fails
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form button
		| FormName          |
		| ParentForm        |
		| ChildForm         |
		| DependentForm_One |
	And user change page type of Parent form as "Parent Child page"
	And user create parent child relationship between the created forms
	And user update child heading to validate the error message
Examples:
	| FileName             |
	| ukprn_latest0924.csv |


@SQLRegressionExecutiontesting
Scenario Outline: 027_Verify that user should be able to validate error messages in Runner for DSI Signin if user have DSI access with one/no UKPRN added to his profile
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form
	Then Enter the form name
	Then Click on Next button
	Then Click on create new form link
	Then User Select the newly created form from the dashboard
	Then User Click on switch access and change to dfesignin with file"<FileName>"
	Then User Select the newly created form from the dashboard
	Then User click on 'Form status'
	Then user change status to "<FormStatus>"
	And user validates runner of the form for error message for user "<User>"
Examples:
	| FileName    | FormStatus | User                         |
	| ukprn 1.csv | Published  | digitalforms01+103@gmail.com |
	| ukprn 1.csv | Published  | digitalforms01+102@gmail.com |

@SQLRegressionExecutiontesting
Scenario Outline: 028_Verify that user should be able to validate error messages in Runner for DSI Signin if user have DSI access with multiple UKPRN added to his profile
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form
	Then Enter the form name
	Then Click on Next button
	Then Click on create new form link
	Then User Select the newly created form from the dashboard
	Then User Click on switch access and change to dfesignin with file"<FileName>"
	Then User Select the newly created form from the dashboard
	Then User click on 'Form status'
	Then user change status to "<FormStatus>"
	And user validates runner of the form for error message for user "<User>" with UKPRN as "<UKPRN>"
Examples:
	| FileName                  | FormStatus | User                           | UKPRN    |
	| ukprn_without10078001.csv | Published  | mohamed.irfan@education.gov.uk | 10078001 |

	@SQLRegressionExecution
Scenario Outline: 029_Verify that user is able to create a form with repeatable sections
	Given User is on Dashboard Page
	Then click on Start Now link
	Then Click on create new form
	Then Enter the form name
	Then Click on Next button
	Then Click on create new form link
	Then User Select the newly created form from the dashboard
	Then User Click on switch access and change to dfesignin with file"<FileName>"
	#Then Click on create new form button
	#	| FormName          |
	#	| TestForm          |
	#Then User selects the form and click on edit button
	Then User Select the newly created form from the dashboard
	Then User click on 'Edit form' in my form
	Then create components in first page
		| ComponentName       |ComponentValue			  |
		| DSI data access | DSI				  |
		| Number          | Number Trigger    |
	Then create components in second page
		| ComponentName        | ComponentValue                      |
		| Multiline text   | Multiline text Component   |
		| Telephone number | Telephone number Component |
		| Email address    | Email address Component    |
		| YesNo            | YesNo Trigger              |
	Then Click on add section
	Then Add repeatable section with Name "<Title>" and  number trigger "<NumberTriggerName>" and Yes no Trigger "<YesNoTriggerName>"
	And add repeatable section "<Title>" to the second page
	Then Click on preview button
	Then Enter "<DFEUserName>" and "<Password>" and select the "<DFESignin>" in "<Org>"
	Then Click on Save and continue
	And I enter repeatable number trigger value as "<Iterations>" and click save and continue
	And I iterate through the repatable pages "<Iterations>" times and navigate to summary
	And I Submit the form with given details

Examples:
	| Iterations | Title              | NumberTriggerName | YesNoTriggerName | FileName             | DFEUserName                    | Password | DFESignin | Org      |
	| 2           | Repeatable Section | Number Trigger    | YesNo Trigger    | ukprn_latest0924.csv | mohamed.irfan@education.gov.uk | Password | UKPRN     | 10078001 |




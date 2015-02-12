# Tenta Killer
A Quiz-like game to help studying for exams.

# TODO
Examination/Test-taking session
Database in own thread
Voice in own thread
Go to selected Student in Students Page
Student Edit Page
Student View Page
Exam View/Edit Page
Exam Take Page
Challange View/Edit Page(s)
Sync. (Bind) VoiceEnabled CheckBox with MainWindow.VoiceEnabled instead of ToggleButton.VoiceEnabled (BUG it is enabled, but reverse for some reason)
Add dates to all domain classes (Models)
Remove Challange
In Challange Page, list Exams it is part of.
In InputWindow, focus on input field on open.
When removing Exam, remove (ask first?) related Challanges (if the Challange is not related to any other exam)
Refactor : rename Challange to Challenge (everywhere)
Filterable/Searchable lists (Challanges, Exams, Students)
Sortable lists (Challanges, Exams, Students)
Center confirmation dialog (want to remove challange?)
BUG after editing the list of Lies in a challange, navigation to exam occurs
BUG clearing one message clears all (sometimes)

# DONE
in Challange Page, list related Exams
BUG sync / bind / ItemsSource ..
  navigate to a exam, add a challange, navigate back to same exam, CRASH!
Challanges Page (list of challanges)
Add Lie
Remove Lie
Edit Lie
Remove Exam
Feedback displayer (informational and errors)
BUG Navigation occurs initally to exam page due to initial selection in exams page triggers SelectionChanged (SelectExam(..))
move Views to own namespace
move Models to own namespace
Go to selected Exam in Exams Page
Give each Page (Views) a reference to MainWindow
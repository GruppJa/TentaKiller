﻿# Tenta Killer
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
BUG sync / bind / ItemsSource ..
  navigate to a exam, add a challange, navigate back to same exam, CRASH!
Add dates to all domain classes (Models)
Remove Challange
In InputWindow, focus on input field on open.
When removing Exam, remove (ask first?) related Challanges (if the Challange is not related to any other exam)
Challanges Page (list of challanges)
Refactor : rename Challange to Challenge (everywhere)

# DONE
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
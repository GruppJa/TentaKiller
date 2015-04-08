﻿# Tenta Killer
A Quiz-like game to help studying for exams.

# TODO
NOW
  Database error handling
  Exam Take Page
LATER
PLAN
  Examination/Test-taking session
  Database in own thread
  Voice in own thread
  Student Edit Page
  Student View Page
  Sync. (Bind) VoiceEnabled CheckBox with MainWindow.VoiceEnabled instead of ToggleButton.VoiceEnabled (BUG it is enabled, but reverse for some reason)
  In InputWindow, focus on input field on open.
  When removing Exam, remove (ask first?) related Challanges (if the Challange is not related to any other exam)
  Refactor : rename Challange to Challenge (everywhere)
  Filterable/Searchable lists (Challanges, Exams, Students)
  Sortable lists (Challanges, Exams, Students)
  Center confirmation dialog (want to remove challange?)
  Offline mode?
  Possibility to add an already existing Challange to an (already existing) Exam.
  Possibility to add a Challange to an already existing Exam.

# DONE
Some "sample" data. (would be nice with some .sql files to execute)
Add dates to all domain classes (Models)
BUG selection in feedback while (ctrl) does not remove
User login / selection (select current student)
Go to selected Student in Students Page
BUG after editing the list of Lies in a challange, navigation to exam occurs
Challange View/Edit Page(s)
Exam View/Edit Page
In Challange Page, list Exams it is part of.
BUG clearing one message clears all (sometimes)
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


NOTES
  Entity Framework - Database Migration
  https://msdn.microsoft.com/en-us/data/jj591621
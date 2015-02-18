INSERT [dbo].[Students] ([Id], [Name], [Created]) VALUES (N'00886014-c390-4a7a-8df5-22e50dd0ddf8', N'Johan', CURRENT_TIMESTAMP)

INSERT [dbo].[Students] ([Id], [Name], [Created]) VALUES (N'00886014-c390-4a7a-8df5-22e50dd0dre9', N'Anna', CURRENT_TIMESTAMP)

INSERT [dbo].[Students] ([Id], [Name], [Created]) VALUES (N'00235114-c390-4a7a-8df5-28e50dd0ddf8', N'Martin', CURRENT_TIMESTAMP)

INSERT [dbo].[Students] ([Id], [Name], [Created]) VALUES (N'00884261-c390-4a7a-8df5-22e50dd0ddf8', N'Jennifer', CURRENT_TIMESTAMP)

INSERT [dbo].[Students] ([Id], [Name], [Created]) VALUES (N'42616014-c390-4a7a-8df5-22e50dd0ddf8', N'Hampus', CURRENT_TIMESTAMP)


INSERT [dbo].[Exams] ([Id], [Name], [Created], [Creator_Id]) VALUES (N'615e96b2-1953-4f7a-8c57-1551b4c662a6', N'English', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Exams] ([Id], [Name], [Created], [Creator_Id]) VALUES (N'616e96b2-1953-4f7a-8c57-1551b4c662a6', N'Mathematics', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Exams] ([Id], [Name], [Created], [Creator_Id]) VALUES (N'617e96b2-1953-4f7a-8c57-1551b4c662a6', N'Astronomy', CURRENT_TIMESTAMP, N'00884261-c390-4a7a-8df5-22e50dd0ddf8')


INSERT [dbo].[Challanges] ([Id], [Question], [Answer], [Created], [Creator_Id]) VALUES (N'00ee5690-d315-4f14-ab1f-1968db337bca', N'What is the swedish translation of the word "Transition"?', N'Övergång', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Challanges] ([Id], [Question], [Answer], [Created], [Creator_Id]) VALUES (N'11ee5690-d315-4f14-ab1f-1968db337bca', N'What is the english word for "Murbräcka"?', N'Battering ram', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Challanges] ([Id], [Question], [Answer], [Created], [Creator_Id]) VALUES (N'22ee5690-d315-4f14-ab1f-1968db337bca', N'Which word is a synonym for "Pocket"?', N'Pouch', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Challanges] ([Id], [Question], [Answer], [Created], [Creator_Id]) VALUES (N'33ee5690-d315-4f14-ab1f-1968db337bca', N'12 * 10 = ?', N'120', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Challanges] ([Id], [Question], [Answer], [Created], [Creator_Id]) VALUES (N'44ee5690-d315-4f14-ab1f-1968db337bca', N'4 * 4 = ?', N'16', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Challanges] ([Id], [Question], [Answer], [Created], [Creator_Id]) VALUES (N'55ee5690-d315-4f14-ab1f-1968db337bca', N'9 / 3 = ?', N'3', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Challanges] ([Id], [Question], [Answer], [Created], [Creator_Id]) VALUES (N'66ee5690-d315-4f14-ab1f-1968db337bca', N'What is the sun?', N'A star', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Challanges] ([Id], [Question], [Answer], [Created], [Creator_Id]) VALUES (N'77ee5690-d315-4f14-ab1f-1968db337bca', N'How many planets exists in our solar system?', N'8', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Challanges] ([Id], [Question], [Answer], [Created], [Creator_Id]) VALUES (N'88ee5690-d315-4f14-ab1f-1968db337bca', N'Is Pluto a ..?', N'Dwarf planet', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')


INSERT [dbo].[ExamChallanges] ([Exam_Id], [Challange_Id]) VALUES (N'615e96b2-1953-4f7a-8c57-1551b4c662a6', N'00ee5690-d315-4f14-ab1f-1968db337bca')

INSERT [dbo].[ExamChallanges] ([Exam_Id], [Challange_Id]) VALUES (N'615e96b2-1953-4f7a-8c57-1551b4c662a6', N'11ee5690-d315-4f14-ab1f-1968db337bca')

INSERT [dbo].[ExamChallanges] ([Exam_Id], [Challange_Id]) VALUES (N'615e96b2-1953-4f7a-8c57-1551b4c662a6', N'22ee5690-d315-4f14-ab1f-1968db337bca')

INSERT [dbo].[ExamChallanges] ([Exam_Id], [Challange_Id]) VALUES (N'616e96b2-1953-4f7a-8c57-1551b4c662a6', N'33ee5690-d315-4f14-ab1f-1968db337bca')

INSERT [dbo].[ExamChallanges] ([Exam_Id], [Challange_Id]) VALUES (N'616e96b2-1953-4f7a-8c57-1551b4c662a6', N'44ee5690-d315-4f14-ab1f-1968db337bca')

INSERT [dbo].[ExamChallanges] ([Exam_Id], [Challange_Id]) VALUES (N'616e96b2-1953-4f7a-8c57-1551b4c662a6', N'55ee5690-d315-4f14-ab1f-1968db337bca')

INSERT [dbo].[ExamChallanges] ([Exam_Id], [Challange_Id]) VALUES (N'617e96b2-1953-4f7a-8c57-1551b4c662a6', N'66ee5690-d315-4f14-ab1f-1968db337bca')

INSERT [dbo].[ExamChallanges] ([Exam_Id], [Challange_Id]) VALUES (N'617e96b2-1953-4f7a-8c57-1551b4c662a6', N'77ee5690-d315-4f14-ab1f-1968db337bca')

INSERT [dbo].[ExamChallanges] ([Exam_Id], [Challange_Id]) VALUES (N'617e96b2-1953-4f7a-8c57-1551b4c662a6', N'88ee5690-d315-4f14-ab1f-1968db337bca')


INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'000d1f9f-fe6c-47b8-8475-9cb10e14008a', N'Framgång', N'00ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'111d1f9f-fe6c-47b8-8475-9cb10e14008a', N'Motgång', N'00ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'222d1f9f-fe6c-47b8-8475-9cb10e14008a', N'Överskrida', N'00ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'333d1f9f-fe6c-47b8-8475-9cb10e14008a', N'Hammering ram', N'11ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'444d1f9f-fe6c-47b8-8475-9cb10e14008a', N'Managing ram', N'11ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'555d1f9f-fe6c-47b8-8475-9cb10e14008a', N'Bulldozer', N'11ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0dre9')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'666d1f9f-fe6c-47b8-8475-9cb10e14008a', N'Much', N'22ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'777d1f9f-fe6c-47b8-8475-9cb10e14008a', N'Futch', N'22ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0dre9')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'888d1f9f-fe6c-47b8-8475-9cb10e14008a', N'Parakeet', N'22ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'018d1f9f-fe6c-47b8-8475-9cb10e14008a', N'124', N'33ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'028d1f9f-fe6c-47b8-8475-9cb10e14008a', N'76', N'33ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'038d1f9f-fe6c-47b8-8475-9cb10e14008a', N'100', N'33ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'048d1f9f-fe6c-47b8-8475-9cb10e14008a', N'10', N'44ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'058d1f9f-fe6c-47b8-8475-9cb10e14008a', N'14', N'44ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'068d1f9f-fe6c-47b8-8475-9cb10e14008a', N'15', N'44ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'078d1f9f-fe6c-47b8-8475-9cb10e14008a', N'2', N'55ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'088d1f9f-fe6c-47b8-8475-9cb10e14008a', N'1', N'55ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'098d1f9f-fe6c-47b8-8475-9cb10e14008a', N'4', N'55ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'118d1f9f-fe6c-47b8-8475-9cb10e14008a', N'A comet', N'66ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'128d1f9f-fe6c-47b8-8475-9cb10e14008a', N'A space station', N'66ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'138d1f9f-fe6c-47b8-8475-9cb10e14008a', N'A black hole', N'66ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'148d1f9f-fe6c-47b8-8475-9cb10e14008a', N'7', N'77ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'158d1f9f-fe6c-47b8-8475-9cb10e14008a', N'9', N'77ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'168d1f9f-fe6c-47b8-8475-9cb10e14008a', N'10', N'77ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'178d1f9f-fe6c-47b8-8475-9cb10e14008a', N'A comet', N'88ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0dre9')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'188d1f9f-fe6c-47b8-8475-9cb10e14008a', N'A meteor', N'88ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7<a-8df5-22e50dd0ddf8')

INSERT [dbo].[Lies] ([Id], [Text], [Challange_Id], [Created], [Creator_Id]) VALUES (N'198d1f9f-fe6c-47b8-8475-9cb10e14008a', N'A mini planet', N'88ee5690-d315-4f14-ab1f-1968db337bca', CURRENT_TIMESTAMP, N'00886014-c390-4a7a-8df5-22e50dd0ddf8')
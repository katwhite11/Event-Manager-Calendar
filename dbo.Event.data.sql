INSERT INTO [dbo].[Event] ([title], [date], [startTime], [endTime], [location], [description], [createdBy], [attendee]) VALUES (N'Church', N'05-14-2023', N'08:00', N'10:00', N'Ashland', N'Worship', N'123456', N'123456')
INSERT INTO [dbo].[Event] ([title], [date], [startTime], [endTime], [location], [description], [createdBy], [attendee]) VALUES (N'End of May Party', N'05-31-2023', N'02:00', N'03:00', N'Bob''s House', N'It''s June!', N'777777', N'111111')
INSERT INTO [dbo].[Event] ([title], [date], [startTime], [endTime], [location], [description], [createdBy], [attendee]) VALUES (N'End of May Party', N'05-31-2023', N'02:00', N'03:00', N'Bob''s House', N'It''s June!', N'777777', N'777777')
INSERT INTO [dbo].[Event] ([title], [date], [startTime], [endTime], [location], [description], [createdBy], [attendee]) VALUES (N'End of May Party', N'05-31-2023', N'02:00', N'03:00', N'Bob''s House', N'It''s June!', N'777777', N'123456')
INSERT INTO [dbo].[Event] ([title], [date], [startTime], [endTime], [location], [description], [createdBy], [attendee]) VALUES (N'Dry Cleaners', N'05-20-2023', N'11:00', N'12:00', N'Choi'' Cleaners', N'Bring Dress', N'111111', N'111111')
INSERT INTO [dbo].[Event] ([title], [date], [startTime], [endTime], [location], [description], [createdBy], [attendee]) VALUES (N'End of Classes', N'05-13-2023', N'23:30', N'24:00', N'EKU', N'Yay!', N'123456', N'123456')
INSERT INTO [dbo].[Event] ([title], [date], [startTime], [endTime], [location], [description], [createdBy], [attendee]) VALUES (N'Mother''s Day', N'05-14-2023', N'12:00', N'14:00', N'Home', N'Celebrate', N'123456', N'123456')
INSERT INTO [dbo].[Event] ([title], [date], [startTime], [endTime], [location], [description], [createdBy], [attendee]) VALUES (N'Dad''s Birthday', N'06-29-2023', N'14:00', N'16:00', N'Home', N'Celebrate', N'123456', N'123456')
INSERT INTO [dbo].[Event] ([title], [date], [startTime], [endTime], [location], [description], [createdBy], [attendee]) VALUES (N'Birthday', N'07-11-2023', N'12:00', N'14:00', N'Home', N'Eat Cake', N'123456', N'123456')
DELETE FROM [dbo].[Event] WHERE [attendee] = '123456'
DELETE FROM [dbo].[Event] WHERE [attendee] = '111111'
DELETE FROM [dbo].[Event] WHERE [attendee] = '777777'
DELETE FROM [dbo].[Event] WHERE [date] = '06-29-2023'
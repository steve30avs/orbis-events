# Orbis Events

Event Registration System

# The Problem

Orbis wishes to create an internal tool that allows its employees to easily create and register for events. The current system being used is plagued with several bugs. Some of the most egregious bugs reported by employees are listed below:

- The system allows non Orbis employees to post phony events
- There is no way to edit an event once it's been created
- It is possible to register multiple times for the same event
- The system does not enforce the maximum registration limit and so events are overfilled
- The system lacks a clean and intuitive user interface

Yuck!

Your task will be to create a new event registration system unencumbered by any of these issues using modern web technologies.

# The Requirements
The new system should:

- Display a list of all upcoming events on the front page
- Allow anyone to view details of individual events
- Allow logged in users to create events
- Allow the event creator to edit the event
- Allow only logged in users to register for events
- Prevent users from registering multiple times
- Prevent further registrations once the maximum registration limit has been reached

# The Starter Project
This repo contains the beginnings of a new and improved event registration system. It is written with C# using Asp.Net Core 2.2. It uses an SQLite database with Entity Framewrok Core 2 for ORM.

What it has:

- Minimum set of models needed to complete requirements (see src/OrbisEvents/Data/Models)
- Minimum set of controllers needed to complete requirements (see src/OrbisEvents/Controllers)
- Database (orbisEvents.db) & Database access layer using Entity Framework Core 2 (see src/OrbisEvents/Data/AppDbContext.cs)
- Simple landing page

What it needs:

- Basic user authentication (registration & login. password encryption optional)
- Pages for creating events
- Pages for viewing & registering for events

The intent is to give you ideas on how you could structure the project. You are free to deviate from this structure as you see fit to meet all the requirements laid out. You are also free to add any additional
features you feel might be useful to the overall experience of the system.

# CW9: Threading in C#

Name: Zach Coomer

Date: 3/6/2023

## Description

A program that simulates throwing darts at a quarter of a dart-board. This program prompts the user to input the number of darts and threads used to simulate throwing darts at a dart-board. Threads are used to increase the number of darts thrown by running simultaneously. 

## Challenges

Determining the logic of the threads was a bit confusing but paying close attention to the names made it manageable. 

## Design Decisions

I decided to put FindPiThread in its own file for clean coding. 

## Files Required

* Program.cs 
	- This file holds Main().

* FindPiThread.cs
	- This file holds the thread logic.

* README.md
	- Here I list brief information about the program and topics related to the program.

## How to Run

This program is currently intended to be run in Visual Studios 2022.

## Extra

I added in timing via Stopwatch.

I added a file containing pi estimates and runtimes to compare speed/accuracy vs the number of threads/darts. The file is `CW9Results.txt`.

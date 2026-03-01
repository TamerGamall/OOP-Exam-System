# OOP Exam System

## Description
This project is an **Examination System** built using **C#**.  
It allows creating different types of questions and exams, including:

- **True/False Questions**
- **Choose One Questions**
- **Choose All Questions** (if you implement it later)

There are two types of exams:
- **Practice Exam**: Shows the correct answers after taking the exam.
- **Final Exam**: Only shows questions and calculates the grade without showing answers.

The system uses **Object-Oriented Programming principles** like:
- Abstract classes (`Question`, `Exam`)
- Inheritance (`True_False`, `ChooseQuestion`, `PracticeExam`, `FinalExam`)
- Encapsulation (properties and methods)
- Enum for question types

---

## Features
1. Add questions to an exam.
2. Show questions to the user.
3. Take user answers.
4. Calculate the total score.
5. Display results differently for Practice and Final exams.

---

## How to Run
1. Open the project in **Visual Studio**.
2. Build the solution.
3. Run the program.
4. Follow console instructions to take the exam.

---

## Classes Overview

### Question (Abstract)
- Properties: `Header`, `Body`, `Marks`, `Answer`, `UserAnswer`
- Methods: `Show()`, `TakeAnswer()`, `CalcDegree()`

### True_False (Derived from Question)
- Represents a True/False question.

### ChooseQuestion (Derived from Question)
- Represents a multiple choice question.
- `choices[]` stores the possible answers.

### Exam (Abstract)
- Properties: `Time`, `NumberOfQuestions`, `Questions[]`, `Subject`
- Methods: `ShowQuestions()`, `TakeAnswers()`, `ShowResult()`

### PracticeExam (Derived from Exam)
- Shows correct answers after the exam.

### FinalExam (Derived from Exam)
- Only shows questions and calculates score.

---

## Example Usage

```csharp
Subject math = new Subject("Math");
PracticeExam exam = new PracticeExam(60, 2, math);

exam.AddQuestion(new True_False("TF Question", "Is 2+2=4?", 5, "True"));
exam.AddQuestion(new ChooseQuestion("Choose Question", "Pick 2+2", 5, "0", new string[]{"4","5","3","2"}));

exam.ShowQuestions();
exam.TakeAnswers();
exam.ShowResult();

# WatchWordImage Prototype (Unity / C#)



## Overview  

This project is a prototype of an English vocabulary learning application built with \*\*Unity (6000.0.47f1)\*\* and \*\*C#\*\*.  

It was created both as a \*\*learning application prototype\*\* and as part of my process for studying \*\*Unity development\*\*.  

The goal of this prototype is to explore how images can support learners in understanding English words directly, without first translating them into their native language.



This concept is inspired by the \*\*Dual Coding Theory\*\*, which suggests that combining verbal information with visual information enhances comprehension and memory.



---



## Features



- Display an English word together with an associated image  
- 4-choice quiz about the meaning of the word  
- Visual and sound feedback for correct and incorrect answers  
- Simple and intuitive UI:
  - **Home → Main (image & quiz loop)**  
  - Fully mouse-controlled

---



## Scenes


### **Home.unity**
- The initial screen of the application.  
- Contains a central “Start” button.  
- Clicking it transitions to the Main scene.

### **Main.unity**
- Displays the image and the 4-choice quiz.  
- **Top-right button:** moves to the next word or next quiz.  
- **Top-left button:** returns to the Home screen.  
- Designed for simple, click-only operation.

---

## Key Scripts (C#)

All scripts are located under `Assets/Scripts/`.

Although this is a small prototype, the structure follows a clean separation of responsibilities:

- **HomeManager.cs**  
  Controls the Home screen and the transition to the Main scene.

- **WordImageManager.cs**  
  Loads and displays the image associated with each word.

- **WordQuizManager.cs**  
  Manages quiz logic, answer checking, feedback, and advancing through questions.

- **EscapeKeyHandler.cs**  
  Handles escape key behavior (used in earlier versions).

- **WordData.cs**  
  Data model for each word, its choices, and the correct answer.

I aimed for clear logic separation and simple, readable C# code suitable for a prototype learning application.

---



## Audio Notice



The original prototype used \*\*VOICEROID (Otomachi Una)\*\* for correct/incorrect voice feedback.  

Due to licensing restrictions, the public version replaces these with \*\*free sound effects\*\*.



No copyrighted audio files are included in this repository.



---



## How to Use



1. Open the project using **Unity 6000.0.47f1** or a compatible version.  
2. Open the **Home.unity** scene from the *Assets* folder.  
3. Press **Play**.  
4. Click “Start” to move to the Main scene.  
5. In the Main scene:
   - Use the **top-right button** to move to the next item  
   - Use the **top-left button** to return to Home  
6. Answer all quiz questions using mouse clicks.

---



## Purpose of the Prototype



- Explore a learning method where English words are understood through \*\*images\*\*, not translation.  

- Experiment with concepts from \*\*Dual Coding Theory\*\* in a practical application.  

- Practice Unity development and C# scripting through building a small but functional prototype.



---



## Repository Structure


Assets/
Scripts/
Images/
Sounds/ (Free SE only)
ProjectSettings/
Packages/



Unnecessary Unity-generated folders (Library, Logs, Temp, etc.) have been removed to keep the repository light and clean.

---

## License

This repository contains only original code and free assets.  
No proprietary audio or commercial assets are included.




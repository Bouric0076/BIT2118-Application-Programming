
---

# **BIT 2118 Application Programming Assignment**  

### **📌 Course:** BIT 2118 – Application Programming  
### **📌 Group:** 5  

## **📖 Project Overview**  
This repository contains **C# solutions** for our **BIT 2118 Application Programming Assignment I**. The project consists of **five programming tasks**, each solving a different problem using C#.  

---

## **📜 Assignment Questions & Solutions**  

### **1️⃣ Game Program (`question-one` Branch)**  
- The user enters the number of rounds to play.  
- For each round, they enter a lucky number.  
- The program checks if the remainder (lucky number ÷ secret number) is:  
  - `0` → **Draw** (+1 point)  
  - **Even number** → **Win** (+3 points)  
  - **Odd number** → **Loss** (-3 points)  
- At the end, it determines if the player **won, lost, or drew**.  

### **2️⃣ Pattern Printing (`pattern-program` Branch)**  
- Uses **nested loops** to print a structured pattern.  
- The diagonal contains `&`, while the rest are `*`.  

### **3️⃣ Credit Worthiness Check (`credit-check` Branch)**  
- Reads **credit limit**, **price**, and **quantity** of items.  
- If the total cost exceeds the limit, the user must re-enter the quantity.  
- Displays an appropriate message based on whether the purchase is allowed.  

### **4️⃣ Area Calculator (`area-calc` Branch)**  
- The user selects a **triangle, rectangle, or circle**.  
- The program calculates the area based on user input.  
- Allows the user **three attempts** in case of an invalid selection.  

### **5️⃣ Sales Report (`question-5` Branch)**  
- Stores sales data for **10 salesmen** selling **5 different items**.  
- Uses **arrays** to calculate:  
  - **Each salesman’s total sales**  
  - **Grand total sales**  
- Displays the report in a tabular format.  

---

## **🛠️ How to Run the Project**  

1. **Clone the repository**  
   ```sh
   git clone <repo-link>
   cd BIT2118-Application-Programming
   ```
2. **Switch to a branch** and run the program  
   ```sh
   git checkout question-one
   dotnet run
   ```
   *(Replace `question-one` with the relevant branch name.)*  

---

## **👥 Contributors (Group Members)**  
| Name | GitHub Username | Role |  
|------|---------------|------|  
| Bouric | `@Bouric0076` | Question 1 |  
| Mark | `@markmatheka` | Question 2 |  
| Caroline | `@Obuya-ai` | Code Review Question 2 |  
| Evans| `ruto-dave90` | Question 3 |  
| Richard | `@username5` | Code Reviiew Question 3 |  
| Duncan | `@DuncanMathai` | Question 4 |  
| Micah | `@username7` | Code Review Question 4 |  
| Brian | `@B-122` | Question 5 |  
| Jessy | `@Jessy12681` | Code Review Question 5 |  

---

## **Collaboration Workflow**  
1. **Pull latest changes**  
   ```sh
   git pull origin main
   ```
2. **Create a new branch for your task**  
   ```sh
   git checkout -b my-task
   ```
3. **Work on the code and commit**  
   ```sh
   git add .
   git commit -m "Implemented game program logic"
   ```
4. **Push your branch to GitHub**  
   ```sh
   git push origin my-task
   ```
5. **Create a Pull Request (PR) on GitHub**  
6. **Review & merge after approval**  

---

## **Notes**
- All group members must **commit their code under their branch**.  
- Use **meaningful commit messages** for better tracking.  
- Before merging, ensure your code **runs without errors**.  

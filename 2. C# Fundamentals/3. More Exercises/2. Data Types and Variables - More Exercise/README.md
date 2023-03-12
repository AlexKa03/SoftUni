
# **More Exercise: Data Types and Variables**


Problems for exercise and homework for the ["C# Fundamentals" course @ SoftUni](https://softuni.bg/trainings/3950/programming-fundamentals-with-csharp-january-2023)
You can check your solutions in [Judge](https://judge.softuni.org/Contests/1271/Data-Types-and-Variables-More-Exercise)

## **1. Data Type Finder**

You will receive input until you receive "**END**". Find what **data type** is the input. Possible data types are:

- Integer 
- Floating point 
- Characters
- Boolean
- Strings

Print the result in the following format: "**{input}** is **{data type}** type".
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>5</p><p>2\.5</p><p>true</p><p>END</p>|<p>5 is integer type</p><p>2\.5 is floating point type</p><p>true is boolean type</p>|
|<p>a</p><p>asd</p><p>-5</p><p>END</p>|<p>a is character type</p><p>asd is string type</p><p>-5 is integer type</p>|

## **2. From Left to the Right**

You will receive a number that represents how many lines we will get as input. On the next N lines, you will receive a string with 2 numbers, separated by a single space. You need to compare them. If the left number is greater than the right number, you need to print the sum of all digits in the left number, otherwise, print the sum of all digits in the right number.
### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|<p>2</p><p>1000 2000</p><p>2000 1000</p>|<p>2</p><p>2</p>|
|<p>4</p><p>123456 2147483647</p><p>5000000 -500000</p><p>97766554 97766554</p><p>9999999999 8888888888</p>|<p>46</p><p>5</p><p>49</p><p>90</p>|

## **3. Floating Equality**
Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers **a** and **b** by a==b, because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more close to each other than some fixed constant eps. 

You will receive two lines, each containing a floating-point number. Your task is to compare the values of the two numbers.
### **Examples**

|**Number a**|**Number b**|**Equal (with precision eps=0.000001)**|**Explanation**|
| :- | :- | :- | :- |
|5\.3|6\.01|False|The difference of 0.71 is too big (> eps)|
|5\.00000001|5\.00000003|True|The difference 0.00000002 < eps|
|5\.00000005|5\.00000001|True|The difference 0.00000004 < eps|
|-0.0000007|0\.00000007|True|The difference 0.00000077 < eps|
|-4.999999|-4.999998|False|Border case. The difference 0.0000001== eps. We consider the numbers are different.|
|4\.999999|4\.999998|False|Border case. The difference 0.0000001 == eps. We consider the numbers are different.|
## **4. Refactoring: Prime Checker**
You are given a program that checks if numbers in a given range [2...N] are prime. For each number is printed "{number} -> {true or false}". The code, however, is not very well written. Your job is to modify it in a way that is easy to read and understand.
### **Code**

|**Sample Code**|
| :-: |
|<p>int \_\_\_Do\_\_\_ = int.Parse(Console.ReadLine());</p><p>for (int takoa = 2; takoa <= \_\_\_Do\_\_\_; takoa++)</p><p>{</p><p>`   `bool takovalie = true;</p><p>`   `for (int cepitel = 2; cepitel < takoa; cepitel++)</p><p>`   `{</p><p>`       `if (takoa % cepitel == 0)</p><p>`       `{</p><p>`          `takovalie = false;</p><p>`          `break;</p><p>`       `}</p><p>`   `}</p><p>Console.WriteLine("{0} -> {1}", takoa, takovalie);</p><p>}</p>|

### **Examples**

|**Input**|**Output**|
| :-: | :-: |
|5|<p>2 -> true</p><p>3 -> true</p><p>4 -> false</p><p>5 -> true</p>|
## **5. Decrypting Messages**
You will receive a **key** (**integer**) and **n** characters afterward. Add the key to each of the characters and append them to a **message**. At the end print the message, which you decrypted. 
### **Input**
- On the **first line,** you will receive the **key.**
- On the **second line,** you will receive **n** – the number of **lines**, which will **follow.**
- On the next **n lines,** you will receive **lower** and **uppercase** characters from the **Latin** alphabet.
### **Output**
Print the **decrypted message**.
### **Constraints**
- The **key** will be in the interval **[0…20].**
- **n** will be in the interval **[1…20].**
- The **characters** will always be **upper** or **lower**-case letters from the **English alphabet.**
- You will receive **one** **letter** per **line.**
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|<p>**3**</p><p>**7**</p><p>P</p><p>l</p><p>c</p><p>q</p><p>R</p><p>k</p><p>f</p>|SoftUni||<p>**1**</p><p>**7**</p><p>C</p><p>d</p><p>b</p><p>q</p><p>x</p><p>o</p><p>s</p>|Decrypt|
## **6. Balanced Brackets**
You will receive **n** lines. On **those** **lines**, you will receive **one** of the following:

- Opening bracket – '**(**',
- Closing bracket – '**)**' or
- **Random string**

Your task is to find out if the **brackets** are **balanced**. That means after every **closing** bracket should follow an **opening** one. Nested parentheses are **not valid** and if **two** **consecutive opening brackets** exist, the expression should be marked as **unbalanced**. 
### **Input**
- On the **first line,** you will receive **n** – the number of lines, which will follow.
- On the next **n** lines, you will receive '**(**',  '**)**' or **another** string.
### **Output**
You have to print "**BALANCED**", if the parentheses are balanced and "**UNBALANCED**" otherwise.
### **Constraints**
- **n** will be in the interval **[1…20].**
- The length of the stings will be between **[1…100]** characters.
### **Examples**

|**Input**|**Output**||**Input**|**Output**|
| :-: | :-: | :-: | :-: | :-: |
|<p>**8**</p><p>(</p><p>5 + 10</p><p>)</p><p>\* 2 +</p><p>(</p><p>5</p><p>)</p><p>-12</p>|BALANCED||<p>**6**</p><p>12 \*</p><p>)</p><p>10 + 2 -</p><p>( </p><p>5 + 10</p><p>)</p><p></p><p></p>|UNBALANCED|




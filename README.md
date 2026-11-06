# Лабораторна робота: Система контролю версій Git

## Опис проєкту
Цей навчальний проєкт створено в рамках виконання практичної (лабораторної) роботи з опанування системи контролю версій **Git** та платформи **GitHub**.

### Автор
- **Студент:** Применко Кирило
- **Дисципліна:** Основи програмної інженерії / Комп'ютерні технології
- **Середовище розробки:** Microsoft Visual Studio, Git Bash, Windows Terminal

---

## Структура репозиторію

| Файл / Каталог | Опис |
| :--- | :--- |
| `GitPracticeApp.sln` | Файл рішення Visual Studio |
| `GitPracticeApp/` | Каталог із вихідним кодом проєкту C# |
| `GitPracticeApp/Program.cs` | Головний модуль програми |
| `GitPracticeApp/GitPracticeApp.csproj` | Файл конфігурації .NET проєкту |
| `.gitignore` | Список виключень файлів компіляції та тимчасових кешів IDE |
| `README.md` | Документація репозиторію у форматі Markdown |

---

## Використані Git команди

1. **Ініціалізація та конфігурація:**
   ```bash
   git init
   git config --global user.name "Kiril Prymenko"
   git config --global user.email "kiril.prymenko@gmail.com"
   ```

2. **Підключення віддаленого сховища:**
   ```bash
   git remote add origin https://github.com/kirilprymenko/GitPracticeApp.git
   git remote add upstream https://github.com/kirilprymenko/GitPracticeApp.git
   ```

3. **Створення гілки та робота з нею:**
   ```bash
   git checkout -b develop
   git commit -m "Feature added in develop branch"
   ```

4. **Злиття в основну гілку:**
   ```bash
   git checkout master
   git merge develop
   ```

---

## Інструкція із запуску
1. Склонувати репозиторій:
   ```bash
   git clone https://github.com/kirilprymenko/GitPracticeApp.git
   ```
2. Відкрити файл `GitPracticeApp.sln` у Visual Studio.
3. Запустити проєкт (`Ctrl + F5`).

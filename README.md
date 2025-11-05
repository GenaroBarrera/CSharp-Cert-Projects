# C#_Cert_Projects

This repository contains a collection of small C# practice projects (each in its own folder) for certification/practice.

## Projects included (top-level folders):

- `P1_IfStatementGame`
- `P2_ImproveRenewalRate`
- `P3_IterationChallange`
- `P4_CreateReadableCode`
- `P5_StudentGradingApp`
- `P6_ChallengeProject`
- `P7_EvaluateAnExpression`
- `P8_CodeBlocksAndVariableScope`
- `P9_SwitchCase`
- `P10_ForLoops`
- `P11_DoAndWhileLoops`
- `P12_Do-WhileVSWhile`
- `P13_StrayPetsProject`
- `P14_Calculator`

## How to use locally
1. Open the solution(s) in Visual Studio (each project has its own `.csproj` or `.sln`).
2. Build and run the project you want to work on.

## Adding new projects
1. Create a new project in Visual Studio:
   - Click "Create New Project"
   - Select your project type (Console App, Class Library, etc.)
   - Set Location to: `C:\Users\thege\Desktop\C#_Cert_Projects`
   - Name it following the pattern: `P14_YourProjectName` (increment the number)
   - Click Create

2. Add it to git:
   ```powershell
   # From repository root
   git add P14_YourProjectName/
   git commit -m "Add P14_YourProjectName"
   git push origin main
   ```

3. Update this README.md:
   - Add your project to the list above
   - Commit and push the README changes

## Working with existing projects
1. Clone the repository:
   ```powershell
   git clone https://github.com/GenaroBarrera/CSharp-Cert-Projects.git
   cd CSharp-Cert-Projects
   ```

2. Open any `.sln` or `.csproj` file in Visual Studio to work on that project.

3. When making changes:
   ```powershell
   git pull origin main  # get latest changes
   git add .            # stage your changes
   git commit -m "Description of your changes"
   git push origin main
   ```

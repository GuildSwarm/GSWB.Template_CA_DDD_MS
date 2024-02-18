# CA_DDD_MS_Template

## How to install the template ##
1-Clone the repo  
2-Run Git Bash CLI as administrator, navigate to the repository root folder and there you will find the clean_install.sh script, execute it "sh clean_install.sh".  
3-Open Visual Studio and make sure you do not have opened any of the template repository files with any other program or VisualStudio itself to avoid problems.  
4-After opening Visual Studio click on Create New Project and in the list of avaliable templates search for "DDD" and select our template. Make sure in the next window the "Place solution and projects in the same directory" checkbox is selected. Also when choosing a path to place this new solution make sure you select the directory containing both Common and TheGoodFramework folders.  
5-Continue selecting the template parameters you wish. After the new project is created from the template run in the DeveloperPowerShell "dotnet restore".  
6-Build the solution and you are ready to work!  

## How to update the installed template after changes in the repository ##
1-Make sure your local repo is up to date(git fetch + git pull)  
2-Run as admin the clean_install.sh script  
3-Now the installed template should be updated so new projects from now will use the new template changes.  

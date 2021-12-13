rm -rf core
git clone https://github.com/fraerSTATA/core.git
dotnet build  $PWD\\Labs.sln --output $PWD/Labs
powershell '(Get-Item  $PWD\bin\Debug\netcoreapp3.1\Labs.dll).VersionInfo.FileVersion' > $PWD/version.txt
read -p "Press enter to continue"
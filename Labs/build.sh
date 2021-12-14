rm -rf core
git clone https://github.com/fraerSTATA/core.git
dotnet build  "$PWD\\Labs.sln" --output "$PWD/build_"
powershell '(Get-Item  $PWD\build_\Labs.dll).VersionInfo.FileVersion' > "$PWD/build_/version.txt"
read -p "Press enter to continue"
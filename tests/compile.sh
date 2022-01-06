#/bin/bash
# this script takes the mds library file and test.cs files and compiles test program into executable. 

execName="test"

mcs test.cs ../mds.cs -out:./build/"${execName}.exe"

printf ""
printf ""
printf "Run the bashscript : run.sh"

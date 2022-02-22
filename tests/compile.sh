#!/bin/bash
# this script takes the mds library file and test.cs files and compiles test program into executable. 

execName="test"

mcs test.cs ../mdserrors.cs ../mds.cs -out:./build/"${execName}.exe"

printf "\n"
printf "\n=====================================\n"
printf "	Run the bashscript : run.sh"
printf "\n=====================================\n"

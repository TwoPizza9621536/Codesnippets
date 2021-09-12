---
layout: post
title: Type Number of Characters Into A File
date: 2021-01-21 16:28:19 -0500
moddate: 2021-09-11 16:17:58 -0500
tags:
  - C
  - C++
  - C#
  - Python
  - Java
  - Kotlin
  - Visual Basic
  - D
  - Fortran
  - Dart
  - Rust
categories:
  - Languages
  - Programming Languages
  - Programming
  - Comparison
toc: true
---

This is page for the snippets shown in .

## C

The download is for Linux.
The snippet below is for Windows.

{% highlight c linenos %}
// Define any preprocessor header files
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

// Entry Point
int main(int argc, char **argv)
{
    // Set variables
    int num = 0;
    char filename[23];

    // Ask how many A's should be written
    // and the name of the file
    printf("How many 'A' should be written to a file: \n");
    scanf("%d", &num);

    printf("What is the name for the file: (Must be 20 characters excluding .txt): \n");
    scanf("%s", filename);

    // Create a file and write to it then close it
    FILE *fptr;

    fptr = fopen(filename, "w");

    for (size_t i = 0; i < num; i++)
    {
        fprintf(fptr, "%c", 'A');
    }

    fclose(fptr);

    // If previous operation completed then press any key to exit
    printf("Operation Completed. Press any to exit.\n");
    getchar();

    return 0;
}
{% endhighlight %}

## C++

{% highlight cpp linenos %}
// Define any preprocessor header files
#include <iostream>
#include <fstream>
#include <string>

// define the standard library unless you name
// your function after std functions

using namespace std;

// Entry point
int main(int argc, char **argv)
{
    // Set variables
    int num = 0;
    string filename;

    // Ask how many A's should be written
    // and the name of the file
    cout << "How many 'A' should be written to a file: " << endl;
    cin >> num;

    cout << "What is the name for the file: " << endl;
    cin >> filename;

    // Create a file and write to it then close it
    ofstream file;

    file.open(filename);

    for (int i = 0; i < num; i++)
    {
        file << 'A';
    }

    file.close();

    // If previous operation completed then press any key to exit
    cout << "Operation Completed. Press any key to exit." << endl;
    cin.ignore();
    cin.get();

    return 0;
}
{% endhighlight %}

## C#

{% highlight csharp linenos %}
// Define any namespace
using System;
using System.IO;

// In CS9 you can write in the Top-level
// below is the entry point

// C# is a Java like language that is closer to Kotlin.

/* namespace program
 * {
 *     public class myclass
 *     {
 *         static void main()
 *         {
 *              Function();
 *         }
 *     }
 * }
 */

// Ask how many A's should be written
// and the name of the file

Console.WriteLine("How many 'A' should be written to a file: ");
string num = Console.ReadLine();

// set varables
int newnum = 0;

// Fast Parsing without quiting
while (!int.TryParse(num, out newnum))
{
    Console.WriteLine("Please enter a positive number:");
    num = Console.ReadLine();
}

Console.WriteLine("What is the name for the file:");
string filename = Console.ReadLine();

// Get directory and add the file name
string currentDirName = Directory.GetCurrentDirectory();
string pathString = Path.Combine(currentDirName, filename);

// Create a file and write to it then close it
using (FileStream fs = File.Create(pathString))
{

    for (int i = 0; i < newnum; i++)
    {
        fs.WriteByte((byte)'A');
    }
}

// If previous operation completed then press any key to exit
Console.WriteLine("Operation Complete. Press any key to exit.");
Console.ReadKey();
}
{% endhighlight %}

## Java

{% highlight java linenos %}
// Define the project as a package to use in other java projects
package io.Printchara;

// Import modules if needed
import java.io.*;
import java.nio.file.*;
import java.nio.ByteBuffer;
import java.nio.channels.FileChannel;
import java.util.Scanner;

// Entry point
public class Main {
    public static void main(String[] args) {
        // Set variables; Java need a package to support inputs.
        Scanner input = new Scanner(System.in);

        // Ask how many 'A' should be written
        // and what is the file name
        System.out.println("How many 'A' should be written to a file: ");
        int num = Integer.parseInt(input.nextLine());

        System.out.println("What is the name for the file: ");
        String filename = input.nextLine();

        // Get directory and add the file name
        String currentDirName = System.getProperty("user.dir");
        Path rootPath = Paths.get(currentDirName);
        Path filePath = Paths.get(filename);
        Path pathString = rootPath.resolve(filePath);

        // Create a file and write to it then close it
        File fs = new File(String.valueOf(pathString));
        try {
            RandomAccessFile stream = new RandomAccessFile(fs, "rw");
            FileChannel channel = stream.getChannel();
            String character = "A";

            for (int i = 0; i < num; i++) {
                byte[] strByte = character.getBytes();
                ByteBuffer buffer = ByteBuffer.allocate(strByte.length);

                buffer.put(strByte);
                buffer.flip();
                channel.write(buffer);
            }
            stream.close();
            channel.close();

        } catch (IOException e) {
            e.printStackTrace();
        }

        System.out.println("Operation Complete. Press Enter to exit.");
        input.nextLine();
        input.close();
    }
}
{% endhighlight %}

## Kotlin

{% highlight kotlin linenos %}
// Kotlin is compatible with Java
// Import modules if needed
import java.io.File
import java.io.IOException
import java.io.RandomAccessFile
import java.nio.ByteBuffer
import java.nio.file.Paths

// Entry point
fun main() {
    // Unlike Java and like C#, Kotlin has it's own input method
    // Ask how many A's should be written
    // and the name of the file
    println("How many 'A' should be written to a file: ")
    val num = Integer.parseInt(readLine())

    println("What is the name name for the file: ")
    val filename = readLine().toString()

    // Get directory and add the file name
    val currentDirName = System.getProperty("user.dir")
    val rootPath = Paths.get(currentDirName)
    val filePath = Paths.get(filename)
    val pathString = rootPath.resolve(filePath)

    // Create a file and write to it then close it
    val fs = File(pathString.toString())
    try {
        val stream = RandomAccessFile(fs, "rw")
        val channel = stream.channel
        val character = "A"
        for (i in 0 until num) {
            val strByte = character.toByteArray()
            val buffer = ByteBuffer.allocate(strByte.size)
            buffer.put(strByte)
            buffer.flip()
            channel.write(buffer)
        }
        stream.close()
        channel.close()
    } catch (e: IOException) {
        e.printStackTrace()
    }

    // If previous operation completed then press any key to exit
    println("Operation Complete. Press Enter to exit.")
    readLine()
}
{% endhighlight %}

## Python

{% highlight python linenos %}
# Define modules if needed
# Python does not need an entry point below is the main
# if **name** == "**main**":

# execute only if run as a script
# name()

# Ask how many A's should be written
# and the name of the file
print("How many 'A' should be written to a file: ")
num = input()

print("What is the name for the file: ")
filename = input()

# Create a file and write to it then close it

with open(filename, 'w+') as f:
for i in range (int(num)):
f.write('A')
i = i + 1

f.close()

# If previous operation completed then press Enter to exit

print("Operation Completed. Press Enter to exit.")
input()
{% endhighlight %}

## Visual Basic

{% highlight visualbasic linenos %}
' Define any namespace
Imports System
Imports System.IO

''' <summery>
''' Visual Basic .Net is almost compatible with C#.
''' The syntax is Visual Basic 6.0 but all of the
''' functions are from the .Net framework.
''' Entry Point similar to Pascal and Fortran.
''' VB is based on Basic if you did not notice already
''' which has an Entry Point that is similar to the
''' two programing languages above.
''' </summery>

' Entry Point
Module Printchara
    Sub Main()
        ' Ask how many 'A' should be written
        ' and the name of the file
        Console.WriteLine("How many 'A' should be written to a file: ")
        Dim num As String = Console.ReadLine()

        ' Set variables
        Dim newnum As Integer = 0

        ' Fast Parsing without quiting
        While Not Integer.TryParse(num, newnum)
            Console.WriteLine("Please enter a positive number: ")
            num = Console.ReadLine()
        End While

        Console.WriteLine("What is the name for the file: ")
        Dim filename As String = Console.ReadLine()

        ' Get directory and add the file name
        Dim currentDirName As String = Directory.GetCurrentDirectory()
        Dim pathString As String = Path.Combine(currentDirName, filename)

        ' Create a file and write to it then close it
        Using fs As Filestream = File.Create(pathString)
            For i As Integer = 0 To newnum
                fs.WriteByte(Convert.ToByte("A"))
            Next i
        End Using

        ' If previous operation completed then press any key to exit
        Console.WriteLine("Operation Complete. Press any key to exit.")
        Console.ReadKey()
    End Sub
End Module
{% endhighlight %}

## Rust

{% highlight rust linenos %}
// import namespace of needed
use std::io;
use std::path::Path;
use std::fs::File;
use std::io::Write;

// Entry point
fn main() {
    // set variables
    let mut num = String::new();
    let mut filename = String::new();
    let mut void = String::new();

    // Ask how many A's should be written
    // and the name of the file
    println!("How many 'A' should be written to a file: ");
    io::stdin()
        .read_line(&mut num)
        .expect("Failed to read line");
    let num: u32 = num.trim().parse().expect("Failed to parse string");

    println!("What is the name for the file: ");
    io::stdin()
        .read_line(&mut filename)
        .expect("Failed to read line");

    let file_path: String = filename.trim().to_string();

    // Create a file and write to it then close
    writefile(file_path, num).expect("Failed to write file");

    // If previous operation completed then press any key to exit
    println!("Operation Completed. Press Enter to exit.");
    io::stdin()
        .read_line(&mut void)
        .expect("Failed to read line");
}

// Have a another function to handle exceptions
fn writefile(filename: String, num: u32) -> std::io::Result<()> {
    // Get directory and add the file name
    let full_path = Path::new(&filename);
    let mut file = File::create(&full_path)?;

    let mut counter = 0;
    while counter < num {
        file.write("A".as_bytes())?;
        counter += 1;
    }
    return Ok(());
}
{% endhighlight %}

## D

{% highlight dlang linenos %}
// Import the standard library components
// This is the similar to c/c++ and alike
// languages
import std.stdio;
import std.string;
import std.file;

void main()
{
    // Set variables
    int num = 0;
    string filename;

    // Ask how many A's should be written
    // and the name of the file
    writeln("How many 'A' should be written to a file: ");
    readf(" %d\n", &num);

    writeln("What is the name for the file: ");
    readf(" %s\n", &filename);

    // Create a file and write to it then close it
    File file = File(filename, "w");

    for (int i = 0; i < num; i++)
    {
        file.write('A');
    }

    writeln("Operation Completed. Press Enter to exit.");
    readln();
}
{% endhighlight %}

## Fortran

For Fortran 90 may be compatible with later fortran.
This is in Fortran 2008 highlighting.

{% highlight fortran linenos %}
! Entry Point
! This is similar to Pascal
program Printchara
    implicit none

    ! Declare variables
    INTEGER :: num
    INTEGER :: i
    CHARACTER(24) :: filename

    ! Ask how many 'A' should be written
    ! and the name of the file
    PRINT *, "How many 'A' should be written to a file: "
    READ(*,*) num

    PRINT *, "What is the name for the file: (Must be 20 characters excluding .txt): "
    READ(*,*) filename

    ! Create a file and write to it then close it
    OPEN(1, file = filename)
    do i = 0, num
        WRITE(1, "(A)", advance='no') 'A'
    end do
    CLOSE(1)

    ! If previous operation completed then press Enter to exit
    PRINT *, "Operation Complete. Press Enter to exit."
    READ(*,*)
end program Printchara
{% endhighlight %}

## Dart

{% highlight dart linenos %}
// import modules if needed
import 'dart:core';
import 'dart:io';

// uncomment this to run it
// import 'package:print_chara/print_chara.dart' as print_chara;

// Entry point
void main() {
    // Ask how many A's should be written
    // and the name of the file
    // Dart is C and javascript like language.

    print("How many 'A' should be written to a file: ");
    var num = stdin.readLineSync();

    var newnum = int.parse(num!);
    assert(newnum is int);

    print('What is the name for the file: ');
    var filename = stdin.readLineSync();

    // Create a file and write to it then close it
    // The writing process is similar to Java/Kotlin
    var file = File(filename!);
    var stream = file.openWrite();
    for (var i = 0; i < newnum; i++) {
        stream.writeCharCode(65);
    }
    stream.close();

    // If previous operation completed then press any key to exit
    print('Complete. Press Enter to exit.');
    stdin.readLineSync();
}
{% endhighlight %}

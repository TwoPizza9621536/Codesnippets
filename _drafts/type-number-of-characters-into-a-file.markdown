---
layout: post
title: Type Number of Characters Into A File
date: 
moddate: 
tags: C C++ C# Python Java Kotlin
categories: Programing Languages
toc:
  enabled: true
---

This is page for the snippets shown in .

## C

{% highlight cpp %}
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

## C++

{% highlight cpp %}
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

## Java

{% highlight java %}
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

{% highlight kotlin %}
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

{% highlight py %}
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

## C#

{% highlight c# %}
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

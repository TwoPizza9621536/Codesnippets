---
layout: post
title: Type n character into a file for Java
date: 2021-01-19 17:44:28 -0500
moddate: 2021-01-19 20:26:57 -0500
slug: type-character-file-java
---

This is a snippet for Syntax highlighting and comparing languages.
Below is the snippet for Java

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

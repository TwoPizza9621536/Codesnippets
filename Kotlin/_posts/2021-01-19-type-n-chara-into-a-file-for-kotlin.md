---
layout: post
title: Type n chara into a file for Kotlin
date: 2021-01-19 20:21:37 -0500
moddate: 2021-01-20 19:31:04 -0500
slug: type-character-file-kotlin
---

This is a snippet for Syntax highlighting and comparing languages.
Below is the snippet for Kotlin.

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

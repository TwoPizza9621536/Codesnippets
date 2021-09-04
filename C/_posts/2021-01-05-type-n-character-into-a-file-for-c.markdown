---
layout: post
title: Type n character into a file for C
date: 2021-01-20 10:11:43 -0500
moddate: 2021-01-20 10:11:43 -0500
slug: type-character-file-c
description: C snippets for the main site.
---

This is a snippet for Syntax highlighting and comparing languages.
Below is the snippet for C.

Depending on your OS you will need to change the
file for press any key to continue.

This snippet is for MSDOS/Windows and the file is for Unix/Linux.

{% highlight c %}
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

[Click Here]({{ "../assets/src/C/Printchara.c" | relative_url }}){:target="blank"}
to download the file.

---
layout: post
title: Type n character into a file for Python
slug: type-character-file-python
date: 2021-01-19 20:21:37 -0500
moddate: 2021-01-20 19:31:04 -0500
---

This is a snippet for Syntax highlighting and comparing languages.
Below is the snippet for Python

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

[Click Here]({{ "assets/src/Python/Printchara.py" | relative_url }}){:target="blank"} to download the file.

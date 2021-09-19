#!/usr/bin/env ruby
# encoding: utf-8
# SPDX-FileCopyrightText: Copyright (c) 2021 Sam W
# SPDX-License-Identifier: MIT
=begin
Copyright (c) 2021 Sam W

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to
deal in the Software without restriction, including without limitation the
rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
sell copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
IN THE SOFTWARE.
=end

# Define modules if needed

# Ruby does not need an entry point because it is both
# a scripting language and programming language like Python

# Ask how many A's should be written
# and the name of the file

# Make STDOUT flush every time
STDOUT.sync = :yes

# Ask how many A's should be written
# and the name of the fil
puts "How many 'A' should be written to a file: "
num = gets.chomp
newnum = num.to_i

puts "What is the name for the file: "
filename = gets.chomp

# Create a file and write to it then close it
File.open(filename, 'w') do |f|
  i = 0
  while i < newnum
    f.print "A"
    i += 1
  end
end

# If previous operation completed then press Enter to exit
puts "Operation Completed. Press Enter to exit."
gets.chomp

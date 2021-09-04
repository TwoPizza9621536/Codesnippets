#include <iostream>
#include <cstdlib>
#include <ctime>

int bottles = 99;

int random()
{
  srand(time(0));
  return (rand() % 100) + 1;
}

void verse(int bottles)
{
  std::cout << bottles << " bottles of beer on the wall,\n";
  std::cout << bottles << " bottles of beer.\n";
  if (random() > 80)
  {
    std::cout << "If one of those bottles should happen to fall,\n";
    std::cout << bottles - 1 << " bottles of beer on the wall.\n\n";
  }
  else if (random() < 20)
  {
    std::cout << "If that one bottle should happens to fall,\n";
    std::cout << "what a waste of alcohol!\n\n";
  }
  else
  {
    std::cout << "Take one down and pass it around.\n";
    std::cout << bottles - 1 << " bottles of beer on the wall.\n\n";
  }
}

int infiniteBottles()
{
  verse(0);
  return -1;
}

int ending(int bottles, bool waste)
{
  if ((random() == 100) && (bottles == 1))
  {
    if (waste)
    {
      std::cout << "what a waste of alcohol!\n\n";
    }
    else
    {
      std::cout << "No more bottles of beer on the wall.\n\n";
    }
    bottles = infiniteBottles();
  }
  else
  {
    if (waste)
    {
      std::cout << "what a waste of alcohol!\n\n";
    }
    else
    {
      std::cout << "No more bottles of beer on the wall.\n\n";
    }

    std::cout << "No more bottles of beer on the wall,\n";
    std::cout << "no more bottles of beer.\n";
    if (random() <= 60)
    {
      bottles = 0;
      if (random() <= 10)
      {
        std::cout << "There's nothing else to fall,\n";
        std::cout << "because there's no more bottles of beer on the wall."
                  << "\n\n";
      }
      else
      {
        std::cout << "We've taken them down and passed them around;\n";
        std::cout << "now we're drunk and passed out!\n\n";
      }
    }
    else
    {
      bottles = 99;
      std::cout << "Go the the store and buy some more,\n";
      std::cout << bottles << " bottles of beer on the wall.\n\n";
    }
  }

  return bottles;
}

int main()
{
  while (bottles != 0)
  {
    bool ifWaste = false;
    while (1 < bottles || bottles <= -1)
    {
      verse(bottles);
      bottles--;
    }

    std::cout << bottles << " bottle of beer on the wall,\n";
    std::cout << bottles << " bottle of beer.\n";
    if (random() > 80)
    {
      std::cout << "If that one bottle should happens to fall,\n";
      if (random() < 20)
      {
        ifWaste = true;
      }
    }
    else
    {
      std::cout << "Take one down and pass it around.\n";
    }

    bottles = ending(bottles, ifWaste);
  }
}

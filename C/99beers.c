#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <sys/types.h>

int bottles = 99;

long random()
{
  return (rand() % 101);
}

void verse(int bottles)
{
  srand(getpid());
  printf("%d bottles of beer on the wall,\n", bottles);
  printf("%d bottles of beer.\n", bottles);
  if (random() > 80)
  {
    printf("If one of those bottles should happen to fall,\n");
    printf("%d bottles of beer on the wall.\n\n", bottles - 1);
  }
  else if (random() < 20)
  {
    printf("If that one bottle should happens to fall,");
    printf("what a waste of alcohol!\n\n");
  }
  else
  {
    printf("Take one down and pass it around.\n");
    printf("%d bottles of beer on the wall.\n\n", bottles - 1);
  }
}

int infiniteBottles()
{
  verse(0);
  return -1;
}

int endingPartTwo()
{
  if (random() <= 60)
  {
    bottles = 0;
    if (random() <= 10)
    {
      printf("There's nothing else to fall,\n");
      printf("because there is no more bottle of beer left on the wall.\n\n");
    }
    else
    {
      printf("We've taken them down and passed them around;\n");
      printf("now we're drunk and passed out!\n\n");
    }
  }
  else
  {
    bottles = 99;
    printf("Go the the store and buy some more,\n");
    printf("%d bottles of beer on the wall.\n\n", bottles);
  }
  return bottles;
}

int endingPartOne(int bottles, bool waste)
{
  if ((random() == 100) && (bottles == 1))
  {
    if (waste)
    {
      printf("what a waste of alcohol!\n\n");
    }
    else
    {
      printf("No more bottles of beer on the wall.\n\n");
    }
    bottles = infiniteBottles();
  }
  else
  {
    if (waste)
    {
      printf("what a waste of alcohol!\n\n");
    }
    else
    {
      printf("No more bottles of beer on the wall.\n\n");
    }

    printf("No more bottles of beer on the wall,\n");
    printf("No more bottles of beer.\n");
  }

  return endingPartTwo();
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

    printf("%d bottles of beer on the wall,\n", bottles);
    printf("%d bottles of beer.\n", bottles);
    if (random() > 80)
    {
      printf("If that one bottle should happen to fall,\n");
      if (random() < 20)
      {
        ifWaste = true;
      }
    }
    else
    {
      printf("Take one down and pass it around.\n");
    }

    bottles = ending(bottles, ifWaste);
  }
}

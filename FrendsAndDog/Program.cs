using System;

int distance = 10000;
int count = 0;
int firstFriendSpeed = 1;
int secondFriendSpedd = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpedd + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpedd) * time;
count = count + 1;
}
Console.Write(count);
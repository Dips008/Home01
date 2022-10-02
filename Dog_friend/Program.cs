int count = 0;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
int distance = 10000;
int friend = 2;
int time = 0;
while (distance > 10)
{
    if (friend == 2)
    {
        time = distance / (DogSpeed + SecondFriendSpeed);
        distance = distance - time * (FirstFriendSpeed + SecondFriendSpeed);
        count++;
        friend = 1;
    }
    if (friend == 1)
    {
        time = distance / (DogSpeed + FirstFriendSpeed);
        distance = distance - time * (FirstFriendSpeed + SecondFriendSpeed);
        count++;
        friend = 2;
    }
}
Console.WriteLine("Собака пробежала : " + count + " раз");
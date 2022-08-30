int count = 0;
double distance = 10000;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_speed = 5;
int friend = 2;
double time = 0;

while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (first_friend_speed + dog_speed);
        friend = 2;
    }
    else
    {
        time = distance / (second_friend_speed + dog_speed);
        friend = 1;
    }
    distance = distance - (first_friend_speed + second_friend_speed) * time;
    Console.Write(count);
    Console.Write(" итерация; distance = ");
    Console.WriteLine("{0:F2}", distance);
    count++;
}    

Console.Write("Собака пробежала ");
Console.Write(count);
Console.Write(" раз.");
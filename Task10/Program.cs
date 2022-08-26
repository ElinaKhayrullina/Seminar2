//Задача 10:Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.

/*
int SecondNumber(){
    int num=new Random().Next(100,1000);
    Console.WriteLine("Your number is + "+ num);
    int dec=num/10;
    int ed=dec%10;
    return ed;
}
Console.WriteLine("Second number of input number is "+SecondNumber());
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void ThirdNumber(int num){
    int numForResult=num;
    int count =0;
    int dec=0;
    int ed=0;
    int positiveNumber=0;
    if(num<0){
        positiveNumber=num*(-1);

    while (positiveNumber>0){
        positiveNumber = positiveNumber/10;
        count++;
}}
    else if(num>0){

    while (num>0){
        num = num/10;
        count++;
}}

    if (count<3){
        Console.WriteLine("Number "+ numForResult+" hasn't third number");
 }
    else if (count==3){
        dec = numForResult%10;
        Console.WriteLine("Number "+ numForResult+" has third number is "+ dec);
 }
    else if (count>3){
        int v=count-4;
        int i=0;
        int result=0;
        result=numForResult/10;
        while (i<v){
            result=result/10;
            i++;
    }
        int result1=result%10;
        if(result1<0){
            result1=result1*(-1);
    }
        Console.WriteLine("Number "+ numForResult+" has third number is "+ result1);
 }
      
}

Console.WriteLine("Input any integer: ");
int num=Convert.ToInt32(Console.ReadLine());

ThirdNumber(num);
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
/*
void NumberOfWeek(int num){
    if (num<6){
        Console.WriteLine("This number of week - "+num+" isn't weekend");
    }
    else{
        Console.WriteLine("This number of week - "+num+" is weekend");
    }
}

Console.WriteLine("Input number of day of week: ");
int num=Convert.ToInt32(Console.ReadLine());
if (num<1||num>7){
    Console.WriteLine("You have input incorrect number of week, try again (from 1 to 7");
}
else{
    NumberOfWeek(num);
}
*/


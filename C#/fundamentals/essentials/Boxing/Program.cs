// See https://aka.ms/new-console-template for more information
//Box some string data into a variable
object BoxedData = "This is clearly a string";
//Make sure it is the type you need before proceeding
if (BoxedData is int) {
    //This shouldn't run
    Console.WriteLine("I guess we have an integer value in this box?");
}
if (BoxedData is string) {
    Console.WriteLine("It is totally a string in the box!");
}

List<object> boxedData = new List<object>{};

boxedData.Add(7);
boxedData.Add(28);
boxedData.Add(-1);
boxedData.Add(true);
boxedData.Add("chair");

foreach (object box in boxedData)
{
        Console.WriteLine(box);
}

int sum = 0;

foreach (object box in boxedData)
{
    if (box is int)
    {
        int intBox = (int)box;
        sum += intBox;
    }
}

Console.WriteLine(sum);


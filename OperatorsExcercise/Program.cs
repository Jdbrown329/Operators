{
    int a = 17, b = 4;
    int quotient = a / b;
    int remainder = a % b;

    Console.WriteLine($"Seventeen divided by four is {quotient} and has a remainder of {remainder}.");
}
{
    Console.WriteLine("Please enter the radius of your circle");
    
    var radius = double.Parse(Console.ReadLine());
    
    double answer = Math.PI * Math.Pow(radius, 2);

    return; Console.WriteLine($"The area of your circle is {answer}");

}

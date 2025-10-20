// Provide the answers to each of your class test
// questions in the relevant classes that are shown in the solution
// explorer. The tabs are also all open for you to use.

using CW1_template;

internal class CW1
{
    static void Main(string[] args)
    {
        //----------------------
        // Do not edit the code
        // inside the Main method
        // Answer your questions within the 
        // relevant Question section below
        //----------------------
        Question1.question1();
        Question2.question2();
        Question3.question3();
        Question4.question4();
        Product product = new Product(1, "Tablet", 1300.50, 4);
        product.DisplayProductInfo();

        Product product1 = new Product(2, "Smartphone", 712.50, 12);
        product1.DisplayProductInfo();

        Question5.question5();
        Question6.question6();
        product.CheapestProduct();

    }
}


    



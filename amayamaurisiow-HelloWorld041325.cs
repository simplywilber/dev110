/********************************************************************* 
*    Course:     DEV 110 
*    Instructor: Phil Duncan
*    Term:       Spring 2025
*
*    Programmer: Wilber Amaya-Maaurisio
*    Assignment: HelloWorld
*    
*    Description:
*    This is a basic Hello World Program
*    It writes a signed hello world statment
*    from me onto the console
*    
*    
* 
*    Revision    Date               Release Comment 
*    --------     ----------        ------------------------------------------------------ 
*    1.0         04/13/2023         Initial Release 
*    1
* 
*/

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World! It's me!! \n- signed Wilber Amaya-Maurisio");
            System.Console.WriteLine("Press any key to continue . . .");
            System.Console.ReadKey();
        }
    }
}

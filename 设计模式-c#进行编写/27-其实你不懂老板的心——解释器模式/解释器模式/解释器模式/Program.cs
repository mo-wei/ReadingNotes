using System;
using 解释器模式.解释器语法;
namespace 解释器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayContext playContext = new PlayContext();

            playContext.Context = "T 500 O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 G 1 C 0.5 ";

            Expression expression = null;

            try
            {
                while(playContext.Context.Length > 0)
                {
                    string str = playContext.Context.Substring(0, 1);
                    switch(str)
                    {
                        case "O":
                            expression = new Scale();
                            break;
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                        case "A":
                        case "B":
                        case "P":
                            expression = new Note();
                            break;
                        case "T":
                            expression = new Speed();
                            break;
                    }
                    expression.Interpret(playContext);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}

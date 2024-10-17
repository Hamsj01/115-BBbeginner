namespace Project10_ErrorHandling;

class Program
{
    static void Main(string[] args)
    {
      #region Try Catch Syntax
      try
      {
        
      }
      catch (System.Exception)
      {
        
        throw;
      }

        #endregion

        #region Try Catch
        int number1 = default;
        int number2 = default;
        string result = default;
        try
        {
            System.Console.Write("1.Sayı: ");
             number1 = int.Parse(Console.ReadLine());
            System.Console.Write("2.Sayı: ");
             number2 = int.Parse(Console.ReadLine());
             result = (number1 / number2).ToString();
            System.Console.WriteLine(result);

        }
        catch (FormatException ex) //format hatası için (formatexception)
        {
            result= "Lütfen geçerli bir değer giriniz!"; 
        }
        catch (OverflowException)
        {
            result = $"Lütfen {int.MinValue}-{int.MaxValue} arasında bir değer giriniz.";
        }
        catch (DivideByZeroException)
        {
            result= $"0 girdiğiniz için default olarak 1'e bölme işlemi yapıldı.\n{number1.ToString()}";
            System.Console.WriteLine();
        }
        catch (Exception ex) 
        {
        result=ex.Message;
        }
        finally
        {
            System.Console.WriteLine(result);
        }
        System.Console.WriteLine("Program sona erdi...");
      #endregion
    }
}

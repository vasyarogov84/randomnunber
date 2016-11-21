
using System;
class favFoods

{
static void Main()
{
  Random rnd = new Random();

string[] favFoods =  {"a","q","w","e","r","t","y","u","i","g"};
 for (int index = 0; index < favFoods.Length; index++)
   {
     if(index <5){
       int month = rnd.Next(1, 10);
     Console.WriteLine("I am eating:" + favFoods[month]);
   } else {
      Console.WriteLine("I am full");
      break;
   }
   }

   }
 }

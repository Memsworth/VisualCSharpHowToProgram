namespace VisualCSharpHowToProgram.ChapterTen;

public static class IntegerSetTest
{
   private static IntegerSet Union(IntegerSet setOne, IntegerSet setTwo)
   {
       var unionSet = new IntegerSet();
       for (int i = 0; i < unionSet.IntSet.Length; i++)
       {
           if (setOne.IntSet[i] || setTwo.IntSet[i])
           {
               unionSet.InsertElement(i);
           }
       }
       
       return unionSet;
   }

   private static IntegerSet Intersection(IntegerSet setOne, IntegerSet setTwo)
   {
       var intersectionSet = new IntegerSet();
       for (int i = 0; i < intersectionSet.IntSet.Length; i++)
       {
           if (setOne.IntSet[i] && setTwo.IntSet[i])
           {
               intersectionSet.InsertElement(i);
           }
       }
       
       return intersectionSet;
   }

   public static bool IsEqualTo(IntegerSet setOne, IntegerSet setTwo) =>
       !setOne.IntSet.Where((t, i) => t != setTwo.IntSet[i]).Any();
       

  public static void RunProgram()
  {
        var rand = new Random();
        var mySet = new IntegerSet();
        var mySet2 = new IntegerSet();
        
        for (int i = 0; i < 50; i++)
        {
            
            mySet.InsertElement(rand.Next(0,100));
            mySet2.InsertElement(rand.Next(0,100));
        }
        
        Console.WriteLine(mySet);
        Console.WriteLine(mySet2);
        Console.WriteLine(Intersection(mySet, mySet2));
    }
    
    
}
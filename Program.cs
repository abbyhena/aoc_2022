var caloriesList = new List<string>(); 
var caloriesNum = new List<int>();
bool res;
int number;
int total = 0;
 
foreach (string line in System.IO.File.ReadLines(@"/Users/dd/aoc_2022/input.txt"))
{  
    
   caloriesList.Add(line);
    
}  
foreach (string line in caloriesList)
{
      res = int.TryParse(line, out number);
      if (res == true)
      {
        total = total + number;
      }
      else if (res == false)
      {
        //Console.WriteLine(total);
        caloriesNum.Add(total);
        total = 0;
      }
}
var max = caloriesNum.Max();
Console.WriteLine(max);
//first part answer
var secondMax = caloriesNum.OrderByDescending(x => x).ToArray()[1]; 
//Console.WriteLine(secondMax);
var thirdMax = caloriesNum.OrderByDescending(r => r).ToArray()[2];
//Console.WriteLine(thirdMax);
var finalMax = max + secondMax + thirdMax;
//second part answer
Console.WriteLine(finalMax);


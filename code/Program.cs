using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\havli\Webs\Advent2022\Task10\Task10.txt");


            int twenty = 0;
            int sixty = 0;
            int onehundred = 0;
            int oneforty = 0;
            int oneeighty = 0;
            int twotwenty = 0;

            int X = 1;
            int cycle = 0;
            foreach (string line in text)
            {

                int num;
                if (line.Contains("noop"))
                {
                    num = 1;
                }
                else
                {
                    num = Convert.ToInt32(Regex.Match(line, @"\d+").Value);
                }

                for (int i = 0; i < num; i++)
                {
                    if (line.Contains("-"))
                    {
                        cycle -= 1;
                    }
                    else
                    {
                        cycle += 1;
                    }

                    if (cycle == 20 && twenty == 0)
                    {
                        twenty = X;
                        Console.WriteLine(twenty);
                    }

                    if (cycle == 60 && sixty == 0)
                    {
                        sixty = X;
                        Console.WriteLine(sixty);
                    }

                    if (cycle == 100 && onehundred == 0)
                    {
                        onehundred = X;
                        Console.WriteLine(onehundred);
                    }

                    if (cycle == 140 && oneforty == 0)
                    {
                        oneforty = X;
                        Console.WriteLine(oneforty);
                    }

                    if (cycle == 180 && oneeighty == 0)
                    {
                        oneeighty = X;
                        Console.WriteLine(oneeighty);
                    }

                    if (cycle == 220 && twotwenty == 0)
                    {
                        twotwenty = X;
                        Console.WriteLine(twotwenty);
                    }


                }
                if (line.Contains("-"))
                {
                    X -= num;
                }
                else
                {
                    X += num;
                }







            }


































































            /*                                                    ///////////////////////////////////////////////////////  TASK 9 1/2
                         int[,] array = new int[1000, 1000];
                        char[,] playground = new char[1000, 1000];

                        for (int i = 0; i < playground.GetLength(0); i++)
                        {
                            for (int j = 0; j < playground.GetLength(1); j++)
                            {
                                playground[i, j] = ' ';
                            }
                        }

                        array[500, 500]++;

                        int index1 = 500, index2 = 500, index3 = 500, index4 = 500;



                        foreach (string line in text)
                        {
                            int num = Convert.ToInt32(Regex.Match(line, @"\d+").Value);
                            for (int i = 0; i < playground.GetLength(0); i++)
                            {
                                for (int j = 0; j < playground.GetLength(1); j++)
                                {
                                    playground[i, j] = ' ';
                                }
                            }
                            playground[index3, index4] = 'T';



                            if (line.Contains("L"))
                            {
                                for (int i = num; i > 0; i--)
                                {
                                    index2--;
                                    if (!isThere(index1, index2))
                                    {

                                        playground[index1, index2 + 1] = 'T';
                                        array[index1, index2 + 1]++;
                                        index3 = index1;
                                        index4 = index2 + 1;

                                    }
                                }
                            }
                            if (line.Contains("R"))
                            {
                                for (int i = 0; i < num; i++)
                                {
                                    index2++;
                                    if (!isThere(index1, index2))
                                    {

                                        playground[index1, index2 - 1] = 'T';
                                        array[index1, index2 - 1]++;
                                        index3 = index1;
                                        index4 = index2 - 1;

                                    }
                                }

                            }
                            if (line.Contains("U"))
                            {
                                for (int i = num; i > 0; i--)
                                {
                                    index1--;
                                    if (!isThere(index1, index2))
                                    {

                                        playground[index1 + 1, index2] = 'T';
                                        array[index1 + 1, index2]++;
                                        index3 = index1 + 1;
                                        index4 = index2;
                                    }
                                }
                            }
                            if (line.Contains("D"))
                            {
                                for (int i = 0; i < num; i++)
                                {
                                    index1++;
                                    if (!isThere(index1, index2))
                                    {
                                        playground[index1 - 1, index2] = 'T';
                                        array[index1 - 1, index2]++;
                                        index3 = index1 - 1;
                                        index4 = index2;

                                    }
                                }


                            }


                        }
                        int max = 0;
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                if (array[i, j] > 0)
                                {
                                    max++;
                                }
                            }
                        }
                        Console.WriteLine(max);


                        bool isThere(int num, int num2)
                        {

                            Console.WriteLine(num.ToString() + " " + num2);
                            if (playground[num - 1, num2] != ' ')
                            {

                                return true;
                            }

                            if (playground[num - 1, num2 - 1] != ' ')
                            {
                                return true;
                            }
                            if (playground[num - 1, num2 + 1] != ' ')
                            {
                                return true;
                            }
                            if (playground[num + 1, num2 + 1] != ' ')
                            {
                                return true;
                            }
                            if (playground[num + 1, num2 - 1] != ' ')
                            {
                                return true;
                            }


                            if (playground[num + 1, num2] != ' ')
                            {

                                return true;
                            }
                            if (playground[num, num2 + 1] != ' ')
                            {

                                return true;
                            }
                            if (playground[num, num2 - 1] != ' ')
                            {

                                return true;
                            }
                            if (index3 == num && index4 == num2)
                            {
                                return true;
                            }


                            return false;
                        }

            */                                   ///////////////////////////////////////////////////////














            /*                                                          ////////////////////////////////////////    TASK 8 2/2
                         List<List<char>> myList = new List<List<char>>();
            List<int> scenic = new List<int>();
            int Final_Count = 0;
            int index = 0;
            foreach(string line in text)
            {

                
                myList.Add(new List<char> { });

                foreach (char c in line)
                {
                    myList[index].Add(c);
                }
                index++;
               
            }

            int pos = 0;
            foreach (List<char> list in myList)
            {


                
                for (int i = 0; i < list.Count; i++)
                {

                    if (pos == 0)
                    {
                        Final_Count++;
                        continue;
                    }
                    if (i == 0)
                    {
                        Final_Count++;
                        continue;
                    }
                    if (i == list.Count - 1)
                    {
                        Final_Count++;
                        continue;
                    }
                    if (pos == myList.Count - 1)
                    {
                        Final_Count++;
                        continue;
                    }


                    bool reset = false;
                    List<bool> sides = new List<bool>();
                    List<int> nums = new List<int>();
                    
                    sides.Add(false);
                    sides.Add(false);
                    sides.Add(false);
                    sides.Add(false);
                    // LEFT
                    int counter = 0;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        counter++;
                        if ((list[j] - '0') >= (list[i] - '0'))
                        {
                            sides[0]=true;
                           
                            break; 
                        }
                       
                    }
                    nums.Add(counter);
                    //RIGHT
                    counter = 0;
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        counter++;
                        if ((list[j] - '0') >= (list[i] - '0'))
                        {
                            sides[1] = true;
                            

                            break;
                        }
                        
                    }
                    nums.Add(counter);

                    //TOP
                    counter = 0;
                    for (int k = pos - 1; k >= 0; k--)
                    {
                        counter++;
                        if ((myList[k][i] - '0') >= (list[i] - '0'))
                        {
                            sides[2] = true;
                            

                            break;
                        }
                      
                    }
                    nums.Add(counter);
                    //BOTTOM
                    counter = 0;
                    for (int k = pos + 1; k < myList.Count; k++)
                    {
                        counter++;
                        if ((myList[k][i] - '0') >= (list[i] - '0'))
                        {
                            sides[3] = true;
                         

                            break;
                        }
                        
                    }
                    nums.Add(counter);


                    int final = 1;
                    foreach (int x in nums)
                    {
                        final *= x;
                        Console.Write(x + " ");

                    }
                    Console.WriteLine();
                    scenic.Add(final);

                    foreach(bool side in sides)
                    {
                        
                        if (!side)
                        {
                            Final_Count++;
                            break;
                        }
                    }
                   




                }
                pos++;
                Console.WriteLine();
            }
            Console.WriteLine(scenic.Max());
            Console.WriteLine(Final_Count);
             
             */     //////////////////////////////////////////////
















            /*                      /////////////////////////////////////////// Task 1/2
             *                      
             *                      int size = 0;

            List<int> sums = new List<int>();
            List<int> smallest = new List<int>();


            foreach (string line in text)
            {
                if (line.Contains("$ cd "))
                {
                    if (line == "$ cd ..")
                    {
                        if (sums[sums.Count - 1] < 100000)
                        {
                            size += sums[sums.Count - 1];
                         
                            
                            
                            sums.RemoveAt(sums.Count - 1);
                        }

                      
                      
                    }
                    else
                    {
                        sums.Add(0);

                    }
                }
                else
                {
                    if (line == "$ ls")
                    {
                        continue;
                    }

                    if (char.IsDigit(line[0]))
                    {
                        string value = "";


                        int i = 0;
                        while(line[i] != ' ')
                        {
                            value += line[i];

                            i++;
                        }

                        sums[sums.Count - 1] += Convert.ToInt32(value);

                        for (int x = 0; x < sums.Count - 1; x++)
                        {
                            sums[x] += sums[sums.Count - 1];
                            if (sums[x] >= 30000000)
                            {
                                
                                smallest.Add(sums[x]);
                            }
                          
                        }
                      


                    }
                }

            }


            Console.WriteLine(smallest.Min(min => min));
            Console.WriteLine(size);
             */                    //////////////////////////////////////////////////


















            /*int score = 0;                          //////////////////////////////////////////////////    TASK 6 2/2
            string packet = "";
            foreach(string line in text)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (packet.Contains(line[i]))
                    {
                        packet = "";
                        score++;
                        i = score - 1;
                        continue;

                    }
                    else
                    {
                        packet += line[i];
                        if (packet.Length == 14)
                        {
                            Console.WriteLine(score);
                            Console.WriteLine(packet);
                            break;
                        }
                    }
                    
                    
                }
            }*/                                    //////////////////////////////////////////////////












            /*            List<char>[] arrayList = new List<char>[9].Select(item => new List<char> {}).ToArray();               /////////////////////   task 5 2/2



            foreach(string line in text)
            {
                if (line[1] == '1')
                {
                    foreach (var list in arrayList)
                    {
                        foreach (var element in list)
                        {
                            Console.Write(element);
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                int position = 0;
                for (int i = 1; i <= 36; i += 4)
                {
                    if (line[i] != ' ')
                    {
                        arrayList[position].Insert(0, line[i]);

                    }
                    position++;
                }
               
            }

            string count = "";
            string start = "";
            string target = "";
          
            foreach(string line in text)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == 'm' && count == "")
                    {
                        for (int j = i + 5; line[j] != ' '; j++)
                        {
                            Console.Write(line[j]);
                            count += line[j];
                            
                        }
                       
                    }

                    if (line[i] == 'f')
                    {
                        for (int j = i + 5; line[j] != ' '; j++)
                        {
                            Console.Write(line[j]);

                            start += line[j];
                           
                        }
                    }

                    if (line[i] == 't')
                    {
                        Console.Write(line[i + 3]);

                        target += line[i + 3];
                    }
                }
                Console.WriteLine();

              

                if (start != "")
                {

                    /*         for (int i = arrayList[Convert.ToInt32(start) - 1].Count; count != "0"; i--)
                             {

                                 arrayList[Convert.ToInt32(target) - 1].Add(arrayList[Convert.ToInt32(start) - 1][i - 1]);
                                 arrayList[Convert.ToInt32(start) - 1].RemoveAt(arrayList[Convert.ToInt32(start) - 1].Count - 1);


                                 count = (Convert.ToInt32(count) - 1).ToString();
                             }

            int position = arrayList[Convert.ToInt32(start) - 1].Count;

            int check = Convert.ToInt32(count);
            while (check > 0)
            {

                arrayList[Convert.ToInt32(target) - 1].Add(arrayList[Convert.ToInt32(start) - 1][position - Convert.ToInt32(count)]);
                Console.WriteLine(arrayList[Convert.ToInt32(start) - 1][position - Convert.ToInt32(count)]);
                arrayList[Convert.ToInt32(start) - 1].RemoveAt(position - Convert.ToInt32(count));



                check--;
            }


        }


        count = "";
                start = "";
                target = "";
            }


            foreach (var list in arrayList)
            {
                foreach (var element in list)
                {
                    Console.Write(element);
                }
Console.WriteLine();
            }*/                                   ////////////////////////////////////////////////////










            /*  int score = 0;                ///////////////////////////// TASK 4
            int[] pole = new int[] {0,0,0,0};
           
            foreach (string line in text)
            {
             
                int pointer = 0;
                string num = "";
                foreach(char c in line)
                {

                    if (c == '-' || c == ',')
                    {
                        pole[pointer] = Convert.ToInt32(num);
                       
                        num = "";
                        pointer++;
                        continue;
                    }
                    num += c;

                    if (pointer > 2)
                    {
                        int i = line.Length - 1;
                        num = "";
                        do
                        {
                           
                            num = line[i] + num;
                            i--;
                          
                        } while (line[i] != '-');
                        pole[3] = Convert.ToInt32(num);

                        break;
                    }

                }
              
                if (pole[1] >= pole[2])
                {
                   

                    if (pole[3] < pole[0])
                    {
                        foreach (int i in pole)
                        {
                            Console.Write(i + " ");
                        }
                        Console.Write("\n no \n");

                        continue;
                    }

                   

                    foreach (int i in pole)
                    {
                        Console.Write(i + " ");
                    }
                    Console.Write("\n YES \n");
                    score++;
                    continue;
                 
                }


                /*   if (pole[0] <= pole[2] && pole[1] >= pole[3])
                   {
                       foreach(int i in pole)
                         {
                             Console.Write(i + " ");   
                         }
                         Console.Write("\n");

                       score++;
                       continue;
                   }
                   if (pole[0] >= pole[2] && pole[1] <= pole[3])
                   {
                      foreach(int i in pole)
                      {
                          Console.Write(i + " ");   
                      }
                      Console.Write("\n");
                       score++;
                       continue;
                   }

                   Console.Write("\n");

            pole = new int[] { 0, 0, 0, 0 };

        }

        Console.WriteLine(score);*/           ///////////////////////////// 

























            /*    string alphabet = "abcdefghijklmnopqrstuvwxyz";                                /////////////// TASK 3 2/2
            var sum = 0;


            
            string firstRucksacks = "";
            string secondRucksacks = "";
            string thirdRucksacks = "";

            for (int i = 0; i < text.Length; i += 3)
            {
                firstRucksacks = text[i];
                secondRucksacks = text[i + 1];
                thirdRucksacks = text[i + 2];


                foreach(char c in firstRucksacks)
                {
                    if (secondRucksacks.Contains(c) && thirdRucksacks.Contains(c))
                    {
                        if (Char.IsUpper(c))
                        {
                            if (c == 'A')
                            {
                                sum += alphabet.IndexOf(Char.ToLower(c)) + 26 + 1;

                            }
                            else
                            {
                                sum += alphabet.IndexOf(Char.ToLower(c)) + 26 + 1;

                            }
                            break;
                          
                        }
                        else
                        {


                            sum += (alphabet.IndexOf(Char.ToLower(c)) + 1);

                            
                        }
                        break;
                    }
                    
                }
                firstRucksacks = "";
                secondRucksacks = "";
                thirdRucksacks = "";
            }
            Console.Write(sum);                           //////////////////////////////////////////////
*/




            /* foreach(string line in text)                  /////////////////////////////////////       Task 3  1/2
            {
                var firstHalf = line.Substring(0, line.Length / 2);
                var secondHalf = line.Substring(line.Length / 2);


                foreach(char c in firstHalf)
                {
                    if (secondHalf.Contains(c))
                    {
                        if (Char.IsUpper(c))
                        {
                            if (c == 'A')
                            {
                                sum += alphabet.IndexOf(Char.ToLower(c)) + 26 + 1;
                                
                            }
                            else
                            {
                                sum += alphabet.IndexOf(Char.ToLower(c)) + 26 + 1;

                            }
                            break;
                        }
                        else
                        {
                           

                            sum += (alphabet.IndexOf(Char.ToLower(c)) + 1);
                            
                            break;
                        }
                    }
                }

                
            }
            Console.WriteLine(sum);*/                        /////////////////////////////////////
































            /*    int score = 0;                             ///////////  TASK 2
                // A = Rock
                // B = Paper
                // C = Scissors
                foreach(string line in text)
                {
                    if (line[0] == 'A' && line[2] == 'X')
                    {

                        score += 3;
                    }else if (line[0] == 'A' && line[2] == 'Y')
                    {
                        score += 3;
                        score += 1;
                    }else if (line[0] == 'A' && line[2] == 'Z')
                    {
                        score += 6;
                        score += 2;
                    }else if (line[0] == 'B' && line[2] == 'X')
                    {
                        score += 1;
                    }else if (line[0] == 'B' && line[2] == 'Y')
                    {
                        score += 3;
                        score += 2;
                    }else if (line[0] == 'B' && line[2] == 'Z')
                    {
                        score += 6;
                        score += 3;
                    }else if (line[0] == 'C' && line[2] == 'X')
                    {

                        score += 2;
                    }else if (line[0] == 'C' && line[2] == 'Y')
                    {
                        score += 6;
                    }else if (line[0] == 'C' && line[2] == 'Z')
                    {
                        score += 7;
                    }
                }

                Console.WriteLine(score);*/                    ///////////////////////












































            /*//////////////////////////////////////////////////////////////          Task 1 
               List<int> list = new List<int>();


            int temp = 0;
            foreach(string line in text)
            {

                if (line == "")
                {
                    list.Add(temp);

                    temp = 0;
                }
                else
                {
                    temp += Convert.ToInt32(line);
                }



            }


            int temp2 = 0;
           
            list.Sort();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
             
             */ ////////////////////////////////////////////////////////  






        }
    }
}

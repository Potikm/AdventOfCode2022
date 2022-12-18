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
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\havli\Webs\Advent2022\code\Task12\Task12.txt");

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            List<List<char>> array = new List<List<char>>();
            for (int i = 0; i < text.Length; i++)
            {
                array.Add(new List<char>());
                foreach (char c in text[i])
                {
                    array[i].Add(c);
                }

            }

            Point[,] points = new Point[array.Count, array[0].Count];

            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    points[i, j] = new Point(0,0,-1);
                }
            }


            int ver = 0;
            int hor = 0;
            int length = 0;

            List<Point> unvisited = new List<Point>();  

            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array[i].Count; j++)
                {
                    if(array[i][j] == 'S')
                    {

                        points[i, j] = new Point(i, j, length);
                        unvisited.Add(new Point(i, j, length));
                        array[i][j] = 'a';
                        ver = i;
                        hor = j;
                      
                    }
                }
            }
            int counter = 0;
            while(unvisited.Count > 0)
            {
                int ver2 = unvisited[0].ver;
                int hor2 = unvisited[0].hor;
                int index =  alphabet.IndexOf(array[ver2][hor2]);

                //top
                Console.WriteLine(array[ver2][hor2]);
                Console.WriteLine(index);
               
                if (ver2 > 0)
                {
                    if (ver2 > 0 && points[ver2 - 1, hor2].Length == -1 && array[ver2 - 1][hor2] == alphabet[index] || array[ver2 - 1][hor2] == alphabet[index + 1])
                    {
                        unvisited.Add(new Point(ver2 - 1, hor2, unvisited[0].Length + 1));
                        points[ver2 - 1, hor2] = new Point(ver2 - 1, hor2, length);

                        Console.WriteLine("top");
                        if (array[ver2 - 1][hor2] == 'E')
                        {
                            Console.WriteLine((ver2 - 1) + " " + hor2);
                            Console.WriteLine(counter);
                            break;
                        }
                    }

                    if (points[ver2 - 1, hor2].Length == -1 && array[ver2 - 1][hor2] == 'm' && array[ver2][hor2] == 'o')
                    {
                        unvisited.Add(new Point(ver2 - 1, hor2, unvisited[0].Length + 1));
                        points[ver2 - 1, hor2] = new Point(ver2 - 1, hor2, length);

                        Console.WriteLine("top");
                        if (array[ver2 - 1][hor2] == 'E')
                        {
                            Console.WriteLine((ver2 - 1) + " " + hor2);
                            Console.WriteLine(counter);
                            break;
                        }
                    }
                }
            

                //left
            
                if (hor2 > 0)
                {
                    if (hor2 > 0 && points[ver2, hor2 - 1].Length == -1 && array[ver2][hor2 - 1] == alphabet[index] || array[ver2][hor2 - 1] == alphabet[index + 1])
                    {
                        unvisited.Add(new Point(ver2, hor2 - 1, unvisited[0].Length + 1));
                        points[ver2, hor2 - 1] = new Point(ver2, hor2 - 1, length);
                        Console.WriteLine("left");
                        if (array[ver2][hor2 - 1] == 'E')
                        {
                            Console.WriteLine(ver2 + " " + (hor2 - 1));
                            Console.WriteLine(counter);
                            break;
                        }
                    }

                    if (points[ver2, hor2 - 1].Length == -1 && array[ver2][hor2 - 1] == 'm' && array[ver2][hor2] == 'o')
                    {
                        unvisited.Add(new Point(ver2, hor2 - 1, unvisited[0].Length + 1));
                        points[ver2, hor2 - 1] = new Point(ver2, hor2 - 1, length);
                        Console.WriteLine("left");
                        if (array[ver2][hor2 - 1] == 'E')
                        {
                            Console.WriteLine(ver2 + " " + (hor2 - 1));
                            Console.WriteLine(counter);
                            break;
                        }
                    }

                }
             

                //right
                if (hor2 < array[0].Count - 1)
                {
                    if (hor2 < array[0].Count - 1 && points[ver2, hor2 + 1].Length == -1 && array[ver2][hor2 + 1] == alphabet[index] || array[ver2][hor2 + 1] == alphabet[index + 1])
                    {
                        unvisited.Add(new Point(ver2, hor2 + 1, unvisited[0].Length + 1));
                        points[ver2, hor2 + 1] = new Point(ver2, hor2 + 1, length);
                        Console.WriteLine("right");
                        if (array[ver2][hor2 + 1] == 'E')
                        {
                            Console.WriteLine(ver2 + " " + (hor2 + 1));
                            Console.WriteLine(counter);
                            break;
                        }
                    }
                }

               

                // bottom 
                if (ver2 < array.Count - 1)
                {
                    if (ver2 < array.Count - 1 && points[ver2 + 1, hor2].Length == -1 && array[ver2 + 1][hor2] == alphabet[index] || array[ver2 + 1][hor2] == alphabet[index + 1])
                    {
                        unvisited.Add(new Point(ver2 + 1, hor2, unvisited[0].Length + 1));
                        points[ver2 + 1, hor2] = new Point(ver2 + 1, hor2, length);
                        Console.WriteLine("bot");
                        if (array[ver2 + 1][hor2] == 'E')
                        {
                            Console.WriteLine((ver2 + 1) + " " + hor2);
                            Console.WriteLine(counter);
                            break;
                        }
                    }
                }

                counter++;
                Console.WriteLine();

                Console.WriteLine(unvisited[0].Length);
                unvisited.RemoveAt(0);
             
            }
          

      






































            /*                                            ///////////////////////////////////////   Task 11 1/2
              List<List<int>> monkes = new List<List<int>>();

            monkes.Add(new List<int> { 65, 78 });
            monkes.Add(new List<int> { 54, 78, 86, 79, 73, 64, 85, 88 });
            monkes.Add(new List<int> { 69, 97, 77, 88, 87 });
            monkes.Add(new List<int> { 99 });
            monkes.Add(new List<int> { 60, 57, 52 });
            monkes.Add(new List<int> { 91, 82, 85, 73, 84, 53 });
            monkes.Add(new List<int> { 88, 74, 68, 56 });
            monkes.Add(new List<int> { 54, 82, 72, 71, 53, 99, 67 });
            List<int> counters = new List<int>() { 0,0,0,0,0,0,0,0};

            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
               
                if (text[i].Contains("Monke"))
                {
                    int active = Convert.ToInt32(Regex.Match(text[i], @"\d+").Value);
                  

                    foreach (int x in monkes[active])
                    {
                        int final = 0;
                       
                        if (text[i + 2].Contains("*"))
                        {
                            if (text[i + 2].Any(char.IsDigit))
                            {
                               
                                int increaser = Convert.ToInt32(Regex.Match(text[i + 2], @"\d+").Value);
                                
                                final = x * increaser;
                            }
                            else
                            {
                               
                                final = x * x;
                            }
                            counters[active]++;
                        }
                     
                        if (text[i + 2].Contains("+"))
                        {
                            int increaser = Convert.ToInt32(Regex.Match(text[i + 2], @"\d+").Value);
                            counters[active]++;
                            final = x + increaser;
                           
                        }

                        final = final / 120;
                        

                        int divisibler = Convert.ToInt32(Regex.Match(text[i + 3], @"\d+").Value);

                        if (final != 0)
                        {
                           
                            if (final % divisibler == 0)
                            {
                                int pointer = Convert.ToInt32(Regex.Match(text[i + 4], @"\d+").Value);
                               
                                monkes[pointer].Add(final);
                               
                            }
                            else
                            {
                                int pointer = Convert.ToInt32(Regex.Match(text[i + 5], @"\d+").Value);
                             
                                monkes[pointer].Add(final);




                            }
                        }
                       



                        
                          
                        




                    }
                    monkes[active].Clear();
                    if (active == 7)
                    {
                       
                        counter++;
                        i = -1;
                    }
                    if (counter == 10000)
                    {
                        counters.Sort();
                        foreach(int x in counters)
                        {
                            Console.WriteLine(x);
                        }
                        break;
                    }
                }
                
            }

             */                                 ///////////////////////////////////////



            /*                                  ///////////////////////////////////////    TASK 10 1/2
               int twenty = 0;
            int sixty = 0;
            int onehundred = 0;
            int oneforty = 0;
            int oneeighty = 0;
            int twotwenty = 0;
            int strength = 0;

            int X = 1;
            int cycle = 0;
            foreach (string line in text)
            {

                int num;
                int repeat = 0;
                if (line.Contains("noop"))
                {
                    num = 0;
                    repeat = 1;
                }
                else
                {
                    num = Convert.ToInt32(Regex.Match(line, @"\d+").Value);
                    repeat = 2;
                }

                for (int i = 0; i < repeat; i++)
                {
                    cycle += 1;


                    if (cycle == 20 && twenty == 0)
                    {
                        twenty = X;
                        Console.WriteLine(twenty);
                        strength += 20 * X;
                    }

                    if (cycle == 60 && sixty == 0)
                    {
                        sixty = X;
                        Console.WriteLine(sixty);
                        strength += 60 * X;
                    }

                    if (cycle == 100 && onehundred == 0)
                    {
                        onehundred = X;
                        Console.WriteLine(onehundred);
                        strength += 100 * X;
                    }

                    if (cycle == 140 && oneforty == 0)
                    {
                        oneforty = X;
                        Console.WriteLine(oneforty);
                        strength += 140 * X;
                    }

                    if (cycle == 180 && oneeighty == 0)
                    {
                        oneeighty = X;
                        Console.WriteLine(oneeighty);
                        strength += 180 * X;
                    }

                    if (cycle == 220 && twotwenty == 0)
                    {
                        twotwenty = X;
                        Console.WriteLine(twotwenty);
                        strength += 220 * X;
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


            Console.WriteLine(strength);
             */                         ///////////////////////////////////////

















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

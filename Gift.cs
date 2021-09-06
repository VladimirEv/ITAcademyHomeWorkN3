using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskItAcademy.Sweets;
using System.IO;
using System.Collections.Concurrent;
using System.Collections;

namespace TaskItAcademy.Sweets
{
    public class Gift : LineWrireSweets
    {
        public int Position { get; set; }
        public string ResultGift { get; set; }
        public double Weight { get; set; }
        public double Cost { get; set; }
        

        
        public Gift()
        {

        }

        public void GiveSweetGift()
        {

            Mars mars = new Mars();
            Snickers snickers = new Snickers();
            Nestle nestle = new Nestle();
            Milko milko = new Milko();
            Alionka alionka = new Alionka();
            Roshen roshen = new Roshen();
            Zefir zefir = new Zefir();

            bool q = true;
            List<string> collectGift = new List<string>();
            double Cost = 0;
            double AllWeight = 0.0;
            double AllCost = 0.0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Type any symbol or word and press enter to continue");
            Console.WriteLine("If you want to exit the store, type 'no' and the program will end.");
            Console.WriteLine("Please, enter the word:");
            Console.ForegroundColor = ConsoleColor.White;
            string Dif = Console.ReadLine();
            if (Dif == "no")
            {
                Program.Description2();
            }
            else
            {
                while (q)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    try
                    {
                        Console.WriteLine("Please enter a number from one to seven inclusive (sweet position): ");
                        Position = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("You entered wrong position. Try one more time!)");
                        GiveSweetGift();
                    }
                    if (Position == 111)
                    {
                        break;
                    }

                    Console.WriteLine("Please enter weight of sweets in this position (kg): ");
                    double weight = Convert.ToDouble(Console.ReadLine());

                    if (Position <= 0 || Position >= 8 && !char.IsDigit(Convert.ToChar(Position)))
                    {
                        Console.WriteLine("You entered wrong position. Try one more time!)");
                        GiveSweetGift();
                    }

                    else
                    {
                        switch (Position)
                        {
                            case 1: ResultGift = mars.SweetName; Weight = weight; Cost = mars.SweetCostInKg * weight; break;
                            case 2: ResultGift = snickers.SweetName; Weight = weight; Cost = snickers.SweetCostInKg * weight; break;
                            case 3: ResultGift = nestle.SweetName; Weight = weight; Cost = nestle.SweetCostInKg * weight; break;
                            case 4: ResultGift = milko.SweetName; Weight = weight; Cost = milko.SweetCostInKg * weight; break;
                            case 5: ResultGift = alionka.SweetName; Weight = weight; Cost = alionka.SweetCostInKg * weight; break;
                            case 6: ResultGift = roshen.SweetName; Weight = weight; Cost = roshen.SweetCostInKg * weight; break;
                            case 7: ResultGift = zefir.SweetName; Weight = weight; Cost = zefir.SweetCostInKg * weight; break;
                            case 111: Console.WriteLine("You ented number 111 !!! You have completed your selection of chocolates for the gift. "); q = false; break;
                                //default: Console.WriteLine(); break;
                        }
                        collectGift.Add(ResultGift);
                        AllWeight += weight;
                        AllCost += Cost;
                    }
                }                                         
                                                    
                           if (Position != 111)
                           {
                               Console.WriteLine("You have collected your New Year's dream gift! CONGRATULATIONS !!!");
                           }
                           else
                           {
                               Console.WriteLine("You ented number 111 !!! You have completed your selection of chocolates for the gift.");
                           }
                           foreach (var item in collectGift)
                           {
                               Console.WriteLine(item);
                           }
                           
                           Console.ForegroundColor = ConsoleColor.White;
                           Console.ForegroundColor = ConsoleColor.Red;
                           Console.WriteLine($"General weight of GIFT (Kg) - {AllWeight}");
                           Console.WriteLine($"The price of GIFT (Euro) - {AllCost}");
                           Console.ForegroundColor = ConsoleColor.White;
                           
                           try
                           {
                               Console.ForegroundColor = ConsoleColor.Yellow;
                               Console.WriteLine();
                               Console.WriteLine("If you want to find the candy with help sugar content, enter the symbol 'Y'. If you don't want, enter any other symbol");
                               Console.WriteLine();
                               char yes = Convert.ToChar(Console.ReadLine());
                               Console.WriteLine();
                               Console.WriteLine("Enter the amount of sugar in the range from 0 to 4 :");
                               Console.WriteLine();
                               Console.ForegroundColor = ConsoleColor.White;
                               double SugarOnSweet = Convert.ToDouble(Console.ReadLine());
                           
                               if (SugarOnSweet <= 2 && SugarOnSweet > 1.4)
                               {
                                   for (int i = 0; i < collectGift.Count; i++)
                                   {
                                       ResultGift = mars.SweetName;
                                       if (collectGift[i] == ResultGift)
                                       {
                                           Console.WriteLine($"The name of sweet {ResultGift}. The count of sugar in this sweet {mars.SweetSugar}");
                                           Console.WriteLine("This candy IS in your gift !");
                                           break;
                                       }
                                       else
                                       {
                                           Console.WriteLine($"The name of sweet {ResultGift}. The count of sugar in this sweet {mars.SweetSugar}");
                                           Console.WriteLine("This candy IS NOT in your gift. You can choose another candy!");
                                           break;
                                       }
                                   }
                               }
                                      if (SugarOnSweet < 4 && SugarOnSweet > 2.3)
                                      {
                                          for (int i = 0; i < collectGift.Count; i++)
                                          {
                                              ResultGift = snickers.SweetName;
                                              if (collectGift[i] == ResultGift)
                                              {
                                                  Console.WriteLine($"The name of sweet {ResultGift}. The count of sugar in this sweet {snickers.SweetSugar}");
                                                  Console.WriteLine("This candy IS in your gift !");
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine($"The name of sweet {ResultGift}. The count of sugar in this sweet {snickers.SweetSugar}");
                                                  Console.WriteLine("This candy IS NOT in your gift. You can choose another candy!");
                                                  break;
                                              }
                                          }
                                      }
                           
                                      if (SugarOnSweet < 1.4 && SugarOnSweet > 1.1)
                                      {
                                          for (int i = 0; i < collectGift.Count; i++)
                                          {
                                              ResultGift = nestle.SweetName;
                                              if (collectGift[i] == ResultGift)
                                              {
                                                  Console.WriteLine($"The name of sweet {ResultGift}. The count of sugar in this sweet {nestle.SweetSugar}");
                                                  Console.WriteLine("This candy IS in your gift !");
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine($"The name of sweet {ResultGift}. The count of sugar in this sweet {nestle.SweetSugar}");
                                                  Console.WriteLine("This candy IS NOT in your gift. You can choose another candy!");
                                                  break;
                                              }
                                          }
                                      }
                           
                                      if (SugarOnSweet < 1.8 && SugarOnSweet > 1.4)
                                      {
                                          for (int i = 0; i < collectGift.Count; i++)
                                          {
                                              ResultGift = milko.SweetName;
                                              if (collectGift[i] == ResultGift)
                                              {
                                                  Console.WriteLine($"The name of sweet {ResultGift}. The count of sugar in this sweet {milko.SweetSugar}");
                                                  Console.WriteLine("This candy IS in your gift !");
                                                  break;
                                              }
                                              else
                                              {
                                                  Console.WriteLine($"The name of sweet {ResultGift}. The count of sugar in this sweet {milko.SweetSugar}");
                                                  Console.WriteLine("This candy IS NOT in your gift. You can choose another candy!");
                                                  break;
                                              }
                                          }
                                      }
                           
                                    if (SugarOnSweet < 2.3 && SugarOnSweet > 2)
                                    {
                                        for (int i = 0; i < collectGift.Count; i++)
                                        {
                                            ResultGift = alionka.SweetName;
                                            if (collectGift[i] == ResultGift)
                                            {
                                                Console.WriteLine($"The name of sweet {ResultGift}. The count of sugar in this sweet {alionka.SweetSugar}");
                                                Console.WriteLine("This candy IS in your gift !");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"The name of sweet {ResultGift}. The count of sugar in this sweet {alionka.SweetSugar}");
                                                Console.WriteLine("This candy IS NOT in your gift. You can choose another candy!");
                                                break;
                                            }
                                        }
                                    }
                           
                                    if (SugarOnSweet < 2.8 && SugarOnSweet > 2.3)
                                    {
                                        for (int i = 0; i < collectGift.Count; i++)
                                        {
                                            ResultGift = roshen.SweetName;
                                            if (collectGift[i] == ResultGift)
                                            {
                                                Console.WriteLine($"The name of sweet {ResultGift}. The count of sugar in this sweet {roshen.SweetSugar}");
                                                Console.WriteLine("This candy IS in your gift !");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"The name of sweet {ResultGift}. The count of sugar in this sweet {roshen.SweetSugar}");
                                                Console.WriteLine("This candy IS NOT in your gift. You can choose another candy!");
                                                break;
                                            }
                                           }
                                       }
                                  
                                  if (SugarOnSweet < 1.1 && SugarOnSweet > 0)
                                  {
                                      for (int i = 0; i < collectGift.Count; i++)
                                      {
                                          ResultGift = zefir.SweetName;
                                          if (collectGift[i] == ResultGift)
                                          {
                                              Console.WriteLine($"The name of sweet {ResultGift}. The count of sugar in this sweet {zefir.SweetSugar}");
                                              Console.WriteLine("This candy IS in your gift !");
                                              break;
                                          }
                                          else
                                          {
                                              Console.WriteLine($"The name of sweet {ResultGift}. The count of sugar in this sweet {zefir.SweetSugar}");
                                              Console.WriteLine("This candy IS NOT in your gift. You can choose another candy!");
                                              break;
                                          }
                                      }
                                  }
                                  
                                     }
                                     
                                     catch
                                     {
                                     
                                     }
                                  
                                  
                                  ArrayList arrayListSugar = new ArrayList();
                                  arrayListSugar.Add(mars.SweetSugar);
                                  arrayListSugar.Add(snickers.SweetSugar);
                                  arrayListSugar.Add(nestle.SweetSugar);
                                  arrayListSugar.Add(milko.SweetSugar);
                                  arrayListSugar.Add(alionka.SweetSugar);
                                  arrayListSugar.Add(roshen.SweetSugar);
                                  arrayListSugar.Add(zefir.SweetSugar);
                                  
                                  ArrayList SugarGift = new ArrayList();
                                  Console.ForegroundColor = ConsoleColor.Yellow;
                                  Console.WriteLine();
                                  
                                  Console.WriteLine("To find a candy in a gift by sugar content, click S.");
                                  Console.WriteLine();
                                  Console.ForegroundColor = ConsoleColor.White;
                                  
                                  char yesS = Convert.ToChar(Console.ReadLine());
                                  if (yesS == 'S')
                                  {
                                      for (int i = 0; i < collectGift.Count; i++)
                                      {
                                          if (mars.SweetName == collectGift[i])
                                          {
                                              SugarGift.Add(mars.SweetSugar);
                                          }
                                          if (snickers.SweetName == collectGift[i])
                                          {
                                              SugarGift.Add(snickers.SweetSugar);
                                          }
                                          if (nestle.SweetName == collectGift[i])
                                          {
                                              SugarGift.Add(nestle.SweetSugar);
                                          }
                                          if (milko.SweetName == collectGift[i])
                                          {
                                              SugarGift.Add(milko.SweetSugar);
                                          }
                                          if (alionka.SweetName == collectGift[i])
                                          {
                                              SugarGift.Add(alionka.SweetSugar);
                                          }
                                          if (roshen.SweetName == collectGift[i])
                                          {
                                              SugarGift.Add(roshen.SweetSugar);
                                          }
                                          if (zefir.SweetName == collectGift[i])
                                          {
                                              SugarGift.Add(zefir.SweetSugar);
                                          }
                                      }
                           
                                  SugarGift.Sort();
                                  Console.ForegroundColor = ConsoleColor.Red;
                                  foreach (double item in SugarGift)
                                   {
                                   if (mars.SweetSugar == item)
                                   {
                                       Console.WriteLine($"The name of sweet - MARS. The amount of sugar in the candy - {item}");
                                   }
                                   if (snickers.SweetSugar == item)
                                   {
                                       Console.WriteLine($"The name of sweet - SNICKERS. The amount of sugar in the candy - {item}");
                                   }
                                   if (nestle.SweetSugar == item)
                                   {
                                       Console.WriteLine($"The name of sweet - NESTLE. The amount of sugar in the candy - {item}");
                                   }
                                   if (milko.SweetSugar == item)
                                   {
                                       Console.WriteLine($"The name of sweet - MILKO. The amount of sugar in the candy - {item}");
                                   }
                                   if (alionka.SweetSugar == item)
                                   {
                                       Console.WriteLine($"The name of sweet - ALIONKA. The amount of sugar in the candy - {item}");
                                   }
                                   if (roshen.SweetSugar == item)
                                   {
                                       Console.WriteLine($"The name of sweet - ROSHEN. The amount of sugar in the candy - {item}");
                                   }
                                   if (zefir.SweetSugar == item)
                                   {
                                       Console.WriteLine($"The name of sweet - ZEFIR. The amount of sugar in the candy - {item}");
                                   }
                               }
                               Console.ForegroundColor = ConsoleColor.White;

                    
                }

                Program.Description1();

                GiveSweetGift();
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_foodorder
{
    
    
        internal class order
        {


            public class Program
            {
                static string[] itemArray = { "Coffee", "Grilled Sandwich", "French Fries", "Noodles", "Pizza" };
                static int[] priceOfItem = { 50, 60, 100, 50, 30 };
                static Dictionary<int, int> itemPurchased = new Dictionary<int, int>();

                public static void Main()
                {
                    int choice;
                    do
                    {
                        Console.WriteLine("\n1. Show Menu");
                        Console.WriteLine("2. Purchase Item and Quantity");
                        Console.WriteLine("3. Calculate Bill");
                        Console.WriteLine("4. Exit");
                        Console.Write("\nEnter your choice: ");
                        choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                ShowMenu();
                                break;
                            case 2:
                                PurchaseItemAndQuantity();
                                break;
                            case 3:
                                CalculateBill();
                                break;
                            case 4:
                                Console.WriteLine("Exiting the program...");
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                                break;
                        }
                    } while (choice != 4);
                }

                public static void ShowMenu()
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("Item No.\tItem\t\tPrice");
                    for (int i = 0; i < itemArray.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}\t\t{itemArray[i]}\t\t{priceOfItem[i]}");
                    }
                }

                public static void PurchaseItemAndQuantity()
                {
                    Console.WriteLine("\nPurchase Items:");
                    int itemNo, quantity;

                    do
                    {
                        Console.Write("Enter item number to purchase (1-5) or 0 to exit: ");
                        itemNo = int.Parse(Console.ReadLine());
                        if (itemNo == 0)
                            break;
                        if (itemNo < 1 || itemNo > 5)
                        {
                            Console.WriteLine("Invalid item number.");
                            continue;
                        }

                        Console.Write("Enter quantity to purchase: ");
                        quantity = int.Parse(Console.ReadLine());

                        itemPurchased[itemNo] = quantity;

                    } while (itemNo != 0);
                }

                public static void CalculateBill()
                {
                    int totalBill = 0;
                    Console.WriteLine("\nItem Purchased\tQuantity\tPrice per item\tTotal Price");
                    foreach (var item in itemPurchased)
                    {
                        int itemNo = item.Key;
                        int quantity = item.Value;
                        int price = priceOfItem[itemNo - 1];
                        int totalPrice = quantity * price;
                        totalBill += totalPrice;
                        Console.WriteLine($"{itemArray[itemNo - 1]}\t\t{quantity}\t\t{price}\t\t{totalPrice}");
                    }
                    Console.WriteLine($"Total Bill: {totalBill}");
                }
            }

        }
    }

    

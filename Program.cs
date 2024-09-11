using System.ComponentModel.DataAnnotations;

namespace InventorySystem
{
	internal class Program
	{
		const int numberOfProducts = 50;

		static string[,] inventory = new string[50,3];
		//ID ==> 50 rows + 3 columns

		static int productCount = 0;	

		static void Main(string[] args)
		{
			// Add product
			// Update product
			// View product ( ID , Name , Quantity
			// Exit

			//To make the application not exit the switch and continue the loop ==>>>> while loop

			while(true)
			{
				Console.WriteLine("Welcome to the inventory system");
				Console.WriteLine("==================================");
				Console.WriteLine("1. Add Product");
				Console.WriteLine("2. Update Product");
				Console.WriteLine("3. View Product");
				Console.WriteLine("4. Exit");

				//int userInput = Convert.ToInt32(Console.ReadLine());
				int userInput = int.Parse(Console.ReadLine());

				switch (userInput)
				{
					case 1:
						AddProduct();
						break;
					case 2:
						UpdateProduct();
						break;
					case 3:
						ViewProducts();
						break;
					case 4:
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Please enter number from 1 to 4 only!!!");
						break;
				}
			}

			
		}

		private static void AddProduct()
		{
			Console.WriteLine("Enter Product Name:");
			string name = Console.ReadLine();

			Console.WriteLine("Enter Product Quantity:");
			string quantity = Console.ReadLine();

			Console.WriteLine("Enter Product Price:");
			string price = Console.ReadLine();

			inventory[productCount, 0] = name;
			inventory[productCount, 1] = quantity;
			inventory[productCount, 2] = price;

			productCount++;

			Console.WriteLine("Product added successfully!!!");
		}

		private static void ViewProducts()
		{
			if(productCount>0)
			{
				Console.WriteLine("Product List: ");

                for(int i=0; i < productCount; i++)
                {
					Console.WriteLine($"Product ID: {i+1} Product Name: {inventory[i, 0]} Product Quantity: {inventory[i, 1]} Product Price: {inventory[i, 2]} ");
                }
            }
		}

		private static void UpdateProduct()
		{
			Console.WriteLine("Enter product name to update: ");
			string searchProduct = Console.ReadLine();

			int productID = -1;

			if (productCount>0)
			{
				for (int i = 0; i < productCount; i++)
				{
					if (inventory[i,0] == searchProduct)
					{
						productID= i;
						break;
					}
				}
				if (productID !=-1)
				{
					Console.WriteLine("Enter the new quantity: ");
					string newQuantity = Console.ReadLine();

					inventory[productID, 1] = newQuantity;

					Console.WriteLine("Quantity updated successfully!!");
				}
				else
				{
					Console.WriteLine("Product is not found!");
				}
			}
		}
	}
}

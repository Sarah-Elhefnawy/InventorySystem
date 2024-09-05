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

			Console.WriteLine("Welcome to the inventory system");
			Console.WriteLine("==================================");
			Console.WriteLine("1. Add Product");
			Console.WriteLine("2. Update Product");
			Console.WriteLine("3. View Product");
			Console.WriteLine("4. Exit");

			//int userInput = Convert.ToInt32(Console.ReadLine());
			int userInput = int.Parse(Console.ReadLine());

			switch(userInput)
			{
				case 1:
					//add product
					AddProduct();
					break;
				case 2:
					//update product
					break;
				case 3:
					//view product
					break;
				case 4:
					Environment.Exit(0);
					break;
				default:
					//update product
					break;
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
	}
}

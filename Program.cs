namespace InventorySystem
{
	internal class Program
	{
		//when initializing any attribute, variable or method --> it MUST be static as you won't initialize new object
		const int numberOfProducts = 50;

		string[,] inventory = new string[50,3];
		//ID ==> 50 rows + 3 columns

		int productCount = 0;	

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
			int quantity = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter Product Price:");
			double price = double.Parse(Console.ReadLine());

			Inventory = 
		}
	}
}

using System.Collections.Generic;
using System.Data.Entity;

namespace SEBProject.Models
{
    public class FoodDatabaseInitializer : DropCreateDatabaseIfModelChanges<FoodContext>
    {

        private static List<Food> GetFoods()
        {
            int counter = 1;
            var foods = new List<Food>
            {
                new Food
                {
                    FoodId = counter++,
                    Name = "Shopska Salad",
                    FoodCategory = FoodCategory.SALAD,
                    Quantity = 50,
                    Ingredients = new List<string>{"Tomatoes", "Cucumbers", "Feta Cheese", "Onions", "Olive Oil"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Shopska.png",
                    Price = 8.00
                },
                new Food
                {
                    FoodId = counter++,
                    Name = "Ceasar Salad",
                    FoodCategory = FoodCategory.SALAD,
                    Quantity = 25,
                    Ingredients = new List<string>{ "Croutons", "Parmesan", "Garlic", "Egg Yolk", "Anchovies", "Lemon Juice", "Romaine Lettuce", "Olive Oil"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Ceasar.png",
                    Price = 12.50
                },
                new Food
                {
                    FoodId = counter++,
                    Name = "Shepherd's Salad",
                    FoodCategory = FoodCategory.SALAD,
                    Quantity = 30,
                    Ingredients = new List<string>{"Tomatoes", "Cucumbers", "Peppers", "Onions", "Feta Cheese", "Mushrooms", "Ham", "Eggs", "Olives", "Olive Oil"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Shepherds.png",
                    Price = 9.70
                },
                new Food
                {
                    FoodId = counter++,
                    Name = "Greek Salad",
                    FoodCategory = FoodCategory.SALAD,
                    Quantity = 50,
                    Ingredients = new List<string>{"Tomatoes", "Cucumbers", "Feta Cheese", "Onions", "Olive Oil", "Vinegar", "Peppers"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Greek.png",
                    Price = 8.50

                },
                new Food
                {
                    FoodId = counter++,
                    Name = "Vitamin Salad",
                    FoodCategory = FoodCategory.SALAD,
                    Quantity = 40,
                    Ingredients = new List<string>{"Carrots", "Apple", "Beetroot", "Vinegar", "Olive Oil"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Vitamina.png",
                    Price = 6.80
                },
                new Food
                {
                    FoodId = counter++,
                    Name = "Seafood Salad",
                    FoodCategory = FoodCategory.SALAD,
                    Quantity = 10,
                    Ingredients = new List<string>{"Lettuce", "Crab", "", "Onions", "Mayonnese", "Tomatoes"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Seafood.png",
                    Price = 14.50
                },
                new Food
                {
                    FoodId = 7,
                    Name = "Avocado Chicken Salad",
                    FoodCategory = FoodCategory.SALAD,
                    Quantity = 10,
                    Ingredients = new List<string>{"Tomatoes", "Lettuce", "Cheddar Cheese", "Chicken", "Avocado"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Avocado.png",
                    Price = 12.60
                },
                new Food
                {
                    FoodId = counter++,
                    Name = "Mediterranean Salad",
                    FoodCategory = FoodCategory.SALAD,
                    Quantity = 50,
                    Ingredients = new List<string>{"Tomatoes", "Cucumbers", "Feta Cheese", "Olives", "Chicken", "Lettuce", "Hummus"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Medditerranean.png",
                    Price = 9.00
                },
                new Food
                {
                    FoodId = counter++,
                    Name = "Pizza",
                    FoodCategory = FoodCategory.MAIN,
                    Quantity = 50,
                    Ingredients = new List<string>{"Tomatoe sause", "Cheese", "Ham", "Onions"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Pizza.png", 
                    Price = 8.00
                },
                new Food
                {
                    FoodId = counter++,
                    Name = "Burger",
                    FoodCategory = FoodCategory.MAIN,
                    Quantity = 25,
                    Ingredients = new List<string>{ "Beef", "Tomatoes", "Onions", "Pickles", "Lettuce"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Burger.png",
                    Price = 10.00
                },
                new Food
                {
                    FoodId = counter++,
                    Name = "Fries",
                    FoodCategory = FoodCategory.MAIN,
                    Quantity = 30,
                    Ingredients = new List<string>{"Potatoes", "Ketchup"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Fries.png",
                    Price = 7.50
                },
                new Food
                {
                    FoodId = counter++,
                    Name = "Chicken Nuggets",
                    FoodCategory = FoodCategory.MAIN,
                    Quantity = 50,
                    Ingredients = new List<string>{"Chicken", "Cornflakes", "Ketchup", "Mayonnese" },
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Nuggets.png",
                    Price = 10.0
                },
                new Food
                {
                    FoodId = counter++,
                    Name = "Salmon with Steamed Broccoli",
                    FoodCategory = FoodCategory.MAIN,
                    Quantity = 40,
                    Ingredients = new List<string>{"Salmon", "Broccoli"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Salmon.png",
                    Price = 15.60
                },
                new Food
                {
                    FoodId = counter++,
                    Name = "Shrimp",
                    FoodCategory = FoodCategory.MAIN,
                    Quantity = 10,
                    Ingredients = new List<string>{"Shrimp", "Butter"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Shrimp.png",
                    Price = 10
                },
                new Food
                {
                    FoodId = counter++,
                    Name = "Potato Soup",
                    FoodCategory = FoodCategory.MAIN,
                    Quantity = 10,
                    Ingredients = new List<string>{"Potatoes", "Cream", "Croutons", "Onion", "Olive Oild"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Soup.png",
                    Price = 5.50
                },
                new Food
                {
                    FoodId = counter++,
                    Name = "Spaghetti Bolognese",
                    FoodCategory = FoodCategory.MAIN,
                    Quantity = 50,
                    Ingredients = new List<string>{"Tomatoes", "Spaghetti", "Meat balls"},
                    Image = "C:\\Users\\PC\\source\\repos\\SEBProject\\Images\\Spaghetti.png",
                    Price = 7.80
                }

            };

            return foods;
        }

        public override void InitializeDatabase(FoodContext context)
        {
            base.InitializeDatabase(context);
        }
        protected override void Seed(FoodContext context)
        {
            GetFoods().ForEach(c => context.Foods.Add(c));
        }


    }
}
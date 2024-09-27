using ClosedXML.Excel;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MileStone_4_ZomatoLikeApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string xmlFilePath = @"Restaurants.xml";
            string excelFilePath = "restaurants.xlsx";
            string jsonInput = @"
        {
            'reviews': [
                {'restaurant': 'Pizza Place', 'review': 'Great pizza!', 'rating': 5},
                {'restaurant': 'Pasta House', 'review': 'Too salty.', 'rating': 2}
            ]
        }";


            Console.WriteLine("-------Read data from xml---------");
            XMLReader.xmlParse(xmlFilePath);

            Console.WriteLine("------------Read menu from csv:--------");

            CsvReader.CsvParser();

            Console.WriteLine("------------Read Restaurants from excel:--------");
            ExcelHandler.CreateExcel(excelFilePath);
            ExcelHandler.ReadExcel(excelFilePath);

            Console.WriteLine("-------Read data using json parser---------");
            JsonHandler.ParseJson(jsonInput);

            
                 

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();


            app.Run();
            
        }

        public static class XMLReader {
        public static void xmlParse(string xmlFilePath)
            {
                XDocument xmlDoc = XDocument.Load(xmlFilePath);

                // Parse and display restaurant data
                var restaurants = xmlDoc.Descendants("restaurant");

                foreach (var restaurant in restaurants)
                {
                    string name = restaurant.Element("name")?.Value;
                    string address = restaurant.Element("address")?.Value;
                    string rating = restaurant.Element("rating")?.Value;

                    Console.WriteLine($"Restaurant: {name}, Address: {address}, Rating: {rating}");
                }
            }
        }
        public static class CsvReader
        {
            public static void CsvParser()
            {
                // Path to the CSV file
                string filePath = "menu.csv";

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read all lines from the file
                    string[] lines = File.ReadAllLines(filePath);

                    // Skip the first line (header)
                    for (int i = 1; i < lines.Length; i++)
                    {
                        // Split each line by comma
                        string[] values = lines[i].Split(',');

                        // Extract item and price
                        string itemName = values[0];
                        string itemPrice = values[1];

                        // Display the formatted output
                        Console.WriteLine($"Item: {itemName}, Price: {itemPrice}");
                    }
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }

        }

        public static class ExcelHandler
        {
            public static void CreateExcel(string filePath)
            {
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Restaurants");
                worksheet.Cell(1, 1).Value = "Name";
                worksheet.Cell(1, 2).Value = "Address";
                worksheet.Cell(1, 3).Value = "Rating";
                worksheet.Cell(2, 1).Value = "Margarita House";
                worksheet.Cell(2, 2).Value = "456 Elm St";
                worksheet.Cell(2, 3).Value = 4.2;
                workbook.SaveAs(filePath);
            }

            public static void ReadExcel(string filePath)
            {
                var workbook = new XLWorkbook(filePath);
                var worksheet = workbook.Worksheet(1);
                var name = worksheet.Cell(2, 1).GetString();
                var address = worksheet.Cell(2, 2).GetString();
                var rating = worksheet.Cell(2, 3).GetDouble();

                Console.WriteLine($"Read Restaurant: {name}, Address: {address}, Rating: {rating}");
            }
        }
        public static class JsonHandler
        {
            public static void ParseJson(string jsonString)
            {
                var reviews = JsonConvert.DeserializeObject<JObject>(jsonString)["reviews"];
                foreach (var review in reviews)
                {
                    Console.WriteLine($"Review for {review["restaurant"]}: {review["review"]}, Rating: {review["rating"]}");
                }
            }
        }
        public static class ServiceNowClient
        {
            private static readonly HttpClient client = new HttpClient();

            public static async Task GetIncidents()
            {
                var response = await client.GetStringAsync("https://your_instance.service-now.com/api/now/table/incident");
                Console.WriteLine(response); // Process the response accordingly
            }
        }

    }

}
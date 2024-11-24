using System;
using System.IO;

public class TextProcessor
{
    public static string SplitIntoParagraphs(string text)
    {
        // Split the text into sentences using ". " as the delimiter
        string[] sentences = text.Split(new[] { ". " }, StringSplitOptions.None);
        string result = string.Empty;
        string paragraph = string.Empty;

        foreach (var sentence in sentences)
        {
            // Check if adding the current sentence will exceed the 400-character limit
            if ((paragraph + sentence + ". ").Length > 400)
            {
                // Add the current paragraph to the result and start a new paragraph
                result += paragraph.Trim() + "\n\n";
                paragraph = string.Empty;
            }

            // Add the current sentence to the paragraph
            paragraph += sentence + ". ";
        }

        // Add the last paragraph if it exists
        if (!string.IsNullOrWhiteSpace(paragraph))
        {
            result += paragraph.Trim();
        }

        return result;
    }

    /*
     2.
Solve the transfer problem where a ProductBackend method has this data
in the form of a string array:
[“Milk”, “Yoghurt”, “Cream”, “Cottage Cheese”]
The data should be transferred to the ProductPresentation method, which
will use the same string array in a loop writing to the console. But the
presentation method only accepts a simple string as parameter. How can
the transfer be done?
     */

    public static string StringArrayToString(string[] products) {
        var result = string.Empty;
        // Process each array element to form a comma separated string
        foreach (var product in products) 
        {
            if (result.Length > 0) {
                result += ", " + product.ToString();
            } else {
                result += product.ToString();
            }
            
        }
        return result;
    }


    public static void Main()
    {
        // Call the StringArrayToString
       
        string[] products = ["Milk", "Yoghurt", "Cream", "Cottage Cheese"];
        Console.WriteLine(StringArrayToString(products));

        Console.WriteLine("\n");

        Console.WriteLine("****************** End of Excercise 2 ***********************\n");
      

        string text = "Nick sat against the wall of the church where they had dragged him to be clear of machine gun fire in the street. Both legs stuck out awkwardly. He had been hit in the spine. His face was sweaty and dirty. The sun shone on his face. The day was very hot. Rinaldi, big backed, his equipment sprawling, lay face downward against the wall. Nick looked straight ahead brilliantly. The pink wall of the house opposite had fallen out from the roof, and an iron bedstead hung twisted toward the street. Two Austrian dead lay in the rubble in the shade of the house. Up the street were other dead. Things were getting forward in the town. It was going well. Stretcher bearers would be. along any time now. Nick turned his head carefully and looked down at Rinaldi. “Senta Rinaldi. Senta. You and me we’ve made a separate peace.” Rinaldi lay still in the sun breathing with difficulty. “Not patriots.” Nick turned his head carefully away smiling sweatily. Rinaldi was a disappointing audience. While the bombardment was knocking the trench to pieces at Fossalta, he lay very flat and sweated and prayed oh jesus christ get me out of here. Dear jesus please get me out. Christ please please please christ. If you’ll only keep me from getting killed I’ll do anything you say. I believe in you and I’ll tell everyone in the world that you are the only thing that matters. Please please dear jesus. The shelling moved further up the line. We went to work on the trench and in the morning the sun came up and the day was hot and muggy and cheerful and quiet. The next night back at Mestre he did not tell the girl he went upstairs with at the Villa Rossa about Jesus. And he never told anybody.";

        string formattedText = SplitIntoParagraphs(text);
        Console.WriteLine(formattedText);
    }
}


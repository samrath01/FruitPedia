using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FruitPedia.Common
{
    public class SeedData
    {
        public static List<FruitType> GetFruitTypes()
        {
            List<FruitType> types = new List<FruitType>();
            types.Add(new FruitType() { FruitTypeName = "Citrus" });
            types.Add(new FruitType() { FruitTypeName = "Stone Fruit" });
            types.Add(new FruitType() { FruitTypeName = "Tropical" });
            types.Add(new FruitType() { FruitTypeName = "Berries" });
            types.Add(new FruitType() { FruitTypeName = "Melons" });
            return types;
        }

        public static List<Fruit> GetFruits()
        {
            List<Fruit> fruits = new List<Fruit>();
            fruits.Add(new Fruit() { FruitName = "Oranges", FruitTypeName = "Citrus", Details = "Oranges are round, orange-colored citrus fruits that grow on trees. They originally came from China, but today these nutritious powerhouses are grown in warm climates around the world." });
            fruits.Add(new Fruit() { FruitName = "Grape Fruits", FruitTypeName = "Citrus", Details = "The grapefruit is a subtropical citrus tree known for its relatively large, sour to semisweet, somewhat bitter fruit. The interior flesh is segmented and varies in color from pale yellow to dark pink." });
            fruits.Add(new Fruit() { FruitName = "Mandarins", FruitTypeName = "Citrus", Details = "The mandarin orange (Citrus reticulata), also known as the mandarin or mandarine, is a small citrus tree fruit. Treated as a distinct species of orange, it is usually eaten plain or in fruit salads." });
            fruits.Add(new Fruit() { FruitName = "Limes", FruitTypeName = "Citrus", Details = "A lime, is a citrus fruit, which is typically round, green in color, 3–6 centimetres in diameter, and contains acidic juice vesicles. There are several species of citrus trees whose fruits are called limes, including the Key lime, Persian lime, kaffir lime, and desert lime." });
            fruits.Add(new Fruit() { FruitName = "Nectarines", FruitTypeName = "Stone Fruit", Details = "Nectarines are a round, yellow-red stone fruit that are about the size of an apple. They have a smooth, firm skin on the outside and a white-yellow flesh inside – both of which are edible –and in the centre, a hard stone or kernel, which is inedible." });
            fruits.Add(new Fruit() { FruitName = "Apricots", FruitTypeName = "Stone Fruit", Details = "An apricot is a fruit, or the tree that bears the fruit, of several species in the genus Prunus. Usually, an apricot is from the species P. armeniaca, but the fruits of the other species in Prunus sect. Armeniaca are also called apricots." });
            fruits.Add(new Fruit() { FruitName = "Peaches", FruitTypeName = "Stone Fruit", Details = "The peach (Prunus persica) is a deciduous tree native to the region of Northwest China between the Tarim Basin and the north slopes of the Kunlun Mountains, where it was first domesticated and cultivated. It bears edible juicy fruits with various characteristics, most called peaches and others (the glossy-skinned varieties), nectarines." });
            fruits.Add(new Fruit() { FruitName = "Plums", FruitTypeName = "Stone Fruit", Details = "A plum is a fruit of some species in Prunus subg. Prunus. Mature plum fruits may have a dusty-white waxy coating that gives them a glaucous appearance. This is an epicuticular wax coating and is known as \"wax bloom\". Dried plums are called prunes, which have a dark, wrinkled appearance." });
            fruits.Add(new Fruit() { FruitName = "Bananas", FruitTypeName = "Tropical", Details = "Bananas are among the most important food crops on the planet. They come from a family of plants called Musa that are native to Southeast Asia and grown in many of the warmer areas of the world. Bananas are a healthy source of fiber, potassium, vitamin B6, vitamin C, and various antioxidants and phytonutrients." });
            fruits.Add(new Fruit() { FruitName = "Mangoes", FruitTypeName = "Tropical", Details = "A mango is an edible stone fruit produced by the tropical tree Mangifera indica which is believed to have originated from the region between northwestern Myanmar, Bangladesh, and northeastern India." });
            fruits.Add(new Fruit() { FruitName = "Strawberries", FruitTypeName = "Berries", Details = "The garden strawberry is a widely grown hybrid species of the genus Fragaria, collectively known as the strawberries, which are cultivated worldwide for their fruit. The fruit is widely appreciated for its characteristic aroma, bright red color, juicy texture, and sweetness" });
            fruits.Add(new Fruit() { FruitName = "Raspberries", FruitTypeName = "Berries", Details = "The raspberry is the edible fruit of a multitude of plant species in the genus Rubus of the rose family, most of which are in the subgenus Idaeobatus. The name also applies to these plants themselves. Raspberries are perennial with woody stems." });
            fruits.Add(new Fruit() { FruitName = "Blueberries", FruitTypeName = "Berries", Details = "Blueberries are perennial flowering plants with blue or purple berries. They are classified in the section Cyanococcus within the genus Vaccinium. Vaccinium also includes cranberries, bilberries, huckleberries and Madeira blueberries. Commercial blueberries—both wild and cultivated —are all native to North America" });
            fruits.Add(new Fruit() { FruitName = "Kiwifruit", FruitTypeName = "Berries", Details = "Kiwifruit or Chinese gooseberry is the edible berry of several species of woody vines in the genus Actinidia. The most common cultivar group of kiwifruit is oval, about the size of a large hen's egg: 5–8 centimetres in length and 4.5–5.5 cm in diameter." });
            fruits.Add(new Fruit() { FruitName = "Passionfruit", FruitTypeName = "Berries", Details = "Passiflora edulis, commonly known as passion fruit, is a vine species of passion flower native to southern Brazil through Paraguay and northern Argentina. It is cultivated commercially in tropical and subtropical areas for its sweet, seedy fruit." });
            fruits.Add(new Fruit() { FruitName = "Watermelons", FruitTypeName = "Melons", Details = "Watermelon is a flowering plant species of the Cucurbitaceae family. A scrambling and trailing vine-like plant, it was originally domesticated in Africa. It is a highly cultivated fruit worldwide, with more than 1,000 varieties. Wild watermelon seeds have been found in the prehistoric Libyan site of Uan Muhuggiag." });
            fruits.Add(new Fruit() { FruitName = "Rockmelons ", FruitTypeName = "Melons", Details = "The cantaloupe, rockmelon, sweet melon, or spanspek is a melon that is a variety of the muskmelon species from the family Cucurbitaceae. Cantaloupes range in weight from 0.5 to 5 kilograms." });
            fruits.Add(new Fruit() { FruitName = "Honeydew Melons", FruitTypeName = "Melons", Details = "The honeydew melon is one of the two main cultivar types in Cucumis melo Inodorus Group. It is characterized by the smooth rind and lack of musky odor. The other main type in the Inodorus Group is the wrinkle-rind casaba melon." });
            return fruits;
        }
    }
}
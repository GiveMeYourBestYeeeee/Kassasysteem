using kassa.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace kassa.Forms
{
    public partial class OrderForm : Form
    {
        private string category = "dairy";

        private List<Item> _dairy;

        private List<Item> _fruit;

        private List<Item> _meat;

        private List<Item> _soda;

        private List<Item> _vegetables;
        
        public OrderForm()
        {
            InitializeComponent();
            generateData();
            
            // first page
            generateButtons(_dairy);
        }

        private void generateData()
        {
            _dairy = new List<Item>();

            Item cheese = new Item("cheese");
            _dairy.Add(cheese);
            
            Item milk = new Item("milk");
            _dairy.Add(milk);
            
            Item skinnyYoghurt = new Item("skinnyYoghurt");
            _dairy.Add(skinnyYoghurt);
            
            Item yoghurt = new Item("yoghurt");
            _dairy.Add(yoghurt);


            _fruit = new List<Item>();

            Item apple = new Item("apple");
            _fruit.Add(apple);

            Item benaan = new Item("benaan");
            _fruit.Add(benaan);

            Item kiwi = new Item("kiwi");
            _fruit.Add(kiwi);

            Item applesauce = new Item("applesauce");
            _fruit.Add(applesauce);

            _meat = new List<Item>();

            Item salami = new Item("salami"); 
            _meat.Add(salami);

            Item sandwichsausage = new Item("sandwichsausage");
            _meat.Add(sandwichsausage);

            Item bloodsausage = new Item("bloodsausage");
            _meat.Add(bloodsausage);

            Item bakedbacon = new Item("bakedbacon");
            _meat.Add(bakedbacon);

            _soda = new List<Item>();

            Item pepsi = new Item("pepsi");
            _soda.Add(pepsi);

            Item redbull = new Item("redbull");
            _soda.Add(redbull);

            Item sisi = new Item("sisi");
            _soda.Add(sisi);

            Item cocacola = new Item("cocacola");
            _soda.Add(cocacola);

            _vegetables = new List<Item>();

            Item rucolamix = new Item("rucolamix");
            _vegetables.Add (rucolamix);

            Item eggplant = new Item("eggplant");
            _vegetables.Add (eggplant);

            Item broccoli = new Item("broccoli");
            _vegetables.Add (broccoli);

            Item tomato = new Item("tomato");
            _vegetables.Add (tomato);





        }

        private void generateButtons(List<Item> items)
        {
            this.buttonGroupBox.Controls.Clear();
            int index = 0;

            for (int y = 0; y < items.Count / 2; y++)
            {
                for (int x = 0; x < items.Count / 2; x++)
                {
                    Button button = new Button();

                    button.Image = Image.FromFile(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\..\\..\\Images\\Items\\" + items[index].Name.ToLower() + ".png");
                    button.Size = new Size(150, 150);
                    button.Location = new Point(150 * x, 150 * y);
                    button.Name = items[index].ItemCode;
                    button.Click += new EventHandler(DynamicButton_Click);

                    this.buttonGroupBox.Controls.Add(button);
                    index++;
                }
            }
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Button button = (Button) sender;

            switch (category)
            {
                case "dairy":
                    getInfo(_dairy, button.Name);
                    break;
                case "fruit":
                    getInfo(_fruit, button.Name);
                    break;
                case "meat":
                    getInfo(_meat, button.Name);
                    break;
                case "soda":
                    getInfo(_soda, button.Name);
                    break;
                case "vegetables":
                    getInfo(_vegetables, button.Name);
                    break;
                default:
                    break;
            }
        }

        private void getInfo(List<Item> items, string itemCode)
        {
            foreach (Item item in items)
            {
                if (item.ItemCode == itemCode)
                {
                    itemCodeInformation.Text = item.ItemCode;
                    nameInformation.Text = item.Name;
                    producerInformation.Text = item.ProducerName;
                }
            }
        }

        private void fruitButton_Click(object sender, EventArgs e)
        {
            generateButtons(_fruit);
            category = "fruit";
        }

        private void meatButton_Click(object sender, EventArgs e)
        {
            generateButtons(_meat);
            category = "meat";
        }

        private void sodaButton_Click(object sender, EventArgs e)
        {
            generateButtons(_soda);
            category = "soda";
        }

        private void vegetablesButton_Click(object sender, EventArgs e)
        {
            generateButtons(_vegetables);
            category = "vegetables";
        }

        private void dairyButton_Click(object sender, EventArgs e)
        {
            generateButtons(_dairy);
            category = "dairy";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HuangLiang.ASP.MVC.Models
{
    public class Menu
    {
        private int id;

        public int Id { get => id; set => id = value; }
        public string Text { get => text; set => text = value; }
        public double Price { get => price; set => price = value; }
        public string Category { get => categary; set => categary = value; }

        private string text;
        private double price;
        private string categary;


    }
}
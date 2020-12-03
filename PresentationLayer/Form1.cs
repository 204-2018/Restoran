using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public readonly RestaurantBusiness restaurantBusiness;
        public Form1()
        {
            this.restaurantBusiness = new RestaurantBusiness();
            InitializeComponent();
        }

        private void RefreshData()
        {
            List<Restaurant> result = this.restaurantBusiness.GettAll();

            listBox1.Items.Clear();
            foreach(Restaurant r in result)
            {
                listBox1.Items.Add(r.Id + "  " + r.Title + "  " + r.Description + "  " + r.Price);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Restaurant r = new Restaurant();
            r.Title = textBoxTitle.Text;
            r.Description = textBoxDescription.Text;
            r.Price = Convert.ToDecimal(textBoxPrice.Text);

            if (this.restaurantBusiness.InsertMenuItems(r))
            {
                RefreshData();
                textBoxTitle.Clear();
                textBoxDescription.Clear();
                textBoxPrice.Clear();
            }
            else
                MessageBox.Show("Eror");
        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            decimal min, max;
            min = Convert.ToDecimal(textBoxMin.Text);
            max = Convert.ToDecimal(textBoxMax.Text);

            List<Restaurant> betweenprice = this.restaurantBusiness.GetBetweenPrice(min, max);

            listBox2.Items.Clear();
            
            foreach(Restaurant r in betweenprice)
            {
                listBox2.Items.Add(r.Id + "  " + r.Title + "  " + r.Description + "  " + r.Price);
            }
      
        }
    }
}

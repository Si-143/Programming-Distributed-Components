using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string searchID;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ts348DataSet2.COMP1690_Restaurants' table. You can move, or remove it, as needed.
            this.cOMP1690_RestaurantsTableAdapter2.Fill(this.ts348DataSet2.COMP1690_Restaurants);



        }
        //old
        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //if (CheckComp.check(aPost.Text))
        //    //{
        //    //    MessageBox.Show("Invalid post code please try again");
        //    //}
        //    //else
        //    //{
        //    addR();
        //    //}
        //}
        private void button1_Click_1(object sender, EventArgs e)
        {
            addR();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    searchID = SearchBox.Text;
        //    searchR();
        //    //OpenImage();




        //}





        // old code
        //private void PriceC_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    PriceC.check(sender, e);
        //}

        //private void PriceC_TextChanged(object sender, EventArgs e)
        //{

        //    if (PriceC.Text.Length == 0)
        //    {
        //        //if the value is null or 0

        //    }
        //    else
        //    {
        //        decimal num = decimal.Parse(PriceC.Text);
        //        if (PriceC.colour(num))
        //        {
        //            PriceC.ForeColor = Color.Red;


        //        }
        //        else
        //        {
        //            PriceC.ForeColor = Color.Black;
        //        }

        //    }

        //}

        private void Search_Click(object sender, EventArgs e)
        {
            searchID = SearchBox.Text;
            searchR();
        }


        private void Upload_Click_1(object sender, EventArgs e)
        {

            getImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void PriceC_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            PriceC.check(sender, e);
        }

        private void PriceC_TextChanged_1(object sender, EventArgs e)
        {

            if (PriceC.Text.Length == 0)
            {
                //if the value is null or 0

            }
            else
            {
                decimal num = decimal.Parse(PriceC.Text);
                if (PriceC.colour(num))
                {
                    PriceC.ForeColor = Color.Red;


                }
                else
                {
                    PriceC.ForeColor = Color.Black;
                }

            }
        }

        private void Edit()
        {
            //try
            //{
            //   // PriceBox.Text = .add(Decimal.Parse(txtNum1.Text), Decimal.Parse(txtNum2.Text)).ToString();
            //}
            //catch (Exception)
            //{
            //    //lblResult.Text = "You need to enter numerical input";
            //}
            byte[] setImage;
            ImageConverter converter = new ImageConverter();
            setImage = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
            decimal price = Convert.ToDecimal(PriceC.Text);
            string myQuery = "UPDATE COMP1690_Restaurants SET Name= @Name ,Postcode= @Postcode ,RestType=@RestType ,Address_=@Address ,Email=@Email ,Average_Price=@Average_Price ,logo=@logo adType=@adType Where RestaurantID =@search";
            SqlConnection myConnection = new SqlConnection("Data Source=SQL-SERVER;Initial Catalog=ts348;Integrated Security=True");
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

            myCommand.Parameters.AddWithValue("@Name", aName.Text);
            myCommand.Parameters.AddWithValue("@Postcode", aPost.Text);
            myCommand.Parameters.AddWithValue("@RestType", aType.Text);
            myCommand.Parameters.AddWithValue("@Address", aAddress.Text);
            myCommand.Parameters.AddWithValue("@Email", aEmail.Text);
            myCommand.Parameters.AddWithValue("@Average_Price", price);
            myCommand.Parameters.AddWithValue("@logo", setImage);
            myCommand.Parameters.AddWithValue("@adType", ADbox.Text);
            myCommand.Parameters.AddWithValue("@search", SearchBox.Text);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();


            }
            finally
            {
                myConnection.Close();
            }
        }
        private void addR()
        {
            byte[] setImage;
            ImageConverter converter = new ImageConverter();
            setImage = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));

            //if (pictureBox1.Image != pictureBox1.ErrorImage)
            //{
            //    // image exist
            //}

            decimal price = Convert.ToDecimal(PriceC.Text);
            string myQuery = "INSERT INTO COMP1690_Restaurants (Name,Postcode,RestType,Address_,Email,Average_Price,logo,adType) VALUES(@Name,@Postcode,@RestType,@Address,@Email,@Average_Price,@logo,@adType)";
            SqlConnection myConnection = new SqlConnection("Data Source=SQL-SERVER;Initial Catalog=ts348;Integrated Security=True");
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
            myCommand.Parameters.AddWithValue("@Name", aName.Text);
            myCommand.Parameters.AddWithValue("@Postcode", aPost.Text);
            myCommand.Parameters.AddWithValue("@RestType", aType.Text);
            myCommand.Parameters.AddWithValue("@Address", aAddress.Text);
            myCommand.Parameters.AddWithValue("@Email", aEmail.Text);
            myCommand.Parameters.AddWithValue("@Average_Price", price);
            myCommand.Parameters.AddWithValue("@logo", setImage);
            myCommand.Parameters.AddWithValue("@adType", ADbox.Text);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();


            }
            finally
            {
                myConnection.Close();
            }
        }
        private void searchR()
        {
            string myQuery = "SELECT Name,Postcode,RestType,Address_,Email,Average_Price,adType,logo FROM COMP1690_Restaurants Where RestaurantID ='" + searchID + "'";
            SqlConnection myConnection = new SqlConnection(("Data Source=SQL-SERVER;Initial Catalog=ts348;Integrated Security=True"));
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
            SqlDataReader myReader;
            int ID = Int32.Parse(SearchBox.Text);

            try
            {

                myConnection.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    eName.Text = myReader["Name"].ToString();
                    ePost.Text = myReader["Postcode"].ToString();
                    eType.Text = myReader["RestType"].ToString();
                    eAddress.Text = myReader["Address_"].ToString();
                    eEmail.Text = myReader["Email"].ToString();
                    Ecomp.Text = myReader["Average_Price"].ToString();
                    ADbox.Text = myReader["adType"].ToString();
                    Ecomp.BackColor = Color.Yellow;


                    byte[] data = (byte[])myReader["logo"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox2.Image = Image.FromStream(ms);








                }
                myReader.Close();
                //image 
                //byte[] image = (byte[])myCommand.ExecuteScalar();
                //MemoryStream stream = new MemoryStream(image);
                //pictureBox1.Image = Image.FromStream(stream);



            }
            finally
            {
                myConnection.Close();
            }


        }

        private void getImage()
        {

            // open file dialog 
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                // display image in picture box
                Bitmap jug = new Bitmap(Image.FromFile(open.FileName), new Size(120, 120));
                pictureBox1.Image = jug;
                // image file path
                //textBox1.Text = open.FileName;
            }
        }
        private void OpenImage()
        {

            string myQuery = "SELECT logo FROM COMP1690_Restaurants Where RestaurantID ='" + searchID + "'";
            SqlConnection myConnection = new SqlConnection(("Data Source=SQL-SERVER;Initial Catalog=ts348;Integrated Security=True"));
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
            SqlDataReader myReader;

            try
            {
                myConnection.Open();

                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {

                    byte[] data = (byte[])myReader["logo"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox1.Image = Image.FromStream(ms);
                    myConnection.Close();

                }
                myReader.Close();
                //  image 
                //byte[] image = (byte[])myCommand.ExecuteScalar();
                //MemoryStream stream = new MemoryStream(image);
                //pictureBox1.Image = Image.FromStream(stream);

            }
            finally
            {
                myConnection.Close();
            }

        }

        private void Change_Click(object sender, EventArgs e)
        {
            getImage();
        }



    }
}

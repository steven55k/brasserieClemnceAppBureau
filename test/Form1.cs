using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private List<Ingredient> lesIngredients = new List<Ingredient>();
        private List<Recette> lesRecettes = new List<Recette>();



        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn;
            string maCo = "server=172.19.0.17;uid=clientsql;pwd=0550002D;database=brasserieClemence;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = maCo;
            conn.Open();

            //afficher les recettes
            string requete = "select * from Recette";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            listBox2.Items.Clear();

            while (rdr.Read())
            {


                listBox2.Items.Add(rdr.GetString(1));


            }


            rdr.Close();

            string requete2 = "select * from Ingredient";
            MySqlCommand cmd2 = new MySqlCommand(requete2, conn);
            MySqlDataReader rdr2 = cmd2.ExecuteReader();

            listBox1.Items.Clear();

            while (rdr2.Read())
            {


                listBox1.Items.Add(rdr2.GetString(1));


            }


            rdr2.Close();
            conn.Close();


        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // ajouter un ingredient dans la bdd
            string nom = tb_nom.Text;
            bool bio;
            if (cb_oui.Checked == true)
            {
                bio = true;
            }
            else
            {
                bio = false;
            }

            Ingredient unIn = new Ingredient(nom, bio);
            lesIngredients.Add(unIn);



            MySqlConnection conn;
            string maCo = "server=172.19.0.17;uid=clientsql;pwd=0550002D;database=brasserieClemence;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = maCo;
            conn.Open();


            string MyInsertQuery = "INSERT INTO Ingredient ( `nomIngredient`, `bio`) VALUES ('" + unIn.getNom() + "', " + unIn.getBio() + ")";
            MySqlCommand maCommande = new MySqlCommand(MyInsertQuery);
            maCommande.Connection = conn;
            maCommande.ExecuteNonQuery();

            string requete = "select * from Ingredient";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            listBox1.Items.Clear();

            while (rdr.Read())
            {


                listBox1.Items.Add(rdr.GetString(1));


            }


            rdr.Close();
            conn.Close();



        }

      
        private void Cb_oui_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // ajouter une nouvelle recette
            string nom = textBox1.Text;
            DateTime localDate = DateTime.Now;

            Recette unRe = new Recette(nom, localDate);
            lesRecettes.Add(unRe);



            MySqlConnection conn;
            string maCo = "server=172.19.0.17;uid=clientsql;pwd=0550002D;database=brasserieClemence;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = maCo;
            conn.Open();


            string MyInsertQuery = "INSERT INTO Recette ( `nomRecette`, `creeLe`) VALUES ('" + unRe.getNom() + "','" + unRe.getCreeLe().Year + "-" + unRe.getCreeLe().Month + "-" + unRe.getCreeLe().Day + "' )";

            MySqlCommand maCommande = new MySqlCommand(MyInsertQuery);
            maCommande.Connection = conn;
            maCommande.ExecuteNonQuery();

            string requete = "select * from Recette";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            listBox2.Items.Clear();

            while (rdr.Read())
            {


                listBox2.Items.Add(rdr.GetString(1));


            }


            rdr.Close();
            conn.Close();

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // voir le détail de la recette séléctionnée
            SqlConnection conn;
            string maCo = "server=172.19.0.17;uid=clientsql;pwd=0550002D;database=brasserieClemence;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = maCo;
            conn.Open();

            string MyInsertQuery = "SELECT * FROM Recette WHERE nomRecette = '" + listBox2.SelectedItem.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(MyInsertQuery, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                label10.Text = rdr.GetString(0);
                label6.Text = rdr.GetString(1);
                label8.Text = rdr.GetString(2);
            }


            rdr.Close();
            conn.Close();

            // affiche les ingrédients de la recette
            listBox3.Items.Clear();
            MySqlConnection conn2;
            string maCo2 = "server=172.19.0.17;uid=clientsql;pwd=0550002D;database=brasserieClemence;";
            conn2 = new MySql.Data.MySqlClient.MySqlConnection();
            conn2.ConnectionString = maCo2;
            conn2.Open();

            string MaRequete = "SELECT nomIngredient, QuantiteCompo FROM Ingredient inner join Composition on Composition.idIngredient = Ingredient.idIngredient WHERE Ingredient.idIngredient AND idRecette=" + label10.Text + "";
            MySqlCommand cmd2 = new MySqlCommand(MaRequete, conn2);
            MySqlDataReader rdr2 = cmd2.ExecuteReader();
           

            while (rdr2.Read() )
            {
                listBox3.Items.Add(Convert.ToString(rdr2[0]) + ": il faut  " + Convert.ToString(rdr2[1]) + "ml pour 1L de cette Bière."); 
            }

           
            rdr2.Close();
            conn2.Close();
        }

    

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ajouter L'ingrédient séléctionné + sa quantité à la recette séléctionnée

            MySqlConnection conn;
            string maCo = "server=172.19.0.17;uid=clientsql;pwd=0550002D;database=brasserieClemence;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = maCo;
            conn.Open();

            string MyInsertQuery = "INSERT INTO Composition (`QuantiteCompo`, `idIngredient`, `idRecette`) Values (" + textBox2.Text.ToString() + ", (SELECT idIngredient FROM Ingredient WHERE nomIngredient ='" + listBox1.SelectedItem.ToString() + "'),(SELECT idRecette FROM Recette WHERE nomRecette ='" + label6.Text + " ')); ";
            MySqlCommand cmd = new MySqlCommand(MyInsertQuery, conn);
            cmd.ExecuteNonQuery();
            label14.Text = listBox1.SelectedItem.ToString();
            listBox3.Items.Clear();

            // affiche les ingrédients de la recette
            string MaRequete = "SELECT nomIngredient, QuantiteCompo FROM Ingredient inner join Composition on Composition.idIngredient = Ingredient.idIngredient WHERE Ingredient.idIngredient AND idRecette=" + label10.Text + "";
            MySqlCommand cmd2 = new MySqlCommand(MaRequete, conn);
            MySqlDataReader rdr = cmd2.ExecuteReader();

           


            while (rdr.Read())
            {
                listBox3.Items.Add(Convert.ToString(rdr[0]) + " en quantité "+ Convert.ToString(rdr[1])); 
            }

            
            rdr.Close();
            conn.Close();
        }

    




    

        private void button7_Click(object sender, EventArgs e)
        {
            // affiche les ingrédients de la recette
            listBox3.Items.Clear();
            MySqlConnection conn;
            string maCo = "server=172.19.0.17;uid=clientsql;pwd=0550002D;database=brasserieClemence;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = maCo;
            conn.Open();

           
            string MyInsertQuery = "SELECT nomIngredient FROM Ingredient WHERE idIngredient IN (SELECT idIngredient FROM Composition WHERE idRecette=" + label10.Text + ")";
            MySqlCommand cmd = new MySqlCommand(MyInsertQuery, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listBox3.Items.Add(Convert.ToString(rdr[0]));
            }


            rdr.Close();
            conn.Close();
        }

        private void lesQuantite_Click(object sender, EventArgs e)
        {
            // calcule les doses nécessaires pour réaliser la quantité de bière souhaité
            MySqlConnection conn;
            string maCo = "server=172.19.0.17;uid=clientsql;pwd=0550002D;database=brasserieClemence;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = maCo;
            conn.Open();

            //string requete = "SELECT nomIngredient, quantite FROM composition INNER JOIN ingredient ON composition.idIngredient = ingredient.idIngredient WHERE composition.idRecette =" + label6.Text;
            string requete = "SELECT nomRecette, QuantiteCompo FROM Composition INNER JOIN Recette ON Composition.idRecette = Recette.idRecette WHERE Composition.idRecette =" + label10.Text;
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                //calcule la quantité de chaque ingrédients (quantité de bière demandé * quantité de l'ingrédient pour 1L / 1L)
                int q = Convert.ToInt32(tb_qBiere.Text) * Convert.ToInt32(rdr[1]) / 1000;
                lb_qNecessaire.Items.Add(Convert.ToString(rdr[1] + " : " + q + "ml"));
            }
            rdr.Close();
            conn.Close();
        }
    }
}

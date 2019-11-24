using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MySQL_Lib
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            
                InitializeComponent();
                conn = new MySqlConnection("Server = localhost; Database = fozde; Uid = root; Pwd =;");
                conn.Open();
            cefreGroup.Enabled = false;
            cefretorles.Enabled = false;
            listCefre.Enabled = false;
            AdatokListazasa();
            
           
        }
        void AdatokListazasa()
        {
            listFozde.Items.Clear();
            listCefre.Items.Clear();
            var command = conn.CreateCommand();
            command.CommandText = @"SELECT id,nev,tulajdonos,alapitas FROM fozde ORDER BY nev";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var tulajdonos = reader.GetString("tulajdonos");
                    var alapitas = reader.GetDateTime("alapitas");

                    var fozde = new Fozde(id,nev,tulajdonos,alapitas);
                    listFozde.Items.Add(fozde);
                }
            }
            
        }

        private void Nev_Click(object sender, EventArgs e)
        {

        }

        private void hozzaad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nev.Text) || string.IsNullOrWhiteSpace(tulajdonos.Text))
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return; //void metódus futása megszakad return-el
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO fozde (nev, tulajdonos, alapitas) VALUES (@nev,@tulajdonos,@alapitas)";

            cmd.Parameters.AddWithValue("@nev", nev.Text);
            cmd.Parameters.AddWithValue("@tulajdonos", tulajdonos.Text);
            cmd.Parameters.AddWithValue("@alapitas", alapitasdatum.Value);

            cmd.ExecuteNonQuery();

            AdatokListazasa();

        }

        private void torles_Click(object sender, EventArgs e)
        {
            try
            {
                if (listFozde.SelectedIndex == -1)
                {
                    MessageBox.Show("Válasszon ki egy elemet a törléshez!");
                    return;
                }
                var cmd = conn.CreateCommand();

                cmd.CommandText = @"DELETE FROM fozde WHERE id = @id";

                var fozde = (Fozde)listFozde.SelectedItem;

                cmd.Parameters.AddWithValue("@id", fozde.Id);
                cmd.ExecuteNonQuery();
                AdatokListazasa();
            }
            catch (Exception)
            {

                MessageBox.Show("A kiválasztott főzdéhez már tartozik cefe, ezért azt nem lehet törölni!");
            }
            
        }

        private void listCefre_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT id,gyumolcs,alkohol,egysegar, fozde_id FROM cefre WHERE fozde_id = @fozde_id ORDER BY id";
            var fozde = (Fozde)listFozde.SelectedItem;
            cmd.Parameters.AddWithValue("@fozde_id", fozde.Id);
            cmd.ExecuteNonQuery();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var gyumolcs = reader.GetString("gyumolcs");
                    var alkohol = reader.GetInt32("alkohol");
                    var egysegar = reader.GetInt32("egysegar");
                    var fozde_id = reader.GetInt32("fozde_id");

                    var cefre = new Cefre(id, gyumolcs, alkohol, egysegar, fozde_id);

                    gyumolcstext.Text = gyumolcs;
                    alkoholtext.Text = alkohol.ToString();
                    egysegartext.Text = egysegar.ToString();
                    fozde_idtext.Text = fozde_id.ToString();

                }
                
            }
            idszam.Text = listCefre.SelectedIndex.ToString();


        }

        private void listFozde_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listFozde.SelectedIndex;
            if (i >= 0)
            {
                cefreGroup.Enabled = true;
                cefretorles.Enabled = true;
                listCefre.Enabled = true;
                cefreListaz(i);
            }
            
        }

        private void cefretorles_Click(object sender, EventArgs e)
        {
            if (listCefre.SelectedIndex == -1)
            {
                MessageBox.Show("Válasszon ki egy elemet a törléshez!");
                return;
            }
            var cmd = conn.CreateCommand();

            cmd.CommandText = @"DELETE FROM cefre WHERE id = @id";

            var cefre = (Cefre)listCefre.SelectedItem;

            cmd.Parameters.AddWithValue("@id", cefre.Id);
            cmd.ExecuteNonQuery();
            AdatokListazasa();
        }

        private void hozzaadCefre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(gyumolcstext.Text) || string.IsNullOrWhiteSpace(alkoholtext.Text) || string.IsNullOrWhiteSpace(egysegartext.Text) || string.IsNullOrWhiteSpace(fozde_idtext.Text))
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return; //void metódus futása megszakad return-el
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO cefre (gyumolcs, alkohol, egysegar, fozde_id) VALUES (@gyumolcs,@alkohol,@egysegar,@fozde_id)";

            cmd.Parameters.AddWithValue("@gyumolcs", gyumolcstext.Text);
            cmd.Parameters.AddWithValue("@alkohol", alkoholtext.Text);
            cmd.Parameters.AddWithValue("@egysegar", egysegartext.Text);
            cmd.Parameters.AddWithValue("@fozde_id", fozde_idtext.Text);

            cmd.ExecuteNonQuery();

            AdatokListazasa();
        }
        private void cefreListaz(int f)
        {
            listCefre.Items.Clear();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT id,gyumolcs,alkohol,egysegar,fozde_id FROM cefre WHERE fozde_id = @fozde_id ORDER BY id";
            var fozde = (Fozde)listFozde.SelectedItem;
            cmd.Parameters.AddWithValue("@fozde_id", fozde.Id);
            cmd.ExecuteNonQuery();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var gyumolcs = reader.GetString("gyumolcs");
                    var alkohol = reader.GetInt32("alkohol");
                    var egysegar = reader.GetInt32("egysegar");
                    var fozde_id = reader.GetInt32("fozde_id");

                    var cefre = new Cefre(id, gyumolcs, alkohol, egysegar, fozde_id);
                    listCefre.Items.Add(cefre);

                }
            }
        }

        

        private void label12_Click(object sender, EventArgs e)
        {

        }

       

        private void modositCefre_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE cefre SET gyumolcs = '" + textBoxGyumolcs.Text + "', alkohol = '" + textBoxAlkohol.Text + "', egysegar = '" + textBoxEgysegar.Text + "', fozde_id = '" + textBoxFozde.Text + "' WHERE id =" + int.Parse(textBoxId.Text);
            MySqlCommand command = new MySqlCommand(updateQuery, conn);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Sikeres frissítés!");
                textBoxId.Text = "";
                textBoxGyumolcs.Text = "";
                textBoxAlkohol.Text = "";
                textBoxEgysegar.Text = "";
                textBoxFozde.Text = "";
            }
        }

        private void modositFozet_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE fozde SET nev = '" + textNev.Text + "', tulajdonos = '" + textTulaj.Text + "', alapitas = '" + dateAlapit.Value + "' WHERE id =" + int.Parse(textId.Text);
            MySqlCommand command = new MySqlCommand(updateQuery, conn);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Sikeres frissítés!");
                textId.Text = "";
                textNev.Text = "";
                textTulaj.Text = "";


            }
        }
    }
}

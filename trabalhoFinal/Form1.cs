using System.Xml.Serialization;

namespace trabalhoFinal
{
    public partial class Form1 : Form
    {
        int cidadeOrigem = -1;
        int cidadeDestino = -1;
        string cidadeOrigemStr;
        string cidadeDestinoStr;

        public enum Cidades
        {
            Uberlandia,
            Tupaciguara,
            MonteAlegreDeMinas,
            Douradinhos,
            Itumbiara,
            Centralina,
            Ituiutaba,
            Capinopolis,
            Araguari,
            Indianopolis,
            CascalhoRico,
            Grupiara,
            EstrelaDoSul,
            Romaria,
            SaoJuliana
        }

        GrafoCidades gCidades = new();

        public Form1()
        {
            InitializeComponent();

            gCidades.AddDistancia((int)Cidades.Uberlandia, (int)Cidades.Tupaciguara, 60);
            gCidades.AddDistancia((int)Cidades.Uberlandia, (int)Cidades.MonteAlegreDeMinas, 60);
            gCidades.AddDistancia((int)Cidades.Uberlandia, (int)Cidades.Douradinhos, 63);
            gCidades.AddDistancia((int)Cidades.Uberlandia, (int)Cidades.Araguari, 30);
            gCidades.AddDistancia((int)Cidades.Uberlandia, (int)Cidades.Romaria, 78);
            gCidades.AddDistancia((int)Cidades.Uberlandia, (int)Cidades.Indianopolis, 45);
            gCidades.AddDistancia((int)Cidades.Tupaciguara, (int)Cidades.Itumbiara, 55);
            gCidades.AddDistancia((int)Cidades.Tupaciguara, (int)Cidades.MonteAlegreDeMinas, 44);
            gCidades.AddDistancia((int)Cidades.MonteAlegreDeMinas, (int)Cidades.Douradinhos, 28);
            gCidades.AddDistancia((int)Cidades.MonteAlegreDeMinas, (int)Cidades.Ituiutaba, 85);
            gCidades.AddDistancia((int)Cidades.MonteAlegreDeMinas, (int)Cidades.Centralina, 75);
            gCidades.AddDistancia((int)Cidades.Douradinhos, (int)Cidades.Ituiutaba, 90);
            gCidades.AddDistancia((int)Cidades.Araguari, (int)Cidades.CascalhoRico, 28);
            gCidades.AddDistancia((int)Cidades.Araguari, (int)Cidades.EstrelaDoSul, 34);
            gCidades.AddDistancia((int)Cidades.Indianopolis, (int)Cidades.SaoJuliana, 40);
            gCidades.AddDistancia((int)Cidades.SaoJuliana, (int)Cidades.Romaria, 28);
            gCidades.AddDistancia((int)Cidades.Romaria, (int)Cidades.EstrelaDoSul, 27);
            gCidades.AddDistancia((int)Cidades.EstrelaDoSul, (int)Cidades.Grupiara, 38);
            gCidades.AddDistancia((int)Cidades.Grupiara, (int)Cidades.CascalhoRico, 32);
            gCidades.AddDistancia((int)Cidades.Itumbiara, (int)Cidades.Centralina, 20);
            gCidades.AddDistancia((int)Cidades.Centralina, (int)Cidades.Capinopolis, 40);
            gCidades.AddDistancia((int)Cidades.Capinopolis, (int)Cidades.Ituiutaba, 30);

            lbDestino.Text = "";
            lbOrigem.Text = "";
        }

        private void LimparBotoes()
        {
            btnUber.BackColor = Color.Orange;
            btnArag.BackColor = Color.Orange;
            btnCapinop.BackColor = Color.Orange;
            btnCasca.BackColor = Color.Orange;
            btnCentra.BackColor = Color.Orange; 
            btnDourad.BackColor = Color.Orange;
            btnEstrela.BackColor = Color.Orange;    
            btnGrupiara.BackColor = Color.Orange;   
            btnIndia.BackColor = Color.Orange;  
            btnItuiu.BackColor = Color.Orange;  
            btnItumb.BackColor = Color.Orange;  
            btnMonte.BackColor = Color.Orange;  
            btnRomaria.BackColor = Color.Orange;    
            btnSaoJu.BackColor = Color.Orange;  
            btnTupa.BackColor = Color.Orange;

            cidadeOrigem = -1;
            cidadeDestino = -1;
            cidadeOrigemStr = "";
            cidadeDestinoStr = "";

            lbDestino.Text = "";
            lbOrigem.Text = "";
        }

        private void btnCapinop_Click(object sender, EventArgs e)
        {   
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.Capinopolis;
                lbOrigem.Text = "Capinópolis";
                cidadeOrigemStr = lbOrigem.Text;
                btnCapinop.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.Capinopolis;
                lbDestino.Text = "Capinópolis";
                cidadeDestinoStr = lbDestino.Text;
                btnCapinop.BackColor = Color.Green;
            }
        }

        private void btnItuiu_Click(object sender, EventArgs e)
        {
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.Ituiutaba;
                lbOrigem.Text = "Ituiutaba";
                cidadeOrigemStr = lbOrigem.Text;
                btnItuiu.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.Ituiutaba;
                lbDestino.Text = "Ituiutaba";
                cidadeDestinoStr = lbDestino.Text;
                btnItuiu.BackColor = Color.Green;
            }
        }

        private void btnCentra_Click(object sender, EventArgs e)
        {
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.Centralina;
                lbOrigem.Text = "Centralina";
                cidadeOrigemStr = lbOrigem.Text;
                btnCentra.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.Centralina;
                lbDestino.Text = "Centralina";
                cidadeDestinoStr = lbDestino.Text;
                btnCentra.BackColor = Color.Green;
            }
        }

        private void btnItumb_Click(object sender, EventArgs e)
        {
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.Itumbiara;
                lbOrigem.Text = "Itumbiara";
                cidadeOrigemStr = lbOrigem.Text;
                btnItumb.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.Itumbiara;
                lbDestino.Text = "Itumbiara";
                cidadeDestinoStr = lbDestino.Text;
                btnItumb.BackColor = Color.Green;
            }
        }

        private void btnMonte_Click(object sender, EventArgs e)
        {
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.MonteAlegreDeMinas;
                lbOrigem.Text = "Monte Alegre de Minas";
                cidadeOrigemStr = lbOrigem.Text;
                btnMonte.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.MonteAlegreDeMinas;
                lbDestino.Text = "Monte Alegre de Minas";
                cidadeDestinoStr = lbDestino.Text;
                btnMonte.BackColor = Color.Green;
            }
        }

        private void btnTupa_Click(object sender, EventArgs e)
        {
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.Tupaciguara;
                lbOrigem.Text = "Tupaciguara";
                cidadeOrigemStr = lbOrigem.Text;
                btnTupa.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.Tupaciguara;
                lbDestino.Text = "Tupaciguara";
                cidadeDestinoStr = lbDestino.Text;
                btnTupa.BackColor = Color.Green;
            }
        }

        private void btnDourad_Click(object sender, EventArgs e)
        {
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.Douradinhos;
                lbOrigem.Text = "Douradinhos";
                cidadeOrigemStr = lbOrigem.Text;
                btnDourad.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.Douradinhos;
                lbDestino.Text = "Douradinhos";
                cidadeDestinoStr = lbDestino.Text;
                btnDourad.BackColor = Color.Green;
            }
        }

        private void btnUber_Click(object sender, EventArgs e)
        {
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.Uberlandia;
                lbOrigem.Text = "Uberlândia";
                cidadeOrigemStr = lbOrigem.Text;
                btnUber.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.Uberlandia;
                lbDestino.Text = "Uberlândia";
                cidadeDestinoStr = lbDestino.Text;
                btnUber.BackColor = Color.Green;
            }
        }

        private void btnArag_Click(object sender, EventArgs e)
        {
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.Araguari;
                lbOrigem.Text = "Araguari";
                cidadeOrigemStr = lbOrigem.Text;
                btnArag.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.Araguari;
                lbDestino.Text = "Araguari";
                cidadeDestinoStr = lbDestino.Text;
                btnArag.BackColor = Color.Green;
            }
        }

        private void btnIndia_Click(object sender, EventArgs e)
        {
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.Indianopolis;
                lbOrigem.Text = "Indianópolis";
                cidadeOrigemStr = lbOrigem.Text;
                btnIndia.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.Indianopolis;
                lbDestino.Text = "Indianópolis";
                cidadeDestinoStr = lbDestino.Text;
                btnIndia.BackColor = Color.Green;
            }
        }

        private void btnCasca_Click(object sender, EventArgs e)
        {
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.CascalhoRico;
                lbOrigem.Text = "Cascalho Rico";
                cidadeOrigemStr = lbOrigem.Text;
                btnCasca.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.CascalhoRico;
                lbDestino.Text = "Cascalho Rico";
                cidadeDestinoStr = lbDestino.Text;
                btnCasca.BackColor = Color.Green;
            }
        }

        private void btnGrupiara_Click(object sender, EventArgs e)
        {
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.Grupiara;
                lbOrigem.Text = "Grupiara";
                cidadeOrigemStr = lbOrigem.Text;
                btnGrupiara.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.Grupiara;
                lbDestino.Text = "Grupiara";
                cidadeDestinoStr = lbDestino.Text;
                btnGrupiara.BackColor = Color.Green;
            }
        }

        private void btnEstrela_Click(object sender, EventArgs e)
        {
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.EstrelaDoSul;
                lbOrigem.Text = "Estrela do Sul";
                cidadeOrigemStr = lbOrigem.Text;
                btnEstrela.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.EstrelaDoSul;
                lbDestino.Text = "Estrela do Sul";
                cidadeDestinoStr = lbDestino.Text;
                btnEstrela.BackColor = Color.Green;
            }
        }

        private void btnRomaria_Click(object sender, EventArgs e)
        {
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.Romaria;
                lbOrigem.Text = "Romaria";
                cidadeOrigemStr = lbOrigem.Text;
                btnRomaria.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.Romaria;
                lbDestino.Text = "Romaria";
                cidadeDestinoStr = lbDestino.Text;
                btnRomaria.BackColor = Color.Green;
            }
        }

        private void btnSaoJu_Click(object sender, EventArgs e)
        {
            if (cidadeOrigem == -1 && cidadeDestino == -1)
            {
                cidadeOrigem = (int)Cidades.SaoJuliana;
                lbOrigem.Text = "São Juliana";
                cidadeOrigemStr = lbOrigem.Text;
                btnSaoJu.BackColor = Color.Red;
            }
            else if (cidadeOrigem != -1 && cidadeDestino == -1)
            {
                cidadeDestino = (int)Cidades.SaoJuliana;
                lbDestino.Text = "São Juliana";
                cidadeDestinoStr = lbDestino.Text;
                btnSaoJu.BackColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparBotoes();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (cidadeDestino == -1 || cidadeOrigem == -1)
            {
                MessageBox.Show("Selecione origem e destino antes de continuar");
                return;
            }

            Dijkstra caminhosInfo = new(gCidades.Distancias, 15, cidadeOrigem, cidadeDestino);

            int menorDist = caminhosInfo.MenoresDistancias[cidadeDestino];
            List<int> caminho = caminhosInfo.Anteriores;
            caminho.Reverse();
           
            //var destino = (Cidades)caminho[cidadeDestino];
            
            string caminho_str = "";

            foreach (int cidadeAnterior in caminho)
            {
                var cidadeAnteriorInt = (Cidades)cidadeAnterior;
                caminho_str += cidadeAnteriorInt.ToString() + " -> ";
            }

            MessageBox.Show("A menor distância entre " + cidadeOrigemStr + " e " + cidadeDestinoStr
                            + " é de " + menorDist.ToString() + " km"
                            + "\n\nO caminho com a menor distância é:\n"
                            + cidadeOrigemStr + " -> " + caminho_str + cidadeDestinoStr);
        }
    }
}
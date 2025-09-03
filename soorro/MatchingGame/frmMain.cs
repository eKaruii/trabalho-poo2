using System.Windows.Forms;
namespace MatchingGame
{
    public partial class frmMain : Form
    {
        private System.Windows.Forms.Timer timer;
        int tempoRestante;
        private bool isFormClosed = false;
        public frmMain(int tempo)
        {
            InitializeComponent();

            tempoRestante = tempo;
            IniciarTimer();

        }

        private void IniciarTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isFormClosed) return;
            label1.Text = "Tempo: " + tempoRestante.ToString();
            tempoRestante--;

            if (tempoRestante <= 0)
            {
                timer.Stop();
                MessageBox.Show("Fim do tempo!");
                telaInicial t = new telaInicial();
                t.Show();
                this.Close();
            }
        }
        Image[] pokemon = {
            Properties.Resources.abra,
            Properties.Resources.articuno,
            Properties.Resources.bellsprout,
            Properties.Resources.bulbasaur,
            Properties.Resources.caterpie,
            Properties.Resources.charmander,
            Properties.Resources.charmander__2_,
            Properties.Resources.dratini,
            Properties.Resources.eevee,
            Properties.Resources.jigglypuff,
            Properties.Resources.mankey,
            Properties.Resources.meowth,
            Properties.Resources.mew,
            Properties.Resources.pidgey,
            Properties.Resources.pikachu,
            Properties.Resources.psyduck,
            Properties.Resources.rattata,
            Properties.Resources.snorlax,
            Properties.Resources.squirtle,
            Properties.Resources.venonat,
            Properties.Resources.weedle
        };

        int[] index = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15, 16, 16, 17, 17, 18, 18, 19, 19, 20, 20 };
        Button firstPokemon;
        int firstIndex, found, movement;



        private void frmMain_Load(object sender, EventArgs e)
        {
            updateCards();
        }

        private void updateCards()
        {
            Random rnd = new Random();

            for (int i = 0; i < 42; i++)
            {
                int number = rnd.Next(0, 21);
                int temp = index[i];
                index[i] = index[number];
                index[number] = temp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;
            int buttonNo = int.Parse(button.Name.Substring(6));
            int indexNo = index[buttonNo - 1];
            button.BackgroundImage = pokemon[indexNo];
            button.Refresh();

            if (firstPokemon == null)
            {
                firstPokemon = button;
                firstIndex = indexNo;
                movement++;
            }
            else
            {
                System.Threading.Thread.Sleep(1000);
                firstPokemon.BackgroundImage = null;
                button.BackgroundImage = null;
                if (firstIndex == indexNo)
                {
                    found++;
                    label2.Text = "Pontuação: " + found.ToString();
                    button.BackColor = Color.MistyRose;
                    firstPokemon.BackColor = Color.MistyRose;
                    button.Click -= button1_Click;
                    firstPokemon.Click -= button1_Click;
                    button.BackgroundImage = pokemon[indexNo];
                    firstPokemon.BackgroundImage = pokemon[indexNo];
                    



                    if (found == 21)
                    {
                        MessageBox.Show("Parabéns! " + movement + " Você terminou a parada...");
                        tableLayoutPanel1.Enabled = false;
                        if (timer != null)
                        {
                            timer.Stop();
                        }
                    }
                }
                button.Enabled = true;
                firstPokemon.Enabled = true;
                firstPokemon = null;
            }
        }

        public frmMain()
        {
            InitializeComponent();
            updateCards();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            isFormClosed = true;

            if (timer != null)
            {
                timer.Stop();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pontosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tempoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {
            telaInicial telaInicial = new telaInicial();
            telaInicial.Show();
            if (timer != null)
            {
                timer.Stop();
            }
            this.Close();
        }

       

        
    }
}

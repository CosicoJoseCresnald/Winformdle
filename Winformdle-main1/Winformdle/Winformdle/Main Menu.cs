using System.Security.Policy;

namespace Winformdle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int gameModePick = 0;
        public static int languagePick = 0;
        public static int difficultyPick = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Visible = false;
            pnlLanguage.Visible = false;
            pnlDifficulty.Visible = false;
            pnlGameMode.Visible = true;

        }

        private void lblChooseDifficulty_Click(object sender, EventArgs e)
        {

        }



        private void btnEasy_Click(object sender, EventArgs e)
        {
            difficultyPick = 1;
            this.Hide();
            EnglishEasy form2 = new EnglishEasy();
            form2.Show();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            difficultyPick = 2;
            this.Hide();
            EnglishEasy form2 = new EnglishEasy();
            form2.Show();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            difficultyPick = 3;
            this.Hide();
            EnglishEasy form2 = new EnglishEasy();
            form2.Show();
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            languagePick = 1;
            pnlLanguage.Visible = false;
            pnlDifficulty.Visible = true;
        }

        private void btnTagalog_Click1(object sender, EventArgs e)
        {
            languagePick = 2;
            pnlLanguage.Visible = false;
            pnlDifficulty.Visible = true;
        }

        private void pnlLanguage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1Player_Click(object sender, EventArgs e)
        {
            gameModePick = 1;
            pnlGameMode.Visible = false;
            pnlMainMenu.Visible = false;
            pnlLanguage.Visible = true;
            pnlDifficulty.Visible =false;
        }

        private void btn2Player_Click(object sender, EventArgs e)
        {
            gameModePick = 2;
            pnlGameMode.Visible = false;
            pnlMainMenu.Visible = false;
            pnlLanguage.Visible = true;
            pnlDifficulty.Visible = false;
        }
    }
}

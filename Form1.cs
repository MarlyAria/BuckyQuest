using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuckyQuest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(154, 96, 1101, 434));
            game.NewLevel(random);
            UpdateCharacter();
        }

        public void UpdateCharacter()
        {
            Bucky.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;
            foreach (Enemy enemy in game.Enemies)
            {
                if(enemy is Bat)
                {
                    Bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.Hitpoints.ToString();
                    if(enemy.Hitpoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    Ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.Hitpoints.ToString();
                    if (enemy.Hitpoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    Ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.Hitpoints.ToString();
                    if (enemy.Hitpoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
        }

       
    }
}

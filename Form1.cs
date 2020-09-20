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
        List<PictureBox> inventoryBoxes = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(154, 96, 1101, 434));
            game.NewLevel(random);
            UpdateCharacter();

            inventoryBoxes.Add(swordInventory);
            inventoryBoxes.Add(bluePotionInventory);
            inventoryBoxes.Add(bowInventory);
            inventoryBoxes.Add(redPotionInventory);
            inventoryBoxes.Add(maceInventory);
        }

        public void UpdateCharacter()
        {
            Bucky.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;
           
            //this code creates the enemies and also makes them invisible
            foreach (Enemy enemy in game.Enemies)
            {
                if(enemy is Bat)
                {
                    batGame.Location = enemy.Location;
                    batHitPoints.Text = enemy.Hitpoints.ToString();
                    if(enemy.Hitpoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    ghostGame.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.Hitpoints.ToString();
                    if (enemy.Hitpoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    ghoulGame.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.Hitpoints.ToString();
                    if (enemy.Hitpoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            if(showBat == false)
            {
                batGame.Visible = false;
                batHitPoints.Text = "";
            }
            if(showGhost == false)
            {
                ghostGame.Visible = false;
                ghostHitPoints.Text = "";
            }
            if(showGhoul == false)
            {
                ghoulGame.Visible = false;
                ghoulHitPoints.Text = "";
            }

            //weapons code
            swordGame.Visible = false;
            bowGame.Visible = false;
            redPotionGame.Visible = false;
            bluePotionGame.Visible = false;
            maceGame.Visible = false;

            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = swordGame; break;
                case "Bow":
                    weaponControl = bowGame; break;
                case "Mace":
                    weaponControl = maceGame; break;
                case "Red Potion":
                    weaponControl = redPotionGame; break;
                case "Blue Potion":
                    weaponControl = bluePotionGame; break;
                default:
                    break;
            }
            weaponControl.Visible = true;

            //check the game object's checkinventory method
            //to ffigure out wether to display inventory icons
            if (game.CheckPlayerInventory("Sword") == true)
                swordInventory.Visible = true;
            else
                swordInventory.Visible = false;

            if (game.CheckPlayerInventory("Bow") == true)
                bowInventory.Visible = true;
            else
                bowInventory.Visible = false;

            if (game.CheckPlayerInventory("Mace") == true)
                maceGame.Visible = true;
            else
                maceGame.Visible = false;
           
            if (game.CheckPlayerInventory("Blue Potion") == true)
                bluePotionInventory.Visible = true;
            else
                bluePotionInventory.Visible = false;
          
            if (game.CheckPlayerInventory("Red Potion") == true)
                redPotionInventory.Visible = true;
            else
                redPotionInventory.Visible = false;

            //check the progress of the game

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;

            if(game.PlayerHitPoints <=0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }

            if (enemiesShown <1)
            {
                MessageBox.Show("You have defeated the enemies on this level!!!");
                game.NewLevel(random);
                if (game.Level < 8)
                    UpdateCharacter();
            }
        }

        public void formEquip(string weaponName, string pictureBoxName)
        {
            if (game.CheckPlayerInventory(weaponName) == true)
            {
                game.Equip(weaponName);

                foreach (PictureBox item in inventoryBoxes)
                {
                    if (item.Name == pictureBoxName)
                    {
                        item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    }
                    else
                    {
                        item.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    }
                }
            }
        }

        private void MoveUpButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacter();
        }

        private void MoveLeftButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacter();
        }

        private void MoveRightButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacter();
        }

        private void MoveDownButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacter();
        }

        private void AttackUpButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacter();
        }

        private void AttackLeftButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacter();
        }

        private void AttackRightButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacter();
        }

        private void AttackDownButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacter();
        }

        private void potionEquipButtons()
        {
            AttackDownButton.Visible = false;
            AttackLeftButton.Visible = false;
            AttackRightButton.Visible = false;
            AttackUpButton.Text = "drink";
        }

        private void WeaponEquipButtons()
        {
            AttackUpButton.Text = "↑";
            AttackRightButton.Visible = true;
            AttackLeftButton.Visible = true;
            AttackDownButton.Visible = true;               ;
        }

        private void swordInventory_Click(object sender, EventArgs e)
        {
            formEquip("Sword", "swordInventory");
            WeaponEquipButtons();
        }

        private void bowInventory_Click(object sender, EventArgs e)
        {
            formEquip("Bow", "bowInventory");
            WeaponEquipButtons();
        }

        private void maceInventory_Click(object sender, EventArgs e)
        {
            formEquip("Mace", "maceInventory");
            WeaponEquipButtons();
        }

        private void bluePotionInventory_Click(object sender, EventArgs e)
        {
            formEquip("Blue Potion", "bluePotionInventory");
            potionEquipButtons();
        }

        private void redPotionInventory_Click(object sender, EventArgs e)
        {
            formEquip("Red Potion", "redPotionInventory");
            potionEquipButtons();
        }
    }
}

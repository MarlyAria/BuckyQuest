namespace BuckyQuest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statsWindow = new System.Windows.Forms.TableLayoutPanel();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.GhoulLabel = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.GhostLabel = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.BatLabel = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.Bucky = new System.Windows.Forms.PictureBox();
            this.Bat = new System.Windows.Forms.PictureBox();
            this.Ghost = new System.Windows.Forms.PictureBox();
            this.Ghoul = new System.Windows.Forms.PictureBox();
            this.Bow = new System.Windows.Forms.PictureBox();
            this.Mace = new System.Windows.Forms.PictureBox();
            this.BluePotion = new System.Windows.Forms.PictureBox();
            this.RedPotion = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.AttackBox = new System.Windows.Forms.GroupBox();
            this.AttackRightButton = new System.Windows.Forms.Button();
            this.AttackLeftButton = new System.Windows.Forms.Button();
            this.AttackDownButton = new System.Windows.Forms.Button();
            this.AttackUpButton = new System.Windows.Forms.Button();
            this.MoveBox = new System.Windows.Forms.GroupBox();
            this.MoveRightButton = new System.Windows.Forms.Button();
            this.MoveLeftButton = new System.Windows.Forms.Button();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.swordInventory = new System.Windows.Forms.PictureBox();
            this.bowInventory = new System.Windows.Forms.PictureBox();
            this.maceInventory = new System.Windows.Forms.PictureBox();
            this.BluePotionInventory = new System.Windows.Forms.PictureBox();
            this.RedPotionInventory = new System.Windows.Forms.PictureBox();
            this.statsWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bucky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.AttackBox.SuspendLayout();
            this.MoveBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swordInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // statsWindow
            // 
            this.statsWindow.BackColor = System.Drawing.Color.Transparent;
            this.statsWindow.ColumnCount = 2;
            this.statsWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.statsWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.statsWindow.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.statsWindow.Controls.Add(this.GhoulLabel, 0, 3);
            this.statsWindow.Controls.Add(this.ghostHitPoints, 1, 2);
            this.statsWindow.Controls.Add(this.GhostLabel, 0, 2);
            this.statsWindow.Controls.Add(this.batHitPoints, 1, 1);
            this.statsWindow.Controls.Add(this.BatLabel, 0, 1);
            this.statsWindow.Controls.Add(this.playerHitPoints, 1, 0);
            this.statsWindow.Controls.Add(this.PlayerLabel, 0, 0);
            this.statsWindow.Location = new System.Drawing.Point(720, 447);
            this.statsWindow.Name = "statsWindow";
            this.statsWindow.RowCount = 4;
            this.statsWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.statsWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.statsWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.statsWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.statsWindow.Size = new System.Drawing.Size(240, 93);
            this.statsWindow.TabIndex = 12;
            this.statsWindow.UseWaitCursor = true;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(99, 69);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(14, 15);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.Text = "0";
            this.ghoulHitPoints.UseWaitCursor = true;
            // 
            // GhoulLabel
            // 
            this.GhoulLabel.AutoSize = true;
            this.GhoulLabel.Location = new System.Drawing.Point(3, 69);
            this.GhoulLabel.Name = "GhoulLabel";
            this.GhoulLabel.Size = new System.Drawing.Size(40, 15);
            this.GhoulLabel.TabIndex = 6;
            this.GhoulLabel.Text = "Ghoul";
            this.GhoulLabel.UseWaitCursor = true;
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(99, 46);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(14, 15);
            this.ghostHitPoints.TabIndex = 5;
            this.ghostHitPoints.Text = "0";
            this.ghostHitPoints.UseWaitCursor = true;
            // 
            // GhostLabel
            // 
            this.GhostLabel.AutoSize = true;
            this.GhostLabel.Location = new System.Drawing.Point(3, 46);
            this.GhostLabel.Name = "GhostLabel";
            this.GhostLabel.Size = new System.Drawing.Size(39, 15);
            this.GhostLabel.TabIndex = 4;
            this.GhostLabel.Text = "Ghost";
            this.GhostLabel.UseWaitCursor = true;
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(99, 23);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(14, 15);
            this.batHitPoints.TabIndex = 3;
            this.batHitPoints.Text = "0";
            this.batHitPoints.UseWaitCursor = true;
            // 
            // BatLabel
            // 
            this.BatLabel.AutoSize = true;
            this.BatLabel.Location = new System.Drawing.Point(3, 23);
            this.BatLabel.Name = "BatLabel";
            this.BatLabel.Size = new System.Drawing.Size(25, 15);
            this.BatLabel.TabIndex = 2;
            this.BatLabel.Text = "Bat";
            this.BatLabel.UseWaitCursor = true;
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(99, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(14, 15);
            this.playerHitPoints.TabIndex = 1;
            this.playerHitPoints.Text = "0";
            this.playerHitPoints.UseWaitCursor = true;
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(3, 0);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(41, 15);
            this.PlayerLabel.TabIndex = 0;
            this.PlayerLabel.Text = "Player";
            this.PlayerLabel.UseWaitCursor = true;
            // 
            // Bucky
            // 
            this.Bucky.BackColor = System.Drawing.Color.Transparent;
            this.Bucky.Image = global::BuckyQuest.Properties.Resources.player;
            this.Bucky.Location = new System.Drawing.Point(184, 130);
            this.Bucky.Name = "Bucky";
            this.Bucky.Size = new System.Drawing.Size(50, 50);
            this.Bucky.TabIndex = 13;
            this.Bucky.TabStop = false;
            this.Bucky.UseWaitCursor = true;
            // 
            // Bat
            // 
            this.Bat.BackColor = System.Drawing.Color.Transparent;
            this.Bat.Image = global::BuckyQuest.Properties.Resources.bat;
            this.Bat.Location = new System.Drawing.Point(257, 130);
            this.Bat.Name = "Bat";
            this.Bat.Size = new System.Drawing.Size(50, 50);
            this.Bat.TabIndex = 14;
            this.Bat.TabStop = false;
            this.Bat.UseWaitCursor = true;
            // 
            // Ghost
            // 
            this.Ghost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ghost.BackColor = System.Drawing.Color.Transparent;
            this.Ghost.Image = global::BuckyQuest.Properties.Resources.ghost;
            this.Ghost.Location = new System.Drawing.Point(331, 130);
            this.Ghost.Name = "Ghost";
            this.Ghost.Size = new System.Drawing.Size(50, 50);
            this.Ghost.TabIndex = 15;
            this.Ghost.TabStop = false;
            this.Ghost.UseWaitCursor = true;
            // 
            // Ghoul
            // 
            this.Ghoul.BackColor = System.Drawing.Color.Transparent;
            this.Ghoul.Image = global::BuckyQuest.Properties.Resources.ghoul;
            this.Ghoul.Location = new System.Drawing.Point(408, 130);
            this.Ghoul.Name = "Ghoul";
            this.Ghoul.Size = new System.Drawing.Size(50, 50);
            this.Ghoul.TabIndex = 16;
            this.Ghoul.TabStop = false;
            this.Ghoul.UseWaitCursor = true;
            // 
            // Bow
            // 
            this.Bow.BackColor = System.Drawing.Color.Transparent;
            this.Bow.Image = global::BuckyQuest.Properties.Resources.bow;
            this.Bow.Location = new System.Drawing.Point(496, 130);
            this.Bow.Name = "Bow";
            this.Bow.Size = new System.Drawing.Size(50, 50);
            this.Bow.TabIndex = 17;
            this.Bow.TabStop = false;
            this.Bow.UseWaitCursor = true;
            // 
            // Mace
            // 
            this.Mace.BackColor = System.Drawing.Color.Transparent;
            this.Mace.Image = global::BuckyQuest.Properties.Resources.mace;
            this.Mace.Location = new System.Drawing.Point(583, 130);
            this.Mace.Name = "Mace";
            this.Mace.Size = new System.Drawing.Size(50, 50);
            this.Mace.TabIndex = 18;
            this.Mace.TabStop = false;
            this.Mace.UseWaitCursor = true;
            // 
            // BluePotion
            // 
            this.BluePotion.BackColor = System.Drawing.Color.Transparent;
            this.BluePotion.Image = global::BuckyQuest.Properties.Resources.potion_blue;
            this.BluePotion.Location = new System.Drawing.Point(661, 130);
            this.BluePotion.Name = "BluePotion";
            this.BluePotion.Size = new System.Drawing.Size(50, 50);
            this.BluePotion.TabIndex = 19;
            this.BluePotion.TabStop = false;
            this.BluePotion.UseWaitCursor = true;
            // 
            // RedPotion
            // 
            this.RedPotion.BackColor = System.Drawing.Color.Transparent;
            this.RedPotion.Image = global::BuckyQuest.Properties.Resources.potion_red;
            this.RedPotion.Location = new System.Drawing.Point(749, 130);
            this.RedPotion.Name = "RedPotion";
            this.RedPotion.Size = new System.Drawing.Size(50, 50);
            this.RedPotion.TabIndex = 20;
            this.RedPotion.TabStop = false;
            this.RedPotion.UseWaitCursor = true;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::BuckyQuest.Properties.Resources.sword;
            this.pictureBox9.Location = new System.Drawing.Point(822, 130);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 50);
            this.pictureBox9.TabIndex = 21;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.UseWaitCursor = true;
            // 
            // AttackBox
            // 
            this.AttackBox.BackColor = System.Drawing.Color.Transparent;
            this.AttackBox.Controls.Add(this.AttackRightButton);
            this.AttackBox.Controls.Add(this.AttackLeftButton);
            this.AttackBox.Controls.Add(this.AttackDownButton);
            this.AttackBox.Controls.Add(this.AttackUpButton);
            this.AttackBox.Location = new System.Drawing.Point(935, 563);
            this.AttackBox.Name = "AttackBox";
            this.AttackBox.Size = new System.Drawing.Size(165, 120);
            this.AttackBox.TabIndex = 22;
            this.AttackBox.TabStop = false;
            this.AttackBox.Text = "Attack";
            this.AttackBox.UseWaitCursor = true;
            // 
            // AttackRightButton
            // 
            this.AttackRightButton.Location = new System.Drawing.Point(106, 52);
            this.AttackRightButton.Name = "AttackRightButton";
            this.AttackRightButton.Size = new System.Drawing.Size(39, 31);
            this.AttackRightButton.TabIndex = 3;
            this.AttackRightButton.Text = "→";
            this.AttackRightButton.UseVisualStyleBackColor = true;
            this.AttackRightButton.UseWaitCursor = true;
            // 
            // AttackLeftButton
            // 
            this.AttackLeftButton.Location = new System.Drawing.Point(16, 51);
            this.AttackLeftButton.Name = "AttackLeftButton";
            this.AttackLeftButton.Size = new System.Drawing.Size(39, 33);
            this.AttackLeftButton.TabIndex = 2;
            this.AttackLeftButton.Text = "←";
            this.AttackLeftButton.UseVisualStyleBackColor = true;
            this.AttackLeftButton.UseWaitCursor = true;
            // 
            // AttackDownButton
            // 
            this.AttackDownButton.Location = new System.Drawing.Point(61, 81);
            this.AttackDownButton.Name = "AttackDownButton";
            this.AttackDownButton.Size = new System.Drawing.Size(39, 33);
            this.AttackDownButton.TabIndex = 1;
            this.AttackDownButton.Text = "↓";
            this.AttackDownButton.UseVisualStyleBackColor = true;
            this.AttackDownButton.UseWaitCursor = true;
            // 
            // AttackUpButton
            // 
            this.AttackUpButton.Location = new System.Drawing.Point(61, 19);
            this.AttackUpButton.Name = "AttackUpButton";
            this.AttackUpButton.Size = new System.Drawing.Size(39, 33);
            this.AttackUpButton.TabIndex = 0;
            this.AttackUpButton.Text = "↑";
            this.AttackUpButton.UseVisualStyleBackColor = true;
            this.AttackUpButton.UseWaitCursor = true;
            // 
            // MoveBox
            // 
            this.MoveBox.BackColor = System.Drawing.Color.Transparent;
            this.MoveBox.Controls.Add(this.MoveRightButton);
            this.MoveBox.Controls.Add(this.MoveLeftButton);
            this.MoveBox.Controls.Add(this.MoveDownButton);
            this.MoveBox.Controls.Add(this.MoveUpButton);
            this.MoveBox.Location = new System.Drawing.Point(749, 563);
            this.MoveBox.Name = "MoveBox";
            this.MoveBox.Size = new System.Drawing.Size(165, 120);
            this.MoveBox.TabIndex = 23;
            this.MoveBox.TabStop = false;
            this.MoveBox.Text = "Move";
            this.MoveBox.UseWaitCursor = true;
            // 
            // MoveRightButton
            // 
            this.MoveRightButton.Location = new System.Drawing.Point(106, 52);
            this.MoveRightButton.Name = "MoveRightButton";
            this.MoveRightButton.Size = new System.Drawing.Size(39, 31);
            this.MoveRightButton.TabIndex = 3;
            this.MoveRightButton.Text = "→";
            this.MoveRightButton.UseVisualStyleBackColor = true;
            this.MoveRightButton.UseWaitCursor = true;
            // 
            // MoveLeftButton
            // 
            this.MoveLeftButton.Location = new System.Drawing.Point(16, 51);
            this.MoveLeftButton.Name = "MoveLeftButton";
            this.MoveLeftButton.Size = new System.Drawing.Size(39, 33);
            this.MoveLeftButton.TabIndex = 2;
            this.MoveLeftButton.Text = "←";
            this.MoveLeftButton.UseVisualStyleBackColor = true;
            this.MoveLeftButton.UseWaitCursor = true;
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Location = new System.Drawing.Point(61, 81);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(39, 33);
            this.MoveDownButton.TabIndex = 1;
            this.MoveDownButton.Text = "↓";
            this.MoveDownButton.UseVisualStyleBackColor = true;
            this.MoveDownButton.UseWaitCursor = true;
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Location = new System.Drawing.Point(61, 19);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(39, 33);
            this.MoveUpButton.TabIndex = 0;
            this.MoveUpButton.Text = "↑";
            this.MoveUpButton.UseVisualStyleBackColor = true;
            this.MoveUpButton.UseWaitCursor = true;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // swordInventory
            // 
            this.swordInventory.BackColor = System.Drawing.Color.Transparent;
            this.swordInventory.BackgroundImage = global::BuckyQuest.Properties.Resources.sword;
            this.swordInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swordInventory.Location = new System.Drawing.Point(153, 577);
            this.swordInventory.Name = "swordInventory";
            this.swordInventory.Size = new System.Drawing.Size(100, 100);
            this.swordInventory.TabIndex = 24;
            this.swordInventory.TabStop = false;
            this.swordInventory.UseWaitCursor = true;
            // 
            // bowInventory
            // 
            this.bowInventory.BackColor = System.Drawing.Color.Transparent;
            this.bowInventory.BackgroundImage = global::BuckyQuest.Properties.Resources.bow;
            this.bowInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bowInventory.Location = new System.Drawing.Point(257, 577);
            this.bowInventory.Name = "bowInventory";
            this.bowInventory.Size = new System.Drawing.Size(100, 100);
            this.bowInventory.TabIndex = 25;
            this.bowInventory.TabStop = false;
            this.bowInventory.UseWaitCursor = true;
            // 
            // maceInventory
            // 
            this.maceInventory.BackColor = System.Drawing.Color.Transparent;
            this.maceInventory.BackgroundImage = global::BuckyQuest.Properties.Resources.mace;
            this.maceInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maceInventory.Location = new System.Drawing.Point(363, 577);
            this.maceInventory.Name = "maceInventory";
            this.maceInventory.Size = new System.Drawing.Size(100, 100);
            this.maceInventory.TabIndex = 26;
            this.maceInventory.TabStop = false;
            this.maceInventory.UseWaitCursor = true;
            // 
            // BluePotionInventory
            // 
            this.BluePotionInventory.BackColor = System.Drawing.Color.Transparent;
            this.BluePotionInventory.BackgroundImage = global::BuckyQuest.Properties.Resources.potion_blue;
            this.BluePotionInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BluePotionInventory.Location = new System.Drawing.Point(469, 577);
            this.BluePotionInventory.Name = "BluePotionInventory";
            this.BluePotionInventory.Size = new System.Drawing.Size(100, 100);
            this.BluePotionInventory.TabIndex = 27;
            this.BluePotionInventory.TabStop = false;
            this.BluePotionInventory.UseWaitCursor = true;
            // 
            // RedPotionInventory
            // 
            this.RedPotionInventory.BackColor = System.Drawing.Color.Transparent;
            this.RedPotionInventory.BackgroundImage = global::BuckyQuest.Properties.Resources.potion_red;
            this.RedPotionInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RedPotionInventory.Location = new System.Drawing.Point(575, 577);
            this.RedPotionInventory.Name = "RedPotionInventory";
            this.RedPotionInventory.Size = new System.Drawing.Size(100, 100);
            this.RedPotionInventory.TabIndex = 28;
            this.RedPotionInventory.TabStop = false;
            this.RedPotionInventory.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BuckyQuest.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 726);
            this.Controls.Add(this.RedPotionInventory);
            this.Controls.Add(this.BluePotionInventory);
            this.Controls.Add(this.maceInventory);
            this.Controls.Add(this.bowInventory);
            this.Controls.Add(this.swordInventory);
            this.Controls.Add(this.MoveBox);
            this.Controls.Add(this.AttackBox);
            this.Controls.Add(this.Bucky);
            this.Controls.Add(this.RedPotion);
            this.Controls.Add(this.BluePotion);
            this.Controls.Add(this.Ghoul);
            this.Controls.Add(this.Ghost);
            this.Controls.Add(this.Bat);
            this.Controls.Add(this.statsWindow);
            this.Controls.Add(this.Bow);
            this.Controls.Add(this.Mace);
            this.Controls.Add(this.pictureBox9);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Bucky\'s Quest";
            this.UseWaitCursor = true;
            this.statsWindow.ResumeLayout(false);
            this.statsWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bucky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.AttackBox.ResumeLayout(false);
            this.MoveBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.swordInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel statsWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label BatLabel;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label GhostLabel;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label GhoulLabel;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.PictureBox Bucky;
        private System.Windows.Forms.PictureBox Bat;
        private System.Windows.Forms.PictureBox Ghost;
        private System.Windows.Forms.PictureBox Ghoul;
        private System.Windows.Forms.PictureBox Bow;
        private System.Windows.Forms.PictureBox Mace;
        private System.Windows.Forms.PictureBox BluePotion;
        private System.Windows.Forms.PictureBox RedPotion;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.GroupBox AttackBox;
        private System.Windows.Forms.Button AttackRightButton;
        private System.Windows.Forms.Button AttackLeftButton;
        private System.Windows.Forms.Button AttackDownButton;
        private System.Windows.Forms.Button AttackUpButton;
        private System.Windows.Forms.GroupBox MoveBox;
        private System.Windows.Forms.Button MoveRightButton;
        private System.Windows.Forms.Button MoveLeftButton;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Button MoveUpButton;
        private System.Windows.Forms.PictureBox swordInventory;
        private System.Windows.Forms.PictureBox bowInventory;
        private System.Windows.Forms.PictureBox maceInventory;
        private System.Windows.Forms.PictureBox BluePotionInventory;
        private System.Windows.Forms.PictureBox RedPotionInventory;
    }
}


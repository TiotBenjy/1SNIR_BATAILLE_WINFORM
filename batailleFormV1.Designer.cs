namespace Bataille_Winform
{
    partial class gameForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameForm));
            this.label_title = new System.Windows.Forms.Label();
            this.btn_CreateCards = new System.Windows.Forms.Button();
            this.btn_ShuffleCards = new System.Windows.Forms.Button();
            this.btn_CouperDistrib = new System.Windows.Forms.Button();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.events_List = new System.Windows.Forms.ListBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pBox_Bataille_Icon_2 = new System.Windows.Forms.PictureBox();
            this.pBox_Bataille_Icon_1 = new System.Windows.Forms.PictureBox();
            this.btn_credits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Bataille_Icon_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Bataille_Icon_1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            resources.ApplyResources(this.label_title, "label_title");
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Name = "label_title";
            // 
            // btn_CreateCards
            // 
            this.btn_CreateCards.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_CreateCards.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_CreateCards, "btn_CreateCards");
            this.btn_CreateCards.Name = "btn_CreateCards";
            this.btn_CreateCards.UseVisualStyleBackColor = false;
            this.btn_CreateCards.Click += new System.EventHandler(this.btn_CreateCards_Click);
            // 
            // btn_ShuffleCards
            // 
            this.btn_ShuffleCards.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ShuffleCards.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_ShuffleCards, "btn_ShuffleCards");
            this.btn_ShuffleCards.Name = "btn_ShuffleCards";
            this.btn_ShuffleCards.UseVisualStyleBackColor = false;
            this.btn_ShuffleCards.Click += new System.EventHandler(this.btn_ShuffleCards_Click);
            // 
            // btn_CouperDistrib
            // 
            this.btn_CouperDistrib.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_CouperDistrib.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_CouperDistrib, "btn_CouperDistrib");
            this.btn_CouperDistrib.Name = "btn_CouperDistrib";
            this.btn_CouperDistrib.UseVisualStyleBackColor = false;
            this.btn_CouperDistrib.Click += new System.EventHandler(this.btn_CouperDistrib_Click);
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_StartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_StartGame, "btn_StartGame");
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.UseVisualStyleBackColor = false;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
            // 
            // events_List
            // 
            this.events_List.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.events_List, "events_List");
            this.events_List.FormattingEnabled = true;
            this.events_List.Name = "events_List";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Exit, "btn_Exit");
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pBox_Bataille_Icon_2
            // 
            this.pBox_Bataille_Icon_2.BackColor = System.Drawing.Color.Transparent;
            this.pBox_Bataille_Icon_2.Image = global::Bataille_Winform.Properties.Resources._1088693;
            resources.ApplyResources(this.pBox_Bataille_Icon_2, "pBox_Bataille_Icon_2");
            this.pBox_Bataille_Icon_2.Name = "pBox_Bataille_Icon_2";
            this.pBox_Bataille_Icon_2.TabStop = false;
            // 
            // pBox_Bataille_Icon_1
            // 
            this.pBox_Bataille_Icon_1.BackColor = System.Drawing.Color.Transparent;
            this.pBox_Bataille_Icon_1.Image = global::Bataille_Winform.Properties.Resources._1088693;
            resources.ApplyResources(this.pBox_Bataille_Icon_1, "pBox_Bataille_Icon_1");
            this.pBox_Bataille_Icon_1.Name = "pBox_Bataille_Icon_1";
            this.pBox_Bataille_Icon_1.TabStop = false;
            // 
            // btn_credits
            // 
            this.btn_credits.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_credits.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_credits, "btn_credits");
            this.btn_credits.Name = "btn_credits";
            this.btn_credits.UseVisualStyleBackColor = false;
            this.btn_credits.Click += new System.EventHandler(this.btn_credits_Click);
            // 
            // gameForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_credits);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.events_List);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.btn_CouperDistrib);
            this.Controls.Add(this.btn_ShuffleCards);
            this.Controls.Add(this.btn_CreateCards);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.pBox_Bataille_Icon_2);
            this.Controls.Add(this.pBox_Bataille_Icon_1);
            this.DoubleBuffered = true;
            this.Name = "gameForm";
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Bataille_Icon_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Bataille_Icon_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox_Bataille_Icon_1;
        private System.Windows.Forms.PictureBox pBox_Bataille_Icon_2;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button btn_CreateCards;
        private System.Windows.Forms.Button btn_ShuffleCards;
        private System.Windows.Forms.Button btn_CouperDistrib;
        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_credits;
        public System.Windows.Forms.ListBox events_List;
    }
}


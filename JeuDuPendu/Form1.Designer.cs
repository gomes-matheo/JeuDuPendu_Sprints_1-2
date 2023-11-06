
namespace JeuDuPendu
{
    partial class FRM_JeuDuPendu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Test = new System.Windows.Forms.Button();
            this.CMB_LetterList = new System.Windows.Forms.ComboBox();
            this.TXB_WordToGuess = new System.Windows.Forms.TextBox();
            this.GPB_LetterGuess = new System.Windows.Forms.GroupBox();
            this.LBL_LettersTested = new System.Windows.Forms.Label();
            this.GPB_WordToGuess = new System.Windows.Forms.GroupBox();
            this.BTN_AddWord = new System.Windows.Forms.Button();
            this.LBL_GameStatus = new System.Windows.Forms.Label();
            this.BTN_Retry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GPB_LetterGuess.SuspendLayout();
            this.GPB_WordToGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(313, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 283);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Test
            // 
            this.BTN_Test.Location = new System.Drawing.Point(181, 21);
            this.BTN_Test.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Test.Name = "BTN_Test";
            this.BTN_Test.Size = new System.Drawing.Size(100, 28);
            this.BTN_Test.TabIndex = 4;
            this.BTN_Test.Text = "Tester";
            this.BTN_Test.UseVisualStyleBackColor = true;
            this.BTN_Test.Click += new System.EventHandler(this.button1_Click);
            // 
            // CMB_LetterList
            // 
            this.CMB_LetterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_LetterList.FormattingEnabled = true;
            this.CMB_LetterList.Location = new System.Drawing.Point(8, 23);
            this.CMB_LetterList.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_LetterList.MaxDropDownItems = 26;
            this.CMB_LetterList.Name = "CMB_LetterList";
            this.CMB_LetterList.Size = new System.Drawing.Size(160, 24);
            this.CMB_LetterList.TabIndex = 3;
            this.CMB_LetterList.SelectedIndexChanged += new System.EventHandler(this.CMB_LetterList_SelectedIndexChanged);
            // 
            // TXB_WordToGuess
            // 
            this.TXB_WordToGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TXB_WordToGuess.Location = new System.Drawing.Point(8, 40);
            this.TXB_WordToGuess.Margin = new System.Windows.Forms.Padding(4);
            this.TXB_WordToGuess.MaxLength = 15;
            this.TXB_WordToGuess.Name = "TXB_WordToGuess";
            this.TXB_WordToGuess.Size = new System.Drawing.Size(179, 26);
            this.TXB_WordToGuess.TabIndex = 1;
            this.TXB_WordToGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTest);
            // 
            // GPB_LetterGuess
            // 
            this.GPB_LetterGuess.Controls.Add(this.LBL_LettersTested);
            this.GPB_LetterGuess.Controls.Add(this.CMB_LetterList);
            this.GPB_LetterGuess.Controls.Add(this.BTN_Test);
            this.GPB_LetterGuess.Location = new System.Drawing.Point(16, 129);
            this.GPB_LetterGuess.Margin = new System.Windows.Forms.Padding(4);
            this.GPB_LetterGuess.Name = "GPB_LetterGuess";
            this.GPB_LetterGuess.Padding = new System.Windows.Forms.Padding(4);
            this.GPB_LetterGuess.Size = new System.Drawing.Size(289, 113);
            this.GPB_LetterGuess.TabIndex = 4;
            this.GPB_LetterGuess.TabStop = false;
            this.GPB_LetterGuess.Text = "Proposer une lettre";
            this.GPB_LetterGuess.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LBL_LettersTested
            // 
            this.LBL_LettersTested.AutoSize = true;
            this.LBL_LettersTested.Location = new System.Drawing.Point(4, 65);
            this.LBL_LettersTested.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_LettersTested.Name = "LBL_LettersTested";
            this.LBL_LettersTested.Size = new System.Drawing.Size(31, 17);
            this.LBL_LettersTested.TabIndex = 3;
            this.LBL_LettersTested.Text = "test";
            // 
            // GPB_WordToGuess
            // 
            this.GPB_WordToGuess.Controls.Add(this.BTN_AddWord);
            this.GPB_WordToGuess.Controls.Add(this.TXB_WordToGuess);
            this.GPB_WordToGuess.Location = new System.Drawing.Point(24, 16);
            this.GPB_WordToGuess.Margin = new System.Windows.Forms.Padding(4);
            this.GPB_WordToGuess.Name = "GPB_WordToGuess";
            this.GPB_WordToGuess.Padding = new System.Windows.Forms.Padding(4);
            this.GPB_WordToGuess.Size = new System.Drawing.Size(267, 106);
            this.GPB_WordToGuess.TabIndex = 5;
            this.GPB_WordToGuess.TabStop = false;
            this.GPB_WordToGuess.Text = "Mot à trouver (<= 15 caractères)";
            // 
            // BTN_AddWord
            // 
            this.BTN_AddWord.Location = new System.Drawing.Point(190, 73);
            this.BTN_AddWord.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_AddWord.Name = "BTN_AddWord";
            this.BTN_AddWord.Size = new System.Drawing.Size(69, 25);
            this.BTN_AddWord.TabIndex = 2;
            this.BTN_AddWord.Text = "Ajouter";
            this.BTN_AddWord.UseVisualStyleBackColor = true;
            this.BTN_AddWord.Click += new System.EventHandler(this.BTN_AddWord_Click);
            // 
            // LBL_GameStatus
            // 
            this.LBL_GameStatus.AutoSize = true;
            this.LBL_GameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LBL_GameStatus.Location = new System.Drawing.Point(19, 267);
            this.LBL_GameStatus.Name = "LBL_GameStatus";
            this.LBL_GameStatus.Size = new System.Drawing.Size(97, 29);
            this.LBL_GameStatus.TabIndex = 6;
            this.LBL_GameStatus.Text = "Gagné !";
            this.LBL_GameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_GameStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTN_Retry
            // 
            this.BTN_Retry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.BTN_Retry.Location = new System.Drawing.Point(177, 267);
            this.BTN_Retry.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Retry.Name = "BTN_Retry";
            this.BTN_Retry.Size = new System.Drawing.Size(128, 32);
            this.BTN_Retry.TabIndex = 5;
            this.BTN_Retry.Text = "Réessayer ?";
            this.BTN_Retry.UseVisualStyleBackColor = true;
            this.BTN_Retry.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FRM_JeuDuPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 313);
            this.Controls.Add(this.BTN_Retry);
            this.Controls.Add(this.LBL_GameStatus);
            this.Controls.Add(this.GPB_WordToGuess);
            this.Controls.Add(this.GPB_LetterGuess);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_JeuDuPendu";
            this.Text = "Jeu du pendu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GPB_LetterGuess.ResumeLayout(false);
            this.GPB_LetterGuess.PerformLayout();
            this.GPB_WordToGuess.ResumeLayout(false);
            this.GPB_WordToGuess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Test;
        private System.Windows.Forms.ComboBox CMB_LetterList;
        private System.Windows.Forms.TextBox TXB_WordToGuess;
        private System.Windows.Forms.GroupBox GPB_LetterGuess;
        private System.Windows.Forms.Label LBL_LettersTested;
        private System.Windows.Forms.GroupBox GPB_WordToGuess;
        private System.Windows.Forms.Label LBL_GameStatus;
        private System.Windows.Forms.Button BTN_Retry;
        private System.Windows.Forms.Button BTN_AddWord;
    }
}


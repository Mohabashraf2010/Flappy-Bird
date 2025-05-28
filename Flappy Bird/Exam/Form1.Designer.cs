namespace Exam
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
            this.components = new System.ComponentModel.Container();
            this.Birdy = new System.Windows.Forms.PictureBox();
            this.pipebot = new System.Windows.Forms.PictureBox();
            this.pipeup = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.txtbox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Birdy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // Birdy
            // 
            this.Birdy.BackColor = System.Drawing.Color.Transparent;
            this.Birdy.Image = global::Exam.Properties.Resources.bird;
            this.Birdy.Location = new System.Drawing.Point(41, 164);
            this.Birdy.Name = "Birdy";
            this.Birdy.Size = new System.Drawing.Size(69, 59);
            this.Birdy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Birdy.TabIndex = 0;
            this.Birdy.TabStop = false;
            // 
            // pipebot
            // 
            this.pipebot.BackColor = System.Drawing.Color.Transparent;
            this.pipebot.Image = global::Exam.Properties.Resources.pipe;
            this.pipebot.Location = new System.Drawing.Point(340, 210);
            this.pipebot.Name = "pipebot";
            this.pipebot.Size = new System.Drawing.Size(59, 175);
            this.pipebot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipebot.TabIndex = 0;
            this.pipebot.TabStop = false;
            // 
            // pipeup
            // 
            this.pipeup.BackColor = System.Drawing.Color.Transparent;
            this.pipeup.Image = global::Exam.Properties.Resources.pipedown;
            this.pipeup.Location = new System.Drawing.Point(643, 1);
            this.pipeup.Name = "pipeup";
            this.pipeup.Size = new System.Drawing.Size(52, 149);
            this.pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeup.TabIndex = 0;
            this.pipeup.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = global::Exam.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-9, 365);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(813, 112);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimeevent);
            // 
            // txtbox
            // 
            this.txtbox.BackColor = System.Drawing.Color.Transparent;
            this.txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox.Location = new System.Drawing.Point(12, 1);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(345, 99);
            this.txtbox.TabIndex = 2;
            this.txtbox.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pipeup);
            this.Controls.Add(this.Birdy);
            this.Controls.Add(this.pipebot);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.txtbox);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Birdy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Birdy;
        private System.Windows.Forms.PictureBox pipebot;
        private System.Windows.Forms.PictureBox pipeup;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label txtbox;
    }
}


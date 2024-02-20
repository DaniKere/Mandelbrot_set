namespace mandi_practice
{
    partial class Mandelprog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mandelprog));
            this.Display = new System.Windows.Forms.PictureBox();
            this.Magnitudo = new System.Windows.Forms.TrackBar();
            this.Iterations = new System.Windows.Forms.TrackBar();
            this.Magnitudo_text = new System.Windows.Forms.Label();
            this.Iterations_text = new System.Windows.Forms.Label();
            this.Magni_count = new System.Windows.Forms.Label();
            this.Iter_count = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.Height_text = new System.Windows.Forms.Label();
            this.Width_text = new System.Windows.Forms.Label();
            this.Paralel = new System.Windows.Forms.CheckBox();
            this.zoom = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.backGroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Magnitudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iterations)).BeginInit();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Image = ((System.Drawing.Image)(resources.GetObject("Display.Image")));
            this.Display.Location = new System.Drawing.Point(12, 59);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(460, 348);
            this.Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Display.TabIndex = 0;
            this.Display.TabStop = false;
            // 
            // Magnitudo
            // 
            this.Magnitudo.Location = new System.Drawing.Point(696, 59);
            this.Magnitudo.Maximum = 1000;
            this.Magnitudo.Minimum = 10;
            this.Magnitudo.Name = "Magnitudo";
            this.Magnitudo.Size = new System.Drawing.Size(104, 56);
            this.Magnitudo.TabIndex = 1;
            this.Magnitudo.Value = 100;
            this.Magnitudo.ValueChanged += new System.EventHandler(this.Magnitudo_ValueChanged);
            // 
            // Iterations
            // 
            this.Iterations.Location = new System.Drawing.Point(696, 140);
            this.Iterations.Maximum = 10000;
            this.Iterations.Minimum = 10;
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(104, 56);
            this.Iterations.TabIndex = 1;
            this.Iterations.Value = 100;
            this.Iterations.ValueChanged += new System.EventHandler(this.Iterations_ValueChanged);
            // 
            // Magnitudo_text
            // 
            this.Magnitudo_text.AutoSize = true;
            this.Magnitudo_text.Location = new System.Drawing.Point(492, 59);
            this.Magnitudo_text.Name = "Magnitudo_text";
            this.Magnitudo_text.Size = new System.Drawing.Size(70, 16);
            this.Magnitudo_text.TabIndex = 2;
            this.Magnitudo_text.Text = "Magnitudo";
            // 
            // Iterations_text
            // 
            this.Iterations_text.AutoSize = true;
            this.Iterations_text.Location = new System.Drawing.Point(492, 140);
            this.Iterations_text.Name = "Iterations_text";
            this.Iterations_text.Size = new System.Drawing.Size(61, 16);
            this.Iterations_text.TabIndex = 2;
            this.Iterations_text.Text = "Iterations";
            // 
            // Magni_count
            // 
            this.Magni_count.AutoSize = true;
            this.Magni_count.Location = new System.Drawing.Point(621, 59);
            this.Magni_count.Name = "Magni_count";
            this.Magni_count.Size = new System.Drawing.Size(28, 16);
            this.Magni_count.TabIndex = 3;
            this.Magni_count.Text = "100";
            // 
            // Iter_count
            // 
            this.Iter_count.AutoSize = true;
            this.Iter_count.Location = new System.Drawing.Point(621, 140);
            this.Iter_count.Name = "Iter_count";
            this.Iter_count.Size = new System.Drawing.Size(28, 16);
            this.Iter_count.TabIndex = 3;
            this.Iter_count.Text = "100";
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(624, 274);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(100, 22);
            this.Height.TabIndex = 4;
            this.Height.Text = "600";
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(624, 302);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(100, 22);
            this.Width.TabIndex = 4;
            this.Width.Text = "800";
            // 
            // Height_text
            // 
            this.Height_text.AutoSize = true;
            this.Height_text.Location = new System.Drawing.Point(495, 274);
            this.Height_text.Name = "Height_text";
            this.Height_text.Size = new System.Drawing.Size(46, 16);
            this.Height_text.TabIndex = 5;
            this.Height_text.Text = "Height";
            // 
            // Width_text
            // 
            this.Width_text.AutoSize = true;
            this.Width_text.Location = new System.Drawing.Point(495, 305);
            this.Width_text.Name = "Width_text";
            this.Width_text.Size = new System.Drawing.Size(41, 16);
            this.Width_text.TabIndex = 6;
            this.Width_text.Text = "Width";
            // 
            // Paralel
            // 
            this.Paralel.AutoSize = true;
            this.Paralel.Location = new System.Drawing.Point(498, 219);
            this.Paralel.Name = "Paralel";
            this.Paralel.Size = new System.Drawing.Size(71, 20);
            this.Paralel.TabIndex = 7;
            this.Paralel.Text = "paralel";
            this.Paralel.UseVisualStyleBackColor = true;
            // 
            // zoom
            // 
            this.zoom.AutoSize = true;
            this.zoom.Location = new System.Drawing.Point(687, 219);
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(14, 16);
            this.zoom.TabIndex = 8;
            this.zoom.Text = "1";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(667, 390);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(32, 16);
            this.time.TabIndex = 9;
            this.time.Text = "time";
            // 
            // backGroundWorker
            // 
            this.backGroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backGroundWorker_DoWork);
            // 
            // Mandelprog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.time);
            this.Controls.Add(this.zoom);
            this.Controls.Add(this.Paralel);
            this.Controls.Add(this.Width_text);
            this.Controls.Add(this.Height_text);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Iter_count);
            this.Controls.Add(this.Magni_count);
            this.Controls.Add(this.Iterations_text);
            this.Controls.Add(this.Magnitudo_text);
            this.Controls.Add(this.Iterations);
            this.Controls.Add(this.Magnitudo);
            this.Controls.Add(this.Display);
            this.Name = "Mandelprog";
            this.Text = "Mandelbroat";
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Magnitudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Display;
        private System.Windows.Forms.TrackBar Magnitudo;
        private System.Windows.Forms.Label Magnitudo_text;
        private System.Windows.Forms.Label Iterations_text;
        private System.Windows.Forms.Label Magni_count;
        private System.Windows.Forms.Label Iter_count;
        private System.Windows.Forms.TrackBar Iterations;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Label Height_text;
        private System.Windows.Forms.Label Width_text;
        private System.Windows.Forms.CheckBox Paralel;
        private System.Windows.Forms.Label zoom;
        private System.Windows.Forms.Label time;
        private System.ComponentModel.BackgroundWorker backGroundWorker;
    }
}


namespace AppExemploMenu
{
    partial class Frmluccazille
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formcafecomcanudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formcleitinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cafeComCanudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem,
            this.formcafecomcanudoToolStripMenuItem,
            this.formcleitinToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 70);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // formcafecomcanudoToolStripMenuItem
            // 
            this.formcafecomcanudoToolStripMenuItem.Name = "formcafecomcanudoToolStripMenuItem";
            this.formcafecomcanudoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.formcafecomcanudoToolStripMenuItem.Text = "Formcafecomcanudo";
            // 
            // formcleitinToolStripMenuItem
            // 
            this.formcleitinToolStripMenuItem.Name = "formcleitinToolStripMenuItem";
            this.formcleitinToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.formcleitinToolStripMenuItem.Text = "Formcleitin";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem1
            // 
            this.exibirToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cafeComCanudoToolStripMenuItem});
            this.exibirToolStripMenuItem1.Name = "exibirToolStripMenuItem1";
            this.exibirToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem1.Text = "Exibir";
            // 
            // cafeComCanudoToolStripMenuItem
            // 
            this.cafeComCanudoToolStripMenuItem.Name = "cafeComCanudoToolStripMenuItem";
            this.cafeComCanudoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cafeComCanudoToolStripMenuItem.Text = "Cafe com canudo";
            // 
            // Frmluccazille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmluccazille";
            this.Text = "Form2";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formcafecomcanudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formcleitinToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cafeComCanudoToolStripMenuItem;
    }
}
namespace ServiceStatusChecking
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ServiceStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RestartServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Программа в трее";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServiceStatusToolStripMenuItem,
            this.toolStripSeparator1,
            this.RestartServiceToolStripMenuItem,
            this.CloseProgramToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 88);
            // 
            // ServiceStatusToolStripMenuItem
            // 
            this.ServiceStatusToolStripMenuItem.Enabled = false;
            this.ServiceStatusToolStripMenuItem.Name = "ServiceStatusToolStripMenuItem";
            this.ServiceStatusToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.ServiceStatusToolStripMenuItem.Text = "Статус службы:";
            this.ServiceStatusToolStripMenuItem.TextChanged += new System.EventHandler(this.ServiceStatusToolStripMenuItem_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // RestartServiceToolStripMenuItem
            // 
            this.RestartServiceToolStripMenuItem.Name = "RestartServiceToolStripMenuItem";
            this.RestartServiceToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.RestartServiceToolStripMenuItem.Text = "Перезапустить службу";
            this.RestartServiceToolStripMenuItem.Click += new System.EventHandler(this.RestartServiceToolStripMenuItem_Click);
            // 
            // CloseProgramToolStripMenuItem
            // 
            this.CloseProgramToolStripMenuItem.Name = "CloseProgramToolStripMenuItem";
            this.CloseProgramToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.CloseProgramToolStripMenuItem.Text = "Выход";
            this.CloseProgramToolStripMenuItem.Click += new System.EventHandler(this.CloseProgramToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CloseProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestartServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ServiceStatusToolStripMenuItem;
    }
}


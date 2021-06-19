using System.Drawing;

namespace HostsEditor
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.FlowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.FootContainer = new System.Windows.Forms.Panel();
            this.OpenButton = new System.Windows.Forms.Button();
            this.FormatButton = new System.Windows.Forms.Button();
            this.SaveAndCloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.FootContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowContainer
            // 
            this.FlowContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.FlowContainer.Location = new System.Drawing.Point(0, 0);
            this.FlowContainer.Margin = new System.Windows.Forms.Padding(0);
            this.FlowContainer.Name = "FlowContainer";
            this.FlowContainer.Size = new System.Drawing.Size(640, 420);
            this.FlowContainer.TabIndex = 2;
            // 
            // FootContainer
            // 
            this.FootContainer.BackColor = System.Drawing.Color.Transparent;
            this.FootContainer.Controls.Add(this.OpenButton);
            this.FootContainer.Controls.Add(this.FormatButton);
            this.FootContainer.Controls.Add(this.SaveAndCloseButton);
            this.FootContainer.Controls.Add(this.SaveButton);
            this.FootContainer.Controls.Add(this.AddItemButton);
            this.FootContainer.Location = new System.Drawing.Point(0, 428);
            this.FootContainer.Margin = new System.Windows.Forms.Padding(0);
            this.FootContainer.Name = "FootContainer";
            this.FootContainer.Size = new System.Drawing.Size(640, 24);
            this.FootContainer.TabIndex = 3;
            // 
            // OpenButton
            // 
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OpenButton.Location = new System.Drawing.Point(130, 0);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(60, 24);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "打开文件";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // FormatButton
            // 
            this.FormatButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FormatButton.Location = new System.Drawing.Point(70, 0);
            this.FormatButton.Margin = new System.Windows.Forms.Padding(0);
            this.FormatButton.Name = "FormatButton";
            this.FormatButton.Size = new System.Drawing.Size(50, 24);
            this.FormatButton.TabIndex = 3;
            this.FormatButton.Text = "格式化";
            this.FormatButton.UseVisualStyleBackColor = true;
            this.FormatButton.Click += new System.EventHandler(this.FormatButton_Click);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveAndCloseButton.Location = new System.Drawing.Point(550, 0);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(80, 24);
            this.SaveAndCloseButton.TabIndex = 2;
            this.SaveAndCloseButton.Text = "保存并关闭";
            this.SaveAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveButton.Location = new System.Drawing.Point(490, 0);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(50, 24);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddItemButton.Location = new System.Drawing.Point(10, 0);
            this.AddItemButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(50, 24);
            this.AddItemButton.TabIndex = 0;
            this.AddItemButton.Text = "新增";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(640, 461);
            this.Controls.Add(this.FlowContainer);
            this.Controls.Add(this.FootContainer);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HostsEditor [堪笑作品]";
            this.Load += new System.EventHandler(this.Main_Load);
            this.FootContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlowContainer;
        private System.Windows.Forms.Panel FootContainer;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button SaveAndCloseButton;
        private System.Windows.Forms.Button FormatButton;
        private System.Windows.Forms.Button OpenButton;
    }
}


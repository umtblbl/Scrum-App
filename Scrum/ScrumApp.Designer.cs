namespace Scrum
{
    partial class ScrumApp
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.listboxDone = new System.Windows.Forms.ListBox();
            this.labelStories = new System.Windows.Forms.Label();
            this.labelNotStarted = new System.Windows.Forms.Label();
            this.labelInProgress = new System.Windows.Forms.Label();
            this.labelDone = new System.Windows.Forms.Label();
            this.btnAddStories = new MetroFramework.Controls.MetroButton();
            this.textStories = new System.Windows.Forms.TextBox();
            this.listboxStories = new System.Windows.Forms.ListBox();
            this.listboxNotStarted = new System.Windows.Forms.ListBox();
            this.listboxInProgress = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveAndExits = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listboxDone
            // 
            this.listboxDone.AllowDrop = true;
            this.listboxDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listboxDone.BackColor = System.Drawing.SystemColors.Info;
            this.listboxDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listboxDone.FormattingEnabled = true;
            this.listboxDone.ItemHeight = 29;
            this.listboxDone.Location = new System.Drawing.Point(967, 161);
            this.listboxDone.Name = "listboxDone";
            this.listboxDone.Size = new System.Drawing.Size(299, 439);
            this.listboxDone.TabIndex = 3;
            this.listboxDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.listboxDone_DragDrop);
            this.listboxDone.DragOver += new System.Windows.Forms.DragEventHandler(this.listboxDone_DragOver);
            this.listboxDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listboxDone_MouseDown);
            // 
            // labelStories
            // 
            this.labelStories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStories.AutoSize = true;
            this.labelStories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStories.Location = new System.Drawing.Point(97, 119);
            this.labelStories.Name = "labelStories";
            this.labelStories.Size = new System.Drawing.Size(82, 27);
            this.labelStories.TabIndex = 4;
            this.labelStories.Text = "Stories";
            // 
            // labelNotStarted
            // 
            this.labelNotStarted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNotStarted.AutoSize = true;
            this.labelNotStarted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNotStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNotStarted.Location = new System.Drawing.Point(415, 119);
            this.labelNotStarted.Name = "labelNotStarted";
            this.labelNotStarted.Size = new System.Drawing.Size(123, 27);
            this.labelNotStarted.TabIndex = 5;
            this.labelNotStarted.Text = "Not Started";
            // 
            // labelInProgress
            // 
            this.labelInProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInProgress.AutoSize = true;
            this.labelInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelInProgress.Location = new System.Drawing.Point(730, 119);
            this.labelInProgress.Name = "labelInProgress";
            this.labelInProgress.Size = new System.Drawing.Size(124, 27);
            this.labelInProgress.TabIndex = 6;
            this.labelInProgress.Text = "In Progress";
            // 
            // labelDone
            // 
            this.labelDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDone.AutoSize = true;
            this.labelDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDone.Location = new System.Drawing.Point(1075, 119);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(65, 27);
            this.labelDone.TabIndex = 7;
            this.labelDone.Text = "Done";
            // 
            // btnAddStories
            // 
            this.btnAddStories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddStories.Location = new System.Drawing.Point(220, 626);
            this.btnAddStories.Name = "btnAddStories";
            this.btnAddStories.Size = new System.Drawing.Size(101, 54);
            this.btnAddStories.TabIndex = 8;
            this.btnAddStories.Text = "Add Stories";
            this.btnAddStories.UseSelectable = true;
            this.btnAddStories.Click += new System.EventHandler(this.btnAddStories_Click);
            // 
            // textStories
            // 
            this.textStories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textStories.Location = new System.Drawing.Point(23, 626);
            this.textStories.Multiline = true;
            this.textStories.Name = "textStories";
            this.textStories.Size = new System.Drawing.Size(191, 54);
            this.textStories.TabIndex = 9;
            // 
            // listboxStories
            // 
            this.listboxStories.AllowDrop = true;
            this.listboxStories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listboxStories.BackColor = System.Drawing.SystemColors.Info;
            this.listboxStories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listboxStories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listboxStories.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listboxStories.FormattingEnabled = true;
            this.listboxStories.ItemHeight = 29;
            this.listboxStories.Location = new System.Drawing.Point(23, 161);
            this.listboxStories.Name = "listboxStories";
            this.listboxStories.Size = new System.Drawing.Size(298, 437);
            this.listboxStories.TabIndex = 0;
            this.listboxStories.DragDrop += new System.Windows.Forms.DragEventHandler(this.listboxStories_DragDrop);
            this.listboxStories.DragOver += new System.Windows.Forms.DragEventHandler(this.listboxStories_DragOver);
            this.listboxStories.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listboxStories_MouseDown);
            // 
            // listboxNotStarted
            // 
            this.listboxNotStarted.AllowDrop = true;
            this.listboxNotStarted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listboxNotStarted.BackColor = System.Drawing.SystemColors.Info;
            this.listboxNotStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listboxNotStarted.FormattingEnabled = true;
            this.listboxNotStarted.ItemHeight = 29;
            this.listboxNotStarted.Location = new System.Drawing.Point(327, 161);
            this.listboxNotStarted.Name = "listboxNotStarted";
            this.listboxNotStarted.Size = new System.Drawing.Size(319, 439);
            this.listboxNotStarted.TabIndex = 1;
            this.listboxNotStarted.DragDrop += new System.Windows.Forms.DragEventHandler(this.listboxNotStarted_DragDrop);
            this.listboxNotStarted.DragOver += new System.Windows.Forms.DragEventHandler(this.listboxNotStarted_DragOver);
            this.listboxNotStarted.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listboxNotStarted_MouseDown);
            // 
            // listboxInProgress
            // 
            this.listboxInProgress.AllowDrop = true;
            this.listboxInProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listboxInProgress.BackColor = System.Drawing.SystemColors.Info;
            this.listboxInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listboxInProgress.FormattingEnabled = true;
            this.listboxInProgress.ItemHeight = 29;
            this.listboxInProgress.Location = new System.Drawing.Point(652, 161);
            this.listboxInProgress.Name = "listboxInProgress";
            this.listboxInProgress.Size = new System.Drawing.Size(309, 439);
            this.listboxInProgress.TabIndex = 2;
            this.listboxInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.listboxInProgress_DragDrop);
            this.listboxInProgress.DragOver += new System.Windows.Forms.DragEventHandler(this.listboxInProgress_DragOver);
            this.listboxInProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listboxInProgress_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 626);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seçili storiesi silmek için boş alana sürükleyin.";
            // 
            // btnSaveAndExits
            // 
            this.btnSaveAndExits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveAndExits.Location = new System.Drawing.Point(1041, 618);
            this.btnSaveAndExits.Name = "btnSaveAndExits";
            this.btnSaveAndExits.Size = new System.Drawing.Size(173, 54);
            this.btnSaveAndExits.TabIndex = 11;
            this.btnSaveAndExits.Text = "Kaydet ve Çık";
            this.btnSaveAndExits.UseSelectable = true;
            this.btnSaveAndExits.Click += new System.EventHandler(this.btnSaveAndExits_Click);
            // 
            // ScrumApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 695);
            this.Controls.Add(this.btnSaveAndExits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textStories);
            this.Controls.Add(this.btnAddStories);
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.labelInProgress);
            this.Controls.Add(this.labelNotStarted);
            this.Controls.Add(this.labelStories);
            this.Controls.Add(this.listboxDone);
            this.Controls.Add(this.listboxInProgress);
            this.Controls.Add(this.listboxNotStarted);
            this.Controls.Add(this.listboxStories);
            this.Name = "ScrumApp";
            this.Text = "ScrumApp v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listboxDone;
        private System.Windows.Forms.Label labelStories;
        private System.Windows.Forms.Label labelNotStarted;
        private System.Windows.Forms.Label labelInProgress;
        private System.Windows.Forms.Label labelDone;
        private MetroFramework.Controls.MetroButton btnAddStories;
        private System.Windows.Forms.TextBox textStories;
        private System.Windows.Forms.ListBox listboxStories;
        private System.Windows.Forms.ListBox listboxNotStarted;
        private System.Windows.Forms.ListBox listboxInProgress;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnSaveAndExits;
    }
}


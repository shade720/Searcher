namespace Searcher.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SelectCatalogButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KeywordFoundedOverallListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeywordFoundByFilesListView = new System.Windows.Forms.ListView();
            this.KeywordsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OccurrencesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CaseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.KeywordFilepathTextbox = new System.Windows.Forms.TextBox();
            this.CatalogPathTextbox = new System.Windows.Forms.TextBox();
            this.SelectKeywordsFileButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catalog:";
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.ShowNewFolderButton = false;
            // 
            // SelectCatalogButton
            // 
            this.SelectCatalogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectCatalogButton.Location = new System.Drawing.Point(511, 456);
            this.SelectCatalogButton.Name = "SelectCatalogButton";
            this.SelectCatalogButton.Size = new System.Drawing.Size(126, 27);
            this.SelectCatalogButton.TabIndex = 2;
            this.SelectCatalogButton.Text = "Select";
            this.SelectCatalogButton.UseVisualStyleBackColor = true;
            this.SelectCatalogButton.Click += new System.EventHandler(this.SelectCatalogButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Keywords file:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KeywordFoundedOverallListView);
            this.groupBox1.Controls.Add(this.KeywordFoundByFilesListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 407);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(787, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // KeywordFoundedOverallListView
            // 
            this.KeywordFoundedOverallListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.KeywordFoundedOverallListView.HideSelection = false;
            this.KeywordFoundedOverallListView.Location = new System.Drawing.Point(625, 21);
            this.KeywordFoundedOverallListView.Name = "KeywordFoundedOverallListView";
            this.KeywordFoundedOverallListView.Size = new System.Drawing.Size(271, 380);
            this.KeywordFoundedOverallListView.TabIndex = 10;
            this.KeywordFoundedOverallListView.UseCompatibleStateImageBehavior = false;
            this.KeywordFoundedOverallListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Keywords";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Occurrences";
            this.columnHeader2.Width = 100;
            // 
            // KeywordFoundByFilesListView
            // 
            this.KeywordFoundByFilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KeywordsColumn,
            this.OccurrencesColumn});
            this.KeywordFoundByFilesListView.HideSelection = false;
            this.KeywordFoundByFilesListView.Location = new System.Drawing.Point(6, 21);
            this.KeywordFoundByFilesListView.Name = "KeywordFoundByFilesListView";
            this.KeywordFoundByFilesListView.ShowItemToolTips = true;
            this.KeywordFoundByFilesListView.Size = new System.Drawing.Size(613, 380);
            this.KeywordFoundByFilesListView.TabIndex = 9;
            this.KeywordFoundByFilesListView.UseCompatibleStateImageBehavior = false;
            this.KeywordFoundByFilesListView.View = System.Windows.Forms.View.Details;
            // 
            // KeywordsColumn
            // 
            this.KeywordsColumn.Text = "Keywords";
            this.KeywordsColumn.Width = 90;
            // 
            // OccurrencesColumn
            // 
            this.OccurrencesColumn.Text = "Occurrences";
            this.OccurrencesColumn.Width = 100;
            // 
            // CaseSensitiveCheckBox
            // 
            this.CaseSensitiveCheckBox.AutoSize = true;
            this.CaseSensitiveCheckBox.Location = new System.Drawing.Point(643, 447);
            this.CaseSensitiveCheckBox.Name = "CaseSensitiveCheckBox";
            this.CaseSensitiveCheckBox.Size = new System.Drawing.Size(117, 20);
            this.CaseSensitiveCheckBox.TabIndex = 8;
            this.CaseSensitiveCheckBox.Text = "Case sensitive";
            this.CaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(833, 436);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 40);
            this.RefreshButton.TabIndex = 7;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // KeywordFilepathTextbox
            // 
            this.KeywordFilepathTextbox.Location = new System.Drawing.Point(102, 425);
            this.KeywordFilepathTextbox.Multiline = true;
            this.KeywordFilepathTextbox.Name = "KeywordFilepathTextbox";
            this.KeywordFilepathTextbox.Size = new System.Drawing.Size(403, 27);
            this.KeywordFilepathTextbox.TabIndex = 8;
            this.KeywordFilepathTextbox.Text = "C:\\Users\\Unh0ly\\Desktop\\keywords.txt";
            // 
            // CatalogPathTextbox
            // 
            this.CatalogPathTextbox.Location = new System.Drawing.Point(102, 457);
            this.CatalogPathTextbox.Multiline = true;
            this.CatalogPathTextbox.Name = "CatalogPathTextbox";
            this.CatalogPathTextbox.Size = new System.Drawing.Size(403, 27);
            this.CatalogPathTextbox.TabIndex = 9;
            this.CatalogPathTextbox.Text = "./";
            // 
            // SelectKeywordsFileButton
            // 
            this.SelectKeywordsFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectKeywordsFileButton.Location = new System.Drawing.Point(511, 424);
            this.SelectKeywordsFileButton.Name = "SelectKeywordsFileButton";
            this.SelectKeywordsFileButton.Size = new System.Drawing.Size(126, 27);
            this.SelectKeywordsFileButton.TabIndex = 10;
            this.SelectKeywordsFileButton.Text = "Select";
            this.SelectKeywordsFileButton.UseVisualStyleBackColor = true;
            this.SelectKeywordsFileButton.Click += new System.EventHandler(this.SelectKeywordsFileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SelectKeywordsFileButton);
            this.Controls.Add(this.CaseSensitiveCheckBox);
            this.Controls.Add(this.SelectCatalogButton);
            this.Controls.Add(this.CatalogPathTextbox);
            this.Controls.Add(this.KeywordFilepathTextbox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Searcher";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Button SelectCatalogButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox KeywordFilepathTextbox;
        private System.Windows.Forms.TextBox CatalogPathTextbox;
        private System.Windows.Forms.Button SelectKeywordsFileButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.CheckBox CaseSensitiveCheckBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ListView KeywordFoundByFilesListView;
        private System.Windows.Forms.ColumnHeader KeywordsColumn;
        private System.Windows.Forms.ColumnHeader OccurrencesColumn;
        private System.Windows.Forms.ListView KeywordFoundedOverallListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


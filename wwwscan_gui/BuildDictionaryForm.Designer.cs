namespace wwwscan_gui
{
    partial class BuildDictionaryForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_openfile = new System.Windows.Forms.Button();
            this.textBox_filepath = new System.Windows.Forms.TextBox();
            this.button_import = new System.Windows.Forms.Button();
            this.button_distinct = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.backgroundWorker_import = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_distinct = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button_openfile
            // 
            this.button_openfile.Location = new System.Drawing.Point(110, 60);
            this.button_openfile.Name = "button_openfile";
            this.button_openfile.Size = new System.Drawing.Size(75, 23);
            this.button_openfile.TabIndex = 0;
            this.button_openfile.Text = "打开";
            this.button_openfile.UseVisualStyleBackColor = true;
            this.button_openfile.Click += new System.EventHandler(this.button_openfile_Click);
            // 
            // textBox_filepath
            // 
            this.textBox_filepath.Location = new System.Drawing.Point(12, 12);
            this.textBox_filepath.Multiline = true;
            this.textBox_filepath.Name = "textBox_filepath";
            this.textBox_filepath.Size = new System.Drawing.Size(260, 42);
            this.textBox_filepath.TabIndex = 1;
            // 
            // button_import
            // 
            this.button_import.Location = new System.Drawing.Point(61, 227);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(75, 23);
            this.button_import.TabIndex = 2;
            this.button_import.Text = "导入";
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // button_distinct
            // 
            this.button_distinct.Location = new System.Drawing.Point(142, 227);
            this.button_distinct.Name = "button_distinct";
            this.button_distinct.Size = new System.Drawing.Size(75, 23);
            this.button_distinct.TabIndex = 3;
            this.button_distinct.Text = "清理冗余";
            this.button_distinct.UseVisualStyleBackColor = true;
            this.button_distinct.Click += new System.EventHandler(this.button_distinct_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(12, 101);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_result.Size = new System.Drawing.Size(259, 89);
            this.textBox_result.TabIndex = 4;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox_result_TextChanged);
            // 
            // backgroundWorker_import
            // 
            this.backgroundWorker_import.WorkerReportsProgress = true;
            this.backgroundWorker_import.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_import_DoWork);
            this.backgroundWorker_import.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_import_ProgressChanged);
            this.backgroundWorker_import.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_import_RunWorkerCompleted);
            // 
            // backgroundWorker_distinct
            // 
            this.backgroundWorker_distinct.WorkerReportsProgress = true;
            this.backgroundWorker_distinct.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_distinct_DoWork);
            this.backgroundWorker_distinct.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_distinct_ProgressChanged);
            this.backgroundWorker_distinct.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_distinct_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 196);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(258, 24);
            this.progressBar1.TabIndex = 5;
            // 
            // BuildDictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_distinct);
            this.Controls.Add(this.button_import);
            this.Controls.Add(this.textBox_filepath);
            this.Controls.Add(this.button_openfile);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "BuildDictionaryForm";
            this.Text = "导入字典";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuildDictionaryForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_openfile;
        private System.Windows.Forms.TextBox textBox_filepath;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_distinct;
        private System.Windows.Forms.TextBox textBox_result;
        private System.ComponentModel.BackgroundWorker backgroundWorker_import;
        private System.ComponentModel.BackgroundWorker backgroundWorker_distinct;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
namespace Library
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
            this.genresView = new System.Windows.Forms.DataGridView();
            this.id_genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_gen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addGenreBtn = new System.Windows.Forms.Button();
            this.editGenre = new System.Windows.Forms.Button();
            this.delGenre = new System.Windows.Forms.Button();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.editBookBtn = new System.Windows.Forms.Button();
            this.delBookBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.genresView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksView)).BeginInit();
            this.SuspendLayout();
            // 
            // genresView
            // 
            this.genresView.AllowUserToAddRows = false;
            this.genresView.AllowUserToDeleteRows = false;
            this.genresView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genresView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_genre,
            this.genre});
            this.genresView.Location = new System.Drawing.Point(12, 12);
            this.genresView.Name = "genresView";
            this.genresView.ReadOnly = true;
            this.genresView.Size = new System.Drawing.Size(244, 150);
            this.genresView.TabIndex = 0;
            this.genresView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.genresView_CellClick);
            // 
            // id_genre
            // 
            this.id_genre.HeaderText = "Id_Жанра";
            this.id_genre.Name = "id_genre";
            this.id_genre.ReadOnly = true;
            // 
            // genre
            // 
            this.genre.HeaderText = "Жанр";
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            // 
            // booksView
            // 
            this.booksView.AllowUserToAddRows = false;
            this.booksView.AllowUserToDeleteRows = false;
            this.booksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.id_gen});
            this.booksView.Location = new System.Drawing.Point(262, 12);
            this.booksView.Name = "booksView";
            this.booksView.ReadOnly = true;
            this.booksView.Size = new System.Drawing.Size(346, 150);
            this.booksView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Книги";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование книги";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // id_gen
            // 
            this.id_gen.HeaderText = "Id_Жанра";
            this.id_gen.Name = "id_gen";
            this.id_gen.ReadOnly = true;
            // 
            // addGenreBtn
            // 
            this.addGenreBtn.Location = new System.Drawing.Point(12, 168);
            this.addGenreBtn.Name = "addGenreBtn";
            this.addGenreBtn.Size = new System.Drawing.Size(113, 23);
            this.addGenreBtn.TabIndex = 2;
            this.addGenreBtn.Text = "Добавить жанр";
            this.addGenreBtn.UseVisualStyleBackColor = true;
            this.addGenreBtn.Click += new System.EventHandler(this.addGenreBtn_Click);
            // 
            // editGenre
            // 
            this.editGenre.Location = new System.Drawing.Point(131, 168);
            this.editGenre.Name = "editGenre";
            this.editGenre.Size = new System.Drawing.Size(125, 23);
            this.editGenre.TabIndex = 3;
            this.editGenre.Text = "Изменить жанр";
            this.editGenre.UseVisualStyleBackColor = true;
            this.editGenre.Click += new System.EventHandler(this.editGenre_Click);
            // 
            // delGenre
            // 
            this.delGenre.Location = new System.Drawing.Point(12, 197);
            this.delGenre.Name = "delGenre";
            this.delGenre.Size = new System.Drawing.Size(244, 23);
            this.delGenre.TabIndex = 4;
            this.delGenre.Text = "Удалить жанр";
            this.delGenre.UseVisualStyleBackColor = true;
            this.delGenre.Click += new System.EventHandler(this.delGenre_Click);
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(262, 168);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(170, 23);
            this.addBookBtn.TabIndex = 5;
            this.addBookBtn.Text = "Добавить книгу";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // editBookBtn
            // 
            this.editBookBtn.Location = new System.Drawing.Point(438, 168);
            this.editBookBtn.Name = "editBookBtn";
            this.editBookBtn.Size = new System.Drawing.Size(170, 23);
            this.editBookBtn.TabIndex = 6;
            this.editBookBtn.Text = "Изменить книгу";
            this.editBookBtn.UseVisualStyleBackColor = true;
            this.editBookBtn.Click += new System.EventHandler(this.editBookBtn_Click);
            // 
            // delBookBtn
            // 
            this.delBookBtn.Location = new System.Drawing.Point(262, 197);
            this.delBookBtn.Name = "delBookBtn";
            this.delBookBtn.Size = new System.Drawing.Size(346, 23);
            this.delBookBtn.TabIndex = 7;
            this.delBookBtn.Text = "Удалить книгу";
            this.delBookBtn.UseVisualStyleBackColor = true;
            this.delBookBtn.Click += new System.EventHandler(this.delBookBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 304);
            this.Controls.Add(this.delBookBtn);
            this.Controls.Add(this.editBookBtn);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.delGenre);
            this.Controls.Add(this.editGenre);
            this.Controls.Add(this.addGenreBtn);
            this.Controls.Add(this.booksView);
            this.Controls.Add(this.genresView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.genresView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView genresView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        public System.Windows.Forms.DataGridView booksView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_gen;
        private System.Windows.Forms.Button addGenreBtn;
        private System.Windows.Forms.Button editGenre;
        private System.Windows.Forms.Button delGenre;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button editBookBtn;
        private System.Windows.Forms.Button delBookBtn;
    }
}


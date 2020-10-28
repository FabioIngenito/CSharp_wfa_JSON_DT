namespace wfa_JSON_DT
{
    partial class FrmJSON_DT
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
            this.LblEnderecoURL = new System.Windows.Forms.Label();
            this.TxtURL = new System.Windows.Forms.TextBox();
            this.BtnAcessar = new System.Windows.Forms.Button();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.GrbResorces = new System.Windows.Forms.GroupBox();
            this.RbtBarra = new System.Windows.Forms.RadioButton();
            this.RbtUsers = new System.Windows.Forms.RadioButton();
            this.RbtTodos = new System.Windows.Forms.RadioButton();
            this.RbtPhotos = new System.Windows.Forms.RadioButton();
            this.RbtAlbums = new System.Windows.Forms.RadioButton();
            this.RbtComments = new System.Windows.Forms.RadioButton();
            this.RbtPosts = new System.Windows.Forms.RadioButton();
            this.BtnAcessarREST = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.GrbResorces.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblEnderecoURL
            // 
            this.LblEnderecoURL.AutoSize = true;
            this.LblEnderecoURL.Location = new System.Drawing.Point(12, 9);
            this.LblEnderecoURL.Name = "LblEnderecoURL";
            this.LblEnderecoURL.Size = new System.Drawing.Size(394, 13);
            this.LblEnderecoURL.TabIndex = 0;
            this.LblEnderecoURL.Text = "Endereço URL - (depois use o SEU endereço com o recurso \"/\" no RadioButton):";
            // 
            // TxtURL
            // 
            this.TxtURL.Location = new System.Drawing.Point(15, 25);
            this.TxtURL.Name = "TxtURL";
            this.TxtURL.Size = new System.Drawing.Size(649, 20);
            this.TxtURL.TabIndex = 1;
            this.TxtURL.Text = "https://jsonplaceholder.typicode.com";
            // 
            // BtnAcessar
            // 
            this.BtnAcessar.Location = new System.Drawing.Point(670, 9);
            this.BtnAcessar.Name = "BtnAcessar";
            this.BtnAcessar.Size = new System.Drawing.Size(56, 88);
            this.BtnAcessar.TabIndex = 2;
            this.BtnAcessar.Text = "&Acessar";
            this.BtnAcessar.UseVisualStyleBackColor = true;
            this.BtnAcessar.Click += new System.EventHandler(this.BtnAcessar_Click);
            // 
            // DgvDados
            // 
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDados.Location = new System.Drawing.Point(12, 103);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.Size = new System.Drawing.Size(776, 335);
            this.DgvDados.TabIndex = 3;
            // 
            // GrbResorces
            // 
            this.GrbResorces.Controls.Add(this.RbtBarra);
            this.GrbResorces.Controls.Add(this.RbtUsers);
            this.GrbResorces.Controls.Add(this.RbtTodos);
            this.GrbResorces.Controls.Add(this.RbtPhotos);
            this.GrbResorces.Controls.Add(this.RbtAlbums);
            this.GrbResorces.Controls.Add(this.RbtComments);
            this.GrbResorces.Controls.Add(this.RbtPosts);
            this.GrbResorces.Location = new System.Drawing.Point(15, 55);
            this.GrbResorces.Name = "GrbResorces";
            this.GrbResorces.Size = new System.Drawing.Size(649, 42);
            this.GrbResorces.TabIndex = 4;
            this.GrbResorces.TabStop = false;
            this.GrbResorces.Text = "JSONPlaceholder comes with a set of 6 common resources:";
            // 
            // RbtBarra
            // 
            this.RbtBarra.AutoSize = true;
            this.RbtBarra.Location = new System.Drawing.Point(611, 19);
            this.RbtBarra.Name = "RbtBarra";
            this.RbtBarra.Size = new System.Drawing.Size(30, 17);
            this.RbtBarra.TabIndex = 6;
            this.RbtBarra.Text = "/";
            this.RbtBarra.UseVisualStyleBackColor = true;
            // 
            // RbtUsers
            // 
            this.RbtUsers.AutoSize = true;
            this.RbtUsers.Location = new System.Drawing.Point(550, 19);
            this.RbtUsers.Name = "RbtUsers";
            this.RbtUsers.Size = new System.Drawing.Size(55, 17);
            this.RbtUsers.TabIndex = 5;
            this.RbtUsers.Text = "/users";
            this.RbtUsers.UseVisualStyleBackColor = true;
            // 
            // RbtTodos
            // 
            this.RbtTodos.AutoSize = true;
            this.RbtTodos.Location = new System.Drawing.Point(488, 19);
            this.RbtTodos.Name = "RbtTodos";
            this.RbtTodos.Size = new System.Drawing.Size(56, 17);
            this.RbtTodos.TabIndex = 4;
            this.RbtTodos.Text = "/todos";
            this.RbtTodos.UseVisualStyleBackColor = true;
            // 
            // RbtPhotos
            // 
            this.RbtPhotos.AutoSize = true;
            this.RbtPhotos.Location = new System.Drawing.Point(420, 19);
            this.RbtPhotos.Name = "RbtPhotos";
            this.RbtPhotos.Size = new System.Drawing.Size(62, 17);
            this.RbtPhotos.TabIndex = 3;
            this.RbtPhotos.Text = "/photos";
            this.RbtPhotos.UseVisualStyleBackColor = true;
            // 
            // RbtAlbums
            // 
            this.RbtAlbums.AutoSize = true;
            this.RbtAlbums.Location = new System.Drawing.Point(351, 19);
            this.RbtAlbums.Name = "RbtAlbums";
            this.RbtAlbums.Size = new System.Drawing.Size(63, 17);
            this.RbtAlbums.TabIndex = 2;
            this.RbtAlbums.Text = "/albums";
            this.RbtAlbums.UseVisualStyleBackColor = true;
            // 
            // RbtComments
            // 
            this.RbtComments.AutoSize = true;
            this.RbtComments.Location = new System.Drawing.Point(267, 19);
            this.RbtComments.Name = "RbtComments";
            this.RbtComments.Size = new System.Drawing.Size(78, 17);
            this.RbtComments.TabIndex = 1;
            this.RbtComments.Text = "/comments";
            this.RbtComments.UseVisualStyleBackColor = true;
            // 
            // RbtPosts
            // 
            this.RbtPosts.AutoSize = true;
            this.RbtPosts.Checked = true;
            this.RbtPosts.Location = new System.Drawing.Point(206, 19);
            this.RbtPosts.Name = "RbtPosts";
            this.RbtPosts.Size = new System.Drawing.Size(55, 17);
            this.RbtPosts.TabIndex = 0;
            this.RbtPosts.TabStop = true;
            this.RbtPosts.Text = "/posts";
            this.RbtPosts.UseVisualStyleBackColor = true;
            // 
            // BtnAcessarREST
            // 
            this.BtnAcessarREST.Location = new System.Drawing.Point(732, 9);
            this.BtnAcessarREST.Name = "BtnAcessarREST";
            this.BtnAcessarREST.Size = new System.Drawing.Size(56, 88);
            this.BtnAcessarREST.TabIndex = 5;
            this.BtnAcessarREST.Text = "&Acessar via REST";
            this.BtnAcessarREST.UseVisualStyleBackColor = true;
            this.BtnAcessarREST.Click += new System.EventHandler(this.BtnAcessarREST_Click);
            // 
            // FrmJSON_DT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAcessarREST);
            this.Controls.Add(this.GrbResorces);
            this.Controls.Add(this.DgvDados);
            this.Controls.Add(this.BtnAcessar);
            this.Controls.Add(this.TxtURL);
            this.Controls.Add(this.LblEnderecoURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJSON_DT";
            this.ShowIcon = false;
            this.Text = "Convertendo JSON para DataTable";
            this.Load += new System.EventHandler(this.FrmJSON_DT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.GrbResorces.ResumeLayout(false);
            this.GrbResorces.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEnderecoURL;
        private System.Windows.Forms.TextBox TxtURL;
        private System.Windows.Forms.Button BtnAcessar;
        private System.Windows.Forms.DataGridView DgvDados;
        private System.Windows.Forms.GroupBox GrbResorces;
        private System.Windows.Forms.RadioButton RbtUsers;
        private System.Windows.Forms.RadioButton RbtTodos;
        private System.Windows.Forms.RadioButton RbtPhotos;
        private System.Windows.Forms.RadioButton RbtAlbums;
        private System.Windows.Forms.RadioButton RbtComments;
        private System.Windows.Forms.RadioButton RbtPosts;
        private System.Windows.Forms.RadioButton RbtBarra;
        private System.Windows.Forms.Button BtnAcessarREST;
    }
}
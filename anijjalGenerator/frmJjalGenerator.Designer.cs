namespace anijjalGenerator
{
    partial class frmJjalGenerator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpenGIF = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddEntity = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.listboxEntities = new System.Windows.Forms.ListBox();
            this.textBoxEntityName = new System.Windows.Forms.TextBox();
            this.btnSaveGIF = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenGIF
            // 
            this.btnOpenGIF.Location = new System.Drawing.Point(587, 13);
            this.btnOpenGIF.Name = "btnOpenGIF";
            this.btnOpenGIF.Size = new System.Drawing.Size(75, 23);
            this.btnOpenGIF.TabIndex = 1;
            this.btnOpenGIF.Text = "Open GIF";
            this.btnOpenGIF.UseVisualStyleBackColor = true;
            this.btnOpenGIF.Click += new System.EventHandler(this.btnOpenGIF_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(3, 434);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(754, 79);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 400);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnAddEntity
            // 
            this.btnAddEntity.Location = new System.Drawing.Point(529, 164);
            this.btnAddEntity.Name = "btnAddEntity";
            this.btnAddEntity.Size = new System.Drawing.Size(75, 23);
            this.btnAddEntity.TabIndex = 4;
            this.btnAddEntity.Text = "추가";
            this.btnAddEntity.UseVisualStyleBackColor = true;
            this.btnAddEntity.Click += new System.EventHandler(this.btnAddEntity_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(529, 93);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "텍스트";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(529, 115);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "이미지";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(529, 137);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(35, 16);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "...";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // listboxEntities
            // 
            this.listboxEntities.FormattingEnabled = true;
            this.listboxEntities.ItemHeight = 12;
            this.listboxEntities.Location = new System.Drawing.Point(529, 204);
            this.listboxEntities.Name = "listboxEntities";
            this.listboxEntities.Size = new System.Drawing.Size(228, 196);
            this.listboxEntities.TabIndex = 6;
            // 
            // textBoxEntityName
            // 
            this.textBoxEntityName.Location = new System.Drawing.Point(607, 87);
            this.textBoxEntityName.Name = "textBoxEntityName";
            this.textBoxEntityName.Size = new System.Drawing.Size(137, 21);
            this.textBoxEntityName.TabIndex = 7;
            // 
            // btnSaveGIF
            // 
            this.btnSaveGIF.Location = new System.Drawing.Point(669, 12);
            this.btnSaveGIF.Name = "btnSaveGIF";
            this.btnSaveGIF.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGIF.TabIndex = 8;
            this.btnSaveGIF.Text = "Save GIF";
            this.btnSaveGIF.UseVisualStyleBackColor = true;
            this.btnSaveGIF.Click += new System.EventHandler(this.btnSaveGIF_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 519);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(754, 62);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "이 프로그램은 http://jjal.download/ 서비스에 영감을 받아 기술적으로 재미삼아 다시 만들어본 프로그램입니다. 글자 입력 뿐만 아니" +
    "라 포지션 위치를 원하는대로 수정할 수 있습니다. 현재는 그림을 추가할 수 없지만 코드를 조금만 수정하면 이미지(에를 들어 닭다리)를 추가해서 " +
    "gif로 저장 가능합니다. 재미있게 사용하시길! by ProgC\n";
            // 
            // frmJjalGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 587);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSaveGIF);
            this.Controls.Add(this.textBoxEntityName);
            this.Controls.Add(this.listboxEntities);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnAddEntity);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpenGIF);
            this.Name = "frmJjalGenerator";
            this.Text = "애니메이션 짤 생성기";
            this.Load += new System.EventHandler(this.frmJjalGenerator_Load);            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenGIF;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddEntity;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ListBox listboxEntities;
        private System.Windows.Forms.TextBox textBoxEntityName;
        private System.Windows.Forms.Button btnSaveGIF;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Gif.Components; //ngif

namespace anijjalGenerator
{
    public partial class frmJjalGenerator : Form
    {
        public frmJjalGenerator()
        {
            InitializeComponent();
        }

        List<Bitmap> bitmapList = new List<Bitmap>();
        
        class Entity
        {
            public enum eEntityType
            {
                Text,
                Image,
                Etc,
            }

            public eEntityType EntityType;
            public List<Point> pos = new List<Point>();
            public string text;            
        }

        List<Entity> EntityList = new List<Entity>();
                
        public static BitmapSource ConvertBitmap(Bitmap source)
        {
            return System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                          source.GetHbitmap(),
                          IntPtr.Zero,
                          System.Windows.Int32Rect.Empty,
                          BitmapSizeOptions.FromEmptyOptions());
        }

        public static Bitmap BitmapFromSource(BitmapSource bitmapsource)
        {
            Bitmap bitmap;
            using (var outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapsource));
                enc.Save(outStream);
                bitmap = new Bitmap(outStream);
            }
            return bitmap;
        }

        private void btnOpenGIF_Click(object sender, EventArgs e)
        {
            bitmapList.Clear();
            EntityList.Clear();

            OpenFileDialog dialog = new OpenFileDialog();
            if ( dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {
                FileStream file = new FileStream(dialog.FileName, FileMode.Open);
                GifBitmapDecoder decoder = new GifBitmapDecoder(file, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
                                
                for ( int i = 0; i < decoder.Frames.Count; ++i )
                {
                    BitmapSource bitmapSource = decoder.Frames[i];                    
                    Bitmap bitmap = BitmapFromSource(bitmapSource);
                    
                    bitmapList.Add(bitmap);
                    
                    pictureBox1.Image = bitmap;
                    imageList1.Images.Add(bitmap);
                    
                    ListViewItem item = listView1.Items.Add( i.ToString(), i );
                    item.ImageIndex = i;
                }
            }
        }
                
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexCollection = listView1.SelectedIndices;
            if (indexCollection.Count > 0)
            {
                int index = indexCollection[0];
                pictureBox1.Image = bitmapList[index];
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // get the current anim index
            if (listView1.SelectedIndices.Count > 0)
            {
                // get the current entity
                int curEntityIndex = listboxEntities.SelectedIndex;
                int curAnimIndex = listView1.SelectedIndices[0];

                // set the entity's position
                int x = e.X;
                int y = e.Y;

                EntityList[curEntityIndex].pos[curAnimIndex] = new Point(x,y);
                pictureBox1.Refresh();
            }
        }

        private void btnAddEntity_Click(object sender, EventArgs e)
        {
            if (bitmapList.Count == 0)
            {
                MessageBox.Show("배경이 될 GIF를 먼저 로드하셔야 합니다.", "정보", MessageBoxButtons.OK);
                return;
            }
            
            Entity newEntity = new Entity();

            if (radioButton1.Checked)
            {
                newEntity.EntityType = Entity.eEntityType.Text;
                newEntity.text = textBoxEntityName.Text;                
            }
            else if (radioButton2.Checked)
            {
            }
            else if (radioButton3.Checked)
            {                
            }
            
            newEntity.pos = new List<Point>(bitmapList.Count);
            for (int i = 0; i < bitmapList.Count; ++i)
            {
                newEntity.pos.Add(new Point(0, 0));
            }

            EntityList.Add(newEntity);
            listboxEntities.Items.Add(newEntity.text);
            listboxEntities.SelectedIndex = EntityList.Count - 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0 ) return;                        
            int curAnimIndex = listView1.SelectedIndices[0];

            if (EntityList.Count > 0)
            {
                for (int i = 0; i < EntityList.Count; ++i)
                {
                    Entity entity = EntityList[i];
                    if (entity.EntityType == Entity.eEntityType.Text)
                    {
                        e.Graphics.DrawString(entity.text, DefaultFont, System.Drawing.Brushes.Black, (PointF)entity.pos[curAnimIndex]);
                    }
                }
            }
        }

        // Unfortunately GifBitmapEncoder doesn't support adding a metadata so I used other solution which is NGif.
        private void btnSaveGIF_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                AnimatedGifEncoder encoder = new AnimatedGifEncoder();
                encoder.Start(dialog.FileName);
                encoder.SetRepeat(0);
                encoder.SetTransparent(System.Drawing.Color.Black);

                for (int i = 0; i < bitmapList.Count; ++i)
                {
                    Bitmap newBitmap = new Bitmap(bitmapList[i]);

                    Graphics g = Graphics.FromImage(newBitmap);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    // newBitmap에 Entity들을 그리고 저장한다.
                    for (int entityIdx = 0; entityIdx < EntityList.Count; ++entityIdx )
                    {
                        Entity entity = EntityList[entityIdx];
                        if (entity.EntityType == Entity.eEntityType.Text)
                        {                                                        
                            g.DrawString(entity.text, DefaultFont, System.Drawing.Brushes.Black, (PointF)entity.pos[i]);
                        }
                    }

                    g.Flush();

                    encoder.AddFrame(newBitmap);
                }
                encoder.Finish();
            }
        }

        private void frmJjalGenerator_Load(object sender, EventArgs e)
        {
        }
    }
}

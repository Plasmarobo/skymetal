using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationBuilder
{

    public partial class Form1 : Form
    {
        Animation currentAnimation;
        Dictionary<String, Animation> Animations;
        Boolean hasSaved;
        Rectangle selected;
        public Form1()
        {
            InitializeComponent();
            hasSaved = true;
            //ImageBox.AutoScroll = true;
            ClearAnims();
        }



        private void ClearAnims()
        {
            currentAnimation = new Animation();
            Animations = new Dictionary<string, Animation>();
            NameList.DataSource = new BindingSource(Animations.Keys, null);
            FramesBox.DataSource = new BindingSource(currentAnimation.mFrames, null);
            //NameList.DisplayMember = "Key";
            //NameList.ValueMember = "Key";
            //NameList.ValueMember = "Value";
        }
        private Boolean WriteAnimationsToFile(String filename)
        {
            FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
            foreach(KeyValuePair<String, Animation> kvp in Animations)
            {
                kvp.Value.Write(file, kvp.Key);
            }
            return true;
        }

        private Boolean ReadAnimationsFromFile(String filename)
        {
            FileStream file = new FileStream(filename, FileMode.Open);
            while(file.Position != file.Length)
            {
                Animation anim = new Animation();
                String name = anim.Read(file);
                Animations.Add(name, anim);
            }
            return true;
        }

        private void DelNameBtn_Click(object sender, EventArgs e)
        {

        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if(!hasSaved)
            {
                DialogResult res = MessageBox.Show("The current animation has not been saved, opening a new image will discard work since last save. Save file?", "Save Animation?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch(res)
                {
                    case DialogResult.Yes:
                        SaveFileDialog save = new SaveFileDialog();
                        if (save.ShowDialog() == DialogResult.OK)
                        {
                            if(!WriteAnimationsToFile(save.FileName))
                            {
                                MessageBox.Show("Could not save animation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case DialogResult.No:
                        ClearAnims();
                        break;
                    case DialogResult.Cancel:
                    default:
                        return;
                }
            }
            OpenFileDialog diag = new OpenFileDialog();
            if( diag.ShowDialog() == DialogResult.OK)
            {
                ImageBox.Load(diag.FileName);
            }
        }

        private void ImageBox_Paint(object sender, PaintEventArgs e)
        {
            if (ShowGrid.Checked)
            {
                using (Pen pen = new Pen(Color.Gray, 1))
                {
                    int inc_x = int.Parse(WidthBox.Text);
                    int inc_y = int.Parse(HeightBox.Text);
                    for (int x = ImagePanel.AutoScrollOffset.X % inc_x; x < ImageBox.Width; x += inc_x)
                    {
                        e.Graphics.DrawLine(pen, x, 0, x, ImageBox.Height);
                    }

                    for (int y = ImagePanel.AutoScrollOffset.Y % inc_y; y < ImageBox.Height; y += inc_y)
                    {
                        e.Graphics.DrawLine(pen, 0, y, ImageBox.Width, y);
                    }
                }
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    if (selected.Width > 0 && selected.Height > 0)
                    {
                        e.Graphics.DrawRectangle(pen, selected);
                    }
                }
            }
        }

        private void ImageBox_MouseDown(object sender, MouseEventArgs e)
        {
            //Is it a valid frame choice
            int w = int.Parse(WidthBox.Text);
            int h = int.Parse(HeightBox.Text);
            selected = new Rectangle(e.X - (e.X % w), e.Y - (e.Y % h), w, h);
            ImageBox.Refresh();
            TextDialog dialog = new TextDialog("Duration", "Set Frame Duration in ms:");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Frame f = new Frame();
                f.mDuration = int.Parse(dialog.Input);
                f.mSource = selected;
                currentAnimation.AddFrame(f);
                FramesBox.DataSource = new BindingSource(currentAnimation.mAnimation, null);
                FramesBox.DisplayMember = "Description";
            }
        }


        private void WidthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void HeightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            ImageBox.Refresh();
            //this.Refresh();
        }

        private void NewNameBtn_Click(object sender, EventArgs e)
        {
            int postfix = 1;
            String name = "NewAnim";
            currentAnimation = new Animation();
            TextDialog nameDiag = new TextDialog("Name Animation", "Enter animation name");
            if (nameDiag.ShowDialog() != DialogResult.OK || nameDiag.Input == "")
            {

                while (Animations.ContainsKey(name))
                {
                    name = "NewAnim" + (postfix.ToString());
                    ++postfix;
                }
            }
            else
            {
                name = nameDiag.Input;
            }
            NameBox.Text = name;
            Animations.Add(name, currentAnimation);
            NameList.DataSource = new BindingSource(Animations.Keys, null);
            //NameList.DisplayMember = "Key";
            //NameList.ValueMember = "Key";
            FramesBox.DataSource = new BindingSource(currentAnimation.mAnimation, null);
            FramesBox.DisplayMember = "Description";
            //FramesBox.Items.Add()
            //FramesBox.DataSource = new BindingSource(currentAnimation.mAnimation, null);
            
            //NameList.Update();

        }

        private void NameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Animations.Count > 0)
            {
                if (NameList.SelectedValue != null)
                {
                    
                        NameBox.Text = ((String)NameList.SelectedValue);
                        if (Animations.TryGetValue((String) NameList.SelectedValue, out currentAnimation))
                        {
                            FramesBox.DataSource = new BindingSource(currentAnimation.mAnimation, null);
                            FramesBox.DisplayMember = "Description";
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        NameList.DataSource = new BindingSource(Animations.Keys, null);
                        //NameList.DisplayMember = "Key";
                        //NameList.ValueMember = "Key";
                    }
                
            }
        }

        private void FramesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FramesBox.SelectedIndex > 0 && FramesBox.SelectedIndex < currentAnimation.mAnimation.Count)
            {
                selected = currentAnimation.mAnimation[FramesBox.SelectedIndex].mSource;
                ImageBox.Refresh();
            }
            else
                selected = new Rectangle(0, 0, 0, 0);
        }

        private void SaveAnims_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                if (!WriteAnimationsToFile(save.FileName))
                {
                    MessageBox.Show("Could not save animation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hasSaved = false;
                }
                else
                {
                    hasSaved = true;
                }
            }
        }

        private void LoadAnims_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                if(!ReadAnimationsFromFile(open.FileName))
                {
                    MessageBox.Show("Could not load animation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hasSaved = true;
                }
                else
                {
                    hasSaved = false;
                    NameList.DataSource = new BindingSource(Animations.Keys, null);
                    //NameList.DisplayMember = "Keys";
                    //NameList.ValueMember = "Key";
                }
            }
        }

        private void NewAnims_Click(object sender, EventArgs e)
        {
            if (!hasSaved)
            {
                DialogResult res = MessageBox.Show("The current animation has not been saved, opening a new animation will discard work since last save. Save file?", "Save Animation?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (res)
                {
                    case DialogResult.Yes:
                        SaveFileDialog save = new SaveFileDialog();
                        if (save.ShowDialog() == DialogResult.OK)
                        {
                            if (!WriteAnimationsToFile(save.FileName))
                            {
                                MessageBox.Show("Could not save animation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case DialogResult.No:
                        ClearAnims();
                        break;
                    case DialogResult.Cancel:
                    default:
                        return;
                }
            }
            ClearAnims();
        }


    }
}

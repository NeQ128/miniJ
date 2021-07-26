using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniJ
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Random r = new Random();
        List<Word> word_list = new List<Word>();
        delegate void add_label(Label lb);
        Thread game;
        int min, max;
        List<Button> btn = new List<Button>();
        int score, hit;
        float speed;
        input_check ic;

        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
            input.Location = new Point(200, 800);
            btn.Add(start_btn);
            btn.Add(button1);
            btn.Add(button2);
        }

        private void btn_switch()
        {
            foreach(var bt in btn)
            {
                bt.Enabled = !bt.Enabled;
                bt.Visible = !bt.Visible;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            min = 1;
            max = 93;
            game_start();
        }

        private void game_start()
        {
            speed = 0;
            score = 0;
            hit = 0;
            btn_switch();
            ic = new input_check();
            game_reset();
            game = new Thread(game_step);
            game.Start();
        }
        
        private void game_step()
        {
            word_move();
            create_word();
            Thread.Sleep(Convert.ToInt32(1000 / (1 + speed*2)));
            game_step();
        }

        private void game_reset()
        {
            foreach (var word in word_list)
            {
                if (InvokeRequired)
                {
                    var d = new add_label(remove_label);
                    Invoke(d, word.label);
                }
                else
                {
                    Controls.Remove(word.label);
                }

                void remove_label(Label lbl)
                {
                    Controls.Remove(lbl);
                }
            }
            word_list.Clear();
        }

        private void word_move()
        {
            try
            {
                foreach (var word in word_list)
                {
                    word.label.Location = new Point(word.label.Location.X, word.label.Location.Y + 50);
                    if (word.label.Location.Y > 620)
                    {
                        game_end();
                    }
                }
            }
            catch
            {

            }
        }

        private void game_end()
        {
            game_reset();
            btn_switch();
            game.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            min = 1;
            max = 47;
            game_start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            min = 47;
            max = 93;
            game_start();
        }

        private void input_KeyUp(object sender, KeyEventArgs e)
        {
            if (game.IsAlive)
            {
                hit_check(ic.input_word(e.KeyCode.ToString()));
            }
        }

        private void hit_check(int num)
        {
            try
            {
                foreach (var word in word_list)
                {
                    if (word.num == num)
                    {
                        Controls.Remove(word.label);
                        word_list.Remove(word);
                        hit_sucess();
                        return;
                    }
                }
            }
            catch
            {

            }
        }

        private void hit_sucess()
        {
            score += Convert.ToInt32(100 * (1 + speed));
            score_lb.Text = "Score : " + score;
            hit++;
            hit_lb.Text = "正解 : " + hit;
            speed_check();
        }

        private void speed_check()
        {
            if(hit % 10 == 0)
            {
                speed = (float)hit / 200;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(game != null)
                game.Abort();
        }

        private void create_word()
        {
            int j = r.Next(min, max);
            Label label = new Label();
            label.Text = ((japanese)j).ToString();
            label.Size = new Size(32, 32);
            label.Font = new Font("UD Digi Kyokasho NK", 20);
            label.Location = new Point(r.Next(20, 340), 40);
            Word word = new Word
            {
                label = label,
                text = label.Text,
                num = j % 46,
            };
            word_list.Add(word);
            if (InvokeRequired)
            {
                var d = new add_label(add_label);
                Invoke(d, label);
            }
            else
            {
                Controls.Add(label);
            }

           void add_label(Label lb)
            {
                Controls.Add(lb);
            }
        }
    }
}

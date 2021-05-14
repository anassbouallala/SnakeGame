using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        int cols = 50, rows = 25, score = 0, dx = 0, dy = 0, font = 0, back = 0;
        Piece[] Snake = new Piece[1250];
        List<int> available = new List<int>();
        bool[,] visit;
        Random Rand = new Random();
        Timer timer1 = new Timer();
        private int front;

        public Form1()
        {
            InitializeComponent();
            initial();
            LunchTimer();
        }

        private void LunchTimer()
        {
            timer1.Interval = 50;
            timer1.Tick += move;
            timer1.Start();
        }

        private void move(object sender, EventArgs e)
        {
            int x = Snake[front].Location.X, y = Snake[front].Location.Y;
            if (dx == 0 && dy == 0) return;
            if (game_over(x + dx, y + dy))
            {
                timer1.Stop();
                MessageBox.Show("ساليتي أ ولد الحاج ", "شوف شويا لهاذ الجيهة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (collisionFood(x + dx, y + dy))
            {
                score += 1;
                LblScore.Text = "Score : "+score.ToString();
                if (hits((y + dy) / 20, (x + dx) / 20)) return;
                Piece head = new Piece(x + dx, y + dy);
                front = (front - 1 + 1250)%1250;
                Snake[front] = head;
                visit[head.Location.Y / 20, head.Location.X / 20]=true;
                Controls.Add(head);
                RandomFood();

            }
            else
            {
                if (hits((y + dy) / 20, (x + dx) / 20)) return;
                visit[Snake[back].Location.Y / 20, Snake[back].Location.X / 20] = false;
                front = (front - 1 + 1250) % 1250;
                Snake[front] = Snake[back];
                Snake[front].Location = new Point(x + dx, y + dy);
                back = (back - 1 + 1250) % 1250;
                visit[(y + dy) / 20, (x + dx) / 20] = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            dx = dy = 0;
            switch (e.KeyCode)
            {
                case Keys.Right:
                    dx = 20;
                    break;
                case Keys.Left:
                    dx = -20;
                    break;
                case Keys.Up:
                    dy = -20;
                    break;
                case Keys.Down:
                    dy = +20;
                    break;



            }
        }

        private void RandomFood()
        {
            available.Clear();
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    if (!visit[i, j]) available.Add(i * cols + j);
                }
                int idx = Rand.Next(available.Count) % available.Count;
                lblFood.Left = (available[idx] * 20) % Width;
                lblFood.Top = (available[idx] * 20) / Width*20;
            }
        }

        private bool hits(int x, int y)
        {
            if (visit[x, y])
            {
                timer1.Stop();
                MessageBox.Show("بق بق نحن نغرق", "شاخضا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private bool collisionFood(int x, int y)
        {
            return x == lblFood.Location.X && y == lblFood.Location.Y;
        }

        private bool game_over(int x, int y)
        {
            return x < 0 || y < 0 || x > 980 || y > 480;
            

        }

        private void initial()
        {
            visit = new bool[rows, cols];
            Piece head = new Piece(((Rand.Next()) % cols) * 20, ((Rand.Next()) % rows) * 20);
            lblFood.Location = new Point(((Rand.Next()) % cols) * 20, ((Rand.Next()) % rows) * 20);
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    visit[i, j] = false;
                    available.Add(i * cols + j);
                }
                visit[head.Location.Y / 20, head.Location.X / 20] = true;
                available.Remove(head.Location.Y/20*cols+head.Location.X/20);
                Controls.Add(head); Snake[front] = head;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        Model model; //экземпляр класса Model, в котором хранятся основные алгоритмы игры
        Help_window help; //экземпляр формы справки
        bool win = false; //флаг, обозначающий было ли сообщение о победе для предотвращения повторного вывода сообщения при продолжении игры после победы
        public bool helpWindow_closed; //флаг, отражающий открыта ли справка
        Label[,] tile = new Label[4, 4]; //плитки с числами
        public Form1()
        {
            InitializeComponent();
            Start();
            this.KeyUp += new KeyEventHandler(pressing_arrows); //добавление обработчика события нажатия клавиш
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            helpWindow_closed = true;
            score_now.Text = "0";
            bestScore.Text = Convert.ToString(Properties.Settings.Default.best_score);
        }

        /// <summary>
        /// Метод, который подготавливает форму к началу игры
        /// </summary>
        private void Start()
        {
            model = new Model();
            model.Start();
            //создание поля, на котором будут двигаться плитки
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Location = new Point(25 + 60 * j, 70 + 60 * i);
                    pic.BorderStyle = BorderStyle.FixedSingle;
                    pic.Size = new Size(60, 60);
                    pic.BackColor = Color.Silver;
                    this.Controls.Add(pic);
                }
            }
            //отображение плиток
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    tile[i, j] = new Label();
                    if (model.GetMap(i, j) > 0)
                        tile[i, j].Text = Convert.ToString(model.GetMap(i, j));
                    else
                        tile[i, j].Text = "";
                    tile[i, j].MinimumSize = new Size(60, 60);
                    tile[i, j].BorderStyle = BorderStyle.FixedSingle;
                    tile[i, j].Size = new Size(60, 60);
                    tile[i, j].Location = new Point(25 + 60 * j, 70 + 60 * i);
                    tile[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    tile[i, j].Font = new Font("Times New Roman", 30);
                    this.Controls.Add(tile[i, j]);
                    tile[i, j].BringToFront();
                    new_color_tile(i, j);
                }
        }

        /// <summary>
        /// Настройка цвета плиток в зависимости от числа на ней
        /// </summary>
        /// <param name="i">Номер строки, в которой находится плитка</param>
        /// <param name="j">Номер столбца, в котором находится плитка</param>
        private void new_color_tile(int i, int j)
        {
            switch (model.GetMap(i, j))
            {
                case 0:
                    tile[i, j].Visible = false;
                    tile[i, j].Font = new Font("Times New Roman", 30); break;
                case 2:
                    tile[i, j].Visible = true;
                    tile[i, j].BackColor = Color.AliceBlue; tile[i, j].Font = new Font("Times New Roman", 30); break;
                case 4:
                    tile[i, j].Visible = true;
                    tile[i, j].BackColor = Color.IndianRed; tile[i, j].Font = new Font("Times New Roman", 30); break;
                case 8:
                    tile[i, j].Visible = true;
                    tile[i, j].BackColor = Color.LightBlue; tile[i, j].Font = new Font("Times New Roman", 30); break;
                case 16:
                    tile[i, j].Visible = true;
                    tile[i, j].BackColor = Color.LightSalmon; tile[i, j].Font = new Font("Times New Roman", 25); break;
                case 32:
                    tile[i, j].Visible = true;
                    tile[i, j].BackColor = Color.Chocolate; tile[i, j].Font = new Font("Times New Roman", 25); break;
                case 64:
                    tile[i, j].Visible = true;
                    tile[i, j].BackColor = Color.Red; tile[i, j].Font = new Font("Times New Roman", 25); break;
                case 128:
                    tile[i, j].Visible = true;
                    tile[i, j].BackColor = Color.LightSeaGreen; tile[i, j].Font = new Font("Times New Roman", 20); break;
                case 256:
                    tile[i, j].Visible = true;
                    tile[i, j].BackColor = Color.Orange; tile[i, j].Font = new Font("Times New Roman", 20); break;
                case 512:
                    tile[i, j].Visible = true;
                    tile[i, j].BackColor = Color.Aquamarine; tile[i, j].Font = new Font("Times New Roman", 20); break;
                case 1024:
                    tile[i, j].Visible = true;
                    tile[i, j].BackColor = Color.Coral; tile[i, j].Font = new Font("Times New Roman", 15); break;
                case 2048:
                    tile[i, j].Visible = true;
                    tile[i, j].BackColor = Color.Gold; tile[i, j].Font = new Font("Times New Roman", 15); break;
                case 4096:
                    tile[i, j].Visible = true;
                    tile[i, j].BackColor = Color.Beige; tile[i, j].Font = new Font("Times New Roman", 15); break;
                default:
                    tile[i, j].Visible = true;
                    tile[i, j].BackColor = Color.DarkViolet; tile[i, j].Font = new Font("Times New Roman", 15); break;

            }
        }

        /// <summary>
        /// Метод, который срабатывает при нажатии клавиш
        /// </summary>
        private void pressing_arrows(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    model.Right();
                    break;
                case "Left":
                    model.Left();
                    break;
                case "Up":
                    model.Up();
                    break;
                case "Down":
                    model.Down();
                    break;
            }
            score_now.Text = Convert.ToString(model.score); //вывод счёта
            //изменение чисел на плитках
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (model.GetMap(i, j) != 0)
                        tile[i, j].Text = Convert.ToString(model.GetMap(i, j));
                    else
                        tile[i, j].Text = "";
                    new_color_tile(i,j);
                }
            //проверка на окончание игры
            if (model.GameOver() || model.win)
            {
                if (model.GameOver())
                {
                    if (MessageBox.Show("Вы проиграли, попробовать снова?", "Поражение", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                        Application.Restart();
                    else
                        this.Close();
                }
                else if(model.win && win == false)
                {
                    if (MessageBox.Show("Поздравляем, вы победили!\nПродолжить игру?", "Победа", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.No)
                        this.Close();
                    win = true;
                }
            }
        }

        /// <summary>
        /// Событие при закрытии формы
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //сохранение лучшего результата
            if (Convert.ToInt32(score_now.Text) > Properties.Settings.Default.best_score)
            {
                Properties.Settings.Default.best_score = Convert.ToInt32(score_now.Text);
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// Вызов справки
        /// </summary>
        private void Form1_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (helpWindow_closed)
            {
                help = new Help_window();
                help.Owner = this;
                helpWindow_closed = false;
                help.ShowDialog();
            }
        }
    }
}

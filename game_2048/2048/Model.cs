using System;
using System.Collections.Generic;

namespace _2048
{
    class Model
    {
        Map_of_tile map; //создание объекта класса Map_of_tile для работы с числами на плитках
        Random rand = new Random(); //объект для получения рандомных значений
        public bool win; //флаг, который отслеживает победу, т.е. достижение числа на плитке = 2048
        bool moved; //флаг, отслеживающий произошло ли передвижение плиток на поле
        List<EmptyTile> emptyTile = new List<EmptyTile>(); //список пустых плиток
        public int score; //счёт игры

        /// <summary>
        /// Конструктор без параметров, выделяющий память под объект класса Map_of_tile
        /// </summary>
        public Model()
        { map = new Map_of_tile(); }

        /// <summary>
        /// Метод, устанавливающий значения для начала игры
        /// </summary>
        public void Start()
        {
            win = false;
            score = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    map.Set(i, j, 0);
            }
            Create_tile();
            Create_tile();
        }

        /// <summary>
        /// Метод создания новых плиток, который устанавливает значения 2 (с вероятностью 90%) или 4 (с вероятностью 10%) на пустую плитку
        /// </summary>
        private void Create_tile()
        {
            emptyTile.Clear();
            if (GameOver()) return;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (map.Get(i, j) <= 0)
                    {
                        emptyTile.Add(new EmptyTile() { X = i, Y = j });
                    }
                }
            }
            if (emptyTile.Count != 0)
            {
                int a = rand.Next(0, emptyTile.Count);
                if (score ==0)
                    map.Set(emptyTile[a].X, emptyTile[a].Y, 2);
                else
                {
                    int z = rand.Next(0, 101);
                    if (z <= 90)
                        map.Set(emptyTile[a].X, emptyTile[a].Y, 2);
                    else
                        map.Set(emptyTile[a].X, emptyTile[a].Y, 4);
                }
            }
        }

        /// <summary>
        /// Метод, осуществляющий сдвиг плиток на поле в выбранную сторону
        /// </summary>
        /// <param name="x">Номер строки, в которой находится плитка</param>
        /// <param name="y">Номер столбца, в котором находится плитка</param>
        /// <param name="newX">Сдвиг плитки по вертикали</param>
        /// <param name="newY">Сдвиг плитки по горизонтали</param>
        void Go_to_the_edge(int x, int y, int newX, int newY)
        {
            if (map.Get(x, y) > 0)
                while (map.Get(x + newX, y + newY) == 0 && map.Get(x, y) > 0)
                {
                    map.Set(x + newX, y + newY, map.Get(x, y));
                    map.Set(x, y, 0);
                    x += newX; y += newY;
                    moved = true;
                }
        }

        /// <summary>
        /// Метод, осуществляющий соединение плиток с одинаковыми числами
        /// </summary>
        /// <param name="x">Номер строки, в которой находится плитка</param>
        /// <param name="y">Номер столбца, в котором находится плитка</param>
        /// <param name="newX">Сдвиг плитки по вертикали</param>
        /// <param name="newY">Сдвиг плитки по горизонтали</param>
        void Join(int x, int y, int newX, int newY)
        {
            if (map.Get(x + newX, y + newY) == map.Get(x, y) && map.Get(x, y) > 0)
            {
                map.Set(x + newX, y + newY, map.Get(x, y) * 2);
                score += map.Get(x, y) * 2;
                if (map.Get(x, y) * 2 == 2048) //проверка победы
                    win = true;
                map.Set(x, y, 0);
                moved = true;
            }
        }

        /// <summary>
        /// Метод движения плиток вправо
        /// </summary>
        public void Right()
        {
            moved = false;
            for (int i = 0; i < 4; i++)
                for (int j = 2; j >= 0; j--)
                    Go_to_the_edge(i, j, 0, 1);
            for (int i = 0; i < 4; i++)
                for (int j = 2; j >= 0; j--)
                    Join(i, j, 0, 1);
            for (int i = 0; i < 4; i++)
                for (int j = 2; j >= 0; j--)
                    Go_to_the_edge(i, j, 0, 1);
            if (moved) //создание новой плитки в случае, если плитки были сдвинуты
                Create_tile();
        }

        /// <summary>
        /// Метод движения плиток влево
        /// </summary>
        public void Left()
        {
            moved = false;
            for (int i = 0; i < 4; i++)
                for (int j = 1; j < 4; j++)
                    Go_to_the_edge(i, j, 0, -1);
            for (int i = 0; i < 4; i++)
                for (int j = 1; j < 4; j++)
                    Join(i, j, 0, -1);
            for (int i = 0; i < 4; i++)
                for (int j = 1; j < 4; j++)
                    Go_to_the_edge(i, j, 0, -1);
            if (moved) //создание новой плитки в случае, если плитки были сдвинуты
                Create_tile();
        }

        /// <summary>
        /// Метод движения плиток вверх
        /// </summary>
        public void Up()
        {
            moved = false;
            for (int j = 0; j < 4; j++)
                for (int i = 1; i < 4; i++)
                    Go_to_the_edge(i, j, -1, 0);
            for (int j = 0; j < 4; j++)
                for (int i = 1; i < 4; i++)
                    Join(i, j, -1, 0);
            for (int j = 0; j < 4; j++)
                for (int i = 1; i < 4; i++)
                    Go_to_the_edge(i, j, -1, 0);
            if (moved) //создание новой плитки в случае, если плитки были сдвинуты
                Create_tile();
        }

        /// <summary>
        /// Метод движения плиток вниз
        /// </summary>
        public void Down()
        {
            moved = false;
            for (int j = 0; j < 4; j++)
                for (int i = 2; i >= 0; i--)
                    Go_to_the_edge(i, j, 1, 0);
            for (int j = 0; j < 4; j++)
                for (int i = 2; i >= 0; i--)
                    Join(i, j, 1, 0);
            for (int j = 0; j < 4; j++)
                for (int i = 2; i >= 0; i--)
                    Go_to_the_edge(i, j, 1, 0);
            if (moved) //создание новой плитки в случае, если плитки были сдвинуты
                Create_tile();
        }

        /// <summary>
        /// Функция проверки окончания игры из-за проигрыша
        /// </summary>
        /// <returns>Окончание игры</returns>
        public bool GameOver()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (map.Get(i, j) == 0)
                        return false;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (map.Get(i, j) == map.Get(i + 1, j) || map.Get(i, j) == map.Get(i, j + 1))
                        return false;
            return true;
        }

        /// <summary>
        /// Функция для получения числа с плитки
        /// </summary>
        /// <param name="i">Номер строки, в которой находится плитка</param>
        /// <param name="j">Номер столбца, в котором находится плитка</param>
        /// <returns>Число на плитке</returns>
        public int GetMap(int i, int j)
        {
            return map.Get(i, j);
        }
    }

    /// <summary>
    /// Класс для записи координат пустых плиток
    /// </summary>
    public class EmptyTile
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}

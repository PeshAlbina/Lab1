using System;

namespace Model
{
    class Map_of_tile
    {
        int[,] map_tile; //двумерный массив для хранения чисел на плитах

        /// <summary>
        /// Конструктор без параметров, в котором выделяется память под масив, хранящий значения на плитках
        /// </summary>
        public Map_of_tile()
        {
            map_tile = new int[4, 4];
        }

        /// <summary>
        /// Функция получения числа на плитке
        /// </summary>
        /// <param name="x">Номер строки, в которой находится плитка</param>
        /// <param name="y">Номер столбца, в котором находится плитка</param>
        /// <returns></returns>
        public int Get(int x, int y)
        {
            if(x>=0&&x<4 && y>=0 && y < 4)
                return map_tile[x, y];
            return -1; //возврат -1, если запрошено значение с плитки вне поля
        }

        /// <summary>
        /// Метод, устанавливающий число на плитке
        /// </summary>
        /// <param name="x">Номер строки, в которой находится плитка</param>
        /// <param name="y">Номер столбца, в котором находится плитка</param>
        /// <param name="num">Устанавливаемое число</param>
        public void Set(int x, int y, int num)
        {
            if (x >= 0 && x < 4 && y >= 0 && y < 4)
                map_tile[x, y] = num;
        }
    }
}

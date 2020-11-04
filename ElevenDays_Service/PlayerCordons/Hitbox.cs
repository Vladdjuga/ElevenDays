using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCordons
{
    // класс который будет описывать границы игрока и его позицию
    [DataContract]
    public class Hitbox
    {
        // начальная позиция игрока
        public Position StartPosition { get; set; }
        // ширина фигуры
        public double Width { get; set; }
        // высота фигуры
        public double Height { get; set; }
    }
    [DataContract]
    public struct Position
    {
        // х в координатной области
        [DataMember]
        public double X { get; set; }
        // у в координатной области
        [DataMember]
        public double Y { get; set; }
        // конструктор
        public Position(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}

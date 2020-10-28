using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCordons
{
    // класс в котором будет описыватся модель фрукта/овоща
    [DataContract]
    public class Model
    {
        // картинка которая будет привязыватся к UI элементам
        public Bitmap Image { get; set; }
        // список кадров бега игрока в лево
        public List<Bitmap> RunningMapLeft { get; set; }
        // список кадров бега игрока в право
        public List<Bitmap> RunningMapRight { get; set; }
        // кадр когда игрок стоит повернутый в лево
        public Bitmap StayImageLeft { get; set; }
        // кадр когда игрок стоит повернутый в право
        public Bitmap StayImageRight { get; set; }
    }
}

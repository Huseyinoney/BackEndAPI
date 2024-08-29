using BackEndAPI.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tensorflow.Binding;
using Tensorflow.Keras;
using Tensorflow;
using Tensorflow.Keras.Models;
using Tensorflow.Keras.Engine;
using Tensorflow.NumPy;
using Microsoft.AspNetCore.Http;
using System.Drawing;


namespace BackEndAPI.Infrastructure.Services
{
    public class KerasEntity : IKerasEntity
    {
        public Tensor FindEntityFromModel(string imagePath)
        {
            var model = tf.keras.models.load_model("modelPath");
            var imageTensor = LoadImage(imagePath);

            var inputTensor = tf.reshape(imageTensor, new long[]
            {
               1,imageTensor.shape[0],imageTensor.shape[1],imageTensor.shape[2]
            });
            var result = model.predict(inputTensor);
            return result;
        }

        public NDArray LoadImage(string imagePath)
        {
            Bitmap bitmap = new Bitmap(imagePath);
            int width = bitmap.Width;
            int height = bitmap.Height;
            int channel = 3;

            var array = np.zeros(new Shape(width, height, channel));


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    array[y, x, 0] = pixel.R;
                    array[y, x, 1] = pixel.G;
                    array[y, x, 2] = pixel.B;
                }
            }
            return array;
        }
    }
}

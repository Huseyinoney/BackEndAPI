using BackEndAPI.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tensorflow.Binding;
using Tensorflow.Keras;
using Tensorflow;
using Tensorflow.NumPy;


namespace BackEndAPI.Infrastructure.Services
{
    public class KerasEntity : IKerasEntity
    {
        public Task<string> FindEntityFromModelAsync(string imagepath)
        {
         var loadedModel  = tf.keras.models.load_model("model path i buraya yazılacak");
            loadedModel.predict(imagepath);
        }
    }
}

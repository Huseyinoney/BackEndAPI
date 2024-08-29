using Microsoft.AspNetCore.Http;
using Tensorflow;
using Tensorflow.NumPy;

namespace BackEndAPI.Application.Services
{
    public interface IKerasEntity
    {
        Tensor FindEntityFromModel(string imagePath);
        NDArray LoadImage(string  imagePath);


    }
}
